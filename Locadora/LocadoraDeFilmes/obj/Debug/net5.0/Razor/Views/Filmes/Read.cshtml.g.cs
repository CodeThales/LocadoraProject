#pragma checksum "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73cf9a8d7ab291c077dfd26ee366c5e1a23b2e96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmes_Read), @"mvc.1.0.view", @"/Views/Filmes/Read.cshtml")]
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
#line 1 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\_ViewImports.cshtml"
using LocadoraDeFilmes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\_ViewImports.cshtml"
using LocadoraDeFilmes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73cf9a8d7ab291c077dfd26ee366c5e1a23b2e96", @"/Views/Filmes/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b71dffba72f2b55ded2e32a49da040d7954e85", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmes_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Filme>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Filmes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>FILME NÃO EXISTE</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cf9a8d7ab291c077dfd26ee366c5e1a23b2e964600", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Visualizando filme ");
#nullable restore
#line 11 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">");
#nullable restore
#line 15 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 16 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">");
#nullable restore
#line 18 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayNameFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 19 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">");
#nullable restore
#line 21 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayNameFor(Model => Model.Sinopse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 22 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayFor(Model => Model.Sinopse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">");
#nullable restore
#line 24 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayNameFor(Model => Model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 25 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayFor(Model => Model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">");
#nullable restore
#line 27 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayNameFor(Model => Model.Lancamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 28 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayFor(Model => Model.Lancamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">");
#nullable restore
#line 30 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayNameFor(Model => Model.Duracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 31 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
                        Write(Html.DisplayFor(Model => Model.Duracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cf9a8d7ab291c077dfd26ee366c5e1a23b2e9611098", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\LocadoraProject\Locadora\LocadoraDeFilmes\Views\Filmes\Read.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Filme> Html { get; private set; }
    }
}
#pragma warning restore 1591
