#pragma checksum "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\Home\Team.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2d62f700a0d0e24c1ee15e27ecbc58b8d93d1fd85f7d4806bdda262d36b5b3ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Team), @"mvc.1.0.view", @"/Views/Home/Team.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\_ViewImports.cshtml"
using RestaurantMVCPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\_ViewImports.cshtml"
using RestaurantMVCPortfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2d62f700a0d0e24c1ee15e27ecbc58b8d93d1fd85f7d4806bdda262d36b5b3ed", @"/Views/Home/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f9976cd38a63c9f474d1a59e75e19c8479379b1a8acc7b1cd3cd385ce7c1cd96", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- Team Start -->
<div class=""container-xxl pt-5 pb-3"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h5 class=""section-title ff-secondary text-center text-primary fw-normal"">Team Members</h5>
            <h1 class=""mb-5"">Our Master Chefs</h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 11 "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\Home\Team.cshtml"
             foreach(var chef in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                    <div class=""team-item text-center rounded overflow-hidden"">
                        <div class=""rounded-circle overflow-hidden m-4"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2d62f700a0d0e24c1ee15e27ecbc58b8d93d1fd85f7d4806bdda262d36b5b3ed4887", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 735, "~/img/", 735, 6, true);
#nullable restore
#line 16 "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\Home\Team.cshtml"
AddHtmlAttributeValue("", 741, chef.Image, 741, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <h5 class=\"mb-0\">");
#nullable restore
#line 18 "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\Home\Team.cshtml"
                                    Write(chef.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <small>");
#nullable restore
#line 19 "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\Home\Team.cshtml"
                          Write(chef.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <div class=\"d-flex justify-content-center mt-3\">\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1066, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1177, "\"", 1184, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1292, "\"", 1299, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\matin\Desktop\MyPortfolio\RestaurantMVCPortfolio\Views\Home\Team.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- Team End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
