#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityDemo.ResourcePackages.Bootstrap4.MVC.Views.StyleSheet
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..MVC\Views\StyleSheet\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/StyleSheet/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"sf-Code\"");

WriteLiteral(">\r\n    <pre>\r\n");

WriteLiteral("    ");

            
            #line 5 "..\..MVC\Views\StyleSheet\Index.cshtml"
Write(ViewBag.DesignModeContent);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\StyleSheet\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..MVC\Views\StyleSheet\Index.cshtml"
     if(!ViewBag.HasDescription)
    {
        
            
            #line default
            #line hidden
            
            #line 8 "..\..MVC\Views\StyleSheet\Index.cshtml"
   Write(Html.Resource("IncludedInHead"));

            
            #line default
            #line hidden
            
            #line 8 "..\..MVC\Views\StyleSheet\Index.cshtml"
                                        ;
    }

            
            #line default
            #line hidden
WriteLiteral("    </pre>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
