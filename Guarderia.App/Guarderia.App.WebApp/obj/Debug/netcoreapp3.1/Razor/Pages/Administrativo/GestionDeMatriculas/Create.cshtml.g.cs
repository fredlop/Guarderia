#pragma checksum "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0deb0e70879200fe68128ca1e5222f32f4906f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas.Pages_Administrativo_GestionDeMatriculas_Create), @"mvc.1.0.razor-page", @"/Pages/Administrativo/GestionDeMatriculas/Create.cshtml")]
namespace Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas
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
#line 1 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\_ViewImports.cshtml"
using Matriculas.App.WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0deb0e70879200fe68128ca1e5222f32f4906f0b", @"/Pages/Administrativo/GestionDeMatriculas/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"121c26a7e5656677e8a8d59298782fb5b7c81ab7", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Administrativo_GestionDeMatriculas_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"h3 mb-2 text-gray-800\">Modulo de administracion de matriculas - Crear</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0deb0e70879200fe68128ca1e5222f32f4906f0b4500", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0deb0e70879200fe68128ca1e5222f32f4906f0b4766", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 8 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("        <div class=\"mb-3\">\r\n            <label class=\"form-label\">Seleccione el estudiante</label>\r\n");
#nullable restore
#line 13 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
             if (Model.Estudiantes.Count() > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <select class=\"form-control\" name=\"estudiante\" id=\"estudiante\">\r\n");
#nullable restore
#line 16 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                     foreach (var item in Model.Estudiantes)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0deb0e70879200fe68128ca1e5222f32f4906f0b7556", async() => {
#nullable restore
#line 18 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                                                                                     Write(item.Nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 18 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                                                                                                  Write(item.Apellido);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                           WriteLiteral(item.IdEstudiante);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 753, "select-", 753, 7, true);
#nullable restore
#line 18 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
AddHtmlAttributeValue("", 760, item.IdEstudiante, 760, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n");
#nullable restore
#line 21 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p> No existen estudiantes en la db </p>\r\n");
#nullable restore
#line 25 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        <div class=\"mb-3\">\r\n            <label class=\"form-label\">Seleccione el año</label>\r\n");
#nullable restore
#line 30 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
             if (Model.Years.Count() > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <select class=\"form-control\" name=\"year\" id=\"year\">\r\n");
#nullable restore
#line 33 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                     foreach (var item in Model.Years)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0deb0e70879200fe68128ca1e5222f32f4906f0b12740", async() => {
#nullable restore
#line 35 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                                                                         Write(item.NombreYear);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                           WriteLiteral(item.IdYear);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1364, "select-", 1364, 7, true);
#nullable restore
#line 35 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
AddHtmlAttributeValue("", 1371, item.IdYear, 1371, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n");
#nullable restore
#line 38 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p> No existen años en la db </p>\r\n");
#nullable restore
#line 42 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        <div class=\"mb-3\">\r\n            <label class=\"form-label\">Seleccione el grado a matricular</label>\r\n");
#nullable restore
#line 47 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
             if (Model.Grados.Count() > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <select class=\"form-control\" name=\"grado\" id=\"grado\">\r\n");
#nullable restore
#line 50 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                     foreach (var item in Model.Grados)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0deb0e70879200fe68128ca1e5222f32f4906f0b17505", async() => {
#nullable restore
#line 52 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                                                                           Write(item.NombreGrado);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                           WriteLiteral(item.IdGrado);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1971, "select-", 1971, 7, true);
#nullable restore
#line 52 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
AddHtmlAttributeValue("", 1978, item.IdGrado, 1978, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n");
#nullable restore
#line 55 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p> No existen grados en la db </p>\r\n");
#nullable restore
#line 59 "C:\FreddyLopez\Estudios\Mintic\ProyectDevelopment\GitHub\Proyecto\MatriculaOnline\Matriculas.App\Matriculas.App.WebApp\Pages\Administrativo\GestionDeMatriculas\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>

        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-right"">
                    <a class=""btn btn-primary btn-icon-split"" href='index'>
                        <span class=""text"">Atras</span>
                    </a>
                    <button type=""submit"" class=""btn btn-success ml-2"">Save</button>
                </div>
            </div>
            <br />
            <br />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas.CreateModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas.CreateModel>)PageContext?.ViewData;
        public Matriculas.App.WebApp.Pages.Administrativo.GestionDeMatriculas.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591