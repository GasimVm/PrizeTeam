#pragma checksum "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f46db9afd4575ee9db637622e75cdb823aa5c12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LeftSideNavPartial), @"mvc.1.0.view", @"/Views/Shared/_LeftSideNavPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LeftSideNavPartial.cshtml", typeof(AspNetCore.Views_Shared__LeftSideNavPartial))]
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
#line 1 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\_ViewImports.cshtml"
using Prize;

#line default
#line hidden
#line 2 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\_ViewImports.cshtml"
using Prize.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f46db9afd4575ee9db637622e75cdb823aa5c12", @"/Views/Shared/_LeftSideNavPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c9426c31ee4617d416847aaccd2722e64dd104", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LeftSideNavPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3670, true);
            WriteLiteral(@"<div class=""left-sidenav"">
    <div class=""main-icon-menu"">
        <nav class=""nav"">
            <a href=""#Dashboard"" class=""nav-link"" data-toggle=""tooltip-custom"" data-placement=""top"" title="""" data-original-title=""Dashboard"">
                <svg class=""nav-svg"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512"">
                    <path class=""svg-primary"" d=""M208 448V320h96v128h97.6V256H464L256 64 48 256h62.4v192z""></path>
                </svg>
            </a><!--end Transaction-->
            <a href=""#Transaction"" class=""nav-link"" data-toggle=""tooltip-custom"" data-placement=""top"" title="""" data-original-title=""Transaction"">
                <svg class=""nav-svg"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512"">
                    <path class=""svg-primary"" d=""M192 382h-22c-24.6 0-29-3.6-33.8-9.6-5.5-6.9-8.2-19.1-8.2-54.2V151.4c19.1-11.1 32-31.7 32-55.4 0-35.3-28.7-64-64-64S32 60.7 32 96c0 23.7 12.9 44.3 32 55.4v166.8c0 46.4 3.7 70.8 22.1 94 19.9 25.1 45 35.8 83.9 35.8h22v64l96-96");
            WriteLiteral(@"-96-96v62zM96 56c22.1 0 40 17.9 40 40s-17.9 40-40 40-40-17.9-40-40 17.9-40 40-40zM448 360.6V190.8c0-46.4-3.7-70.8-22.1-94C406 71.7 380.9 62 342 62h-22V0l-96 96 96 96v-64h22c24.6 0 29 2.6 33.8 8.6 5.5 6.9 8.2 19.1 8.2 54.2v169.8c-19.1 11.1-32 31.7-32 55.4 0 35.3 28.7 64 64 64s64-28.7 64-64c0-23.7-12.9-44.3-32-55.4zM416 456c-22.1 0-40-17.9-40-40s17.9-40 40-40 40 17.9 40 40-17.9 40-40 40z""></path>
                </svg>
            </a><!--end Transaction-->
            <a href=""#Wallet"" class=""nav-link"" data-toggle=""tooltip-custom"" data-placement=""top"" title="""" data-original-title=""Wallet"">
                <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512"">
                    <path class=""svg-primary"" d=""M202.7 341.3V170.7c0-23.5 19-42.7 42.7-42.7h197v-21.3c0-23.5-18.9-42.7-42.3-42.7H92c-23.7 0-44 18.5-44 42v300c0 23.5 20.3 42 44 42h308c23.5 0 42.3-19.2 42.3-42.7V384h-197c-23.6 0-42.6-19.2-42.6-42.7z""></path>
                    <path d=""M245 186v140c0 8.8 7.2 16 16 16h187c8.8 0 16-7.2 16-16V1");
            WriteLiteral(@"86c0-8.8-7.2-16-16-16H261c-8.8 0-16 7.2-16 16zm77.1 101.9c-19.3 1.2-35.2-14.7-34-34 1-15.9 13.9-28.8 29.9-29.9 19.3-1.2 35.2 14.7 34 34-1.1 16-14 28.9-29.9 29.9z""></path>
                </svg>
            </a><!--end Transaction-->
            <a href=""#User"" class=""nav-link"" data-toggle=""tooltip-custom"" data-placement=""top"" title="""" data-original-title=""User"">
                <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512"">
                    <path class=""svg-primary"" d=""M202.7 341.3V170.7c0-23.5 19-42.7 42.7-42.7h197v-21.3c0-23.5-18.9-42.7-42.3-42.7H92c-23.7 0-44 18.5-44 42v300c0 23.5 20.3 42 44 42h308c23.5 0 42.3-19.2 42.3-42.7V384h-197c-23.6 0-42.6-19.2-42.6-42.7z""></path>
                    <path d=""M245 186v140c0 8.8 7.2 16 16 16h187c8.8 0 16-7.2 16-16V186c0-8.8-7.2-16-16-16H261c-8.8 0-16 7.2-16 16zm77.1 101.9c-19.3 1.2-35.2-14.7-34-34 1-15.9 13.9-28.8 29.9-29.9 19.3-1.2 35.2 14.7 34 34-1.1 16-14 28.9-29.9 29.9z""></path>
                </svg>
            </a>
        </nav><!-");
            WriteLiteral(@"-end nav-->
    </div><!--end main-icon-menu-->

    <div class=""main-menu-inner"">
        <div class=""menu-body slimscroll"">
            <div id=""Dashboard"" class=""main-icon-menu-pane"">
                <div class=""title-box"">
                    <h6 class=""menu-title"">Dashboard</h6>
                </div>
                <ul class=""nav"">
                    <li class=""nav-item""><a class=""nav-link"" href=""#""><i class=""dripicons-device-desktop""></i>Dashboard</a></li>
                </ul>
                <ul class=""nav"">
                    <li class=""nav-item""><a class=""nav-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3670, "\"", 3703, 1);
#line 39 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml"
WriteAttributeValue("", 3677, Url.Action("Send","User"), 3677, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3704, 415, true);
            WriteLiteral(@"><i class=""dripicons-device-desktop""></i>Send friend</a></li>
                </ul>
            </div><!-- end Dashboard -->

            <div id=""Transaction"" class=""main-icon-menu-pane"">
                <div class=""title-box"">
                    <h6 class=""menu-title"">Transactions</h6>
                </div>
                <ul class=""nav"">
                    <li class=""nav-item""><a class=""nav-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4119, "\"", 4160, 1);
#line 48 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml"
WriteAttributeValue("", 4126, Url.Action("Index","Transaction"), 4126, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4161, 397, true);
            WriteLiteral(@"><i class=""dripicons-swap""></i>Transactions</a></li>
                </ul>
            </div><!-- end Transaction -->

            <div id=""Wallet"" class=""main-icon-menu-pane"">
                <div class=""title-box"">
                    <h6 class=""menu-title"">Wallet</h6>
                </div>
                <ul class=""nav"">
                    <li class=""nav-item""><a class=""nav-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4558, "\"", 4596, 1);
#line 57 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml"
WriteAttributeValue("", 4565, Url.Action("Valyuta","Wallet"), 4565, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4597, 170, true);
            WriteLiteral("><i class=\"dripicons-wallet\"></i>My Wallet</a></li>\r\n                </ul>\r\n                <ul class=\"nav\">\r\n                    <li class=\"nav-item\"><a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4767, "\"", 4803, 1);
#line 60 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml"
WriteAttributeValue("", 4774, Url.Action("Udush","Wallet"), 4774, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4804, 403, true);
            WriteLiteral(@"><i class=""dripicons-wallet""></i>My Gift</a></li>
                </ul>
                 
            </div><!-- end Wallet -->
            <div id=""User"" class=""main-icon-menu-pane"">
                <div class=""title-box"">
                    <h6 class=""menu-title"">Users</h6>
                </div>
                <ul class=""nav"">
                    <li class=""nav-item""><a class=""nav-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5207, "\"", 5241, 1);
#line 69 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml"
WriteAttributeValue("", 5214, Url.Action("Index","User"), 5214, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5242, 170, true);
            WriteLiteral("><i class=\"dripicons-wallet\"></i>All Users</a></li>\r\n                </ul>\r\n                <ul class=\"nav\">\r\n                    <li class=\"nav-item\"><a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5412, "\"", 5447, 1);
#line 72 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml"
WriteAttributeValue("", 5419, Url.Action("Online","User"), 5419, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5448, 173, true);
            WriteLiteral("><i class=\"dripicons-wallet\"></i>Online Users</a></li>\r\n                </ul>\r\n                <ul class=\"nav\">\r\n                    <li class=\"nav-item\"><a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5621, "\"", 5659, 1);
#line 75 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Shared\_LeftSideNavPartial.cshtml"
WriteAttributeValue("", 5628, Url.Action("BlockUser","User"), 5628, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5660, 183, true);
            WriteLiteral("><i class=\"dripicons-wallet\"></i>Block Users</a></li>\r\n                </ul>\r\n            </div>\r\n        </div><!--end menu-body-->\r\n    </div><!-- end main-menu-inner-->\r\n</div>\r\n\r\n");
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
