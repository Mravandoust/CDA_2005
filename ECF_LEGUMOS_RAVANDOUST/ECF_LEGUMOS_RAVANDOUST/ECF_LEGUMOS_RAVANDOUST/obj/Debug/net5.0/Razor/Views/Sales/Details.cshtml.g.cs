#pragma checksum "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "136f33a89158b7a50d257d19e2c07835fa16c7b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Details), @"mvc.1.0.view", @"/Views/Sales/Details.cshtml")]
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
#line 1 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\_ViewImports.cshtml"
using ECF_LEGUMOS_RAVANDOUST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\_ViewImports.cshtml"
using ECF_LEGUMOS_RAVANDOUST.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"136f33a89158b7a50d257d19e2c07835fa16c7b1", @"/Views/Sales/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6775a35df512294704ab62704240948e2d885a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECF_LEGUMOS_RAVANDOUST.Models.Sale>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n    <h4>Sale</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 8 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 11 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayFor(model => model.SaleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleWeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayFor(model => model.SaleWeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleUnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayFor(model => model.SaleUnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayFor(model => model.SaleActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vegetable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vegetable.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "136f33a89158b7a50d257d19e2c07835fa16c7b17523", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "D:\GitHub\CDA_2005\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\ECF_LEGUMOS_RAVANDOUST\Views\Sales\Details.cshtml"
                           WriteLiteral(Model.SaleId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "136f33a89158b7a50d257d19e2c07835fa16c7b19704", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECF_LEGUMOS_RAVANDOUST.Models.Sale> Html { get; private set; }
    }
}
#pragma warning restore 1591
