#pragma checksum "E:\Web\ASP.NETcore\ElectronicEquipmentStore\ElectronicEquipmentStore\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51703e521ebe79ffdaf52eb053830c6a91582181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
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
#line 1 "E:\Web\ASP.NETcore\ElectronicEquipmentStore\ElectronicEquipmentStore\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Web\ASP.NETcore\ElectronicEquipmentStore\ElectronicEquipmentStore\Areas\Identity\Pages\_ViewImports.cshtml"
using ElectronicEquipmentStore.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Web\ASP.NETcore\ElectronicEquipmentStore\ElectronicEquipmentStore\Areas\Identity\Pages\_ViewImports.cshtml"
using ElectronicEquipmentStore.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Web\ASP.NETcore\ElectronicEquipmentStore\ElectronicEquipmentStore\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ElectronicEquipmentStore.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51703e521ebe79ffdaf52eb053830c6a91582181", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f20e2b2860f7151932c5b7ff6c58b31fbeeab41", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7b0426686cc42f7cb5ee5aed5cffc167a20ff8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Web\ASP.NETcore\ElectronicEquipmentStore\ElectronicEquipmentStore\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
#nullable restore
#line 8 "E:\Web\ASP.NETcore\ElectronicEquipmentStore\ElectronicEquipmentStore\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">You do not have access to this resource.</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
