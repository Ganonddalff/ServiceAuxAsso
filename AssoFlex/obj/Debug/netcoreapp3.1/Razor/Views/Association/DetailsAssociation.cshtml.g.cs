#pragma checksum "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Association/DetailsAssociation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "046735683dd93f1553a631124f9a299afb97496c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Association_DetailsAssociation), @"mvc.1.0.view", @"/Views/Association/DetailsAssociation.cshtml")]
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
#line 1 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/_ViewImports.cshtml"
using AssoFlex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/_ViewImports.cshtml"
using AssoFlex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046735683dd93f1553a631124f9a299afb97496c", @"/Views/Association/DetailsAssociation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea595367083bd9ff9f30c85678ac5d20d53440a", @"/Views/_ViewImports.cshtml")]
    public class Views_Association_DetailsAssociation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssoFlex.Models.Association>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Association/DetailsAssociation.cshtml"
  
    ViewBag.Title = "Association";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container p-5 my-5 bg-dark text-white text-center\">\n    <h2>Page de l&apos;association ");
#nullable restore
#line 8 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Association/DetailsAssociation.cshtml"
                              Write(Model.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h5>");
#nullable restore
#line 9 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Association/DetailsAssociation.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssoFlex.Models.Association> Html { get; private set; }
    }
}
#pragma warning restore 1591
