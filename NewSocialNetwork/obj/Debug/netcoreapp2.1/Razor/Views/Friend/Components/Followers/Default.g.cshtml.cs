#pragma checksum "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Followers\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0c54be2098f5d54c9363cd4061bdc6ef0e0198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_Components_Followers_Default), @"mvc.1.0.view", @"/Views/Friend/Components/Followers/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Friend/Components/Followers/Default.cshtml", typeof(AspNetCore.Views_Friend_Components_Followers_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0c54be2098f5d54c9363cd4061bdc6ef0e0198", @"/Views/Friend/Components/Followers/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7efe26b96a2288f23edc2ab975cb104e61a4d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_Components_Followers_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Followers\Default.cshtml"
 if (Model != null && Model.Count != 0)
{

#line default
#line hidden
            BeginContext(44, 44, true);
            WriteLiteral("    <h2 class=\"text-center\">Followers</h2>\r\n");
            EndContext();
#line 4 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Followers\Default.cshtml"
     foreach (User item in Model)
    {
        

#line default
#line hidden
            BeginContext(139, 42, false);
#line 6 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Followers\Default.cshtml"
   Write(await Html.PartialAsync("_Follower", item));

#line default
#line hidden
            EndContext();
            BeginContext(183, 16, true);
            WriteLiteral("        <hr />\r\n");
            EndContext();
#line 8 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Followers\Default.cshtml"
    }

#line default
#line hidden
#line 8 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Followers\Default.cshtml"
     

}
else
{

#line default
#line hidden
            BeginContext(220, 60, true);
            WriteLiteral("    <h4 class=\"text-center\"> Followers list is empty </h4>\r\n");
            EndContext();
#line 14 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Followers\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
