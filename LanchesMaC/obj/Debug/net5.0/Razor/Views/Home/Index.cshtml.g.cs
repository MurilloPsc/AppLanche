#pragma checksum "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0973cec428809812eeb500209c159fa16b428bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\_ViewImports.cshtml"
using LanchesMaC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\_ViewImports.cshtml"
using LanchesMaC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\_ViewImports.cshtml"
using LanchesMaC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0973cec428809812eeb500209c159fa16b428bc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28fee8c130bc82de2fd61761f5415e9eac5344e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Carousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Os Preferidos da semana</h2>\r\n<h4>Tá com fome ???</h4>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\Home\Index.cshtml"
     foreach(var lanche in Model.LanchesPreferidos)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\Home\Index.cshtml"
           Write(Html.Partial("_LanchesResumo", lanche));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\murillo.silva\Desktop\CursoAspNet\LanchesMaC\LanchesMaC\Views\Home\Index.cshtml"
                                                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
