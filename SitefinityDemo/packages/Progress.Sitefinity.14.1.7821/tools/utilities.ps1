function Get-PackageVersion($package)
{
    if($package -and $package.Version)
    {
		[convert]::ToInt32($package.Version.ToString().Replace("-beta", "").Replace("-preview", "").Replace(".", ""), 10)
    }
    else
    {
        return 0;
    }
}

function Get-BuildProject($project)
{
    return [Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($project.FullName) | Select-Object -First 1
}

function ApplyProjectTransformations($project)
{
	$transformations = Get-Content "$PSScriptRoot\transformations\Project.transform.json" -Raw | ConvertFrom-Json    

	foreach($item in $transformations.items)
	{
		switch ($item.transform)
		{
			"Remove" 
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode)
				{
					$project.RemoveItem($itemNode)
				}

				$itemFilePath = $null
				if($item.type -eq "Content")
				{
					$itemFilePath = Join-Path $project.DirectoryPath $item.include
				}
				if($item.type -eq "Reference")
				{
					$itemFilePath = Join-Path $project.DirectoryPath "\bin\$($item.include).dll"
				}
				
				if($itemFilePath -ne $null -and (Test-Path $itemFilePath))
				{
					try
					{						
						Write-Warning "Deleting '$itemFilePath' from the FileSystem..."
						Remove-Item $itemFilePath -Force
					} catch {
						Write-Warning "Could not delete '$itemFilePath' from the FileSystem!"
					}
				}

				break
			}

			"InsertIfMissing"
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode -eq $null)
				{
					$project.AddItem($item.type, $item.include)
				}
				break
			}

			"Replace"
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode)
				{
					$project.RemoveItem($itemNode)
				}
				$project.AddItem($item.type, $item.include)
				break
			}
		}
	}

	foreach($import in $transformations.imports)
	{
		if($import.transform -eq "Remove")
		{
			$importNode = $project.Xml.Imports | Where-Object { $_.Project -eq $import.project } | Select-Object -First 1
			if($importNode)
			{
				$project.Xml.RemoveChild($importNode)
			}
		}
	}

	$project.Save()
}

function TransformXML($xml, $xdt, $output)
{
    Add-Type -LiteralPath "$PSScriptRoot\lib\Microsoft.Web.XmlTransform.dll"

    $xmldoc = New-Object Microsoft.Web.XmlTransform.XmlTransformableDocument
    $xmldoc.PreserveWhitespace = $true
    $xmldoc.Load($xml)

    $transf = New-Object Microsoft.Web.XmlTransform.XmlTransformation($xdt)
    if ($transf.Apply($xmldoc) -eq $false)
    {
        throw "Transformation for '$xml' FAILED!"
    }
    
    $xmldoc.Save($output)
    $xmldoc.Dispose()
}

function TransformPackagesConfig($packagesConfig)
{
	if(!(Test-Path $packagesConfig))
	{
		Write-Warning "Could not find packages.config..."
		return
	}

	$transformations = Get-Content "$PSScriptRoot\transformations\packages.json" -Raw | ConvertFrom-Json
	$packagesConfigXML = [xml](Get-Content $packagesConfig)

	foreach($item in $transformations.items) 
	{
		$packageNode = $packagesConfigXML.SelectSingleNode("/packages/package[@id='$($item.id)']")

		switch ($item.transform)
		{
			"Remove" 
			{
				if($packageNode) 
				{
					$packageNode.ParentNode.RemoveChild($packageNode)
				}
				break
			}

			"InsertIfMissing"
			{
				if($packageNode -eq $null)
				{
					
					$packageNode = $packagesConfigXML.CreateElement("package")
					$packageNode.SetAttribute("id", $item.id)
					$packageNode.SetAttribute("version", $item.version)
					$packageNode.SetAttribute("targetFramework", $item.targetFramework)
					$packagesNode = $packagesConfigXML.SelectSingleNode("/packages")
					$packagesNode.AppendChild($packageNode) | out-null
					$packagesSorted = $packagesNode.SelectNodes("package") | Sort id
					$packagesNode.RemoveAll()
					$packagesSorted | foreach { $packagesNode.AppendChild($_) | out-null } 	
				}

				break
			}

			"Replace"
			{
				if($packageNode)
				{
					$packageNode.SetAttribute("version", $item.version)
					$packageNode.SetAttribute("targetFramework", $item.targetFramework)
				}

				break
			}
		}
	}

	$packagesConfigXML.Save($packagesConfig)
}
# SIG # Begin signature block
# MIIoCwYJKoZIhvcNAQcCoIIn/DCCJ/gCAQExCzAJBgUrDgMCGgUAMGkGCisGAQQB
# gjcCAQSgWzBZMDQGCisGAQQBgjcCAR4wJgIDAQAABBAfzDtgWUsITrck0sYpfvNR
# AgEAAgEAAgEAAgEAAgEAMCEwCQYFKw4DAhoFAAQUPbTNt93e4o7QB7X1m2O4IM5f
# qZiggiI3MIIETjCCAzagAwIBAgINAe5fFp3/lzUrZGXWajANBgkqhkiG9w0BAQsF
# ADBXMQswCQYDVQQGEwJCRTEZMBcGA1UEChMQR2xvYmFsU2lnbiBudi1zYTEQMA4G
# A1UECxMHUm9vdCBDQTEbMBkGA1UEAxMSR2xvYmFsU2lnbiBSb290IENBMB4XDTE4
# MDkxOTAwMDAwMFoXDTI4MDEyODEyMDAwMFowTDEgMB4GA1UECxMXR2xvYmFsU2ln
# biBSb290IENBIC0gUjMxEzARBgNVBAoTCkdsb2JhbFNpZ24xEzARBgNVBAMTCkds
# b2JhbFNpZ24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDMJXaQeQZ4
# Ihb1wIO2hMoonv0FdhHFrYhy/EYCQ8eyip0EXyTLLkvhYIJG4VKrDIFHcGzdZNHr
# 9SyjD4I9DCuul9e2FIYQebs7E4B3jAjhSdJqYi8fXvqWaN+JJ5U4nwbXPsnLJlkN
# c96wyOkmDoMVxu9bi9IEYMpJpij2aTv2y8gokeWdimFXN6x0FNx04Druci8unPvQ
# u7/1PQDhBjPogiuuU6Y6FnOM3UEOIDrAtKeh6bJPkC4yYOlXy7kEkmho5TgmYHWy
# n3f/kRTvriBJ/K1AFUjRAjFhGV64l++td7dkmnq/X8ET75ti+w1s4FRpFqkD2m7p
# g5NxdsZphYIXAgMBAAGjggEiMIIBHjAOBgNVHQ8BAf8EBAMCAQYwDwYDVR0TAQH/
# BAUwAwEB/zAdBgNVHQ4EFgQUj/BLf6guRSSuTVD6Y5qL3uLdG7wwHwYDVR0jBBgw
# FoAUYHtmGkUNl8qJUC99BM00qP/8/UswPQYIKwYBBQUHAQEEMTAvMC0GCCsGAQUF
# BzABhiFodHRwOi8vb2NzcC5nbG9iYWxzaWduLmNvbS9yb290cjEwMwYDVR0fBCww
# KjAooCagJIYiaHR0cDovL2NybC5nbG9iYWxzaWduLmNvbS9yb290LmNybDBHBgNV
# HSAEQDA+MDwGBFUdIAAwNDAyBggrBgEFBQcCARYmaHR0cHM6Ly93d3cuZ2xvYmFs
# c2lnbi5jb20vcmVwb3NpdG9yeS8wDQYJKoZIhvcNAQELBQADggEBACNw6c/ivvVZ
# rpRCb8RDM6rNPzq5ZBfyYgZLSPFAiAYXof6r0V88xjPy847dHx0+zBpgmYILrMf8
# fpqHKqV9D6ZX7qw7aoXW3r1AY/itpsiIsBL89kHfDwmXHjjqU5++BfQ+6tOfUBJ2
# vgmLwgtIfR4uUfaNU9OrH0Abio7tfftPeVZwXwzTjhuzp3ANNyuXlava4BJrHEDO
# xcd+7cJiWOx37XMiwor1hkOIreoTbv3Y/kIvuX1erRjvlJDKPSerJpSZdcfL03v3
# ykzTr1EhkluEfSufFT90y1HonoMOFm8b50bOI7355KKL0jlrqnkckSziYSQtjipI
# cJDEHsXo4HAwggT+MIID5qADAgECAhANQkrgvjqI/2BAIc4UAPDdMA0GCSqGSIb3
# DQEBCwUAMHIxCzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxEaWdpQ2VydCBJbmMxGTAX
# BgNVBAsTEHd3dy5kaWdpY2VydC5jb20xMTAvBgNVBAMTKERpZ2lDZXJ0IFNIQTIg
# QXNzdXJlZCBJRCBUaW1lc3RhbXBpbmcgQ0EwHhcNMjEwMTAxMDAwMDAwWhcNMzEw
# MTA2MDAwMDAwWjBIMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNlcnQsIElu
# Yy4xIDAeBgNVBAMTF0RpZ2lDZXJ0IFRpbWVzdGFtcCAyMDIxMIIBIjANBgkqhkiG
# 9w0BAQEFAAOCAQ8AMIIBCgKCAQEAwuZhhGfFivUNCKRFymNrUdc6EUK9CnV1TZS0
# DFC1JhD+HchvkWsMlucaXEjvROW/m2HNFZFiWrj/ZwucY/02aoH6KfjdK3CF3gIY
# 83htvH35x20JPb5qdofpir34hF0edsnkxnZ2OlPR0dNaNo/Go+EvGzq3YdZz7E5t
# M4p8XUUtS7FQ5kE6N1aG3JMjjfdQJehk5t3Tjy9XtYcg6w6OLNUj2vRNeEbjA4Mx
# KUpcDDGKSoyIxfcwWvkUrxVfbENJCf0mI1P2jWPoGqtbsR0wwptpgrTb/FZUvB+h
# h6u+elsKIC9LCcmVp42y+tZji06lchzun3oBc/gZ1v4NSYS9AQIDAQABo4IBuDCC
# AbQwDgYDVR0PAQH/BAQDAgeAMAwGA1UdEwEB/wQCMAAwFgYDVR0lAQH/BAwwCgYI
# KwYBBQUHAwgwQQYDVR0gBDowODA2BglghkgBhv1sBwEwKTAnBggrBgEFBQcCARYb
# aHR0cDovL3d3dy5kaWdpY2VydC5jb20vQ1BTMB8GA1UdIwQYMBaAFPS24SAd/imu
# 0uRhpbKiJbLIFzVuMB0GA1UdDgQWBBQ2RIaOpLqwZr68KC0dRDbd42p6vDBxBgNV
# HR8EajBoMDKgMKAuhixodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vc2hhMi1hc3N1
# cmVkLXRzLmNybDAyoDCgLoYsaHR0cDovL2NybDQuZGlnaWNlcnQuY29tL3NoYTIt
# YXNzdXJlZC10cy5jcmwwgYUGCCsGAQUFBwEBBHkwdzAkBggrBgEFBQcwAYYYaHR0
# cDovL29jc3AuZGlnaWNlcnQuY29tME8GCCsGAQUFBzAChkNodHRwOi8vY2FjZXJ0
# cy5kaWdpY2VydC5jb20vRGlnaUNlcnRTSEEyQXNzdXJlZElEVGltZXN0YW1waW5n
# Q0EuY3J0MA0GCSqGSIb3DQEBCwUAA4IBAQBIHNy16ZojvOca5yAOjmdG/UJyUXQK
# I0ejq5LSJcRwWb4UoOUngaVNFBUZB3nw0QTDhtk7vf5EAmZN7WmkD/a4cM9i6PVR
# Snh5Nnont/PnUp+Tp+1DnnvntN1BIon7h6JGA0789P63ZHdjXyNSaYOC+hpT7ZDM
# jaEXcw3082U5cEvznNZ6e9oMvD0y0BvL9WH8dQgAdryBDvjA4VzPxBFy5xtkSdgi
# mnUVQvUtMjiB2vRgorq0Uvtc4GEkJU+y38kpqHNDUdq9Y9YfW5v3LhtPEx33Sg1x
# fpe39D+E68Hjo0mh+s6nv1bPull2YYlffqe0jmd4+TaY4cso2luHpoovMIIFMTCC
# BBmgAwIBAgIQCqEl1tYyG35B5AXaNpfCFTANBgkqhkiG9w0BAQsFADBlMQswCQYD
# VQQGEwJVUzEVMBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cuZGln
# aWNlcnQuY29tMSQwIgYDVQQDExtEaWdpQ2VydCBBc3N1cmVkIElEIFJvb3QgQ0Ew
# HhcNMTYwMTA3MTIwMDAwWhcNMzEwMTA3MTIwMDAwWjByMQswCQYDVQQGEwJVUzEV
# MBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cuZGlnaWNlcnQuY29t
# MTEwLwYDVQQDEyhEaWdpQ2VydCBTSEEyIEFzc3VyZWQgSUQgVGltZXN0YW1waW5n
# IENBMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvdAy7kvNj3/dqbqC
# mcU5VChXtiNKxA4HRTNREH3Q+X1NaH7ntqD0jbOI5Je/YyGQmL8TvFfTw+F+CNZq
# FAA49y4eO+7MpvYyWf5fZT/gm+vjRkcGGlV+Cyd+wKL1oODeIj8O/36V+/OjuiI+
# GKwR5PCZA207hXwJ0+5dyJoLVOOoCXFr4M8iEA91z3FyTgqt30A6XLdR4aF5FMZN
# JCMwXbzsPGBqrC8HzP3w6kfZiFBe/WZuVmEnKYmEUeaC50ZQ/ZQqLKfkdT66mA+E
# f58xFNat1fJky3seBdCEGXIX8RcG7z3N1k3vBkL9olMqT4UdxB08r8/arBD13ays
# 6Vb/kwIDAQABo4IBzjCCAcowHQYDVR0OBBYEFPS24SAd/imu0uRhpbKiJbLIFzVu
# MB8GA1UdIwQYMBaAFEXroq/0ksuCMS1Ri6enIZ3zbcgPMBIGA1UdEwEB/wQIMAYB
# Af8CAQAwDgYDVR0PAQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUFBwMIMHkGCCsG
# AQUFBwEBBG0wazAkBggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29t
# MEMGCCsGAQUFBzAChjdodHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNl
# cnRBc3N1cmVkSURSb290Q0EuY3J0MIGBBgNVHR8EejB4MDqgOKA2hjRodHRwOi8v
# Y3JsNC5kaWdpY2VydC5jb20vRGlnaUNlcnRBc3N1cmVkSURSb290Q0EuY3JsMDqg
# OKA2hjRodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vRGlnaUNlcnRBc3N1cmVkSURS
# b290Q0EuY3JsMFAGA1UdIARJMEcwOAYKYIZIAYb9bAACBDAqMCgGCCsGAQUFBwIB
# FhxodHRwczovL3d3dy5kaWdpY2VydC5jb20vQ1BTMAsGCWCGSAGG/WwHATANBgkq
# hkiG9w0BAQsFAAOCAQEAcZUS6VGHVmnN793afKpjerN4zwY3QITvS4S/ys8DAv3F
# p8MOIEIsr3fzKx8MIVoqtwU0HWqumfgnoma/Capg33akOpMP+LLR2HwZYuhegiUe
# xLoceywh4tZbLBQ1QwRostt1AuByx5jWPGTlH0gQGF+JOGFNYkYkh2OMkVIsrymJ
# 5Xgf1gsUpYDXEkdws3XVk4WTfraSZ/tTYYmo9WuWwPRYaQ18yAGxuSh1t5ljhSKM
# Ycp5lH5Z/IwP42+1ASa2bKXuh1Eh5Fhgm7oMLSttosR+u8QlK0cCCHxJrhO24XxC
# QijGGFbPQTS2Zl22dHv1VjMiLyI2skuiSpXY9aaOUjCCBaIwggSKoAMCAQICEHgD
# GEJFcIpBz28BuO60qVQwDQYJKoZIhvcNAQEMBQAwTDEgMB4GA1UECxMXR2xvYmFs
# U2lnbiBSb290IENBIC0gUjMxEzARBgNVBAoTCkdsb2JhbFNpZ24xEzARBgNVBAMT
# Ckdsb2JhbFNpZ24wHhcNMjAwNzI4MDAwMDAwWhcNMjkwMzE4MDAwMDAwWjBTMQsw
# CQYDVQQGEwJCRTEZMBcGA1UEChMQR2xvYmFsU2lnbiBudi1zYTEpMCcGA1UEAxMg
# R2xvYmFsU2lnbiBDb2RlIFNpZ25pbmcgUm9vdCBSNDUwggIiMA0GCSqGSIb3DQEB
# AQUAA4ICDwAwggIKAoICAQC2LcUw3Xroq5A9A3KwOkuZFmGy5f+lZx03HOV+7JOD
# qoT1o0ObmEWKuGNXXZsAiAQl6fhokkuC2EvJSgPzqH9qj4phJ72hRND99T8iwqNP
# kY2zBbIogpFd+1mIBQuXBsKY+CynMyTuUDpBzPCgsHsdTdKoWDiW6d/5G5G7ixAs
# 0sdDHaIJdKGAr3vmMwoMWWuOvPSrWpd7f65V+4TwgP6ETNfiur3EdaFvvWEQdESy
# mAfidKv/aNxsJj7pH+XgBIetMNMMjQN8VbgWcFwkeCAl62dniKu6TjSYa3AR3jjK
# 1L6hwJzh3x4CAdg74WdDhLbP/HS3L4Sjv7oJNz1nbLFFXBlhq0GD9awd63cNRkdz
# zr+9lZXtnSuIEP76WOinV+Gzz6ha6QclmxLEnoByPZPcjJTfO0TmJoD80sMD8IwM
# 0kXWLuePmJ7mBO5Cbmd+QhZxYucE+WDGZKG2nIEhTivGbWiUhsaZdHNnMXqR8tSM
# eW58prt+Rm9NxYUSK8+aIkQIqIU3zgdhVwYXEiTAxDFzoZg1V0d+EDpF2S2kUZCY
# qaAHN8RlGqocaxZ396eX7D8ZMJlvMfvqQLLn0sT6ydDwUHZ0WfqNbRcyvvjpfgP0
# 54d1mtRKkSyFAxMCK0KA8olqNs/ITKDOnvjLja0Wp9Pe1ZsYp8aSOvGCY/EuDiRk
# 3wIDAQABo4IBdzCCAXMwDgYDVR0PAQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUF
# BwMDMA8GA1UdEwEB/wQFMAMBAf8wHQYDVR0OBBYEFB8Av0aACvx4ObeltEPZVlC7
# zpY7MB8GA1UdIwQYMBaAFI/wS3+oLkUkrk1Q+mOai97i3Ru8MHoGCCsGAQUFBwEB
# BG4wbDAtBggrBgEFBQcwAYYhaHR0cDovL29jc3AuZ2xvYmFsc2lnbi5jb20vcm9v
# dHIzMDsGCCsGAQUFBzAChi9odHRwOi8vc2VjdXJlLmdsb2JhbHNpZ24uY29tL2Nh
# Y2VydC9yb290LXIzLmNydDA2BgNVHR8ELzAtMCugKaAnhiVodHRwOi8vY3JsLmds
# b2JhbHNpZ24uY29tL3Jvb3QtcjMuY3JsMEcGA1UdIARAMD4wPAYEVR0gADA0MDIG
# CCsGAQUFBwIBFiZodHRwczovL3d3dy5nbG9iYWxzaWduLmNvbS9yZXBvc2l0b3J5
# LzANBgkqhkiG9w0BAQwFAAOCAQEArPfMFYsweagdCyiIGQnXHH/+hr17WjNuDWcO
# e2LZ4RhcsL0TXR0jrjlQdjeqRP1fASNZhlZMzK28ZBMUMKQgqOA/6Jxy3H7z2Awj
# uqgtqjz27J+HMQdl9TmnUYJ14fIvl/bR4WWWg2T+oR1R+7Ukm/XSd2m8hSxc+lh3
# 0a6nsQvi1ne7qbQ0SqlvPfTzDZVd5vl6RbAlFzEu2/cPaOaDH6n35dSdmIzTYUsv
# wyh+et6TDrR9oAptksS0Zj99p1jurPfswwgBqzj8ChypxZeyiMgJAhn2XJoa8U1s
# MNSzBqsAYEgNeKvPF62Sk2Igd3VsvcgytNxN69nfwZCWKb3BfzCCBuYwggTOoAMC
# AQICEHe9DgOhtwj4VKsGchDZBEcwDQYJKoZIhvcNAQELBQAwUzELMAkGA1UEBhMC
# QkUxGTAXBgNVBAoTEEdsb2JhbFNpZ24gbnYtc2ExKTAnBgNVBAMTIEdsb2JhbFNp
# Z24gQ29kZSBTaWduaW5nIFJvb3QgUjQ1MB4XDTIwMDcyODAwMDAwMFoXDTMwMDcy
# ODAwMDAwMFowWTELMAkGA1UEBhMCQkUxGTAXBgNVBAoTEEdsb2JhbFNpZ24gbnYt
# c2ExLzAtBgNVBAMTJkdsb2JhbFNpZ24gR0NDIFI0NSBDb2RlU2lnbmluZyBDQSAy
# MDIwMIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEA1kJN+eNPxiP0bB2B
# pjD3SD3P0OWN5SAilgdENV0Gzw8dcGDmJlT6UyNgAqhfAgL3jsluPal4Bb2O9U8Z
# JJl8zxEWmx97a9Kje2hld6vYsSw/03IGMlxbrFBnLCVNVgY2/MFiTH19hhaVml1U
# ulDQsH+iRBnp1m5sPhPCnxHUXzRbUWgxYwr4W9DeullfMa+JaDhAPgjoU2dOY7Yh
# ju/djYVBVZ4cvDfclaDEcacfG6VJbgogWX6Jo1gVlwAlad/ewmpQZU5T+2uhnxge
# ig5fVF694FvP8gwE0t4IoRAm97Lzei7CjpbBP86l2vRZKIw3ZaExlguOpHZ3FUmE
# ZoIl50MKd1KxmVFC/6Gy3ZzS3BjZwYapQB1Bl2KGvKj/osdjFwb9Zno2lAEgiXgf
# kPR7qVJOak9UBiqAr57HUEL6ZQrjAfSxbqwOqOOBGag4yJ4DKIakdKdHlX5yWip7
# FWocxGnmsL5AGZnL0n1VTiKcEOChW8OzLnqLxN7xSx+MKHkwRX9sE7Y9LP8tSooq
# 7CgPLcrUnJiKSm1aNiwv37rL4kFKCHcYiK01YZQS86Ry6+42nqdRJ5E896IazPyH
# 5ZfhUYdp6SLMg8C3D0VsB+FDT9SMSs7PY7G1pBB6+Q0MKLBrNP4haCdv7Pj6JoRb
# dULNiSZ5WZ1rq2NxYpAlDQgg8f8CAwEAAaOCAa4wggGqMA4GA1UdDwEB/wQEAwIB
# hjATBgNVHSUEDDAKBggrBgEFBQcDAzASBgNVHRMBAf8ECDAGAQH/AgEAMB0GA1Ud
# DgQWBBTas43AJJCja3fTDKBZ3SFnZHYLeDAfBgNVHSMEGDAWgBQfAL9GgAr8eDm3
# pbRD2VZQu86WOzCBkwYIKwYBBQUHAQEEgYYwgYMwOQYIKwYBBQUHMAGGLWh0dHA6
# Ly9vY3NwLmdsb2JhbHNpZ24uY29tL2NvZGVzaWduaW5ncm9vdHI0NTBGBggrBgEF
# BQcwAoY6aHR0cDovL3NlY3VyZS5nbG9iYWxzaWduLmNvbS9jYWNlcnQvY29kZXNp
# Z25pbmdyb290cjQ1LmNydDBBBgNVHR8EOjA4MDagNKAyhjBodHRwOi8vY3JsLmds
# b2JhbHNpZ24uY29tL2NvZGVzaWduaW5ncm9vdHI0NS5jcmwwVgYDVR0gBE8wTTBB
# BgkrBgEEAaAyATIwNDAyBggrBgEFBQcCARYmaHR0cHM6Ly93d3cuZ2xvYmFsc2ln
# bi5jb20vcmVwb3NpdG9yeS8wCAYGZ4EMAQQBMA0GCSqGSIb3DQEBCwUAA4ICAQAI
# iHImxq/6rF8GwKqMkNrQssCil/9uEzIWVP0+9DARn4+Y+ZtS3fKiFu7ZeJWmmnxh
# uAS1+OvL9GERM/ZlJbcRQovYaW7H/5W0gUOpfq6/gtZNzBGjg3FqEF4ZBafnbH9W
# 9Khcw04JrVlruPl+pS64/N4OwqD7sATUExvHJ6m5qi0xO89GTJ3rTOy8Lpzxh6N/
# OGlfQUBn9lN96kHvjj37qdQROEbfPOv2zSK9E83w4eblM6C+POR41RvMIPIwc7Ai
# HPaE1ptcAALhKFJL/xJLQOrusBoGBp6E5ufw24RG+3PZK0K2yVc0xxbApushuaoO
# 9/7byuu8F8u4Z+vjPk/bqZSGZFXJCQrA2QRxShFLWmTDvHh4rUxHJmUHmdXNNmCh
# M1Oz9nsq1YlAPHGlq/iZWf3jm5JL3QW9Cwx4BivPU9i9EppbJ4aFP5G+4HiAc1Tf
# px1nK2q2rk2JgCQIUnBQ8wH/RK4vmuDhSQjh4VvXONGeCoqdlCebyqO52+I2auNv
# uVhi4DZ4NgH6waeJeiZTo1y70rLristjCC/+HvNWKeI1m9j/6aW9bUtZLIksL1K7
# tSmQ2kNHvHLdvNm/gMHcsKu0Sx1YNjdk65vhhReaKaL95gjSkv+g+Hzh6afRMI5f
# JlArx6Lil3eK79hNPibrmUBg8zxnDLYIcik1U4E03DCCBxowggUCoAMCAQICDGkH
# P0aECQR2MCgazTANBgkqhkiG9w0BAQsFADBZMQswCQYDVQQGEwJCRTEZMBcGA1UE
# ChMQR2xvYmFsU2lnbiBudi1zYTEvMC0GA1UEAxMmR2xvYmFsU2lnbiBHQ0MgUjQ1
# IENvZGVTaWduaW5nIENBIDIwMjAwHhcNMjExMjEwMTY0ODIwWhcNMjMwMjA5MTky
# MDM1WjCBhzELMAkGA1UEBhMCVVMxFjAUBgNVBAgTDU1hc3NhY2h1c2V0dHMxEDAO
# BgNVBAcTB0JlZGZvcmQxJjAkBgNVBAoTHVBST0dSRVNTIFNPRlRXQVJFIENPUlBP
# UkFUSU9OMSYwJAYDVQQDEx1QUk9HUkVTUyBTT0ZUV0FSRSBDT1JQT1JBVElPTjCC
# AiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAMJJ7WAtTjEmt2SptFJwWzu2
# DdxCi3qdXzqx5Oq5dTlQx6NSQJR6X6D+l2LmZjGryV9GNzVjS0kVFKXCR69AlRk1
# Ql83NUpZTjsZK/DJbQzgxKoF3PxyX2J4OS+gUs0YCwwlRf98WRzIJITq8bNTZgz7
# pIKSet+LcNZ46NtnkhpfRIp75O/g92xl6ObCKVNBY4MWTWRF93ENqrV59MdgoVeV
# MviISIjSu7TCpvOGde+6xlBFF8A1oXmx0AOB/VsGS5ITAIWMnytdrvD/8aULg5sd
# m+o+mQeCAx0Mbu05fZ8D6+A3BV6phlSHDna0zg39DLZaLiDSjDElZppJnfg+tF9+
# tzgrr4YcPf03NQ04jpyaWn51h28tW5bzC8Mj/NfMM4l6ID85DEUk/NsjGzXzZC8b
# +mHaH89aOL1QIt45cO2kE+6Nq/tkUojUOYSOpU4/IpnIJgBHsyKQFBdvzPkppbRa
# rqffn1GsXVLuzpnOuzuJC5qZTdbWSk9YRxGFffDJzQ5gFNYUm2YqvOWICPZL6+NZ
# cssajjTI9yExVDptTfAZBrmrTluxAJ/kRmZkkBCp/ThtfkUDhiTBnIG2rWo0mbvc
# thvpEmnqJBRlik3dEyFdXnFl+szFyqcjJGF2U+55CDuIKwye87nsWSNv2ZXsTlER
# dJQ9gH/ShuGACl9AUjLpAgMBAAGjggGxMIIBrTAOBgNVHQ8BAf8EBAMCB4AwgZsG
# CCsGAQUFBwEBBIGOMIGLMEoGCCsGAQUFBzAChj5odHRwOi8vc2VjdXJlLmdsb2Jh
# bHNpZ24uY29tL2NhY2VydC9nc2djY3I0NWNvZGVzaWduY2EyMDIwLmNydDA9Bggr
# BgEFBQcwAYYxaHR0cDovL29jc3AuZ2xvYmFsc2lnbi5jb20vZ3NnY2NyNDVjb2Rl
# c2lnbmNhMjAyMDBWBgNVHSAETzBNMEEGCSsGAQQBoDIBMjA0MDIGCCsGAQUFBwIB
# FiZodHRwczovL3d3dy5nbG9iYWxzaWduLmNvbS9yZXBvc2l0b3J5LzAIBgZngQwB
# BAEwCQYDVR0TBAIwADBFBgNVHR8EPjA8MDqgOKA2hjRodHRwOi8vY3JsLmdsb2Jh
# bHNpZ24uY29tL2dzZ2NjcjQ1Y29kZXNpZ25jYTIwMjAuY3JsMBMGA1UdJQQMMAoG
# CCsGAQUFBwMDMB8GA1UdIwQYMBaAFNqzjcAkkKNrd9MMoFndIWdkdgt4MB0GA1Ud
# DgQWBBRakSXq7meVtZe/bDj0VxtUvRKdEjANBgkqhkiG9w0BAQsFAAOCAgEAJMeD
# VELlM+XZvu6Nc0EDmQcZOBcFpfhkmsJuiJ00hsHaMmYi+xP2/IsoKAtPNyb0cOWS
# 5GF228SdeIAn7CiwMv9LEqRZmtT4Y7Vb1B4soVFRQPSx+8cMzFnrivPK5a+Vkjsx
# nl7VUWs4qE+e+iuUkcz2RIum69c8bGNaldft5Yzz4wm11dWT53uQzmMe4xHzc3iA
# 6IHNf6uv442Wjo/+XfQ2UzAoyx1PngYqQ64Nl/7TpNVFESvq674Etopf9z7csqZx
# PuPmLhckdp/6elgK4qq4/7P5YWARtUArW7DADGBaJtjpu+TlTKgRSSqXgjzNMyKb
# pb/GtPaSIH7UwehrCrpIO2ZiHhKw1qkIMrvxQgOJ6JjO3ANLJu0Jm8oQzNpVWMr9
# a+DnbvJdX3hL0VjxB3n95n+zh+8LumfB5oW7eoZxo85K4LmLESsMiIXxNz+/shmu
# l5IJx/Dn8zFnDFsc+dVlw/V2zgp/Jeb5qTpsI1UfFSD674rcIf4Zh8wnKg3OymNo
# AJI2nxqWdsGxDspCqymwplcDSAmJ4tRhj/pRtzbG1FoQqstqoWdOxWihgPcsskjH
# utOFtkcDg39uXTu85upM5xNfuIWt9SCaLZXc81pMEnTFzCBUGcFQq2ZNAuNiNMkh
# CIfvE9nSowgmPSYTLnIgrIo8+4nVpUImvqTAsIMxggU+MIIFOgIBATBpMFkxCzAJ
# BgNVBAYTAkJFMRkwFwYDVQQKExBHbG9iYWxTaWduIG52LXNhMS8wLQYDVQQDEyZH
# bG9iYWxTaWduIEdDQyBSNDUgQ29kZVNpZ25pbmcgQ0EgMjAyMAIMaQc/RoQJBHYw
# KBrNMAkGBSsOAwIaBQCgeDAYBgorBgEEAYI3AgEMMQowCKACgAChAoAAMBkGCSqG
# SIb3DQEJAzEMBgorBgEEAYI3AgEEMBwGCisGAQQBgjcCAQsxDjAMBgorBgEEAYI3
# AgEVMCMGCSqGSIb3DQEJBDEWBBRL8NftyipWg/AQSvBPtcbbsoczpDANBgkqhkiG
# 9w0BAQEFAASCAgAeQvUvdairyhsFwJ65LujwyljLWTwIrBPXqBadzlUzVFGzI/IZ
# d3RB3RddyvuzuZ2F3W3+OeTIu/GcX+pnkyla6FBUb8rMGVR4VS7BuGlccLKgjshV
# ccJNY/PiFLkCDS+PNwUAFPGsDpiOqP2++2o+AbV1BQBbZHv4p1GqXFv/PYmhuGvU
# /0q24VPm1jbdxBkkC5yT7vH8USWcMLCrTJbEODy393e77/H7eBkgcx9nZ0jCrEu7
# zUNOh0O9l8MHO47u036fkWSoxVoncmgQXKzI9m6EY59Xw45suLVhYo6IJdb/CjbX
# JCzh6SkrFhxx56/x/+QnCEpxZqle1squcPeArtQDMjgkjirGyBPl1PI4wZnlU05Y
# 6wqXluyk2nrczdMm8OsbGiNjJLPMniMwq2w+//MnnEKwkecoj9vk4zuh+GhHDZbF
# qT1qRHSamY+kzWS4z+UWRJF7UiHmW5ShEEYlBRJr4LZSO063fUTfhh8pSVdEVMvt
# YbEPI+czM4SJo5ySH65L2mql9ZgRSswKGcTDnEE20Blv5qG4ukdsmQCiAsGP87eb
# 0hb7KgloKTOQHYW2r/F0V+iFjUp5lt6TBb6KxYHokigkX4+bVTFyCqNrHQjHBdE8
# JSwabN//QxRs+2UiswIaY/CBRP4FtyErWYMNoGwh0tTmOUexfoZSAMXmgaGCAjAw
# ggIsBgkqhkiG9w0BCQYxggIdMIICGQIBATCBhjByMQswCQYDVQQGEwJVUzEVMBMG
# A1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cuZGlnaWNlcnQuY29tMTEw
# LwYDVQQDEyhEaWdpQ2VydCBTSEEyIEFzc3VyZWQgSUQgVGltZXN0YW1waW5nIENB
# AhANQkrgvjqI/2BAIc4UAPDdMA0GCWCGSAFlAwQCAQUAoGkwGAYJKoZIhvcNAQkD
# MQsGCSqGSIb3DQEHATAcBgkqhkiG9w0BCQUxDxcNMjIwMzI0MTIwMTIxWjAvBgkq
# hkiG9w0BCQQxIgQgVL5qj+EwNdyqxL7W7/qq75BgXYlIWouw/45yI+bdpZgwDQYJ
# KoZIhvcNAQEBBQAEggEANy1tit3nI8200LbVRhEdwfqsQzqARX3jU3iCo0CCEada
# +gUf7orWxr450s0aq7i2Q33kzg6pjBE3+7g5W+KVACJ7Nxzqab9wADYT7isZdPl3
# Ch62Dt9T8bFy4IE+LvKzjwUe4lN7Pvm4qMmyNZzqVnSTEabXt5Gt9fAwfeaMDv1d
# CrBDSNmP9w5C2OOv0jb1gmH4N/01QjERVXXSxvbGJAp1vyKzSCWBNdQ4GRbXjOOE
# Yjmj/HJrE6NHPlBll4cnAY6QyAG+zXHV59lZPqalutoYwuUKwjhJobFq1Q1TiYuN
# y4qqk7NEAXx9aFOHo+87gVVZ21akVz0rHSJQpnicng==
# SIG # End signature block
