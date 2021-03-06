#pragma checksum "/Users/Guest/Desktop/Recipes/Views/Categories/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e554e98e3601ee2f5de124a028b7b4a0c80ca86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e554e98e3601ee2f5de124a028b7b4a0c80ca86", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ac766e05ac3f3ac52c771947f696b36ef9f93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 82, true);
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Food Categories</h1>\n    <ul>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/Recipes/Views/Categories/Index.cshtml"
       if (@Model.Count == 0)
      {

#line default
#line hidden
            BeginContext(120, 52, true);
            WriteLiteral("        <h2>Currently there are no categories.</h2>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Recipes/Views/Categories/Index.cshtml"
      }

#line default
#line hidden
            BeginContext(180, 6, true);
            WriteLiteral("      ");
            EndContext();
#line 8 "/Users/Guest/Desktop/Recipes/Views/Categories/Index.cshtml"
       foreach (Category category in Model)
      {

#line default
#line hidden
            BeginContext(232, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 246, "\"", 276, 2);
            WriteAttributeValue("", 253, "categories/", 253, 11, true);
#line 10 "/Users/Guest/Desktop/Recipes/Views/Categories/Index.cshtml"
WriteAttributeValue("", 264, category.id, 264, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(277, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(279, 13, false);
#line 10 "/Users/Guest/Desktop/Recipes/Views/Categories/Index.cshtml"
                                         Write(category.name);

#line default
#line hidden
            EndContext();
            BeginContext(292, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Recipes/Views/Categories/Index.cshtml"
      }

#line default
#line hidden
            BeginContext(310, 92, true);
            WriteLiteral("    </ul>\n    <a class=\"btn btn-dark\" href=\"categories/new\">Add a food category!</a>\n</div>\n");
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
