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
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/Lists/List.ExpandableList.cshtml")]
    public partial class List_ExpandableList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {

#line 51 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
public System.Web.WebPages.HelperResult GetAngleDirection()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 52 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
 
    if (Html.RenderDirAttribute().ToString() != "dir=\"rtl\"")
    {
        

#line default
#line hidden

#line 55 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("angle-right"));


#line default
#line hidden

#line 55 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                         ;
    }
    else
    {
        

#line default
#line hidden

#line 59 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("angle-left"));


#line default
#line hidden

#line 59 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                        ;
    }


#line default
#line hidden
});

#line 61 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
}
#line default
#line hidden

        public List_ExpandableList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 221), Tuple.Create("\"", 244)
            
            #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
, Tuple.Create(Tuple.Create("", 229), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 229), false)
);

WriteLiteral(" data-sf-role=\"lists\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"float-end\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" data-sf-role=\"expandAll\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">");

            
            #line 12 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                           Write(Html.Resource("ExpandAll"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <button");

WriteLiteral(" data-sf-role=\"collapseAll\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">");

            
            #line 13 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                                   Write(Html.Resource("CollapseAll"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        </div>\r\n\r\n        <div>\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
             foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h3 ");

            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                                                   Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">\r\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 23 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                     foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div ");

            
            #line 25 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                               ");

            
            #line 27 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                          Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                               data-sf-role=\"toggleLink\"\r\n                     " +
"          role=\"button\"\r\n                               data-toggle=\"collapse\"\r\n" +
"                               data-target=\"#");

            
            #line 31 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                        Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                               aria-expanded=\"false\"\r\n                        " +
"       aria-controls=\"");

            
            #line 33 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                         Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                                    <use");

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral(" data-sf-toggle=\"collapsed\"");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1929), Tuple.Create("\"", 2022)
, Tuple.Create(Tuple.Create("", 1942), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 1942), false)
            
            #line 35 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                 , Tuple.Create(Tuple.Create("", 2002), Tuple.Create<System.Object, System.Int32>(GetAngleDirection()
            
            #line default
            #line hidden
, 2002), false)
);

WriteLiteral("></use>\r\n                                    <use");

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral(" data-sf-toggle=\"expanded\"");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 2119), Tuple.Create("\"", 2202)
, Tuple.Create(Tuple.Create("", 2132), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#angle-down")
, 2132), false)
);

WriteLiteral(" style=\"display:none\"");

WriteLiteral("></use>\r\n                                </svg>\r\n");

WriteLiteral("                                ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                           Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n                            <div ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                            Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(" style=\"display:none;\" class=\"ms-4 collapse multi-collapse\" id=\'");

            
            #line 40 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                                                                                     Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\'>\r\n");

WriteLiteral("                                ");

            
            #line 41 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                           Write(Html.HtmlSanitize((string)listItem.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");

            
            #line 44 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n");

            
            #line 46 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");

WriteLiteral("\r\n");

            
            #line 62 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Lists\List.ExpandableList.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Lists/lists.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
