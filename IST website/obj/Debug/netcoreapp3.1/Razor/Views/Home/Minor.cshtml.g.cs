#pragma checksum "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82370c946ee744546655e38c3741d836f5c7269d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Minor), @"mvc.1.0.view", @"/Views/Home/Minor.cshtml")]
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
#line 1 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82370c946ee744546655e38c3741d836f5c7269d", @"/Views/Home/Minor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Minor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.MinorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/sunny/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n<style>\r\n\tbody{\r\n\t\tbackground-color: bisque;\r\n\t}\r\n\th3{\r\n\t\tbackground-color:darkorange;\r\n\t}\r\n</style>\r\n");
            }
            );
            WriteLiteral("<h2 style=\"text-align: center\">");
#nullable restore
#line 13 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n<div id=\"myUnderDegrees\"></div>\r\n\r\n");
#nullable restore
#line 19 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
 foreach (var under in Model.Minors)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3");
            BeginWriteAttribute("id", " id=", 314, "", 354, 1);
#nullable restore
#line 21 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
WriteAttributeValue("", 318, String.Concat("myHdng", under.name), 318, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 21 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
                                              Write(under.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n");
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=", 391, "", 430, 1);
#nullable restore
#line 23 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
WriteAttributeValue("", 395, String.Concat("myDiv", under.name), 395, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p>");
#nullable restore
#line 24 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
      Write(under.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 25 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
      Write(under.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t<p>");
#nullable restore
#line 26 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
      Write(under.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <ul>\r\n");
#nullable restore
#line 28 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
             foreach (var conc in @under.courses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 30 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
               Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 35 "/Users/anandsurya/Documents/RIT/Fall 20/Client/Project3_Details_And_Views/Project3EnahncedCode/Project3_FinalExam/Views/Home/Minor.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82370c946ee744546655e38c3741d836f5c7269d8953", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82370c946ee744546655e38c3741d836f5c7269d10036", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82370c946ee744546655e38c3741d836f5c7269d11199", async() => {
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
                WriteLiteral(@"
	<script>
	// Create Accordion
		let headings = document.querySelectorAll(""h3"");
		let divs = document.querySelectorAll(""[id^='myDiv']"");

		for (var i = 0; i < headings.length; i++) {
			$(""#myUnderDegrees"").append($(""#"" + headings[i].id));
			$(""#myUnderDegrees"").append($(""#"" + divs[i].id));
		}

		$('#myUnderDegrees').accordion({
			collapsible: true,
			active: false,
			heightStyle: ""content""
		});
	</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.MinorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
