#pragma checksum "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c4f5e054cb06274850f5ffead288c33a655332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amortizacion_Validar), @"mvc.1.0.view", @"/Views/Amortizacion/Validar.cshtml")]
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
#line 1 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\_ViewImports.cshtml"
using WebAppCreditos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\_ViewImports.cshtml"
using WebAppCreditos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
using Modelo.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c4f5e054cb06274850f5ffead288c33a655332", @"/Views/Amortizacion/Validar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6c9008726b359ebdcc8892dff49e89cf6e89be", @"/Views/_ViewImports.cshtml")]
    public class Views_Amortizacion_Validar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Amortizacion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Validar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Amortizacion</h1>\n\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-sm-4\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70c4f5e054cb06274850f5ffead288c33a6553325883", async() => {
                WriteLiteral("\n                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70c4f5e054cb06274850f5ffead288c33a6553326156", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AmortizacionId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <div class=\"form-group\">\n                    <label class=\"control-label\">Valor del Credito</label>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70c4f5e054cb06274850f5ffead288c33a6553328030", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ValorCredito);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <label class=\"control-label\">Pago Mensual</label>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70c4f5e054cb06274850f5ffead288c33a6553329792", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PagoMensual);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"Estado\">Estado</label>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70c4f5e054cb06274850f5ffead288c33a65533211538", async() => {
                    WriteLiteral("\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70c4f5e054cb06274850f5ffead288c33a65533211829", async() => {
                        WriteLiteral("--Selecciona un Estado Civil--");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 27 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Estado);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<Estado>();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <input type=\"submit\" value=\"Validar\" class=\"btn btn-primary\" />\n                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""col-sm-8"">
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <td>Nombre</td>
                            <td>Total Credito</td>
                            <td>Ingresos Netos</td>
                            <td>Calculado el 35%</td>
                            <td>Cuota Mensual</td>
                            <td>Aprobado</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 50 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                         foreach (var item in Model.Solicitud_Dets)
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 53 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.Afiliado.Solicitante.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 53 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                                                            Write(item.Solicitud.Afiliado.Solicitante.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 54 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.TotalCredito);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td>");
#nullable restore
#line 55 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.CapacidadPago.CapcidadPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 56 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                 if(item.Solicitud != null) { 


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 58 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(ViewBag.Calculo.CapacidadPago(item.Solicitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 59 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.TotalCuota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 60 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(ViewBag.Calculo.Aprobado(item.Solicitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 61 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>--</td>\n                                <td>--</td>\n");
#nullable restore
#line 66 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\n");
#nullable restore
#line 68 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <td>Nombre</td>
                            <td>Aportaciones al IESS</td>
                            <td>Mas de 12 Aportaciones</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 80 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                         foreach (var item in Model.Solicitud_Dets)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 83 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.Afiliado.Solicitante.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 83 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                                                            Write(item.Solicitud.Afiliado.Solicitante.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 84 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.Afiliado.TotalAportaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n");
#nullable restore
#line 85 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                 if (item.Solicitud != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Verdadero</td>\n");
#nullable restore
#line 88 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                }else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Falso</td>\n");
#nullable restore
#line 91 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>");
#nullable restore
#line 92 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <td>Nombre</td>
                            <td>Estado Historial Crediticio</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 103 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                         foreach (var item in Model.Solicitud_Dets)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 106 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.Afiliado.Solicitante.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 106 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                                                            Write(item.Solicitud.Afiliado.Solicitante.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 107 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                               Write(item.Solicitud.HistorialCrediticio.EstadoHistorial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>");
#nullable restore
#line 108 "C:\Users\Anthony Rosero\source\repos\Solicitud Creditos\WebAppCreditos\Views\Amortizacion\Validar.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n         </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Amortizacion> Html { get; private set; }
    }
}
#pragma warning restore 1591
