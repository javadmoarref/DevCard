#pragma checksum "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29eecc82fc50d19a12291e09a95b5effc5da6fc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Projects__Projects), @"mvc.1.0.view", @"/Views/Home/Components/Projects/_Projects.cshtml")]
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
#line 1 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\_ViewImports.cshtml"
using DevCard_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\_ViewImports.cshtml"
using DevCard_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29eecc82fc50d19a12291e09a95b5effc5da6fc5", @"/Views/Home/Components/Projects/_Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ea277473dae7db72ca738c33dca534c6f6f02d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Projects__Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevCard_Project.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"                      <section class=""featured-section p-3 p-lg-5"">
                          <div class=""container"">
                              <h2 class=""section-title font-weight-bold mb-5"">خاص ترین پروژه ها</h2>
                              <div class=""row"">
");
#nullable restore
#line 6 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
                                   foreach (var project in Model)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                      <div class=""col-md-6 mb-5"">
                                          <div class=""card project-card"">
                                              <div class=""row no-gutters"">
                                                  <div class=""col-lg-4 card-img-holder"">
                                                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "29eecc82fc50d19a12291e09a95b5effc5da6fc54581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 799, "~/assets/images/project/", 799, 24, true);
#nullable restore
#line 12 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
AddHtmlAttributeValue("", 823, project.Image, 823, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
AddHtmlAttributeValue("", 861, project.Name, 861, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                  </div>
                                                  <div class=""col-lg-8"">
                                                      <div class=""card-body"">
                                                          <h5 class=""card-title"">
                                                              <a href=""project.html"" class=""theme-link"">
                                                                 ");
#nullable restore
#line 18 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
                                                            Write(project.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 18 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
                                                                          Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                              </a>
                                                          </h5>
                                                          <p class=""card-text"">
                                                             ");
#nullable restore
#line 22 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
                                                        Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                          </p>\r\n                                                          <p class=\"card-text\">\r\n                                                              <small class=\"text-muted\">مشتری: ");
#nullable restore
#line 25 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
                                                                                          Write(project.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                                          </p>
                                                      </div>
                                                  </div>
                                              </div>
                                          </div>
                                      </div>
");
#nullable restore
#line 32 "C:\Users\JAVAD\Desktop\VS\ASP.Net\DevCard\DevCard_Project\Views\Home\Components\Projects\_Projects.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                              </div>\r\n                          </div>\r\n                      </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevCard_Project.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
