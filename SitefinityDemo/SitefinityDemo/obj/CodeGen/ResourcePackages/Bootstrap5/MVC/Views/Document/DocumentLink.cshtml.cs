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

namespace SitefinityDemo.ResourcePackages.Bootstrap5.MVC.Views.Document
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/Document/DocumentLink.cshtml")]
    public partial class DocumentLink : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.Document.DocumentViewModel>
    {

#line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
public System.Web.WebPages.HelperResult GetFileExtensionCssClass(String extension)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 29 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
 

    if (extension == "xlsx")
    {
        

#line default
#line hidden

#line 33 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-green"));


#line default
#line hidden

#line 33 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                      ;
    }
    else if (extension == "doc" || extension == "docx")
    {
        

#line default
#line hidden

#line 37 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-blue"));


#line default
#line hidden

#line 37 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                     ;
    }
	else if (extension == "ppt" || extension == "pptx")
    {
        

#line default
#line hidden

#line 41 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-orange"));


#line default
#line hidden

#line 41 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                       ;
    }
	else if (extension == "pdf")
    {
        

#line default
#line hidden

#line 45 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-red"));


#line default
#line hidden

#line 45 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                    ;
    }
	else if (extension == "zip")
    {
        

#line default
#line hidden

#line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-purple"));


#line default
#line hidden

#line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                       ;
    }
	else
	{
        

#line default
#line hidden

#line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-gray"));


#line default
#line hidden

#line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                     ;
	}


#line default
#line hidden
});

#line 55 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
}
#line default
#line hidden

        public DocumentLink()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 137), Tuple.Create("\"", 160)
            
            #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 145), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 145), false)
);

WriteLiteral(">\r\n");

            
            #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
     if(!string.IsNullOrEmpty(Model.MediaUrl))
    {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"d-flex gap-3 align-items-center\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"flex-shrink-0 pt-1\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"fa-layers fa-3x\"");

WriteLiteral(">\r\n                <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(">\r\n                    <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 452), Tuple.Create("\"", 529)
, Tuple.Create(Tuple.Create("", 465), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#file")
, 465), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n                </svg>\r\n                <span");

WriteAttribute("class", Tuple.Create(" class=\"", 605), Tuple.Create("\"", 763)
, Tuple.Create(Tuple.Create("", 613), Tuple.Create("fa-layers-text", 613), true)
, Tuple.Create(Tuple.Create(" ", 627), Tuple.Create("fa-layers-bottom-right", 628), true)
, Tuple.Create(Tuple.Create(" ", 650), Tuple.Create("text-uppercase", 651), true)
, Tuple.Create(Tuple.Create(" ", 665), Tuple.Create("ps-3", 666), true)
, Tuple.Create(Tuple.Create(" ", 670), Tuple.Create("pe-3", 671), true)
, Tuple.Create(Tuple.Create(" ", 675), Tuple.Create("mb-2", 676), true)
, Tuple.Create(Tuple.Create(" ", 680), Tuple.Create("text-white", 681), true)
            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                            , Tuple.Create(Tuple.Create(" ", 691), Tuple.Create<System.Object, System.Int32>(GetFileExtensionCssClass(Model.Extension)
            
            #line default
            #line hidden
, 692), false)
, Tuple.Create(Tuple.Create(" ", 734), Tuple.Create("sf-icon-txt-", 735), true)
            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                                                                    , Tuple.Create(Tuple.Create("", 747), Tuple.Create<System.Object, System.Int32>(Model.Extension
            
            #line default
            #line hidden
, 747), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                                                                                                                                                                Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(" role=\"group\"");

WriteLiteral(">\r\n            <div>\r\n                <a");

WriteAttribute("class", Tuple.Create(" class=\"", 911), Tuple.Create("\"", 957)
            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 919), Tuple.Create<System.Object, System.Int32>(String.Concat(" sf", Model.Extension)
            
            #line default
            #line hidden
, 919), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 958), Tuple.Create("\"", 980)
            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 965), Tuple.Create<System.Object, System.Int32>(Model.MediaUrl
            
            #line default
            #line hidden
, 965), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                                                                                    Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                <span");

WriteLiteral(" class=\"text-muted small\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1062), Tuple.Create("\"", 1107)
            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 1075), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileExtension")
            
            #line default
            #line hidden
, 1075), false)
);

WriteLiteral(">(");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                                                                         Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n            </div>\r\n            <span");

WriteLiteral(" class=\"text-muted small\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1198), Tuple.Create("\"", 1238)
            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 1211), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileSize")
            
            #line default
            #line hidden
, 1211), false)
);

WriteLiteral(">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
                                                                               Write(Model.FileSize);

            
            #line default
            #line hidden
WriteLiteral(" KB</span>\r\n        </div>\r\n    </div>\r\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Document\DocumentLink.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
