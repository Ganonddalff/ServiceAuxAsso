#pragma checksum "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c02240e976b56482941b6bd37fe26fdc9ef5c3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_DashboardAdmin), @"mvc.1.0.view", @"/Views/Dashboard/DashboardAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c02240e976b56482941b6bd37fe26fdc9ef5c3b", @"/Views/Dashboard/DashboardAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea595367083bd9ff9f30c85678ac5d20d53440a", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_DashboardAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssoFlex.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
  
    ViewBag.Title = "Dashboard Admin";
    Layout = "_LayoutDashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container p-5 my-5 bg-dark text-white"" style=""text-align: center;"">
    <h1>Liste des associations</h1>
</div>
<div class=""container mt-auto"">
    <table class=""table-responsive"">
        <thead class=""table-dark"">
        <tr>
            <th>ID</th>
            <th>Nom</th>
            <th>SIRET</th>
            <th>Inscription</th>
            <th>Administrateur</th>
            <th></th>
        </tr>
        </thead>
        
");
#nullable restore
#line 24 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
         foreach (var association in Model.Associations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 27 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(association.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(association.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(association.NumSiret);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(association.DateInscription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <th>");
#nullable restore
#line 31 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(association.AdminAsso.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
                                             Write(association.AdminAsso.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td><a class=\"link-primary\"");
            BeginWriteAttribute("href", " href=", 965, "", 1045, 1);
#nullable restore
#line 32 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
WriteAttributeValue("", 971, Url.Action("DetailsAssociation","Association",new {id = @association.Id}), 971, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Voir Détails</a></td>\n                <td></td>\n            </tr>\n");
#nullable restore
#line 35 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div class=""container p-5 my-5 bg-dark text-white"" style=""text-align: center;"">
    <h1>Liste des membres</h1>
</div>
<div class=""container mt-auto"">
    <table class=""table-responsive"">
        <thead class=""table-dark"">
        <tr>
            <th>ID</th>
            <th>Prenom</th>
            <th>Nom</th>
            <th>Adresse</th>
            <th>Telephone</th>
            <th>Email</th>
            <th>Role</th>
        </tr>
        </thead>
        
");
#nullable restore
#line 55 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
         foreach (var user in Model.Utilisateurs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 58 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 59 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(user.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 60 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(user.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 61 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(user.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 62 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(user.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 63 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 64 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(user.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            </tr>\n");
#nullable restore
#line 67 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div class=""container p-5 my-5 bg-dark text-white"" style=""text-align: center;"">
    <h1>Liste des adhésions</h1>
</div>
<div class=""container mt-sm-auto"">
    <table class=""table-responsive"">
        <thead class=""table-dark"">
            <tr>
                <th>ID</th>
                <th>Associaiton</th>
                <th>Utilisateur</th>
                <th>Date de début</th>
                <th>Date de fin</th>
            </tr>
        </thead>
        
");
#nullable restore
#line 85 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
         foreach (var adh in Model.Adhesions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 88 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(adh.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 89 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(adh.Association.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 90 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(adh.Utilisateur.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 90 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
                                       Write(adh.Utilisateur.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 91 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(adh.DateDebut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 92 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
               Write(adh.DateFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            </tr>\n");
#nullable restore
#line 95 "/mnt/sdb1/Sauvegarde/Documents/Formation - ISIKA/Projets/ISIKA_Projet2/AssoFlex/AssoFlex/Views/Dashboard/DashboardAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssoFlex.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
