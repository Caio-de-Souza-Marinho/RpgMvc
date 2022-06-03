#pragma checksum "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2bdc46f7bf73fc4c290548dd9b63be4d0646ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Index), @"mvc.1.0.view", @"/Views/Personagens/Index.cshtml")]
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
#line 1 "D:\caio2ds\ds\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\caio2ds\ds\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2bdc46f7bf73fc4c290548dd9b63be4d0646ba8", @"/Views/Personagens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.PersonagemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Namespace da classe de Modelo para esta view -->\r\n");
            WriteLiteral("\r\n<!-- Inclua os TempData para o Sucesso e o Erro aqui, conforme exemplo na view de Autenticação -->\r\n\r\n");
#nullable restore
#line 6 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 10 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Configuração para exibir mensagem de erro -->\r\n");
#nullable restore
#line 12 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 15 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
  
    ViewBag.Title = "Personagens";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Título da página para o navegador -->\r\n<h2>Relação de Personagens</h2> <!-- Título da página -->\r\n<p>\r\n    <!-- Links apontando para views na mesma pasta -->\r\n    ");
#nullable restore
#line 25 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Criar Novo Personagem", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <!-- Titulos das tabelas -->\r\n        <th>");
#nullable restore
#line 30 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 31 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 32 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 33 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 34 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 35 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n    <!-- Looping para escrever os dados na tabela -->\r\n");
#nullable restore
#line 39 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 42 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <!--Coluna para links/botões-->\r\n            ");
#nullable restore
#line 50 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.ActionLink("Editar", "Edit", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 51 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 52 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }
            , new { onclick = "return confirm('Deseja realmente deletar esse personagem?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
#nullable restore
#line 59 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Embate com armas!", "Index", "Disputas", null, new { @class = "btn - btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 60 "D:\caio2ds\ds\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Embate com habilidades!", "IndexHabilidade", "Disputas", null, new { @class = "btn - btn-dark" }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.PersonagemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
