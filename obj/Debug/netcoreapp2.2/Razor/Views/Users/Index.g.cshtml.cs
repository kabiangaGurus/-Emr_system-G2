#pragma checksum "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc5f672efa5af90a42a23ef231e70bdc8509083f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "C:\Users\kili\source\repos\Group2\Group2\Views\_ViewImports.cshtml"
using Group2;

#line default
#line hidden
#line 2 "C:\Users\kili\source\repos\Group2\Group2\Views\_ViewImports.cshtml"
using Group2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5f672efa5af90a42a23ef231e70bdc8509083f", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96fd50d293d4063eaea51b234754faf4ddfbc9c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Group2.Models.Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 262, true);
            WriteLiteral(@"

<div class="""" style=""margin-top:24px"">
    <div class=""row"">



        <div class=""col-sm-4""></div>
        <div class=""col-sm-4 text-center""><h3>List Of Patients</h3></div>
        <div class=""col-sm-4 text-right"">
            <p>
                ");
            EndContext();
            BeginContext(346, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5f672efa5af90a42a23ef231e70bdc8509083f4639", async() => {
                BeginContext(401, 16, true);
                WriteLiteral("Register Patient");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(421, 125, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"card\" style=\"text-align:center;padding-top:24px\">\r\n\r\n  \r\n");
            EndContext();
#line 25 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
     using (Html.BeginForm("Index", "c_Post", FormMethod.Get))
    {


#line default
#line hidden
            BeginContext(619, 606, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-sm-3""></div>
            <div class=""input-group mb-3 col-sm-6"" style=""margin:8px"">
                <input type=""text"" style=""border-color:#00396e;border-top-left-radius:4px;border-bottom-left-radius:4px""
                       class=""form-control"" placeholder=""Search"" id=""searching"" name=""searching"">
                <input type=""submit"" value=""search"" style=""background-color:#00396e;border-top-right-radius:4px;
    border-bottom-right-radius:4px;color:white"" />
            </div>
            <div class=""col-sm-2""></div>
        </div>
");
            EndContext();
#line 38 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1234, 323, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-sm-1""></div>
        <div class=""col-sm-11"">
            <table class=""table table-responsive text-center overflow-auto"">
                <thead class=""card-header table-responsive-lg"">
                    <tr>
                        <th>
                            ");
            EndContext();
            BeginContext(1558, 45, false);
#line 48 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.fULL_NAME));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1695, 41, false);
#line 51 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.d_O_b));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 188, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            Gender\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1925, 44, false);
#line 57 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.uSERNAME));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 421, true);
            WriteLiteral(@"
                        </th>

                        <th>
                            Identity
                        </th>
                        <th>
                            Location
                        </th>
                        <th>
                            Phone
                        </th>
                        <th></th>
                    </tr>
                </thead>


");
            EndContext();
#line 74 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                 if (Model.Count() == 0)
                {


#line default
#line hidden
            BeginContext(2453, 129, true);
            WriteLiteral("                    <div class=\"well\" style=\"color:red\">\r\n                        No mach Found!!..\r\n                    </div>\r\n");
            EndContext();
#line 80 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(2644, 29, true);
            WriteLiteral("                    <tbody>\r\n");
            EndContext();
#line 85 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2754, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2851, 44, false);
#line 89 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.fULL_NAME));

#line default
#line hidden
            EndContext();
            BeginContext(2895, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2999, 40, false);
#line 92 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.d_O_b));

#line default
#line hidden
            EndContext();
            BeginContext(3039, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3143, 41, false);
#line 95 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GENDER));

#line default
#line hidden
            EndContext();
            BeginContext(3184, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3288, 43, false);
#line 98 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.uSERNAME));

#line default
#line hidden
            EndContext();
            BeginContext(3331, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3437, 43, false);
#line 102 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.uniqueId));

#line default
#line hidden
            EndContext();
            BeginContext(3480, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3584, 43, false);
#line 105 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LOCATION));

#line default
#line hidden
            EndContext();
            BeginContext(3627, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3731, 40, false);
#line 108 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PHONE));

#line default
#line hidden
            EndContext();
            BeginContext(3771, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 110 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                             if (User.IsInRole("DOCTOR"))
                            {

#line default
#line hidden
            BeginContext(3898, 76, true);
            WriteLiteral("                                <td>\r\n\r\n                                    ");
            EndContext();
            BeginContext(3974, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5f672efa5af90a42a23ef231e70bdc8509083f14227", async() => {
                BeginContext(4022, 4, true);
                WriteLiteral("View");
                EndContext();
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
#line 114 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4030, 39, true);
            WriteLiteral("\r\n                                </td>");
            EndContext();
#line 115 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                                     }
                            else
                            { }

#line default
#line hidden
            BeginContext(4139, 35, true);
            WriteLiteral("\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 121 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4201, 30, true);
            WriteLiteral("                    </tbody>\r\n");
            EndContext();
#line 123 "C:\Users\kili\source\repos\Group2\Group2\Views\Users\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4250, 56, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Group2.Models.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
