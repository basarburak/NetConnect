#pragma checksum "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.WebApp\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86b502753852c03101ddda5e60ac571748f2d1c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chat/Index.cshtml", typeof(AspNetCore.Views_Chat_Index))]
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
#line 1 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.WebApp\Views\_ViewImports.cshtml"
using NetConnect.Hosting.WebApp;

#line default
#line hidden
#line 2 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.WebApp\Views\_ViewImports.cshtml"
using NetConnect.Hosting.WebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.WebApp\Views\_ViewImports.cshtml"
using NetConnect.Hosting.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86b502753852c03101ddda5e60ac571748f2d1c6", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6081094f74ffcac84b301e03d588bf0e562f1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.WebApp\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.WebApp\Views\Chat\Index.cshtml"
  
    var name = User.Claims.Where(x => x.Type == NetConnectClaims.Name).First().Value;
    var lastname = User.Claims.Where(x => x.Type == NetConnectClaims.Lastname).First().Value;
    var fullName = name + " " + lastname;

#line default
#line hidden
            BeginContext(324, 255, true);
            WriteLiteral("\r\n<br /> <br /> <br />\r\n<div class=\"container\">\r\n    <input type=\"text\" id=\"message\" />\r\n    <input type=\"button\" id=\"sendmessage\" value=\"Send\" />\r\n    <ul id=\"discussion\"></ul>\r\n</div>\r\n<!--Script references. -->\r\n<!--Reference the SignalR library. -->\r\n");
            EndContext();
            BeginContext(579, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154bd582ffe34fcfa75768e7d15e256f", async() => {
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
            BeginContext(634, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(636, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9f8262905b942f09d70cc6550a7b63a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(680, 312, true);
            WriteLiteral(@"
<!--Add script to update the page and send messages.-->
<script type=""text/javascript"">
    document.addEventListener('DOMContentLoaded', function () {

        var messageInput = document.getElementById('message');

        // Get the user name and store it to prepend to messages.
        var name = '");
            EndContext();
            BeginContext(993, 8, false);
#line 30 "C:\Users\HKD44\Documents\GitHub\NetConnect\NetConnect.Hosting.WebApp\Views\Chat\Index.cshtml"
               Write(fullName);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 1714, true);
            WriteLiteral(@"';
        // Set initial focus to message input box.
        messageInput.focus();
        // Start the connection.
        var connection = new signalR.HubConnectionBuilder()
            .withUrl('https://localhost:44317/chat')
            .build();

        // Create a function that the hub can call to broadcast messages.
        //Mesaj Geldıgınde...
        connection.on('broadcastMessage', function (name, message) {
            // Html encode display name and message.
            var encodedName = name;
            var encodedMsg = message;
            // Add the message to the page.
            var liElement = document.createElement('li');
            liElement.innerHTML = '<strong>' + encodedName + '</strong>:&nbsp;&nbsp;' + encodedMsg;
            document.getElementById('discussion').appendChild(liElement);
        });

        // Transport fallback functionality is now built into start.
        connection.start()
            .then(function () {
                console.log(con");
            WriteLiteral(@"nection);

                console.log('connection started');
                //send message
                document.getElementById('sendmessage').addEventListener('click', function (event) {
                    // Call the Send method on the hub.
                    connection.invoke('send', name, messageInput.value);

                    // Clear text box and reset focus for next comment.
                    messageInput.value = '';
                    messageInput.focus();
                    event.preventDefault();
                });

            })
            .catch(error => {
                console.error(error.message);
            });
    });</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
