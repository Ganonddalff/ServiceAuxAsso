#pragma checksum "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b7ab829a29c7d2d418ce600ac38789478f1a05a"
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
#line 1 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\_ViewImports.cshtml"
using AssoFlex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\_ViewImports.cshtml"
using AssoFlex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b7ab829a29c7d2d418ce600ac38789478f1a05a", @"/Views/Evenement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9050087cb6c0c93e3f4753a6bade7da318cb88db", @"/Views/_ViewImports.cshtml")]
    public class Views_Evenement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<AssoFlex.Models.Evenement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
  
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
#line 23 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
     foreach (var evenements in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
           Write(evenements.DateDebutEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
           Write(evenements.LieuEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
           Write(evenements.NomEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<br/>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=", 709, "", 754, 1);
#nullable restore
#line 35 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
WriteAttributeValue("", 715, Url.Action("AchatTicket", "Evenement"), 715, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Acheter un billet</a>\r\n\r\n<br/>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=", 791, "", 822, 1);
#nullable restore
#line 39 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Evenement\Index.cshtml"
WriteAttributeValue("", 797, Url.Action("CreerEvent"), 797, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Créer un évènement</a>\r\n");
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
