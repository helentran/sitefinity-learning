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

namespace SitefinityDemo.ResourcePackages.Bootstrap4.MVC.Views.HiddenField
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
    
    #line 3 "..\..MVC\Views\HiddenField\Read.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\HiddenField\Read.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/HiddenField/Read.Default.cshtml")]
    public partial class Read_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.HiddenField.HiddenFieldViewModel>
    {
        public Read_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<input");

WriteAttribute("id", Tuple.Create(" id=\'", 207), Tuple.Create("\'", 241)
            
            #line 6 "..\..MVC\Views\HiddenField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 212), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("HiddenField")
            
            #line default
            #line hidden
, 212), false)
);

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 256), Tuple.Create("\"", 289)
            
            #line 6 "..\..MVC\Views\HiddenField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 263), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 263), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 290), Tuple.Create("\"", 327)
            
            #line 6 "..\..MVC\Views\HiddenField\Read.Default.cshtml"
                  , Tuple.Create(Tuple.Create("", 298), Tuple.Create<System.Object, System.Int32>(Model.MetaField.DefaultValue
            
            #line default
            #line hidden
, 298), false)
);

WriteLiteral(" />");

        }
    }
}
#pragma warning restore 1591
