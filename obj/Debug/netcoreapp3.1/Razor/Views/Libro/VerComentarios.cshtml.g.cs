#pragma checksum "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa4604eeead8c0f07a957e37eecaf945426274cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libro_VerComentarios), @"mvc.1.0.view", @"/Views/Libro/VerComentarios.cshtml")]
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
#line 1 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\_ViewImports.cshtml"
using Bookflix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\_ViewImports.cshtml"
using Bookflix.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4604eeead8c0f07a957e37eecaf945426274cd", @"/Views/Libro/VerComentarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f8bfde9510ffbcd17bd83115ced13087a80cbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Libro_VerComentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookflix.Models.Libro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DesmarcarSpoiler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarcarSpoiler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Libro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComentario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
  
    ViewData["Title"] = "Comentarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color: red;\">Comentarios del libro \"");
#nullable restore
#line 7 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                          Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""</h1>

<table class=""table"">
    <thead>
        <tr>
            <th style=""color: white;"">
                Comentario
            </th>
            <th style=""color: white;"">Marcar Como</th>
            <th style=""color: white;"">Eliminar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
 foreach (var item in Model.Perfil_Valora_Libros) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"color: white;\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comentario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td >\r\n");
#nullable restore
#line 25 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
             if(item.Spoiler)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa4604eeead8c0f07a957e37eecaf945426274cd7313", async() => {
                WriteLiteral("No Spoiler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                                                                                    WriteLiteral(item.PerfilId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                                                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["libroId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-libroId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["libroId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 30 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa4604eeead8c0f07a957e37eecaf945426274cd10778", async() => {
                WriteLiteral("Spoiler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                                                                                 WriteLiteral(item.PerfilId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["libroId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-libroId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["libroId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 34 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                <button type=\"button\" class=\"btn btn-primary btn-sm\" data-toggle=\"modal\" data-target=\"#Modal-");
#nullable restore
#line 36 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                                                                                        Write(item.PerfilId);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 36 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                                                                                                       Write(item.LibroId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    Eliminar\r\n                </button>\r\n\r\n                <!-- Modal -->\r\n                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1432, "\"", 1471, 4);
            WriteAttributeValue("", 1437, "Modal-", 1437, 6, true);
#nullable restore
#line 41 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
WriteAttributeValue("", 1443, item.PerfilId, 1443, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1457, "-", 1457, 1, true);
#nullable restore
#line 41 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
WriteAttributeValue("", 1458, item.LibroId, 1458, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
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
#line 51 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
                                                                            Write(item.Comentario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"?</p>\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-secondary mb-2\" data-dismiss=\"modal\">Cancelar</button>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa4604eeead8c0f07a957e37eecaf945426274cd17115", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"libroId\" id=\"libroId\"");
                BeginWriteAttribute("value", " value=\"", 2601, "\"", 2622, 1);
#nullable restore
#line 56 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
WriteAttributeValue("", 2609, item.LibroId, 2609, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                <input type=\"hidden\" name=\"PerfilId\" id=\"PerfilId\"");
                BeginWriteAttribute("value", " value=\"", 2709, "\"", 2731, 1);
#nullable restore
#line 57 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
WriteAttributeValue("", 2717, item.PerfilId, 2717, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                <button type=\"submit\" class=\"btn btn-danger mb-2\">Confirmar</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 71 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
 if(Model.Perfil_Valora_Libros.Count() == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ¡No se han realizado comentarios para este libro! \r\n    </div>\r\n");
#nullable restore
#line 75 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
}else if(Model.Perfil_Valora_Libros.Count() > 3){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"ir-arriba btn btn-dark btn-sm btn-block\" type=\"button\">Volver arriba</button>\r\n");
#nullable restore
#line 77 "C:\Users\Josef\Documents\GitHub\Bookflix\Views\Libro\VerComentarios.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookflix.Models.Libro> Html { get; private set; }
    }
}
#pragma warning restore 1591
