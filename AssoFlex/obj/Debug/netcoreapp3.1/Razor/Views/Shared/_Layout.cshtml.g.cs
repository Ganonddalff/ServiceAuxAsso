#pragma checksum "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56f8907cbb27724bcb9bc84f4da2b0a3db41dfc0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9050087cb6c0c93e3f4753a6bade7da318cb88db", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/fontawesome-free-6.1.0-web/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/logo_startup.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/popper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc06305", async() => {
                WriteLiteral(@"
	<meta charset=""utf-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<title>AssoFlex</title>
	<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"">
	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""></script>
	<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""></script>
	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc07100", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc08907", async() => {
                WriteLiteral("\r\n<!-- Navigation -->\r\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light sticky-top\">\r\n    <div class=\"container-fluid\">\r\n    \t<a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=", 962, "", 996, 1);
#nullable restore
#line 21 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 968, Url.Action("Index", "Home"), 968, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc09764", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
    	<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"">
    		<span class=""navbar-toggler-icon""></span>
    	</button>
	    <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
		    <div class=""navbar"">
			    <a class=""nav-item nav-link""");
                BeginWriteAttribute("href", " href=", 1357, "", 1391, 1);
#nullable restore
#line 27 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1363, Url.Action("Index", "Home"), 1363, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Acceuil</a>\r\n\t\t\t    <a class=\"nav-item nav-link\"");
                BeginWriteAttribute("href", " href=", 1440, "", 1482, 1);
#nullable restore
#line 28 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1446, Url.Action("Index", "Presentation"), 1446, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Présentation</a>
			    <div class=""nav-item dropdown"">
				    <a class=""nav-link dropdown-toggle"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" 
				       aria-haspopup=""true"" aria-expanded=""false"" href=""#"">
					    Nos services
				    </a>
				    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
					    <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=", 1852, "", 1894, 1);
#nullable restore
#line 35 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1858, Url.Action("Index", "Crowdfunding"), 1858, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Crowdfunding</a> \r\n\t\t\t\t\t    <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=", 1947, "", 1986, 1);
#nullable restore
#line 36 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1953, Url.Action("Index", "Evenement"), 1953, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Évènement</a> \r\n\t\t\t\t    </div>\r\n\t\t\t    </div>\r\n\t\t\t     <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=", 2061, "", 2102, 1);
#nullable restore
#line 39 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2067, Url.Action("Index", "Association"), 2067, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Nos associations</a>\r\n\t\t    </div>\r\n\t\t    <div class=\"navbar-nav ms-auto\">\r\n\t\t\t    <a class=\"nav-item nav-link\"");
                BeginWriteAttribute("href", " href=", 2214, "", 2255, 1);
#nullable restore
#line 42 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2220, Url.Action("Index","Souscription"), 2220, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color: #0c63e4; font-weight:700;\">Inscris Ton Asso</a> ");
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
                  
				    if (User.Identity.IsAuthenticated)
				    {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t    <div class=\"nav-item dropdown\">\r\n\t\t\t\t\t\t    <a class=\"nav-link dropdown-toggle\" data-bs-toggle=\"dropdown\" href=\"#userResponsive\">Bonjour ");
#nullable restore
#line 47 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
                                                                                                                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n\t\t\t\t\t\t    <div class=\"dropdown-menu\" id=\"userResponsive\">\r\n");
#nullable restore
#line 49 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
                                 if (User.IsInRole("Admin"))
							    {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t    <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=", 2751, "", 2799, 1);
#nullable restore
#line 51 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2757, Url.Action("DashboardAdmin", "Dashboard"), 2757, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Dashboard</a>\r\n");
#nullable restore
#line 52 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
							    }else if (User.IsInRole("Admin-Asso"))
							    {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t    <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=", 2916, "", 3014, 1);
#nullable restore
#line 54 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2922, Url.Action("Profil", "Dashboard", new {id=User.FindFirst(ClaimTypes.NameIdentifier).Value}), 2922, 92, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Profil</a>\r\n");
#nullable restore
#line 55 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
							    }
							    else
							    {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t    <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=", 3108, "", 3206, 1);
#nullable restore
#line 58 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3114, Url.Action("Profil", "Dashboard", new {id=User.FindFirst(ClaimTypes.NameIdentifier).Value}), 3114, 92, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Profil</a>\r\n");
#nullable restore
#line 59 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
							    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t    \r\n\t\t\t\t\t\t\t    <div class=\"dropdown-divider\"></div>\r\n\t\t\t\t\t\t\t    <a class=\"nav-link dropdown-item\" role=\"menuitem\"");
                BeginWriteAttribute("href", " href=", 3355, "", 3396, 1);
#nullable restore
#line 62 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3361, Url.Action("Deconnexion", "Login"), 3361, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><b>Se Déconnecter</b></a>\r\n\t\t\t\t\t\t    </div>\r\n\t\t\t\t\t    </div>\r\n");
#nullable restore
#line 65 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
				    }
				    else
				    {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t    <div class=\"dropdown\">\r\n\t\t\t\t\t\t    <a class=\"nav-item nav-link\"");
                BeginWriteAttribute("href", " href=", 3566, "", 3601, 1);
#nullable restore
#line 69 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3572, Url.Action("Index", "Login"), 3572, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color: #157347; font-weight:700;\"><b>Se Connecter</b></a>\r\n\t\t\t\t\t    </div>\r\n");
#nullable restore
#line 71 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
				    }
			    

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t    </div>\r\n\t\t    \r\n\t    </div>\r\n    </div>\r\n</nav>\r\n<div id=\"main\">\r\n");
                WriteLiteral("\t<div id=\"content\">\r\n\t\t");
#nullable restore
#line 85 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t</div>\r\n</div>\r\n<!--- Footer -->\r\n<footer>\r\n\t<div class=\"container-fluid padding\">\r\n\t\t<div class=\"row text-center\">\r\n\t\t\t<div class=\"col-md-4\">\r\n");
                WriteLiteral(@"				<hr class=""light"">
				<p>+33 (0)7 55 17 23 16</p>
				<p>contact@assoflex.com</p>
				<p>31 rue de l'aurore</p>
				<p>78100, Saint-Germain-en-Laye, France</p>
			</div>
			<div class=""col-md-4"">
				<hr class=""light"">
				<h5>Nos horaires</h5>
				<hr class=""light"">
				<p>Lundi, Mardi : 9h - 17h</p>
				<p>Mercredi,Jeudi : 12h - 17h</p>
				<p>Vendredi : Fermé</p>
			</div>
			<div class=""col-md-4"">
				<hr class=""light"">
				<h5>Ville</h5>
				<hr class=""light"">
				<p>78100, Saint-Germain-en-Laye, France</p>
				<p>75000, Paris, France</p>
				<p>51100 , Reims, France</p>
			</div>
			<div class=""col-12"">
				<hr class=""light-100"">
				<h5>&COPY; ");
#nullable restore
#line 118 "C:\Users\PKAMMEGNE\Documents\Paul\ISIKA\Formation ISIKA\Partie 2\Projet 2\ServiceAuxAsso\AssoFlex\Views\Shared\_Layout.cshtml"
                      Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Assoflex.com</h5>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</footer>\r\n\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc022020", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc023116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc024212", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f8907cbb27724bcb9bc84f4da2b0a3db41dfc025308", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
