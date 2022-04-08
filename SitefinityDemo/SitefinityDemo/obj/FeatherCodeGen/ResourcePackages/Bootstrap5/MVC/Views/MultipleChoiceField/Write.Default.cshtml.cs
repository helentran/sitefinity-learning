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

namespace SitefinityDemo.ResourcePackages.Bootstrap5.MVC.Views.MultipleChoiceField
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
    
    #line 4 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/MultipleChoiceField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 703), Tuple.Create("\"", 731)
            
            #line 14 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 711), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 711), false)
, Tuple.Create(Tuple.Create(" ", 726), Tuple.Create("my-3", 727), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"form-label fs-6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 817), Tuple.Create("\'", 855)
            
            #line 15 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 822), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 822), false)
);

WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                      Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 948), Tuple.Create("\'", 1052)
, Tuple.Create(Tuple.Create("", 956), Tuple.Create("{", 956), true)
, Tuple.Create(Tuple.Create(" ", 957), Tuple.Create("\"required\":", 958), true)
, Tuple.Create(Tuple.Create(" ", 969), Tuple.Create("\"", 970), true)
            
            #line 16 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 971), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 971), false)
, Tuple.Create(Tuple.Create("", 1002), Tuple.Create("\",", 1002), true)
, Tuple.Create(Tuple.Create(" ", 1004), Tuple.Create("\"maxLength\":\"", 1005), true)
            
            #line 16 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                , Tuple.Create(Tuple.Create("", 1018), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1018), false)
, Tuple.Create(Tuple.Create("", 1050), Tuple.Create("\"}", 1050), true)
);

WriteLiteral(" />\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1087), Tuple.Create("\'", 1138)
            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1105), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1105), false)
);

WriteLiteral(" ");

            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                    if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                              Write(Html.UniqueId("RadioGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                               Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                                                       } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                                                                                    Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                                                                                                                                            } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 18 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
          int i = 0;
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var selctedAttributes = isSelected ? "checked" : string.Empty;
            i++;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(">\r\n                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 1935), Tuple.Create("\"", 1976)
            
            #line 28 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1941), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 1941), false)
);

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 29 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                      
                        var val = choice;
                        if (val.Length > 255)
                        {
                            val = val.Substring(0, 255);
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2344), Tuple.Create("\"", 2361)
            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2351), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2351), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2362), Tuple.Create("\"", 2402)
            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2367), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 2367), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 2403), Tuple.Create("\"", 2415)
            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                      , Tuple.Create(Tuple.Create("", 2411), Tuple.Create<System.Object, System.Int32>(val
            
            #line default
            #line hidden
, 2411), false)
);

WriteLiteral(" class=\"form-check-input\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                           Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                              Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"radio\" aria-required=\"");

            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                                                                              Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n            </li>\r\n");

            
            #line 40 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 41 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         if (Model.HasOtherChoice)
        {
            i++;

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <div");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(">\r\n                    <label");

WriteAttribute("for", Tuple.Create(" for=\"", 2750), Tuple.Create("\"", 2791)
            
            #line 46 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2756), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 2756), false)
);

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 47 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                   Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 48 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                 Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 3046), Tuple.Create("\"", 3063)
            
            #line 50 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3053), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 3053), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 3064), Tuple.Create("\"", 3104)
            
            #line 50 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3069), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 3069), false)
);

WriteLiteral(" class=\"form-check-input\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" role=\"radio\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 3236), Tuple.Create("\"", 3263)
            
            #line 50 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 3252), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 3252), false)
);

WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"ms-4\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" class=\"form-control mt-2\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 3444), Tuple.Create("\"", 3471)
            
            #line 53 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                   , Tuple.Create(Tuple.Create("", 3460), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 3460), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 3472), Tuple.Create("\"", 3514)
            
            #line 53 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                            , Tuple.Create(Tuple.Create("", 3485), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 3485), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </li>\r\n");

            
            #line 56 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"

        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n    \r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 3601), Tuple.Create("\'", 3646)
            
            #line 60 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3606), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupErrorMessage")
            
            #line default
            #line hidden
, 3606), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"invalid-feedback\"");

WriteLiteral("></div> \r\n\r\n");

            
            #line 62 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 62 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 3791), Tuple.Create("\'", 3828)
            
            #line 64 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3796), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupInfo")
            
            #line default
            #line hidden
, 3796), false)
);

WriteLiteral(" class=\"form-text\"");

WriteLiteral(">");

            
            #line 64 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                              Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 65 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n</fieldset>\r\n\r\n");

            
            #line 69 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
