#pragma checksum "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01095dc7dcf1aaf568474ee9fb528f3624c4db85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_Components_Following_Default), @"mvc.1.0.view", @"/Views/Friend/Components/Following/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Friend/Components/Following/Default.cshtml", typeof(AspNetCore.Views_Friend_Components_Following_Default))]
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
#line 1 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01095dc7dcf1aaf568474ee9fb528f3624c4db85", @"/Views/Friend/Components/Following/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7efe26b96a2288f23edc2ab975cb104e61a4d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_Components_Following_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
 if (Model != null && Model.Count != 0)
{

#line default
#line hidden
            BeginContext(126, 24, true);
            WriteLiteral("<h2 class=\"text-center\">");
            EndContext();
            BeginContext(151, 22, false);
#line 6 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
                   Write(Localizer["Following"]);

#line default
#line hidden
            EndContext();
            BeginContext(173, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 7 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
     foreach (User item in Model)
    {
        

#line default
#line hidden
            BeginContext(231, 43, false);
#line 9 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
   Write(await Html.PartialAsync("_Following", item));

#line default
#line hidden
            EndContext();
            BeginContext(276, 16, true);
            WriteLiteral("        <hr />\r\n");
            EndContext();
#line 11 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
    }

#line default
#line hidden
#line 11 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
     

}
else
{

#line default
#line hidden
            BeginContext(313, 33, true);
            WriteLiteral("        <h4 class=\"text-center\"> ");
            EndContext();
            BeginContext(347, 18, false);
#line 16 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
                            Write(Localizer["empty"]);

#line default
#line hidden
            EndContext();
            BeginContext(365, 8, true);
            WriteLiteral(" </h4>\r\n");
            EndContext();
#line 17 "D:\5_SEM\IGI\MainProject\NewSocialNetwork\NewSocialNetwork\Views\Friend\Components\Following\Default.cshtml"
           
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
