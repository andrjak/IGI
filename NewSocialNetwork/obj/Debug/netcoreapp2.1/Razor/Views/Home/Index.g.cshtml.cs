#pragma checksum "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a47480207247d79dc55342d2ac4a8865e586d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a47480207247d79dc55342d2ac4a8865e586d60", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1286316b4d4ab6d62a0d8cebd2a5e8b17b6ac909", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewSocialNetwork.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProfileSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(79, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(88, 10, false);
#line 5 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(98, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(100, 13, false);
#line 5 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
               Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(113, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(122, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 130, "", 151, 1);
#line 7 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 135, Model.ImagePath, 135, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(151, 46, true);
            WriteLiteral(" alt=\"User photo\" width=\"300\" height=\"250\"/>\r\n");
            EndContext();
            BeginContext(199, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(207, 14, false);
#line 9 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
  Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(221, 23, true);
            WriteLiteral("</p>\r\n    <p>Country:  ");
            EndContext();
            BeginContext(245, 13, false);
#line 10 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
            Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(258, 24, true);
            WriteLiteral("</p>\r\n    <p>Birthday:  ");
            EndContext();
            BeginContext(283, 14, false);
#line 11 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
             Write(Model.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(297, 59, true);
            WriteLiteral("</p>\r\n    <details>\r\n        <summary>Detailed information ");
            EndContext();
            BeginContext(356, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23179f17ce044e03a7767585aa27ebae", async() => {
                BeginContext(429, 17, true);
                WriteLiteral("Edit user profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(450, 54, true);
            WriteLiteral("</summary>\r\n        <ul>\r\n            <li>Languages:  ");
            EndContext();
            BeginContext(505, 16, false);
#line 15 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
                       Write(Model?.Languages);

#line default
#line hidden
            EndContext();
            BeginContext(521, 35, true);
            WriteLiteral("</li>\r\n            <li>Interests:  ");
            EndContext();
            BeginContext(557, 16, false);
#line 16 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
                       Write(Model?.Interests);

#line default
#line hidden
            EndContext();
            BeginContext(573, 41, true);
            WriteLiteral("</li>\r\n            <li>Favorites Games:  ");
            EndContext();
            BeginContext(615, 20, false);
#line 17 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
                             Write(Model?.FavoriteGames);

#line default
#line hidden
            EndContext();
            BeginContext(635, 41, true);
            WriteLiteral("</li>\r\n            <li>Favorites Films:  ");
            EndContext();
            BeginContext(677, 20, false);
#line 18 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
                             Write(Model?.FavoriteFilms);

#line default
#line hidden
            EndContext();
            BeginContext(697, 36, true);
            WriteLiteral("</li>\r\n            <li>Activities:  ");
            EndContext();
            BeginContext(734, 17, false);
#line 19 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
                        Write(Model?.Activities);

#line default
#line hidden
            EndContext();
            BeginContext(751, 38, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </details>\r\n");
            EndContext();
#line 22 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(801, 41, true);
            WriteLiteral("    <h3>Log in to see your profile</h3>\r\n");
            EndContext();
#line 26 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewSocialNetwork.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
