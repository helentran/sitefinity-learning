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

namespace SitefinityDemo.ResourcePackages.Bootstrap4.MVC.Views.DropdownListField
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
    
    #line 4 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/DropdownListField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.DropdownListField.DropdownListFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
  
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 482), Tuple.Create("\"", 516)
            
            #line 12 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 490), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 490), false)
, Tuple.Create(Tuple.Create(" ", 505), Tuple.Create("form-group", 506), true)
);

WriteLiteral(" data-sf-role=\"dropdown-list-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 623), Tuple.Create("\'", 679)
, Tuple.Create(Tuple.Create("", 631), Tuple.Create("{", 631), true)
, Tuple.Create(Tuple.Create(" ", 632), Tuple.Create("\"required\":", 633), true)
, Tuple.Create(Tuple.Create(" ", 644), Tuple.Create("\"", 645), true)
            
            #line 13 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 646), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 646), false)
, Tuple.Create(Tuple.Create("", 677), Tuple.Create("\"}", 677), true)
);

WriteLiteral(" />\r\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 706), Tuple.Create("\'", 738)
            
            #line 14 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 712), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 712), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
   Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </label>\r\n    <select");

WriteAttribute("id", Tuple.Create(" id=\'", 799), Tuple.Create("\'", 830)
            
            #line 17 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 804), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 804), false)
);

WriteLiteral("\r\n            data-sf-role=\"dropdown-list-field-select\"");

WriteAttribute("name", Tuple.Create("\r\n            name=\"", 886), Tuple.Create("\"", 932)
            
            #line 19 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 906), false)
);

WriteLiteral("\r\n            ");

            
            #line 20 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
       Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n            class=\"form-control\"\r\n            aria-required=\"");

            
            #line 22 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                      Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");

            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
              if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                        Write(Html.UniqueId("DropdownInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                       Write(Html.UniqueId("DropdownErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                                                                             } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                                                                                                          Write(Html.UniqueId("DropdownErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                                                                                                                                                                } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 24 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 24 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                            (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var optionAttributes = isSelected ? "selected" : string.Empty;
            var optionValue = Model.IsRequired && choice == Model.Choices.FirstOrDefault() ? string.Empty : choice;


            
            #line default
            #line hidden
WriteLiteral("            <option ");

            
            #line 33 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
               Write(optionAttributes);

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 33 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                        Write(optionValue);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 33 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                      Write(choice);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 34 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </select>\r\n\r\n");

            
            #line 37 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 2056), Tuple.Create("\'", 2091)
            
            #line 39 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2061), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("DropdownInfo")
            
            #line default
            #line hidden
, 2061), false)
);

WriteLiteral(">");

            
            #line 39 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                             Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 40 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 2142), Tuple.Create("\'", 2185)
            
            #line 41 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2147), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("DropdownErrorMessage")
            
            #line default
            #line hidden
, 2147), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</div>\r\n\r\n");

            
            #line 44 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
