#pragma checksum "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b84bf5476be64afcc8627c1199d9603b8cc8d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_Details), @"mvc.1.0.view", @"/Views/Reportes/Details.cshtml")]
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
#line 1 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\_ViewImports.cshtml"
using Bookflix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\_ViewImports.cshtml"
using Bookflix.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b84bf5476be64afcc8627c1199d9603b8cc8d7", @"/Views/Reportes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f8bfde9510ffbcd17bd83115ced13087a80cbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookflix.Models.Perfil_Comenta_Libro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reportes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
  
    ViewData["Title"] = "Reporte";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color: #E50914;\">Detalles del Comentario</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comentario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comentario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            Realizado por\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(Model.obtenerUsuario().UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            Motivo de reporte\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(ViewBag.Motivo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            Titulo del libro\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(ViewBag.Libro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            Descripción \r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(ViewBag.Libro.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            Autor\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(ViewBag.Libro.Autor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            Editorial\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(ViewBag.Libro.Editorial.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\" style=\"color: #E50914;\">\r\n            Género\r\n        </dt>\r\n        <dd class = \"col-sm-10\" style=\"color: white;\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
       Write(ViewBag.Libro.Genero.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<div>
    <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#exampleModal"">
        Borrar Comentario
    </button>

    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar comentario</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>¿Estas seguro que quieres eliminar el comentario """);
#nullable restore
#line 77 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Comentario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"?</p>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary mb-2\" data-dismiss=\"modal\">Cancelar</button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41b84bf5476be64afcc8627c1199d9603b8cc8d710804", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3108, "\"", 3130, 1);
#nullable restore
#line 82 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
WriteAttributeValue("", 3116, Model.LibroId, 3116, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <input type=\"hidden\" name=\"nro\" id=\"nro\"");
                BeginWriteAttribute("value", " value=\"", 3195, "\"", 3226, 1);
#nullable restore
#line 83 "C:\Users\Pasquet3\Documents\Project-Bookflix\Bookflix\Views\Reportes\Details.cshtml"
WriteAttributeValue("", 3203, Model.NumeroComentario, 3203, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <button type=\"submit\" class=\"btn btn-danger mb-2\">Confirmar</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41b84bf5476be64afcc8627c1199d9603b8cc8d713753", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookflix.Models.Perfil_Comenta_Libro> Html { get; private set; }
    }
}
#pragma warning restore 1591
