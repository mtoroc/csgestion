#pragma checksum "C:\Users\developer\Desktop\CSGestion\repositorio\csgestion\CSGestion\Views\RegistroSolicitud\Agregar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d2150b856f6b71c802cf4fe811b64d0b13e9cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroSolicitud_Agregar), @"mvc.1.0.view", @"/Views/RegistroSolicitud/Agregar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroSolicitud/Agregar.cshtml", typeof(AspNetCore.Views_RegistroSolicitud_Agregar))]
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
#line 1 "C:\Users\developer\Desktop\CSGestion\repositorio\csgestion\CSGestion\Views\_ViewImports.cshtml"
using CSGestion;

#line default
#line hidden
#line 2 "C:\Users\developer\Desktop\CSGestion\repositorio\csgestion\CSGestion\Views\_ViewImports.cshtml"
using CSGestion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d2150b856f6b71c802cf4fe811b64d0b13e9cc", @"/Views/RegistroSolicitud/Agregar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54ff2ce91e1666f76c2cfa8dc7b4280296dd938", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroSolicitud_Agregar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 587, true);
            WriteLiteral(@"
<div class=""modal-content"">
    <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalCenterTitle"">Calendario de solicitudes</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
    <div class=""modal-body"">
        <div class=""row"">
            <div class=""col-md-12 mb-3"">
                <label for=""sectorSolicitado"">Sector solicitado</label>
                <select class=""form-control"" id=""sectorSolicitado"">
                    ");
            EndContext();
            BeginContext(587, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08f5b80d95fe43409b7371e2b643aac3", async() => {
                BeginContext(595, 13, true);
                WriteLiteral("Seleccione...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(617, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(639, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2704d8d280f340f6be7754d5a49cde83", async() => {
                BeginContext(647, 18, true);
                WriteLiteral("Salón de eventos A");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(674, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(696, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bd8f9d304d34ac2ae1e92fa0db3c5d1", async() => {
                BeginContext(704, 18, true);
                WriteLiteral("Salón de eventos B");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(731, 2000, true);
            WriteLiteral(@"
                </select>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 mb-3"">
                <label for=""fechaHoraInicio"">Fecha/Hora inicio</label>
                <div class='input-group date' id='fechaHoraInicio'>
                    <input type='text' class=""form-control"" />
                    <span class=""input-group-addon"">
                        <span class=""glyphicon glyphicon-calendar"">asd</span>
                    </span>
                </div>
            </div>
            <div class=""col-md-6 mb-3"">
                <label for=""fechaHoraFin"">Fecha/Hora  fin</label>
                <input type=""text"" class=""form-control"" id=""fechaHoraFin"" placeholder="""" value="""">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 mb-3"">
                <label for=""rutSolicitante"">Rut solicitante</label>
                <input type=""text"" class=""form-control"" id=""rutSolicitante"" placeholder="""" value=""""");
            WriteLiteral(@">
            </div>
            <div class=""col-md-6 mb-3"">
                <label for=""nombreSolicitante"">Nombre</label>
                <input type=""text"" class=""form-control"" id=""nombreSolicitante"" placeholder="""" value="""">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 mb-3"">
                <label for=""CasaDepto"">Casa / Depto</label>
                <input type=""text"" class=""form-control"" id=""CasaDepto"" placeholder="""" value="""">
            </div>
            <div class=""col-md-6 mb-3"">
                <label for=""ubicacion"">Ubicación</label>
                <input type=""text"" class=""form-control"" id=""ubicacion"" placeholder="""" value="""">
            </div>
        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-primary"">Crear</button>
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2749, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
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
