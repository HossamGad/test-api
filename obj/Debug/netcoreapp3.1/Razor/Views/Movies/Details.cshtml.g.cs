#pragma checksum "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfd0272d6b932ad92c95d45fe000034dc1937020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfd0272d6b932ad92c95d45fe000034dc1937020", @"/Views/Movies/Details.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SFF_Api_App.Models.Movie>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfd0272d6b932ad92c95d45fe000034dc19370202939", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Details</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfd0272d6b932ad92c95d45fe000034dc19370203992", async() => {
                WriteLiteral("\n\n<div>\n    <h4>Movie</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 27 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 30 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 33 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 36 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-action=\"Edit\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 891, "\"", 915, 1);
#nullable restore
#line 41 "D:\viktig new\båros3\SFF-master\SFF_Api_App\Views\Movies\Details.cshtml"
WriteAttributeValue("", 906, Model.Id, 906, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a> |\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SFF_Api_App.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
