#pragma checksum "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fcde923a856c7fe36dcaf3e2f11e4457077902f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.FrontEnd.Pages.Mascota.Pages_Mascota_DetallesMascota), @"mvc.1.0.razor-page", @"/Pages/Mascota/DetallesMascota.cshtml")]
namespace MascotaFeliz.App.FrontEnd.Pages.Mascota
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
#line 1 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fcde923a856c7fe36dcaf3e2f11e4457077902f", @"/Pages/Mascota/DetallesMascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e968b00c86c979a2fd0e0516e812d0f8c887b71b", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Mascota_DetallesMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Mascota/ListarMascota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fcde923a856c7fe36dcaf3e2f11e4457077902f4734", async() => {
                WriteLiteral("\r\n<section class=\"formularios\">\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fcde923a856c7fe36dcaf3e2f11e4457077902f5027", async() => {
                    WriteLiteral("\r\n<h2>Detalles de la Mascota</h2>\r\n<div><p>Id: ");
#nullable restore
#line 9 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
       Write(Model.mascota.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p></div>\r\n<div><p>Nombre: ");
#nullable restore
#line 10 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
           Write(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p></div>\r\n<div><p>Color: ");
#nullable restore
#line 11 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
          Write(Model.mascota.Color);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p></div>\r\n<div><p>Raza: ");
#nullable restore
#line 12 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
         Write(Model.mascota.Raza);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p></div>\r\n<div><p>Especie: ");
#nullable restore
#line 13 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
            Write(Model.mascota.Especie);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p></div>\r\n");
#nullable restore
#line 14 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
 if (Model.mascota.Dueno == null)
{

#line default
#line hidden
#nullable disable
                    WriteLiteral("<div><p>Dueno: NO EXISTE</p></div>\r\n");
#nullable restore
#line 17 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
                    WriteLiteral("<div><p>Dueno: ");
#nullable restore
#line 20 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
          Write(Model.mascota.Dueno.Nombres);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 20 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
                                       Write(Model.mascota.Dueno.Apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p></div>    \r\n");
#nullable restore
#line 21 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
}

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n");
#nullable restore
#line 23 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
 if (Model.mascota.Veterinario == null)
{

#line default
#line hidden
#nullable disable
                    WriteLiteral("<div><p>Veterinario: NO EXISTE</p></div>\r\n");
#nullable restore
#line 26 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
                    WriteLiteral("<div><p>Veterinario: ");
#nullable restore
#line 29 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
                Write(Model.mascota.Veterinario.Nombres);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 29 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
                                                   Write(Model.mascota.Veterinario.Apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </p></div>   \r\n");
#nullable restore
#line 30 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
}

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
 if (Model.mascota.Historia == null)
{

#line default
#line hidden
#nullable disable
                    WriteLiteral("<div><p>Historia: NO EXISTE</p></div>\r\n");
#nullable restore
#line 35 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
                    WriteLiteral("<div><p>Historia: ");
#nullable restore
#line 38 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
             Write(Model.mascota.Historia.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p></div>   \r\n");
#nullable restore
#line 39 "D:\MascotaFelizG5Tech\mascotafeliz.app.frontend\Pages\Mascota\DetallesMascota.cshtml"
}

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n<div><p>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fcde923a856c7fe36dcaf3e2f11e4457077902f10307", async() => {
                        WriteLiteral("Retornar");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</p></div>\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.FrontEnd.DetallesMascotaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.FrontEnd.DetallesMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.FrontEnd.DetallesMascotaModel>)PageContext?.ViewData;
        public MascotaFeliz.App.FrontEnd.DetallesMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
