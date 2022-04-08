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

namespace SitefinityDemo.ResourcePackages.Bootstrap4.MVC.Views.Profile
{
    using System;
    
    #line 3 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    
    #line 4 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using System.Linq.Expressions;
    
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
    
    #line 6 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Profile/Edit.ProfileEdit.cshtml")]
    public partial class Edit_ProfileEdit : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile.ProfileEditViewModel>
    {

#line 138 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<ProfileEditViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 139 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
 
    var hasValidationMessage = Html.ValidationMessageFor(expression) != null;
    var attributes = new Dictionary<string, object>();
    var cls = "form-control";

    if (classValue != null)
    {
        cls += " " + classValue;
    }

    attributes.Add("class", cls);

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId(descId));
    }
    if (additionalAttributes != null)
    {
        attributes = attributes.Concat(additionalAttributes).ToDictionary(x => x.Key, x => x.Value);
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"form-group\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 161 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 162 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        

#line default
#line hidden

#line 162 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 165 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 165 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 169 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 169 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 173 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 173 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");


#line 179 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 8921), Tuple.Create("\'", 8948)

#line 181 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 8926), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 8926), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"form-text\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 182 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
          WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n            </div>\r\n");


#line 184 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 186 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"


#line default
#line hidden
});

#line 186 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
}
#line default
#line hidden

#line 187 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
public System.Web.WebPages.HelperResult ReadOnlyFormGroupPanel(string label, Expression<Func<ProfileEditViewModel, string>> expression, string message = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 188 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"form-group\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <label>\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 191 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.Resource(label));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </label>\r\n");


#line 193 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        

#line default
#line hidden

#line 193 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         if (message == null)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div>\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 196 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.HiddenFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 197 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.DisplayTextFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n");


#line 199 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div>");


#line 202 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, message);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 203 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 205 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"


#line default
#line hidden
});

#line 205 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
}
#line default
#line hidden

        public Edit_ProfileEdit()
        {
        }
        public override void Execute()
        {
            
            #line 11 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.19.3/jquery.validate.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 667), Tuple.Create("\"", 690)
            
            #line 14 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 675), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 675), false)
);

WriteLiteral(">\r\n    <h3>");

            
            #line 15 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
   Write(Html.Resource("EditProfileLink"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 16 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     if (Model.ShowProfileChangedMsg)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                       Write(Html.Resource("ChangesAreSaved"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 19 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 20 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                      Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 23 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 24 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     using (Html.BeginFormSitefinity("Index", "EditProfileForm", FormMethod.Post, new Dictionary<string, object> { { "enctype", "multipart/form-data" }, { "role", "form" } }))
    {
        string[] readOnlyFields = ViewBag.ReadOnlyFields.ContainsKey("SitefinityProfile") ? (string[])ViewBag.ReadOnlyFields["SitefinityProfile"] : new string[0];
        if (readOnlyFields.Count() > 0 || ViewBag.IsEmailReadOnly)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-info\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                  Write(string.Format(Html.Resource("YouAreRegisteredWith"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 30 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"media sf-profile\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"sf-profile-aside media-left\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.HiddenFor(u => u.DeletePicture, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-delete-picture" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 34 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.HiddenFor(u => u.DefaultAvatarUrl, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-default-avatar-url" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"media-object\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"sf-profile-avatar\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" data-sf-role=\"edit-profile-user-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 2219), Tuple.Create("\"", 2246)
            
            #line 37 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 2225), Tuple.Create<System.Object, System.Int32>(Model.AvatarImageUrl
            
            #line default
            #line hidden
, 2225), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 2247), Tuple.Create("\"", 2268)
            
            #line 37 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                     , Tuple.Create(Tuple.Create("", 2253), Tuple.Create<System.Object, System.Int32>(Model.UserName
            
            #line default
            #line hidden
, 2253), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" />\r\n                        ");

WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        " +
"<input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-input\"");

WriteLiteral(" name=\"UploadedImage\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" />\r\n                        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-button\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(">");

            
            #line 44 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                                Write(Html.Resource("EditProfileUploadImage"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n   " +
"         <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\r\n");

            
            #line 49 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 49 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("FirstName", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 51 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileFirstName", u => u.Profile["FirstName"]));

            
            #line default
            #line hidden
            
            #line 51 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 55 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileFirstName", u => u.Profile["FirstName"], "ProfileFirstName"));

            
            #line default
            #line hidden
            
            #line 55 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 58 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 58 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("LastName", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 60 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileLastName", u => u.Profile["LastName"]));

            
            #line default
            #line hidden
            
            #line 60 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                              
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileLastName", u => u.Profile["LastName"], "ProfileLastName"));

            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                         
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 67 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 67 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("Nickname", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 69 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileNickname", u => u.Profile["Nickname"]));

            
            #line default
            #line hidden
            
            #line 69 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                              
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 73 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileNickname", u => u.Profile["Nickname"], "ProfileNickName"));

            
            #line default
            #line hidden
            
            #line 73 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                         
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 76 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 76 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("About", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 78 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileAbout", u => u.Profile["About"]));

            
            #line default
            #line hidden
            
            #line 78 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                        
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 82 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileAbout", u => u.Profile["About"], "ProfileAbout", "textarea"));

            
            #line default
            #line hidden
            
            #line 82 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 85 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 85 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (ViewBag.IsEmailReadOnly)
                {
                    
            
            #line default
            #line hidden
            
            #line 87 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileEmail", u => u.Email));

            
            #line default
            #line hidden
            
            #line 87 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                             
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 91 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileEmail", u => u.Email, "ProfileEmail"));

            
            #line default
            #line hidden
            
            #line 91 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                     
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 94 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 94 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (string.IsNullOrEmpty(Model.ExternalProviderName))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-button\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 98 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileChangePasswordButton"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 99 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                             Write(Html.Resource("WillExpandChangePasswordSection"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-holder\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\r\n                        <h4>");

            
            #line 103 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileEditChangePasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

WriteLiteral("                        ");

            
            #line 104 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileOldPassword", u => u.OldPassword, "ProfileOldPassword", "password", null, new Dictionary<string, object>() { { "autocomplete", "off" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 105 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileNewPassword", u => u.NewPassword, "ProfileNewPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 106 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileRepeatPassword", u => u.RepeatPassword, "ProfileRepeatPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 108 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 111 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("Password", null, string.Format(Html.Resource("ExternalProviderNoPassword"), Model.ExternalProviderName)));

            
            #line default
            #line hidden
            
            #line 111 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                                                                     
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 114 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 114 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (SystemManager.IsDesignMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" disabled>");

            
            #line 116 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                    Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 117 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 120 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                           Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 121 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 123 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 123 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (SystemManager.IsPreviewMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"profile-submit-preview-message\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"form-text\"");

WriteLiteral("><span");

WriteLiteral(" class=\"field-validation-error\"");

WriteLiteral(">");

            
            #line 126 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                Write(Html.Resource("PreviewProfileSaveMessage"));

            
            #line default
            #line hidden
WriteLiteral("</span></span>\r\n                    </div>\r\n");

            
            #line 128 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n");

            
            #line 131 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 133 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
  
    bool hasPasswordErrors = ViewBag.HasPasswordErrors is bool && ViewBag.HasPasswordErrors == true;

            
            #line default
            #line hidden
WriteLiteral("\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"has-password-errors\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7401), Tuple.Create("\"", 7457)
            
            #line 136 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 7409), Tuple.Create<System.Object, System.Int32>(hasPasswordErrors.ToString().ToLowerInvariant()
            
            #line default
            #line hidden
, 7409), false)
);

WriteLiteral(" />\r\n");

            
            #line 137 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Profile/profile-edit.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
