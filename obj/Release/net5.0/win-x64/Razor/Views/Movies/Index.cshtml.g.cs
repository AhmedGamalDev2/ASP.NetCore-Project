#pragma checksum "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41038cfb7f0ef657e7976cc21ee4e5488087ee68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\_ViewImports.cshtml"
using DotNetCore5CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\_ViewImports.cshtml"
using DotNetCore5CRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\_ViewImports.cshtml"
using DotNetCore5CRUD.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41038cfb7f0ef657e7976cc21ee4e5488087ee68", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bd0328b50694cab0c0c54606a6343f38d2f84a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Movies";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\r\n    <i class=\"bi bi-film\"></i>\r\n    Movies\r\n</h2>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41038cfb7f0ef657e7976cc21ee4e5488087ee685510", async() => {
                WriteLiteral(" ");
                WriteLiteral("\r\n    <i class=\"bi bi-plus-lg\"></i>Add Movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n \r\n<div>\r\n");
#nullable restore
#line 16 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
     if (!Model.Any()  )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12\">\r\n        <div class=\"alert alert-warning mt-4\" role=\"alert\">\r\n            <i class=\"bi bi-exclamation-triangle\"></i>No Movies Found\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 23 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-60-px\">\r\n             \r\n");
#nullable restore
#line 28 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                 foreach (var movie in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12\">\r\n                        <div class=\"card mb-3\" >\r\n                            <div class=\"row no-gutters\">\r\n");
            WriteLiteral("                                <div class=\"col-md-2 poster\"");
            BeginWriteAttribute("style", "  style=\"", 884, "\"", 977, 3);
            WriteAttributeValue("", 893, "background-image:url(data:image\\/*;base64,", 893, 42, true);
#nullable restore
#line 34 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
WriteAttributeValue("", 935,  Convert.ToBase64String(movie.Poster) , 935, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 976, ")", 976, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    
                                </div>

                                <div class=""col-md-10"">
                                    <div class=""card-body d-flex flex-column justify-content-between h-100 "">
                                        <div>
                                            <h5 class=""card-title"">");
#nullable restore
#line 41 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                                                              Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 41 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                                                                            Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                                            <p class=\"card-text text-justify\"> ");
#nullable restore
#line 42 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                                                                           Write( movie.StoreLine.Length>500? $"{movie.StoreLine.Substring(0,500)}...": movie.StoreLine );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        
                                        <div class=""d-flex justify-content-between"">
                                            <p class=""card-text mb-0 mt-3"" >
                                                <i class=""bi bi-star-fill text-warning""></i>");
            WriteLiteral("\r\n                                                <small class=\"text-muted\">");
#nullable restore
#line 48 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                                                                     Write(movie.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                            </p>\r\n                                            <div>");
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41038cfb7f0ef657e7976cc21ee4e5488087ee6810843", async() => {
                WriteLiteral("\r\n                                                    <i class=\"bi bi-camera-reels\"></i>\r\n                                                    Details\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                                                                           WriteLiteral(movie.MovieID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41038cfb7f0ef657e7976cc21ee4e5488087ee6813349", async() => {
                WriteLiteral("\r\n                                                    <i class=\"bi bi-pencil\"></i>\r\n                                                    Edit\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                                                                     WriteLiteral(movie.MovieID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                                             <a  href=\"javascrip:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 60 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                                                                                                         Write(movie.MovieID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                    <i class=""bi bi-trash""></i>
                                                    Delete
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 72 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 74 "E:\.net Ahmed\Projects\DotNetCore5CRUD\Views\Movies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);
                // console.log(btn.data('id'));
                var Result = confirm('are you sure that you need delete this movie');
                if (Result) {
                    $.ajax({
                        url: 'Movies/delete/' + btn.data('id'),
                        success: function () {
                            btn.parents('.col-12').fadeOut();
                            toastr.success('Movie deleted');
                        },
                        error: function(){
                        toastr.error('Something went wrong!');  }
                    });
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
