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

namespace SitefinityDemo.ResourcePackages.Bootstrap5.MVC.Views.SearchBox
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
    
    #line 5 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(!String.IsNullOrEmpty(Model.CssClass) ?
        Html.Raw(String.Format("<div class=\"{0}\">", HttpUtility.HtmlAttributeEncode(Model.CssClass))) :
        Html.Raw("<div>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"d-flex gap-3 my-3\"");

WriteLiteral(" role=\"search\"");

WriteLiteral(">\r\n\r\n    <input");

WriteLiteral(" type=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 543), Tuple.Create("\"", 580)
            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 551), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 551), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 581), Tuple.Create("\"", 616)
            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 595), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 595), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 617), Tuple.Create("\"", 638)
            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                        , Tuple.Create(Tuple.Create("", 622), Tuple.Create<System.Object, System.Int32>(searchTextBoxId
            
            #line default
            #line hidden
, 622), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 660), Tuple.Create("\"", 690)
            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                       , Tuple.Create(Tuple.Create("", 668), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchQuery
            
            #line default
            #line hidden
, 668), false)
);

WriteLiteral(" aria-autocomplete=\"both\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\'", 716), Tuple.Create("\'", 763)
            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                                         , Tuple.Create(Tuple.Create("", 735), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 735), false)
);

WriteLiteral(" />\r\n\r\n    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("id", Tuple.Create(" id=\"", 820), Tuple.Create("\"", 842)
            
            #line 17 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 825), Tuple.Create<System.Object, System.Int32>(searchButtonId
            
            #line default
            #line hidden
, 825), false)
);

WriteLiteral(" ");

            
            #line 17 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                     Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                    Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n    <span");

WriteAttribute("id", Tuple.Create(" id=\'", 941), Tuple.Create("\'", 974)
            
            #line 18 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 946), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 946), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" hidden>When autocomplete results are available use up and down arrows to review " +
"and enter to select.</span>\r\n\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1158), Tuple.Create("\"", 1185)
            
            #line 21 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1166), Tuple.Create<System.Object, System.Int32>(Model.ResultsUrl
            
            #line default
            #line hidden
, 1166), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1245), Tuple.Create("\"", 1276)
            
            #line 22 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1253), Tuple.Create<System.Object, System.Int32>(Model.IndexCatalogue
            
            #line default
            #line hidden
, 1253), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1331), Tuple.Create("\"", 1368)
            
            #line 23 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1339), Tuple.Create<System.Object, System.Int32>(Model.WordsMode.ToString()
            
            #line default
            #line hidden
, 1339), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1432), Tuple.Create("\'", 1490)
            
            #line 24 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1440), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? ("true") : ("false")
            
            #line default
            #line hidden
, 1440), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1555), Tuple.Create("\"", 1591)
            
            #line 25 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1563), Tuple.Create<System.Object, System.Int32>(Model.MinSuggestionLength
            
            #line default
            #line hidden
, 1563), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1653), Tuple.Create("\"", 1686)
            
            #line 26 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1661), Tuple.Create<System.Object, System.Int32>(Model.SuggestionFields
            
            #line default
            #line hidden
, 1661), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1740), Tuple.Create("\"", 1765)
            
            #line 27 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1748), Tuple.Create<System.Object, System.Int32>(Model.Language
            
            #line default
            #line hidden
, 1748), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"siteId\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1817), Tuple.Create("\"", 1871)
            
            #line 28 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1825), Tuple.Create<System.Object, System.Int32>(SystemManager.CurrentContext.CurrentSite.Id
            
            #line default
            #line hidden
, 1825), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1933), Tuple.Create("\"", 1966)
            
            #line 29 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1941), Tuple.Create<System.Object, System.Int32>(Model.SuggestionsRoute
            
            #line default
            #line hidden
, 1941), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2027), Tuple.Create("\'", 2070)
            
            #line 30 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2035), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 2035), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2130), Tuple.Create("\'", 2172)
            
            #line 31 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 2138), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"scoringSettings\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2233), Tuple.Create("\'", 2283)
            
            #line 32 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2241), Tuple.Create<System.Object, System.Int32>(ViewBag.ScoringSettings ?? string.Empty
            
            #line default
            #line hidden
, 2241), false)
);

WriteLiteral(" />\r\n</div>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 37 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 38 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 39 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
