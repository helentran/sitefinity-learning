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

namespace SitefinityDemo.ResourcePackages.Bootstrap5.MVC.Views.Lists
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/Lists/List.AnchorList.cshtml")]
    public partial class List_AnchorList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_AnchorList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 200), Tuple.Create("\"", 223)
            
            #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 208), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 208), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1 ");

            
            #line 11 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n            <a");

WriteAttribute("id", Tuple.Create(" id=\"", 404), Tuple.Create("\"", 428)
            
            #line 12 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 409), Tuple.Create<System.Object, System.Int32>(item.Fields.Id
            
            #line default
            #line hidden
, 409), false)
, Tuple.Create(Tuple.Create("", 424), Tuple.Create("-Top", 424), true)
);

WriteLiteral("\r\n               ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
          Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n               href=\"#");

            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                 Write(item.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                                  Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </h1>\r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <ul>\r\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
             foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    <a ");

            
            #line 21 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                  Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                       href=\"#");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                         Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                                              Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1 ");

            
            #line 30 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            id=\"");

            
            #line 32 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
           Write(item.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </h1>\r\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"

        foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(" ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                         Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <h3 ");

            
            #line 39 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
               Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    id=\"");

            
            #line 40 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                   Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");

WriteLiteral("                    ");

            
            #line 41 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
               Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n\r\n                <div ");

            
            #line 44 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 44 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                                                                          Write(Html.HtmlSanitize((string)listItem.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <div");

WriteLiteral(" class=\"mt-2\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2049), Tuple.Create("\"", 2076)
, Tuple.Create(Tuple.Create("", 2056), Tuple.Create("#", 2056), true)
            
            #line 47 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 2057), Tuple.Create<System.Object, System.Int32>(item.Fields.Id
            
            #line default
            #line hidden
, 2057), false)
, Tuple.Create(Tuple.Create("", 2072), Tuple.Create("-Top", 2072), true)
);

WriteLiteral("> \r\n                        <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                            <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 2194), Tuple.Create("\"", 2275)
, Tuple.Create(Tuple.Create("", 2207), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#arrow-up")
, 2207), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n                        </svg> \r\n");

WriteLiteral("                        ");

            
            #line 51 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
                   Write(Html.Resource("BackToTop"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");

            
            #line 55 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.AnchorList.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
