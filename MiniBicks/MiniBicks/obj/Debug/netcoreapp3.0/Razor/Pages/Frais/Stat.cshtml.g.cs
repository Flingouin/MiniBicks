#pragma checksum "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3180c9669c615e365f63a0efca616e5213d0be4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MiniBicks.Pages.Frais.Pages_Frais_Stat), @"mvc.1.0.razor-page", @"/Pages/Frais/Stat.cshtml")]
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
#line 2 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
using Entities.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
using Helpers.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3180c9669c615e365f63a0efca616e5213d0be4c", @"/Pages/Frais/Stat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0486b20584bc372a72d218afd3364098065580f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Frais_Stat : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
  
    ViewData["Title"] = "Stat";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Stats du mois</h1>\r\n<h2>Par type de frais</h2>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Type de frais</th>\r\n            <th>Montant total</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
         foreach (KeyValuePair<FraiEnum, decimal> kvp in Model.DicoFrais)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
                Write(FraisEnumHelper.GetFriendlyEnum(kvp.Key));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
                Write(string.Format("{0:C2}",Math.Round(kvp.Value,2)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h2>Par employé</h2>\r\n<table class=\"myTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>Utilisateur</th>\r\n            <th>Montant total</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
         foreach (KeyValuePair<string, decimal> kvp in Model.DicoFraisByUser)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 41 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
               Write(kvp.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
                Write(string.Format("{0:C2}", Math.Round(kvp.Value, 2)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\Frais\Stat.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiniBicks.Pages.Frais.StatModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiniBicks.Pages.Frais.StatModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiniBicks.Pages.Frais.StatModel>)PageContext?.ViewData;
        public MiniBicks.Pages.Frais.StatModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
