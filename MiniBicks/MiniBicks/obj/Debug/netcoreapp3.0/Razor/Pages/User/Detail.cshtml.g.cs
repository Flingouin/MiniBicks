#pragma checksum "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "784e86b4f16f39e615b51cf42c018700a09f66ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MiniBicks.Pages.User.Pages_User_Detail), @"mvc.1.0.razor-page", @"/Pages/User/Detail.cshtml")]
namespace MiniBicks.Pages.User
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784e86b4f16f39e615b51cf42c018700a09f66ad", @"/Pages/User/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0486b20584bc372a72d218afd3364098065580f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_User_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 7 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
   Write(Model.User.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
                   Write(Model.User.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>");
#nullable restore
#line 8 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
  Write(Model.User.RoleEnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Adresse :</p>\r\n<p>");
#nullable restore
#line 10 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
Write(Model.User.Adresse.NumeroRue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
                            Write(Model.User.Adresse.Rue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
Write(Model.User.Adresse.CodePostal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
                             Write(Model.User.Adresse.Ville);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Pays : ");
#nullable restore
#line 12 "D:\GitHub\MiniBicks\MiniBicks\MiniBicks\Pages\User\Detail.cshtml"
     Write(Model.User.Adresse.PaysEnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiniBicks.Pages.User.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiniBicks.Pages.User.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiniBicks.Pages.User.DetailModel>)PageContext?.ViewData;
        public MiniBicks.Pages.User.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591