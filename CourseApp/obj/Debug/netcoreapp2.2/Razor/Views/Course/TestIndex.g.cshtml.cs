#pragma checksum "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb60aa304825d6e52e18576487af0d89c4da099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_TestIndex), @"mvc.1.0.view", @"/Views/Course/TestIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/TestIndex.cshtml", typeof(AspNetCore.Views_Course_TestIndex))]
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
#line 1 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\_ViewImports.cshtml"
using CourseApp.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\_ViewImports.cshtml"
using CourseApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb60aa304825d6e52e18576487af0d89c4da099", @"/Views/Course/TestIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5763f0ae78d1e6741873829e78e04c1ffe51ba9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_TestIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseStudentsViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
  
   Layout=null;

#line default
#line hidden
#line 5 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
  
    var classname = Model.Students.Count>2 ? "popular" : null;

#line default
#line hidden
            BeginContext(127, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(162, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeb60aa304825d6e52e18576487af0d89c4da0993723", async() => {
                BeginContext(168, 311, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Document</title>
    <style>
        .popular{
            color: green;
            font-weight: 700;
        }

    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(486, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(488, 394, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeb60aa304825d6e52e18576487af0d89c4da0995224", async() => {
                BeginContext(494, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(501, 23, false);
#line 24 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
Write(Html.Partial("_header"));

#line default
#line hidden
                EndContext();
                BeginContext(524, 9, true);
                WriteLiteral("\r\n    <h2");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 533, "\"", 551, 1);
#line 25 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
WriteAttributeValue("", 541, classname, 541, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(552, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(554, 17, false);
#line 25 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
                      Write(Model.Course.Name);

#line default
#line hidden
                EndContext();
                BeginContext(571, 27, true);
                WriteLiteral("</h2>\r\n    <hr>\r\n    <ul>\r\n");
                EndContext();
#line 28 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
     if (Model.Students.Count!=0)
    {
        

#line default
#line hidden
#line 30 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
         foreach (var item in Model.Students)
        {

#line default
#line hidden
                BeginContext(698, 34, true);
                WriteLiteral("            <li>\r\n                ");
                EndContext();
                BeginContext(733, 9, false);
#line 33 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
           Write(item.name);

#line default
#line hidden
                EndContext();
                BeginContext(742, 21, true);
                WriteLiteral("\r\n            </li>\r\n");
                EndContext();
#line 35 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
            
        }

#line default
#line hidden
#line 36 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
         
    }else
    {

#line default
#line hidden
                BeginContext(806, 36, true);
                WriteLiteral("       <li>Kayıtlı öğreci yok</li>\r\n");
                EndContext();
#line 40 "C:\Users\Mert Bilgiç\Desktop\dotnet\CourseApp\Views\Course\TestIndex.cshtml"
    }

#line default
#line hidden
                BeginContext(849, 26, true);
                WriteLiteral("    </ul>\r\n   \r\n\r\n\r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(882, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseStudentsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
