#pragma checksum "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "256bf9339588dd56f72c2bda03ec3693102cb56d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MiniBicks.Pages.Frais.Pages_Frais_ToRefund), @"mvc.1.0.razor-page", @"/Pages/Frais/ToRefund.cshtml")]
namespace MiniBicks.Pages.Frais
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
#line 1 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\_ViewImports.cshtml"
using MiniBicks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
using Helpers.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256bf9339588dd56f72c2bda03ec3693102cb56d", @"/Pages/Frais/ToRefund.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0486b20584bc372a72d218afd3364098065580f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Frais_ToRefund : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Frais/ValidateOrRefuse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
  
    ViewData["Title"] = "ToRefund";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Demandes de remboursement </h1>
<table>
    <thead>
        <tr>
            <th>Nom</th>
            <th>Prenom</th>
            <th>Type de frais</th>
            <th>Etat de la demande</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
         foreach (Entities.Frai frais in Model.ListeFrais)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
               Write(frais.User.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
               Write(frais.User.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
                Write(new FraisEnumHelper().GetFriendlyEnum(frais.FraiEnum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
                Write(new ValidatiEnumHelper().GetFriendlyEnum(frais.ValidateEnum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "256bf9339588dd56f72c2bda03ec3693102cb56d5201", async() => {
                WriteLiteral("Manager");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idFrai", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
                                                                WriteLiteral(frais.ID_Frai);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idFrai"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idFrai", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idFrai"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\ToRefund.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiniBicks.Pages.Frais.ToRefundModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiniBicks.Pages.Frais.ToRefundModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiniBicks.Pages.Frais.ToRefundModel>)PageContext?.ViewData;
        public MiniBicks.Pages.Frais.ToRefundModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591