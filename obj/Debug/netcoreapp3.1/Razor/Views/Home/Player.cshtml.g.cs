#pragma checksum "C:\Users\Alex\Desktop\ChessStatistics\ChessStatistics\Views\Home\Player.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf68b722eac7336250ce1d26d053f44bfa7b7a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Player), @"mvc.1.0.view", @"/Views/Home/Player.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Alex\Desktop\ChessStatistics\ChessStatistics\Views\_ViewImports.cshtml"
using ChessStatistics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\ChessStatistics\ChessStatistics\Views\_ViewImports.cshtml"
using ChessStatistics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf68b722eac7336250ce1d26d053f44bfa7b7a0", @"/Views/Home/Player.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197962091e9c6879f9dbe761c94ccf7c489f1fee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Player : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChessStatistics.Models.User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alex\Desktop\ChessStatistics\ChessStatistics\Views\Home\Player.cshtml"
    ViewData["CurrentPage"] = "Player";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5 class=\"text-light\"> Профиль игрока ");
#nullable restore
#line 6 "C:\Users\Alex\Desktop\ChessStatistics\ChessStatistics\Views\Home\Player.cshtml"
                                  Write(Model.FIO);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChessStatistics.Models.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
