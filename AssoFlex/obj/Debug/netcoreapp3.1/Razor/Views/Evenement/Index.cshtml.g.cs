#pragma checksum "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b4fdca04ca31b0d2fb517980910fba5ae549403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evenement_Index), @"mvc.1.0.view", @"/Views/Evenement/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4fdca04ca31b0d2fb517980910fba5ae549403", @"/Views/Evenement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea595367083bd9ff9f30c85678ac5d20d53440a", @"/Views/_ViewImports.cshtml")]
    public class Views_Evenement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<AssoFlex.Models.Evenement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Bienvenue sur l'espace billetterie</h1>
<br/>
<div>
    <label for=""site-search"">Search the site:</label>
    <input type=""search"" id=""site-search"" name=""q"">
    
    <button>Search</button>
</div>
<br/>
<p>Evènements à venir :</p>
<br/>
<table>
    <tr>
        <th>Date</th>
        <th>Lieu</th>
        <th>Nom de l'évènement</th>
    </tr>
");
#nullable restore
#line 23 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
     foreach (var evenements in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 26 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
           Write(evenements.DateDebutEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
           Write(evenements.LieuEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 28 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
           Write(evenements.NomEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 30 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<br/>\n\n<a");
            BeginWriteAttribute("href", " href=", 675, "", 720, 1);
#nullable restore
#line 35 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
WriteAttributeValue("", 681, Url.Action("AchatTicket", "Evenement"), 681, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Acheter un billet</a>\n\n<br/>\n\n<a");
            BeginWriteAttribute("href", " href=", 753, "", 784, 1);
#nullable restore
#line 39 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Evenement/Index.cshtml"
WriteAttributeValue("", 759, Url.Action("CreerEvent"), 759, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Créer un évènement</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<AssoFlex.Models.Evenement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
