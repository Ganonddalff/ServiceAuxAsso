#pragma checksum "C:\Users\hp\Desktop\projett\ServiceAuxAsso\AssoFlex\Views\Souscription\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2014fa4ebd724b3b1dd6dcb861a7d97ddb1cf520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Souscription_Index), @"mvc.1.0.view", @"/Views/Souscription/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\projett\ServiceAuxAsso\AssoFlex\Views\_ViewImports.cshtml"
using AssoFlex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\projett\ServiceAuxAsso\AssoFlex\Views\_ViewImports.cshtml"
using AssoFlex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2014fa4ebd724b3b1dd6dcb861a7d97ddb1cf520", @"/Views/Souscription/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9050087cb6c0c93e3f4753a6bade7da318cb88db", @"/Views/_ViewImports.cshtml")]
    public class Views_Souscription_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("msform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Desktop\projett\ServiceAuxAsso\AssoFlex\Views\Souscription\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2014fa4ebd724b3b1dd6dcb861a7d97ddb1cf5205313", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"">
    <title>Inscription</title>
    <!-- Normalize CSS -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css"">
    <!-- Bootstrap 4 CSS -->
    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-beta.2/css/bootstrap.css'>
    <!-- Telephone Input CSS -->
    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/12.1.2/css/intlTelInput.css'>
    <!-- Icons CSS -->
    <link rel='stylesheet' href='https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css'>
    <!-- Nice Select CSS -->
    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/css/nice-select.min.css'>
    <!-- Style CSS -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2014fa4ebd724b3b1dd6dcb861a7d97ddb1cf5206507", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2014fa4ebd724b3b1dd6dcb861a7d97ddb1cf5208398", async() => {
                WriteLiteral("\r\n      <section class=\"multi_step_form\">  \r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2014fa4ebd724b3b1dd6dcb861a7d97ddb1cf5208711", async() => {
                    WriteLiteral(@" 
          <!-- Tittle -->
          <div class=""tittle"">
            <h2>Processus d'inscription</h2>
            <p>Afin de pourvoir profiter des services mis à votre dispostion par Assoflex.</p>
            <p>Veuillez suivre ce processus d'inscription</p>
          </div>
          <!-- progressbar -->
          <ul id=""progressbar"">
            <li class=""active"">Formulaire</li>
            <li>Choix services(s)</li> 
            <li>Paiement</li>
          </ul>
          <!-- fieldsets -->
          <fieldset>
            <h3>Remplissez les champs</h3>
");
                    WriteLiteral(@"            <div class=""form-row""> 
              <div class=""form-group col-md-4""></div>  
              <div class=""form-group col-md-4""> 
                <input type=""text"" class=""form-control"" placeholder=""Nom"">
              </div>
              <div class=""form-group col-md-4""></div> 
            </div> 
            <div class=""form-row""> 
              <div class=""form-group col-md-4""></div>  
              <div class=""form-group col-md-4""> 
                <input type=""text"" class=""form-control"" placeholder=""Numéro SIRET"">
              </div>
              <div class=""form-group col-md-4""></div> 
            </div> 
            <div class=""form-row""> 
              <div class=""form-group col-md-4""></div>  
              <div class=""form-group col-md-4""> 
                <input type=""text"" class=""form-control"" placeholder=""Description"">
              </div>
              <div class=""form-group col-md-4""></div> 
            </div>
            <button type=""button"" class=""action-but");
                    WriteLiteral(@"ton previous_button"">Back</button>
            <button type=""button"" class=""next action-button"">Continue</button>  
          </fieldset>
          
          <fieldset>
            <h3>Formule de souscription</h3>
            <h6>Chosissez une formule de souscription</h6>
            <section class=""pricing-table"">
                   <div class=""row justify-content-md-center"">
                       <div class=""col-md-4 col-lg-3"">
                           <div class=""item"">
                              <div class=""heading"">
                                 <h3>GRATUIT</h3>
                              </div>
                              <div class=""features"">
                                 <h4><span class=""feature"">Gestion d&apos;Adhérent</span> : <span class=""value"">Oui</span></h4>
                                 <h4><span class=""feature"">Billetterie</span> : <span class=""value"">Non</span></h4>
                                 <h4><span class=""feature"">Crowdfunding</span> : <span cl");
                    WriteLiteral(@"ass=""value"">Non</span></h4>
                              </div>
                              <div class=""price"">
                                 <h4>0€</h4>
                              </div>
                              <button class=""btn btn-block btn-outline-primary"" type=""submit"">BUY NOW</button>
                           </div>
                        </div>
                       <div class=""col-md-4 col-lg-3"">
                           <div class=""item"">
                                <div class=""ribbon"">Bon Plan</div>
                               <div class=""heading"">
                                   <h3>BASIC 1 </h3>
                               </div>
                               <div class=""features"">
                                   <h4><span class=""feature"">Gestion d&apos;Adhérent</span> : <span class=""value"">Oui</span></h4>
                                   <h4><span class=""feature"">Billetterie</span> : <span class=""value"">Oui</span></h4>
                    ");
                    WriteLiteral(@"               <h4><span class=""feature"">Crowdfunding</span> : <span class=""value"">Non</span></h4>
                               </div>
                               <div class=""price"">
                                   <h4>50€</h4>
                               </div>
                               <button class=""btn btn-block btn-outline-primary"" type=""submit"">BUY NOW</button>
                           </div>
                       </div>
                       <div class=""col-md-4 col-lg-3"">
                           <div class=""item"">
                               <div class=""ribbon"">Bon Plan</div>
                               <div class=""heading"">
                                   <h3>BASIC 2</h3>
                               </div>
                               <div class=""features"">
                                   <h4><span class=""feature"">Gestion d&apos;Adhérent</span> : <span class=""value"">Oui</span></h4>
                                   <h4><span class=""feature"">Bil");
                    WriteLiteral(@"letterie</span> : <span class=""value"">Non</span></h4>
                                   <h4><span class=""feature"">Crowdfunding</span> : <span class=""value"">Oui</span></h4>
                               </div>
                               <div class=""price"">
                                   <h4>50€</h4>
                               </div>
                               <button class=""btn btn-block btn-primary"" type=""submit"">BUY NOW</button>
                           </div>
                       </div>
                       <div class=""col-md-4 col-lg-3"">
                           <div class=""item"">
                               <div class=""heading"">
                                   <h3>FULL</h3>
                               </div>
                               <div class=""features"">
                                   <h4><span class=""feature"">Gestion d&apos;Adhérent</span> : <span class=""value"">Oui</span></h4>
                                   <h4><span class=""feature"">Billet");
                    WriteLiteral(@"terie</span> : <span class=""value"">Oui</span></h4>
                                   <h4><span class=""feature"">Crowdfunding</span> : <span class=""value"">Oui</span></h4>
                               </div>
                               <div class=""price"">
                                   <h4>95€</h4>
                               </div>
                               <button class=""btn btn-block btn-outline-primary"" type=""submit"">BUY NOW</button>
                           </div>
                       </div>
                   </div>
            </section>
            <button type=""button"" class=""action-button previous previous_button"">Back</button>
            <button type=""button"" class=""next action-button"">Continue</button>  
          </fieldset>  
          
          <fieldset>
            <h3>Paiement</h3>
            <h6>Procéder au paiement de votre souscription</h6> 
            
            <button type=""button"" class=""action-button previous previous_button"">Back</button> ");
                    WriteLiteral("\r\n            <a href=\"#\" class=\"action-button\">Finish</a> \r\n          </fieldset>  \r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"  
      </section>
      <!-- jQuery -->
      <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
      <!-- Bootstrap JS -->
      <script src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-beta/js/bootstrap.min.js'></script>
      <!-- jQuery Easing JS -->
      <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js'></script>
      <!-- Telephone Input JS -->
      <script src='https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/12.1.2/js/intlTelInput.js'></script>
      <!-- Popper JS -->
      <script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js'></script>
      <!-- jQuery Nice Select JS -->
      <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/js/jquery.nice-select.min.js'></script>
      <!-- Initialization -->
      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2014fa4ebd724b3b1dd6dcb861a7d97ddb1cf52018285", async() => {
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
                WriteLiteral("\r\n    ");
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
            WriteLiteral("\r\n</html>");
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
