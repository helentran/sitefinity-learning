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

namespace SitefinityDemo.ResourcePackages.Bootstrap5.MVC.Views.DocumentsList
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
    
    #line 3 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/DocumentsList/Detail.DocumentDetails.cshtml")]
    public partial class Detail_DocumentDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentDetailsViewModel>
    {

#line 47 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
public System.Web.WebPages.HelperResult GetFileExtensionCssClass(String extension)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 48 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
 

    if (extension == "xlsx")
    {
        

#line default
#line hidden

#line 52 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-green"));


#line default
#line hidden

#line 52 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                      ;
    }
    else if (extension == "doc" || extension == "docx")
    {
        

#line default
#line hidden

#line 56 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-blue"));


#line default
#line hidden

#line 56 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                     ;
    }
	else if (extension == "ppt" || extension == "pptx")
    {
        

#line default
#line hidden

#line 60 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-orange"));


#line default
#line hidden

#line 60 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                       ;
    }
	else if (extension == "pdf")
    {
        

#line default
#line hidden

#line 64 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-red"));


#line default
#line hidden

#line 64 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                    ;
    }
	else if (extension == "zip")
    {
        

#line default
#line hidden

#line 68 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-purple"));


#line default
#line hidden

#line 68 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                       ;
    }
	else
	{
        

#line default
#line hidden

#line 72 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-gray"));


#line default
#line hidden

#line 72 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                     ;
	}


#line default
#line hidden
});

#line 74 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
}
#line default
#line hidden

        public Detail_DocumentDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 195), Tuple.Create("\"", 218)
            
            #line 6 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 203), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 203), false)
);

WriteLiteral(" role=\"group\"");

WriteLiteral(">\r\n\r\n    <h1>\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </h1>\r\n\r\n    <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 13 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                 Write(Html.Resource("PublishedOn"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

            
            #line 19 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Description))
    {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"mt-3\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 683), Tuple.Create("\"", 730)
            
            #line 21 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 696), Tuple.Create<System.Object, System.Int32>(Html.Resource(" DocumentSummary")
            
            #line default
            #line hidden
, 696), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 24 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"d-flex gap-3 align-items-center mt-3\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"flex-shrink-0 pt-1\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"fa-layers fa-3x\"");

WriteLiteral(">\r\n                <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(">\r\n                    <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1033), Tuple.Create("\"", 1110)
, Tuple.Create(Tuple.Create("", 1046), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#file")
, 1046), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n                </svg>\r\n                <span");

WriteAttribute("class", Tuple.Create(" class=\"", 1186), Tuple.Create("\"", 1344)
, Tuple.Create(Tuple.Create("", 1194), Tuple.Create("fa-layers-text", 1194), true)
, Tuple.Create(Tuple.Create(" ", 1208), Tuple.Create("fa-layers-bottom-right", 1209), true)
, Tuple.Create(Tuple.Create(" ", 1231), Tuple.Create("text-uppercase", 1232), true)
, Tuple.Create(Tuple.Create(" ", 1246), Tuple.Create("ps-3", 1247), true)
, Tuple.Create(Tuple.Create(" ", 1251), Tuple.Create("pe-3", 1252), true)
, Tuple.Create(Tuple.Create(" ", 1256), Tuple.Create("mb-2", 1257), true)
, Tuple.Create(Tuple.Create(" ", 1261), Tuple.Create("text-white", 1262), true)
            
            #line 32 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                           , Tuple.Create(Tuple.Create(" ", 1272), Tuple.Create<System.Object, System.Int32>(GetFileExtensionCssClass(Model.Extension)
            
            #line default
            #line hidden
, 1273), false)
, Tuple.Create(Tuple.Create(" ", 1315), Tuple.Create("sf-icon-txt-", 1316), true)
            
            #line 32 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                   , Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(Model.Extension
            
            #line default
            #line hidden
, 1328), false)
);

WriteLiteral(">");

            
            #line 32 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                                                                                                                Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(" role=\"group\"");

WriteLiteral(">\r\n            <div>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1492), Tuple.Create("\"", 1526)
            
            #line 37 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1499), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1499), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 37 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                 Write(Html.Resource("Download"));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 37 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                                                         Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n                <span");

WriteLiteral(" class=\"text-muted small\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1683), Tuple.Create("\"", 1728)
            
            #line 38 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1696), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileExtension")
            
            #line default
            #line hidden
, 1696), false)
);

WriteLiteral(">(");

            
            #line 38 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                         Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n            </div>\r\n            <span");

WriteLiteral(" class=\"text-muted small\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1819), Tuple.Create("\"", 1859)
            
            #line 40 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1832), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileSize")
            
            #line default
            #line hidden
, 1832), false)
);

WriteLiteral(">");

            
            #line 40 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                Write(Math.Ceiling((double)Model.Item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
