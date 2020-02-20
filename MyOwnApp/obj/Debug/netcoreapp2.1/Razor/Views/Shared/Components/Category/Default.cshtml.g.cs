#pragma checksum "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff48bef725435131906b66eb3a56711ccf89cae5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Category/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Category_Default))]
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
#line 1 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\_ViewImports.cshtml"
using MyOwnApp;

#line default
#line hidden
#line 2 "C:\Users\marty\OneDrive\Desktop\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\_ViewImports.cshtml"
using MyOwnApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff48bef725435131906b66eb3a56711ccf89cae5", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89f785f8d9fdcf99730d89829f8a55d9b8ff0f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdownForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 3645, true);
            WriteLiteral(@"<div class=""sideB"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col"">
                <h5 class=""pl-2"">Material</h5>
                <div class=""container p-0"">
                    <div class=""control-group"">
                        <label class=""control control--checkbox"">
                            Genuine leather
                            <input type=""checkbox"" checked=""checked"" />
                            <div class=""control__indicator""></div>
                        </label>
                        <label class=""control control--checkbox"">
                            Artificial leather
                            <input type=""checkbox"" />
                            <div class=""control__indicator""></div>
                        </label>
                        <label class=""control control--checkbox"">
                            Suede
                            <input type=""checkbox"" />
                            <div class=""control__indicat");
            WriteLiteral(@"or""></div>
                        </label>
                    </div>
                </div>
            </div>

            <div class=""col"">
                <h5 class=""pl-2"">Type</h5>
                <div class=""container p-0"">
                    <div class=""control-group"">

                        <label class=""control control--checkbox"">
                            Men
                            <input type=""checkbox"" checked=""checked"" />
                            <div class=""control__indicator""></div>
                        </label>
                        <label class=""control control--checkbox"">
                            Women
                            <input type=""checkbox"" />
                            <div class=""control__indicator""></div>
                        </label>
                        <label class=""control control--checkbox"">
                            Kids
                            <input type=""checkbox"" />
                            <div class=""con");
            WriteLiteral(@"trol__indicator""></div>
                        </label>
                    </div>
                </div>
            </div>
            <div class=""col"">
                <h5 class=""pl-2"">Model</h5>
                <div class=""container p-0"">
                    <div class=""control-group"">

                        <label class=""control control--checkbox"">
                            Classic bag
                            <input type=""checkbox"" checked=""checked"" />
                            <div class=""control__indicator""></div>
                        </label>
                        <label class=""control control--checkbox"">
                            Purse
                            <input type=""checkbox"" />
                            <div class=""control__indicator""></div>
                        </label>
                        <label class=""control control--checkbox"">
                            Tablet bag
                            <input type=""checkbox"" />
                 ");
            WriteLiteral(@"           <div class=""control__indicator""></div>
                        </label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""range-slider"">
        <input class=""priceRangePrint"" type=""number"" value=""25000"" min=""0"" max=""120000"" />
        <input class=""priceRangePrint"" type=""number"" value=""50000"" min=""0"" max=""120000"" />
        <input value=""25000"" min=""0"" max=""120000"" step=""500"" type=""range"" />
        <input value=""50000"" min=""0"" max=""120000"" step=""500"" type=""range"" />
    </div>
    ");
            EndContext();
            BeginContext(3645, 627, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "553936b6b5494545aec7ea27609730c4", async() => {
                BeginContext(3672, 593, true);
                WriteLiteral(@"
        <input class=""chosen-value"" type=""text"" value="""" placeholder=""Type to filter"">
        <ul class=""value-list"">
            <li>Nike</li>
            <li>Alaska</li>
            <li>Arizona</li>
            <li>Arkansas</li>
            <li>California</li>
            <li>Colorado</li>
            <li>Connecticut</li>
            <li>Delaware</li>
            <li>Florida</li>
            <li>Georgia</li>
            <li>Hawaii</li>
            <li>Idaho</li>
            <li>Illinois</li>
            <li>Indiana</li>
            <li>Iowa</li>
        </ul>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4272, 12, true);
            WriteLiteral("\r\n\r\n\r\n</div>");
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
