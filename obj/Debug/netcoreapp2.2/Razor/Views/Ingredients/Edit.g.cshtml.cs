#pragma checksum "/Users/Guest/Desktop/Recipes/Views/Ingredients/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363836e48ca833170210f3fb7dc6c94defc5af3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_Edit), @"mvc.1.0.view", @"/Views/Ingredients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ingredients/Edit.cshtml", typeof(AspNetCore.Views_Ingredients_Edit))]
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
#line 1 "/Users/Guest/Desktop/Recipes/Views/_ViewImports.cshtml"
using Recipes;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/Recipes/Views/_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363836e48ca833170210f3fb7dc6c94defc5af3f", @"/Views/Ingredients/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ac766e05ac3f3ac52c771947f696b36ef9f93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 57, true);
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Edit ");
            EndContext();
            BeginContext(58, 10, false);
#line 2 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Edit.cshtml"
                          Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(68, 10, true);
            WriteLiteral("</h1>\n    ");
            EndContext();
            BeginContext(78, 480, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363836e48ca833170210f3fb7dc6c94defc5af3f3890", async() => {
                BeginContext(131, 110, true);
                WriteLiteral("\n      <label for=\"ingredientName\">Ingredient Name:</label><br>\n      <input type=\"text\" name=\"ingredientName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 241, "\"", 260, 1);
#line 5 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Edit.cshtml"
WriteAttributeValue("", 249, Model.name, 249, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(261, 181, true);
                WriteLiteral("><br>\n      <label for=\"ingredientDescription\">Ingredient Description:</label><br>\n      <textarea rows=\"5\" cols=\"80\" type=\"text\" name=\"ingredientDescription\" autofocus=\"autofocus\">");
                EndContext();
                BeginContext(443, 17, false);
#line 7 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Edit.cshtml"
                                                                                             Write(Model.description);

#line default
#line hidden
                EndContext();
                BeginContext(460, 91, true);
                WriteLiteral("</textarea><br>\n      <button type=\"submit\" class=\"btn btn-dark\">Save Changes</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 92, "/ingredients/", 92, 13, true);
#line 3 "/Users/Guest/Desktop/Recipes/Views/Ingredients/Edit.cshtml"
AddHtmlAttributeValue("", 105, Model.id, 105, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(558, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
