#pragma checksum "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Chats\SelectedChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfe4337464bdf39d45e6877c8e061a4656759354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chats_SelectedChat), @"mvc.1.0.view", @"/Views/Chats/SelectedChat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chats/SelectedChat.cshtml", typeof(AspNetCore.Views_Chats_SelectedChat))]
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
#line 1 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\_ViewImports.cshtml"
using NewSocialNetwork;

#line default
#line hidden
#line 2 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\_ViewImports.cshtml"
using NewSocialNetwork.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfe4337464bdf39d45e6877c8e061a4656759354", @"/Views/Chats/SelectedChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7efe26b96a2288f23edc2ab975cb104e61a4d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Chats_SelectedChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(19, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad0cef9a65f4f24b06caf58dff7ecbc", async() => {
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
            BeginContext(84, 117, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n<h2 class=\"text-center\"> ");
            EndContext();
            BeginContext(202, 13, false);
#line 4 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Chats\SelectedChat.cshtml"
                    Write(Model[0].Name);

#line default
#line hidden
            EndContext();
            BeginContext(215, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(217, 16, false);
#line 4 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Chats\SelectedChat.cshtml"
                                   Write(Model[0].Surname);

#line default
#line hidden
            EndContext();
            BeginContext(233, 47, true);
            WriteLiteral(" </h2>\r\n<h4 id=\"userName\" class=\"text-center\"> ");
            EndContext();
            BeginContext(281, 17, false);
#line 5 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Chats\SelectedChat.cshtml"
                                  Write(Model[0].UserName);

#line default
#line hidden
            EndContext();
            BeginContext(298, 1887, true);
            WriteLiteral(@" </h4>

<div class=""center-block"">
    <div class=""MessageList"">

    </div>

    <input type=""text"" id=""message"">
    <br />
    <button id=""sendBtn"" class=""btn btn-sm btn-primary"">Send</button>
</div>

<script>
        let token;
        const hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(""/chat"")
            .build();

        //function getData() {
        //    var mainData
        //    $.ajax({
        //        type: 'GET',
        //        url: '/Chats/getData',
        //        success: function (data) {
        //            if (data != '') {
        //                mainData = data
        //            }
        //        }
        //    });
        //    alert(""getData "" + mainData)
        //    return mainData
        //}

        function getMessage(massage, userName) {
            alert(""getMessage"" + massage + "" "" + userName)
            $.ajax({
                type: 'GET',
                url: '/Chats/getMessage',
        ");
            WriteLiteral(@"        data: { message, userName },
                success: function (data) {
                    if (data != '') {
                        $("".MessageList"").append(data);
                    }
                }
            });
        }
        // получение сообщения с сервера
        hubConnection.on(""Receive"", function (message, userName) {
            getMessage(message, userName)
        });

        // отправка сообщения на сервер
        document.getElementById(""sendBtn"").addEventListener(""click"", function (e) {
            alert(""handler"")
            let message = document.getElementById(""message"").value
            alert(""Message "" + message)
            var to = document.getElementById(""userName"").textContent
            alert(""Send "" + to)
            hubConnection.invoke(""Send"", message, to)
        });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
