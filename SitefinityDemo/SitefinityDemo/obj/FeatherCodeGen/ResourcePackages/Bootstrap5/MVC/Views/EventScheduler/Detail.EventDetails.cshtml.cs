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

namespace SitefinityDemo.ResourcePackages.Bootstrap5.MVC.Views.EventScheduler
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
    
    #line 3 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/EventScheduler/Detail.EventDetails.cshtml")]
    public partial class Detail_EventDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_EventDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 230), Tuple.Create("\"", 253)
            
            #line 7 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 238), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 238), false)
);

WriteLiteral(" ");

            
            #line 7 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row me-3\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"col-auto position-relative\"");

WriteLiteral(">\r\n            <span ");

            
            #line 10 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
             Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 10 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                      Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <span");

WriteLiteral(" class=\"position-absolute top-50 start-100 translate-middle p-2 border border-lig" +
"ht rounded-circle\"");

WriteAttribute("style", Tuple.Create(" style=\"", 664), Tuple.Create("\"", 717)
, Tuple.Create(Tuple.Create("", 672), Tuple.Create("background:", 672), true)
            
            #line 11 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                        , Tuple.Create(Tuple.Create(" ", 683), Tuple.Create<System.Object, System.Int32>(Model.Item.EventCalendarColour()
            
            #line default
            #line hidden
, 684), false)
);

WriteLiteral("></span>\r\n        </h1>\r\n    </div>\r\n");

            
            #line 14 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.EventDates())) 
	{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">\r\n        <time");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                            Write(Model.Item.EventDates());

            
            #line default
            #line hidden
WriteLiteral("</time> ");

            
            #line 17 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                            Write(Html.CommentsCount(string.Empty, Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 19 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n    <div");

WriteLiteral(" class=\"bg-light p-4 mb-4\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 22 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.City) || !string.IsNullOrEmpty(Model.Item.Fields.Country) || !string.IsNullOrEmpty(Model.Item.Fields.Location))
    {
            
            #line default
            #line hidden
WriteLiteral("<address>\r\n\r\n");

            
            #line 25 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.City) && !string.IsNullOrEmpty(Model.Item.Fields.Country))
        {
            
            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.City);

            
            #line default
            #line hidden
WriteLiteral(" <span>,</span> ");

            
            #line 27 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                   
            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                              Write(Model.Item.Fields.Country);

            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                             

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 29 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 32 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        Write(string.IsNullOrEmpty(Model.Item.Fields.City) ? Model.Item.Fields.Country : Model.Item.Fields.City);

            
            #line default
            #line hidden
            
            #line 32 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                                

            
            #line default
            #line hidden
WriteLiteral("             <br>\r\n");

            
            #line 34 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 36 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.Street))
        {
            
            
            #line default
            #line hidden
            
            #line 38 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Street);

            
            #line default
            #line hidden
            
            #line 38 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                     

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 40 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("         ");

            
            #line 41 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
          if (!string.IsNullOrEmpty(Model.Item.Fields.Location))
        {       
                
            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                        
                
            
            #line default
            #line hidden
            
            #line 44 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
           Write(Model.Item.Fields.Location);

            
            #line default
            #line hidden
            
            #line 44 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                           
        }

            
            #line default
            #line hidden
WriteLiteral("    </address>\r\n");

            
            #line 47 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n    <div>\r\n");

            
            #line 50 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactName))
        {
            
            
            #line default
            #line hidden
            
            #line 52 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactName);

            
            #line default
            #line hidden
            
            #line 52 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 54 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 56 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 56 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactPhone))
        {
            
            
            #line default
            #line hidden
            
            #line 58 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactPhone);

            
            #line default
            #line hidden
            
            #line 58 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                           

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 60 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 62 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 62 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactCell))
        {
            
            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactCell);

            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 66 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("            \r\n");

            
            #line 68 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 68 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactEmail))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2542), Tuple.Create("\"", 2589)
, Tuple.Create(Tuple.Create("", 2549), Tuple.Create("mailto:", 2549), true)
            
            #line 70 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2556), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.ContactEmail
            
            #line default
            #line hidden
, 2556), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 70 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                          Write(Model.Item.Fields.ContactEmail);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("            <br>\r\n");

            
            #line 72 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 74 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 74 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactWeb))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2767), Tuple.Create("\"", 2831)
            
            #line 76 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2774), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize((string)Model.Item.Fields.ContactWeb)
            
            #line default
            #line hidden
, 2774), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 76 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                           Write(Model.Item.Fields.ContactWeb);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 77 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n");

            
            #line 80 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 80 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (ViewBag.AllowCalendarExport)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"mt-3\"");

WriteLiteral(">\r\n            <span>");

            
            #line 83 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
             Write(Html.Resource("AddTo"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <ul");

WriteLiteral(" class=\"list-inline d-inline-block\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3133), Tuple.Create("\"", 3172)
            
            #line 85 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3140), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateOutlookUrl()
            
            #line default
            #line hidden
, 3140), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 85 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                   Write(Html.Resource("OutlookEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\r\n                <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3292), Tuple.Create("\"", 3328)
            
            #line 86 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3299), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateICalUrl()
            
            #line default
            #line hidden
, 3299), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 86 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                Write(Html.Resource("ICalEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\r\n                <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3445), Tuple.Create("\"", 3483)
            
            #line 87 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3452), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateGoogleUrl()
            
            #line default
            #line hidden
, 3452), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 87 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                  Write(Html.Resource("GoogleEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 90 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("   \r\n    </div>\r\n    \r\n\r\n");

            
            #line 95 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 95 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Summary))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(" ");

            
            #line 97 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                   Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 97 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                             Write(Html.HtmlSanitize((string)Model.Item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 98 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 101 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 101 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Description))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\r\n");

WriteLiteral("            ");

            
            #line 104 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n");

            
            #line 106 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 108 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 108 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Content))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 110 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 110 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                Write(Html.HtmlSanitize((string)Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 111 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 113 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
Write(Html.CommentsList(Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
