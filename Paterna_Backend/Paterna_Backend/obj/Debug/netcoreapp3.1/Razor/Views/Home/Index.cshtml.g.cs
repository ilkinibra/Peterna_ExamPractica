#pragma checksum "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f441ac7e2bf25543f377324bce800592743a5d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\_ViewImports.cshtml"
using Paterna_Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\_ViewImports.cshtml"
using Paterna_Backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f441ac7e2bf25543f377324bce800592743a5d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bf29caa0175b56999fe984a8181b79ab7767c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main>\r\n    <section id=\"page-intro\">\r\n        <div class=\"intro-text\">\r\n            <h1 class=\"page-h1\">");
#nullable restore
#line 10 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                           Write(Model.PageIntro.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"page-p1\">");
#nullable restore
#line 11 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                          Write(Model.PageIntro.subTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"page-p2\">");
#nullable restore
#line 12 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                          Write(Model.PageIntro.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <button class=""page-btn"">DOWNLOAD THIS THEME NOW!</button>
        </div>
    </section>

    <section id=""our-services"">
        <div class=""container"">
            <div class=""row"">
                <div class=""services col-6"">
                    <h2>OUR SERVICES:</h2>
                    <p class=""services-title"">");
#nullable restore
#line 22 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                         Write(Model.Services.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"services-description\">");
#nullable restore
#line 23 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                               Write(Model.Services.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"services2 col-6\">\r\n                    <p class=\"services-title\">");
#nullable restore
#line 26 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                         Write(Model.Services.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"services-description\">");
#nullable restore
#line 27 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                               Write(Model.Services.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                </div>\r\n                <div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
#nullable restore
#line 31 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                     foreach (var item in Model.servicesCard)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <div class=\"col\">\r\n                        <div class=\"card h-100\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                       Write(Html.Raw(item.IconPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 37 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 38 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"services-footer col-12\">\r\n                    <p class=\"servicesfooter-title\">");
#nullable restore
#line 45 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                               Write(Model.Services.subTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"servicesfooter-description\">");
#nullable restore
#line 46 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                     Write(Model.Services.subDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
    </section>

    <section id=""wallstreet"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-8"">
                    <h1 class=""wallstreet-title"">Featured In Wall Street</h1>
                    <p class=""wallstreet-description"">and many other magazines.</p>
                </div>
                <div class=""col-4"">
                    <p class=""count"">300+</p>
                    <p class=""count-title"">Reports</p>
                </div>
            </div>
        </div>
    </section>

    <section id=""our-plans"">
        <div class=""container"">
            <div class=""row"">
                <div class=""plan col-6"">
                    <h2>OUR PLANS:</h2>
                    <p class=""plan-title"">");
#nullable restore
#line 72 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                     Write(Model.Plan.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"plan-description\">");
#nullable restore
#line 73 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                           Write(Model.Plan.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"plan2 col-6\">\r\n                    <p class=\"plan-title\">");
#nullable restore
#line 76 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                     Write(Model.Plan.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"plan-description\">");
#nullable restore
#line 77 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                           Write(Model.Plan.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"our-plan-cards\">\r\n                    <div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
#nullable restore
#line 81 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                         foreach (var item in Model.planCards)
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col \">\r\n                            <div class=\"card card-list text-center card-content\">\r\n                                <ul>\r\n                                    <li class=\"card-title\">");
#nullable restore
#line 87 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li class=\"list-item pt-4\">\r\n                                        <b>");
#nullable restore
#line 89 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                      Write(item.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> Accounts\r\n                                    </li>\r\n                                    <li class=\"list-item\"><b>");
#nullable restore
#line 91 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                        Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>Emails</li>\r\n\r\n                                    <li class=\"list-item\"><b>");
#nullable restore
#line 93 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                        Write(item.Space);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> Space</li>\r\n                                    <li class=\"list-item\"><b>");
#nullable restore
#line 94 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                        Write(item.Support);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> Support</li>\r\n                                    <li class=\"Price\"><b>$");
#nullable restore
#line 95 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" only</b> </li>
                                    <li class=""button py-5""><a href=""#"" class=""btn btn-danger py-3"" style=""width: 100%;"">Read more</a> </li>
                                </ul>
                            </div>
                        </div>
");
#nullable restore
#line 100 "C:\Users\HP\Desktop\AspNet\Paterna_Backend\Paterna_Backend\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""countstreet"">
        <div class=""container"">
            <div class=""row"">
                <div class=""street-title"" style=""margin-bottom:2rem ;"">
                    <div class=""col-3"">
                        <h1 class=""countstreet-count"">5000+</h1>
                        <p class=""countstreet-description"">Projects</p>
                    </div>
                    <div class=""col-3"">
                        <p class=""countstreet-count"">205+</p>
                        <p class=""countstreet-description"">Countries</p>
                    </div>
                    <div class=""col-3"">
                        <h1 class=""countstreet-count"">1300+</h1>
                        <p class=""countstreet-description"">Officies</p>
                    </div>
                    <div class=""col-3"">
                        <p class=""countstreet-count"">2400+</p>
                      ");
            WriteLiteral("  <p class=\"countstreet-description\">Clients</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section id=\"contact-form\">\r\n        <h2 style=\"color: #00798A; \">Contact Us:</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f441ac7e2bf25543f377324bce800592743a5d716628", async() => {
                WriteLiteral(@"
            <label><span>Name</span><input name=""name"" type=""text"" placeholder=""Name"" /></label>
            <label><span>Email</span><input name=""email"" type=""email"" placeholder=""Email"" /></label>
            <label><span>Message</span><textarea name=""message"" placeholder=""Message""></textarea></label>
            <input name=""submit"" type=""submit"" value=""Send"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <aside>
            <p>Just hit Send on an empty form to see the invalid input animation</p>
            <p>Fill in the form fields to see the success animation (no real validation, any random input will do)</p>
        </aside>
    </section>

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591