#pragma checksum "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "471211efb1c6ffc5eca88d7b6f12468afaa81ec6"
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
#line 1 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\_ViewImports.cshtml"
using BusTicketReservation.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\_ViewImports.cshtml"
using BusTicketReservation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\_ViewImports.cshtml"
using BusTicketReservation.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\_ViewImports.cshtml"
using BusTicketReservation.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"471211efb1c6ffc5eca88d7b6f12468afaa81ec6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82ec6dd61c80b35243129743ed73e4067be92fb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471211efb1c6ffc5eca88d7b6f12468afaa81ec67084", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - BusTicketReservation.WebUI</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link href=""/css/style.css"" rel=""stylesheet"" />
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471211efb1c6ffc5eca88d7b6f12468afaa81ec69056", async() => {
                WriteLiteral(@"
    <div class=""navbar navbar-expand-lg navbar-dark bg-danger"">
        <div class=""container-fluid"">
            <div class=""d-flex justify-content-end"">
                <a class=""navbar-brand"" href=""#"">
                    <img src=""/img/logo.png"" class=""d-inline-block"" width=""439"">
                </a>
            </div>
            <div class=""d-flex justify-content-end"">
                <div class=""collapse navbar-collapse align-items-center"" id=""navbarTogglerDemo02"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                        <li class=""nav-item pt-4"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa-brands fa-twitter-square""></i>
                            </a>
                        </li>
                        <li class=""nav-item pt-4"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa-brands fa-facebook-square""></i>
                           ");
                WriteLiteral(@" </a>
                        </li>
                        <li class=""nav-item pt-4"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa-brands fa-instagram""></i>
                            </a>
                        </li>
                        <li class=""nav-item pt-4"">
                            <a class=""nav-link"">
                                <i class=""fa-brands fa-spotify""></i>
                            </a>
                        </li>
                        <li class=""nav-item pt-4"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa-brands fa-linkedin""></i>
                            </a>
                        </li>
                        <li class=""nav-item pt-4"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa-brands fa-pinterest-square""></i>
                            </a>
                        </li>");
                WriteLiteral(@"
                        <li class=""nav-item p-1"">
                            <a class=""nav-link"" href=""#"">
                                <img src=""https://d3rh8btizouuof.cloudfront.net/images/seperator3.png""
                                     style=""max-height:60px;"">
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" style=""font-size: 17px;"">
                                <p>7/24 Yolcu Hizmetleri</p>
                                <span style=""font-size: 20px;"">0 850 333 35 35</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <header class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""container-fluid"">
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarTogglerDemo02""
                ");
                WriteLiteral(@"    aria-controls=""navbarTogglerDemo02"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                    <li class=""nav-item"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471211efb1c6ffc5eca88d7b6f12468afaa81ec612990", async() => {
                    WriteLiteral("ANASAYFA");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle active"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            OTOBÜS BİLETİ
                        </a>
                        <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                            <li><a class=""dropdown-item"" href=""#"">> Afyon</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Ankara</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Antalya</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Aydın</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Balıkesir</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Bilecik</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Çanakkale</a></li>
        ");
                WriteLiteral(@"                    <li><a class=""dropdown-item"" href=""#"">> Denizli</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Eskişehir</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Isparta</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> İstanbul</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> İzmir</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Tekirdağ</a></li>
                            <li><a class=""dropdown-item"" href=""#"">> Zonguldak</a></li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" href=""#"">İLETİŞİM</a>
                    </li>

");
#nullable restore
#line 105 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {
                        if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471211efb1c6ffc5eca88d7b6f12468afaa81ec616941", async() => {
                    WriteLiteral("ADMIN PANELİ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 112 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n            <div>\r\n                <ul class=\"navbar-nav flex-grow-1\">\r\n");
#nullable restore
#line 118 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
                     if (!User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li class=""nav-item"">
                            <a href=""/account/login"" class=""nav-link text-dark"">Login</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/account/register"" class=""nav-link text-dark"">Register</a>
                        </li>
");
#nullable restore
#line 126 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a href=\"/account/manage\" class=\"nav-link text-dark\">");
#nullable restore
#line 130 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
                                                                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"/account/logout\" class=\"nav-link text-dark\">Logout</a>\r\n                        </li>\r\n");
#nullable restore
#line 135 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <div class=\"container-fluid p-0\">\r\n        <main role=\"main\"");
                BeginWriteAttribute("class", " class=\"", 7688, "\"", 7696, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            ");
#nullable restore
#line 144 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <footer>
        <div class=""container my-5"">
            <!-- Footer -->
            <div class=""text-center text-lg-start text-white""
                 style=""background-color: #929fba"">
                <!-- Grid container -->
                <div class=""container p-4 pb-0"">
                    <!-- Section: Links -->
                    <section");
                BeginWriteAttribute("class", " class=\"", 8119, "\"", 8127, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <!--Grid row-->
                        <div class=""row"">
                            <!-- Grid column -->
                            <div class=""col-md-3 col-lg-3 col-xl-3 mx-auto mt-3"">
                                <h6 class=""text-uppercase mb-4 font-weight-bold text-dark"">
                                    Kurnaz Turizm
                                </h6>
                                <p class=""text-dark"">Hayallerinize Taşır.</p>
                            </div>
                            <!-- Grid column -->

                            <hr class=""w-100 clearfix d-md-none"" />

                            <!-- Grid column -->
                            <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mt-3 text-dark"">
                                <h6 class=""text-uppercase mb-4 font-weight-bold"">Products</h6>
                                <p>
                                    <a class=""text-dark"">Misyonumuz</a>
                                </");
                WriteLiteral(@"p>
                                <p>
                                    <a class=""text-dark"">Vizyonumuz</a>
                                </p>
                                <p>
                                    <a class=""text-dark"">Kalite Politikamız</a>
                                </p>
                                <p>
                                    <a class=""text-dark"">Güvenli Hizmet</a>
                                </p>
                            </div>
                            <!-- Grid column -->

                            <hr class=""w-100 clearfix d-md-none"" />

                            <!-- Grid column -->
                            <hr class=""w-100 clearfix d-md-none"" />

                            <!-- Grid column -->
                            <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mt-3 text-dark"">
                                <h6 class=""text-uppercase mb-4 font-weight-bold"">İLETİŞİM</h6>
                                <p><i class=""");
                WriteLiteral(@"fas fa-home mr-3""></i> İSTANBUL</p>
                                <p><i class=""fas fa-envelope mr-3""></i> info@kurnazturizm.com</p>
                                <p><i class=""fas fa-phone mr-3""></i> 0 850 333 35 35</p>
                                <p><i class=""fas fa-print mr-3""></i> 0 850 333 36 36</p>
                            </div>
                            <!-- Grid column -->
                            <!-- Grid column -->
                            <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mt-3 text-dark"">
                                <h6 class=""text-uppercase mb-4 font-weight-bold"">Bizi Takip Edin</h6>

                                <!-- Facebook -->
                                <a class=""btn btn-primary btn-floating m-1""
                                   style=""background-color: #3b5998""
                                   href=""#!""
                                   role=""button"">
                                    <i class=""fab fa-facebook-f""></i>
        ");
                WriteLiteral(@"                        </a>

                                <!-- Twitter -->
                                <a class=""btn btn-primary btn-floating m-1""
                                   style=""background-color: #55acee""
                                   href=""#!""
                                   role=""button"">
                                    <i class=""fab fa-twitter""></i>
                                </a>

                                <!-- Google -->
                                <a class=""btn btn-primary btn-floating m-1""
                                   style=""background-color: #dd4b39""
                                   href=""#!""
                                   role=""button"">
                                    <i class=""fab fa-google""></i>
                                </a>

                                <!-- Instagram -->
                                <a class=""btn btn-primary btn-floating m-1""
                                   style=""background-color: #");
                WriteLiteral(@"ac2bac""
                                   href=""#!""
                                   role=""button"">
                                    <i class=""fab fa-instagram""></i>
                                </a>

                                <!-- Linkedin -->
                                <a class=""btn btn-primary btn-floating m-1""
                                   style=""background-color: #0082ca""
                                   href=""#!""
                                   role=""button"">
                                    <i class=""fab fa-linkedin-in""></i>
                                </a>
                                <!-- Github -->
                                <a class=""btn btn-primary btn-floating m-1""
                                   style=""background-color: #333333""
                                   href=""#!""
                                   role=""button"">
                                    <i class=""fab fa-github""></i>
                                </a>
     ");
                WriteLiteral(@"                       </div>
                        </div>
                        <!--Grid row-->
                    </section>
                    <!-- Section: Links -->
                </div>
                <!-- Grid container -->
                <!-- Copyright -->
                <div class=""text-center p-3""
                     style=""background-color: rgba(0, 0, 0, 0.2)"">
                    © 2022 Copyright:
                    <p>KURNAZ TURIZM</p>
                </div>
                <!-- Copyright -->
            </div>
            <!-- Footer -->
        </div>
    </footer>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471211efb1c6ffc5eca88d7b6f12468afaa81ec628074", async() => {
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
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\" crossorigin=\"anonymous\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471211efb1c6ffc5eca88d7b6f12468afaa81ec629396", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 272 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 273 "C:\Users\Metehan\Documents\GitHub\Metehan_Kurnaz\BusTicketReservation\BusTicketReservation.WebUI\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
