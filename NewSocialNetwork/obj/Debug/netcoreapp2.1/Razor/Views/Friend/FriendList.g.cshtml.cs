#pragma checksum "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18abb4565ab09465544d18e02f0a4bbe40e13320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_FriendList), @"mvc.1.0.view", @"/Views/Friend/FriendList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Friend/FriendList.cshtml", typeof(AspNetCore.Views_Friend_FriendList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18abb4565ab09465544d18e02f0a4bbe40e13320", @"/Views/Friend/FriendList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7efe26b96a2288f23edc2ab975cb104e61a4d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_FriendList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Friend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindFriends", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<h2>Your friends</h2>\r\n\r\n<br>\r\n");
            EndContext();
            BeginContext(31, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd5d3706c61347b491441634e34a4579", async() => {
                BeginContext(126, 15, true);
                WriteLiteral("Find new friend");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(145, 10, true);
            WriteLiteral("\r\n<br>\r\n\r\n");
            EndContext();
#line 7 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
 if (Model != null && Model.Count != 0)
{

    

#line default
#line hidden
#line 10 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
     foreach (User item in Model)
    {

#line default
#line hidden
            BeginContext(243, 31, true);
            WriteLiteral("        <div>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 274, "", 294, 1);
#line 13 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
WriteAttributeValue("", 279, item.ImagePath, 279, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(294, 63, true);
            WriteLiteral(" alt=\"User photo\" width=\"300\" height=\"250\" />\r\n            <h4>");
            EndContext();
            BeginContext(358, 9, false);
#line 14 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(367, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(369, 12, false);
#line 14 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
                      Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(381, 22, true);
            WriteLiteral("</h4>\r\n            <p>");
            EndContext();
            BeginContext(404, 13, false);
#line 15 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
          Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(417, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 17 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
    }

#line default
#line hidden
#line 17 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
     

}
else
{

#line default
#line hidden
            BeginContext(460, 38, true);
            WriteLiteral("    <h4> Friends list is empty </h4>\r\n");
            EndContext();
#line 23 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\FriendList.cshtml"
}

#line default
#line hidden
            BeginContext(501, 2, true);
            WriteLiteral("\r\n");
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