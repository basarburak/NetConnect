#pragma checksum "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c7173460a618bcdff9e6cb17c78ed0c316b5bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grants_Index), @"mvc.1.0.view", @"/Views/Grants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grants/Index.cshtml", typeof(AspNetCore.Views_Grants_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c7173460a618bcdff9e6cb17c78ed0c316b5bc", @"/Views/Grants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b49bb18fbe88f2fb7e20eb130e64338d7f2c37", @"/Views/_ViewImports.cshtml")]
    public class Views_Grants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GrantsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Revoke", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 337, true);
            WriteLiteral(@"
<div class=""grants"">
    <div class=""row page-header"">
        <div class=""col-sm-10"">
            <h1>
                Client Application Access
            </h1>
            <div>Below is the list of applications you have given access to and the names of the resources they have access to.</div>
        </div>
    </div>

");
            EndContext();
#line 13 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
     if (Model.Grants.Any() == false)
    {

#line default
#line hidden
            BeginContext(407, 238, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                <div class=\"alert alert-info\">\r\n                    You have not given access to any applications\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
    }
    else
    {
        foreach (var grant in Model.Grants)
        {

#line default
#line hidden
            BeginContext(725, 77, true);
            WriteLiteral("            <div class=\"row grant\">\r\n                <div class=\"col-sm-2\">\r\n");
            EndContext();
#line 29 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                     if (grant.ClientLogoUrl != null)
                    {

#line default
#line hidden
            BeginContext(880, 28, true);
            WriteLiteral("                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 908, "\"", 934, 1);
#line 31 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
WriteAttributeValue("", 914, grant.ClientLogoUrl, 914, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(935, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 32 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(961, 108, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-sm-8\">\r\n                    <div class=\"clientname\">");
            EndContext();
            BeginContext(1070, 16, false);
#line 35 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                       Write(grant.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 97, true);
            WriteLiteral("</div>\r\n                    <div>\r\n                        <span class=\"created\">Created:</span> ");
            EndContext();
            BeginContext(1184, 36, false);
#line 37 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                                         Write(grant.Created.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 39 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                     if (grant.Expires.HasValue)
                    {

#line default
#line hidden
            BeginContext(1323, 97, true);
            WriteLiteral("                        <div>\r\n                            <span class=\"expires\">Expires:</span> ");
            EndContext();
            BeginContext(1421, 42, false);
#line 42 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                                             Write(grant.Expires.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 44 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1520, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 45 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                     if (grant.IdentityGrantNames.Any())
                    {

#line default
#line hidden
            BeginContext(1601, 139, true);
            WriteLiteral("                        <div>\r\n                            <div class=\"granttype\">Identity Grants</div>\r\n                            <ul>\r\n");
            EndContext();
#line 50 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.IdentityGrantNames)
                        {

#line default
#line hidden
            BeginContext(1848, 40, true);
            WriteLiteral("                                    <li>");
            EndContext();
            BeginContext(1889, 4, false);
#line 52 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(1893, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 53 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1935, 67, true);
            WriteLiteral("                            </ul>\r\n                        </div>\r\n");
            EndContext();
#line 56 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2025, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 57 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                     if (grant.ApiGrantNames.Any())
                    {

#line default
#line hidden
            BeginContext(2101, 134, true);
            WriteLiteral("                        <div>\r\n                            <div class=\"granttype\">API Grants</div>\r\n                            <ul>\r\n");
            EndContext();
#line 62 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.ApiGrantNames)
                                {

#line default
#line hidden
            BeginContext(2346, 40, true);
            WriteLiteral("                                    <li>");
            EndContext();
            BeginContext(2387, 4, false);
#line 64 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(2391, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 65 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2433, 67, true);
            WriteLiteral("                            </ul>\r\n                        </div>\r\n");
            EndContext();
#line 68 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2523, 84, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2607, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40fbe0b9721a4a8781524af4e2aa0952", async() => {
                BeginContext(2633, 62, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"clientId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2695, "\"", 2718, 1);
#line 72 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
WriteAttributeValue("", 2703, grant.ClientId, 2703, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2719, 102, true);
                WriteLiteral(">\r\n                        <button class=\"btn btn-danger\">Revoke Access</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2828, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 77 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.Auth\Views\Grants\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2892, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrantsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
