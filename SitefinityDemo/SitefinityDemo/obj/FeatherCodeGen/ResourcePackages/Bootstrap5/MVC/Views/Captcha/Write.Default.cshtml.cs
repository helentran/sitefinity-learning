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

namespace SitefinityDemo.ResourcePackages.Bootstrap5.MVC.Views.Captcha
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
    
    #line 3 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Captcha/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.Captcha.CaptchaViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"field-captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteAttribute("class", Tuple.Create(" class=\"", 329), Tuple.Create("\"", 357)
            
            #line 7 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 337), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 337), false)
, Tuple.Create(Tuple.Create(" ", 352), Tuple.Create("my-3", 353), true)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-12 mb-2\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"d-flex gap-4\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteAttribute("src", Tuple.Create(" src=\'", 508), Tuple.Create("\'", 561)
            
            #line 11 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 514), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 514), false)
);

WriteLiteral(" width=\"180\"");

WriteLiteral(" height=\"50\"");

WriteLiteral(" />\r\n");

            
            #line 12 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                
            
            #line default
            #line hidden
            
            #line 12 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                 if (Model.EnableAudioCode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" class=\"btn btn-light\"");

WriteLiteral(" data-sf-role=\"captcha-audio-btn\"");

WriteLiteral(" type=\"button\"");

WriteAttribute("title", Tuple.Create(" title=\"", 751), Tuple.Create("\"", 796)
            
            #line 14 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                         , Tuple.Create(Tuple.Create("", 759), Tuple.Create<System.Object, System.Int32>(Html.Resource("CaptchaAudioTooltip")
            
            #line default
            #line hidden
, 759), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 797), Tuple.Create("\"", 847)
            
            #line 14 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                                            , Tuple.Create(Tuple.Create("", 810), Tuple.Create<System.Object, System.Int32>(Html.Resource("CaptchaAudioTooltip")
            
            #line default
            #line hidden
, 810), false)
);

WriteLiteral(">\r\n                        <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                            <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 964), Tuple.Create("\"", 1046)
, Tuple.Create(Tuple.Create("", 977), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#volume-up")
, 977), false)
);

WriteLiteral("></use>\r\n                        </svg>\r\n                    </button>\r\n");

WriteLiteral("                    <audio");

WriteLiteral(" data-sf-role=\"captcha-audio\"");

WriteLiteral(" controls");

WriteLiteral(" style=\"display:none\"");

WriteLiteral("></audio>\r\n");

            
            #line 20 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            <div");

WriteLiteral(" class=\"mt-2\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"link-secondary\"");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral(">\r\n                    <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-14\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1463), Tuple.Create("\"", 1540)
, Tuple.Create(Tuple.Create("", 1476), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#sync")
, 1476), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n                    </svg>\r\n");

WriteLiteral("                    ");

            
            #line 27 "..\..MVC\Views\Captcha\Write.Default.cshtml"
               Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n            </div>\r\n        </div>\r\n        \r\n        <di" +
"v");

WriteLiteral(" class=\"col-auto\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1812), Tuple.Create("\'", 1887)
, Tuple.Create(Tuple.Create("", 1820), Tuple.Create("{\"required\":", 1820), true)
, Tuple.Create(Tuple.Create(" ", 1832), Tuple.Create("\"", 1833), true)
            
            #line 33 "..\..MVC\Views\Captcha\Write.Default.cshtml"
        , Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1834), false)
, Tuple.Create(Tuple.Create("", 1885), Tuple.Create("\"}", 1885), true)
);

WriteLiteral(" />\r\n            <label");

WriteAttribute("for", Tuple.Create(" for=\'", 1911), Tuple.Create("\'", 1942)
            
            #line 34 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1917), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1917), false)
);

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">");

            
            #line 34 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                                 Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral(" </label>\r\n            <input");

WriteAttribute("id", Tuple.Create(" id=\'", 2023), Tuple.Create("\'", 2053)
            
            #line 35 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2028), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 2028), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2095), Tuple.Create("\"", 2129)
            
            #line 35 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                 , Tuple.Create(Tuple.Create("", 2102), Tuple.Create<System.Object, System.Int32>(Model.CaptchaAnswerFormKey
            
            #line default
            #line hidden
, 2102), false)
);

WriteLiteral(" required=\"required\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"invalid-feedback\"");

WriteLiteral("></div>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-k\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2359), Tuple.Create("\"", 2390)
            
            #line 39 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2366), Tuple.Create<System.Object, System.Int32>(Model.CaptchaKeyFormKey
            
            #line default
            #line hidden
, 2366), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2452), Tuple.Create("\"", 2478)
            
            #line 40 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2460), Tuple.Create<System.Object, System.Int32>(Model.GenerateUrl
            
            #line default
            #line hidden
, 2460), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-iam\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2535), Tuple.Create("\'", 2580)
            
            #line 41 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2543), Tuple.Create<System.Object, System.Int32>(Html.Resource("CaptchaErrorMessage")
            
            #line default
            #line hidden
, 2543), false)
);

WriteLiteral(" />\r\n</div>\r\n");

            
            #line 43 "..\..MVC\Views\Captcha\Write.Default.cshtml"
 if (SystemManager.IsDesignMode)
{
    var scriptUrl = Url.WidgetContent("Mvc/Scripts/Captcha/captcha.js");
    var queryAddition = scriptUrl.Contains("?") ? "&" : "?";
    var fullScriptUrl = scriptUrl + queryAddition + string.Format("_={0}", DateTime.UtcNow.Ticks.ToString());


            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\'", 2914), Tuple.Create("\'", 2934)
            
            #line 49 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2920), Tuple.Create<System.Object, System.Int32>(fullScriptUrl
            
            #line default
            #line hidden
, 2920), false)
);

WriteLiteral("></script>\r\n");

            
            #line 50 "..\..MVC\Views\Captcha\Write.Default.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 53 "..\..MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 53 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                                                    
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
