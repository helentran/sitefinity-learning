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

namespace SitefinityDemo.ResourcePackages.Bootstrap4.MVC.Views.CheckboxesField
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/CheckboxesField/Write.Default_Inline.csht" +
        "ml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.CheckboxesField.CheckboxesFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
  
    var fieldName = Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 611), Tuple.Create("\"", 645)
            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 619), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 619), false)
, Tuple.Create(Tuple.Create(" ", 634), Tuple.Create("form-group", 635), true)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 713), Tuple.Create("\'", 754)
            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 718), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 718), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                            Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 849), Tuple.Create("\'", 905)
, Tuple.Create(Tuple.Create("", 857), Tuple.Create("{", 857), true)
, Tuple.Create(Tuple.Create(" ", 858), Tuple.Create("\"required\":", 859), true)
, Tuple.Create(Tuple.Create(" ", 870), Tuple.Create("\"", 871), true)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 872), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 872), false)
, Tuple.Create(Tuple.Create("", 903), Tuple.Create("\"}", 903), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"required-validator\"");

WriteAttribute("value", Tuple.Create(" value=\'", 969), Tuple.Create("\'", 1005)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 977), Tuple.Create<System.Object, System.Int32>(Model.IsRequired.ToString()
            
            #line default
            #line hidden
, 977), false)
);

WriteLiteral(" />\r\n\r\n    <ul");

WriteLiteral(" class=\"list-inline\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1040), Tuple.Create("\'", 1094)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1058), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 1058), false)
);

WriteLiteral(" ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                     if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                                               Write(Html.UniqueId("CheckboxGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                                                                                   Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                              } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                                           Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                                                                                                      } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            string selectedValue = !string.IsNullOrEmpty(value) ? value : Model.MetaField.DefaultValue;
            var selctedAttributes = !string.IsNullOrEmpty(selectedValue) && selectedValue.Contains(choice as string) ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1862), Tuple.Create("\"", 1879)
            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1869), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1869), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1880), Tuple.Create("\"", 1895)
            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1888), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1888), false)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" ");

            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                              Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"checkbox\" aria-required=\"");

            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                                                                                Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </li>\r\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
         if (Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2244), Tuple.Create("\"", 2261)
            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2251), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2251), false)
);

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-checkbox\"");

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" role=\"checkbox\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2364), Tuple.Create("\"", 2391)
            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                  , Tuple.Create(Tuple.Create("", 2380), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2380), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                     Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-text\"");

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2682), Tuple.Create("\"", 2709)
            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                      , Tuple.Create(Tuple.Create("", 2698), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2698), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2710), Tuple.Create("\"", 2752)
            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                               , Tuple.Create(Tuple.Create("", 2723), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 2723), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");

            
            #line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    
            
            #line default
            #line hidden
            
            #line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 2861), Tuple.Create("\'", 2901)
            
            #line 47 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2866), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupInfo")
            
            #line default
            #line hidden
, 2866), false)
);

WriteLiteral(">");

            
            #line 47 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                  Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 2952), Tuple.Create("\'", 2995)
            
            #line 49 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2957), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupMessage")
            
            #line default
            #line hidden
, 2957), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</fieldset>\r\n\r\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
