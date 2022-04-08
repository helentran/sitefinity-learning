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

namespace SitefinityDemo.ResourcePackages.Bootstrap4.MVC.Views.ImageGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/ImageGallery/List.ImageGallery.cshtml")]
    public partial class List_ImageGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ImageGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\r\n  <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 361), Tuple.Create("\"", 416)
, Tuple.Create(Tuple.Create("", 369), Tuple.Create("sf-Gallery-thumbs", 369), true)
, Tuple.Create(Tuple.Create(" ", 386), Tuple.Create("list-unstyled", 387), true)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 400), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 401), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 417), Tuple.Create("\"", 460)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 430), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 430), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
     for (int i = 0; i < Model.Items.Count(); i++)
    {
        var item = Model.Items.ElementAt(i);
        var thumbnailViewModel = (ThumbnailViewModel)item;

        var itemIndex = (Model.CurrentPage - 1) * ViewBag.ItemsPerPage + i + 1;
        var detailPageUrl = ViewBag.OpenInSamePage ? HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex) :
            HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"d-inline-block\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("href", Tuple.Create("\r\n               href=\"", 1080), Tuple.Create("\"", 1117)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1103), Tuple.Create<System.Object, System.Int32>(detailPageUrl
            
            #line default
            #line hidden
, 1103), false)
);

WriteAttribute("title", Tuple.Create("\r\n               title=\"", 1118), Tuple.Create("\"", 1180)
, Tuple.Create(Tuple.Create("", 1142), Tuple.Create("Go", 1142), true)
, Tuple.Create(Tuple.Create(" ", 1144), Tuple.Create("to", 1145), true)
, Tuple.Create(Tuple.Create(" ", 1147), Tuple.Create("image", 1148), true)
            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 1153), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 1154), false)
, Tuple.Create(Tuple.Create(" ", 1172), Tuple.Create("details", 1173), true)
);

WriteLiteral(">\r\n                <img");

WriteLiteral(" loading=\"lazy\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1219), Tuple.Create("\"", 1259)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1225), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 1225), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1260), Tuple.Create("\'", 1358)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
  , Tuple.Create(Tuple.Create("", 1266), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1266), false)
);

WriteLiteral("\r\n                     ");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
                Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                     ");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
                Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n            </a>\r\n        </li>\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("  </ul>\r\n</div>\r\n\r\n");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
