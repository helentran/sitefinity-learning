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
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/MultipleChoiceField/Write.Default_Inline." +
        "cshtml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 703), Tuple.Create("\"", 731)
            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
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
            
            #line 15 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 822), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 822), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
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
            
            #line 16 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 971), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 971), false)
, Tuple.Create(Tuple.Create("", 1002), Tuple.Create("\",", 1002), true)
, Tuple.Create(Tuple.Create(" ", 1004), Tuple.Create("\"maxLength\":\"", 1005), true)
            
            #line 16 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                , Tuple.Create(Tuple.Create("", 1018), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1018), false)
, Tuple.Create(Tuple.Create("", 1050), Tuple.Create("\"}", 1050), true)
);

WriteLiteral(" />\r\n    <ul");

WriteLiteral(" class=\"list-inline\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1085), Tuple.Create("\'", 1136)
            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1103), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1103), false)
);

WriteLiteral(" ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                  if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                            Write(Html.UniqueId("RadioGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                             Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                     } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                                  Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                                                                                          } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
          int i = 0;
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
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

WriteLiteral(" class=\"form-check form-check-inline\"");

WriteLiteral(">\r\n                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 1951), Tuple.Create("\"", 1992)
            
            #line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1957), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 1957), false)
);

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                      
                        var val = choice;
                        if (val.Length > 255)
                        {
                            val = val.Substring(0, 255);
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2360), Tuple.Create("\"", 2377)
            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2367), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2367), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2378), Tuple.Create("\"", 2418)
            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2383), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 2383), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 2419), Tuple.Create("\"", 2431)
            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                      , Tuple.Create(Tuple.Create("", 2427), Tuple.Create<System.Object, System.Int32>(val
            
            #line default
            #line hidden
, 2427), false)
);

WriteLiteral(" class=\"form-check-input\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                           Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                              Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"radio\" aria-required=\"");

            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                              Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n            </li>\r\n");

            
            #line 40 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 41 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if (Model.HasOtherChoice)
        {
            i++;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"form-check form-check-inline text-nowrap\"");

WriteLiteral(">\r\n                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 2769), Tuple.Create("\"", 2810)
            
            #line 45 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2775), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 2775), false)
);

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 47 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                             Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 3049), Tuple.Create("\"", 3066)
            
            #line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 3056), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 3056), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 3067), Tuple.Create("\"", 3107)
            
            #line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 3072), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 3072), false)
);

WriteLiteral(" class=\"form-check-input\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" role=\"radio\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 3239), Tuple.Create("\"", 3266)
            
            #line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 3255), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 3255), false)
);

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" class=\"form-control d-inline-block align-top\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 3403), Tuple.Create("\"", 3430)
            
            #line 50 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                   , Tuple.Create(Tuple.Create("", 3419), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 3419), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 3431), Tuple.Create("\"", 3473)
            
            #line 50 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                            , Tuple.Create(Tuple.Create("", 3444), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 3444), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");

            
            #line 54 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    
            
            #line default
            #line hidden
            
            #line 54 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 3563), Tuple.Create("\'", 3600)
            
            #line 56 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 3568), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupInfo")
            
            #line default
            #line hidden
, 3568), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 56 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 57 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 3670), Tuple.Create("\'", 3715)
            
            #line 58 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 3675), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupErrorMessage")
            
            #line default
            #line hidden
, 3675), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</fieldset>\r\n\r\n");

            
            #line 61 "..\..\ResourcePackages\Bootstrap5\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
