#pragma checksum "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1872069acc8582dd7489d7ca73ef3bcaf2bcc39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/LoggedOut.cshtml", typeof(AspNetCore.Views_Account_LoggedOut))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1872069acc8582dd7489d7ca73ef3bcaf2bcc39", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b49bb18fbe88f2fb7e20eb130e64338d7f2c37", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoggedOutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signout-redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
   
    // set this so the layout rendering sees an anonymous user
    ViewData["signed-out"] = true;

#line default
#line hidden
            BeginContext(137, 126, true);
            WriteLiteral("\r\n<div class=\"page-header logged-out\">\r\n    <h1>\r\n        Logout\r\n        <small>You are now logged out</small>\r\n    </h1>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
     if (Model.PostLogoutRedirectUri != null)
    {

#line default
#line hidden
            BeginContext(317, 65, true);
            WriteLiteral("        <div>\r\n            Click <a class=\"PostLogoutRedirectUri\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 382, "\"", 417, 1);
#line 17 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 389, Model.PostLogoutRedirectUri, 389, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(418, 46, true);
            WriteLiteral(">here</a> to return to the\r\n            <span>");
            EndContext();
            BeginContext(465, 16, false);
#line 18 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
             Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(481, 38, true);
            WriteLiteral("</span> application.\r\n        </div>\r\n");
            EndContext();
#line 20 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(526, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
     if (Model.SignOutIframeUrl != null)
    {

#line default
#line hidden
            BeginContext(577, 52, true);
            WriteLiteral("        <iframe width=\"0\" height=\"0\" class=\"signout\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 629, "\"", 658, 1);
#line 24 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 635, Model.SignOutIframeUrl, 635, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 12, true);
            WriteLiteral("></iframe>\r\n");
            EndContext();
#line 25 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(678, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(707, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
     if (Model.AutomaticRedirectAfterSignOut)
    {

#line default
#line hidden
                BeginContext(763, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(771, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d70466f1014cbbbba22d26b44fbd15", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(819, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 33 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
