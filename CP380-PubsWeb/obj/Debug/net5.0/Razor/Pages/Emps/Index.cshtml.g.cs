#pragma checksum "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad0e69891dc877de50d2bd193a1d0cbdc7048b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CP380_PubsWeb.Pages.Emps.Pages_Emps_Index), @"mvc.1.0.razor-page", @"/Pages/Emps/Index.cshtml")]
namespace CP380_PubsWeb.Pages.Emps
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
#line 1 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\_ViewImports.cshtml"
using CP380_PubsWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad0e69891dc877de50d2bd193a1d0cbdc7048b7", @"/Pages/Emps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3383e08ee21d59c03356eeff79ac7a11f773f74", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Emps_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Jobs/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-11 text-center\">\r\n        <h2 class=\"text-success\">Employees List</h2>\r\n    </div>\r\n    <div class=\"col-1 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad0e69891dc877de50d2bd193a1d0cbdc7048b73762", async() => {
                WriteLiteral("\r\n            <span class=\"material-icons\">\r\n                undo\r\n            </span>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-12"">
        <table class=""table table-striped"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Employee ID</th>
                    <th scope=""col"">Employee Name</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                 if (Model.EmpList.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\" class=\"text-info text-center\">\r\n                            Oops... No employee found!\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                     foreach (var item in Model.EmpList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 38 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.emp_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 40 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                           Write(Html.DisplayFor(m => item.fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 40 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                                                                  Write(Html.DisplayFor(m => item.lname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\rahol\Desktop\Lab 14\CP380-PubsWeb\CP380-PubsWeb\Pages\Emps\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CP380_PubsWeb.Pages.Emps.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CP380_PubsWeb.Pages.Emps.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CP380_PubsWeb.Pages.Emps.IndexModel>)PageContext?.ViewData;
        public CP380_PubsWeb.Pages.Emps.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
