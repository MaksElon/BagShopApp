#pragma checksum "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b9f175d4d2c336fb889b4d3cafbc26601c9739"
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
#line 1 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\_ViewImports.cshtml"
using MyOwnApp;

#line default
#line hidden
#line 2 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\_ViewImports.cshtml"
using MyOwnApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b9f175d4d2c336fb889b4d3cafbc26601c9739", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89f785f8d9fdcf99730d89829f8a55d9b8ff0f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyOwnApp.ComponentModels.SideBarModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("priceRangePrint"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdownForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 252, true);
            WriteLiteral("<div class=\"sideB\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col\">\r\n                <h5 class=\"pl-2\">Material</h5>\r\n                <div class=\"container p-0\">\r\n                    <div class=\"control-group\">\r\n");
            EndContext();
#line 10 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                          
                            foreach (var item in Model.Materials)
                            {
                                var link1 = Url.RouteUrl("twoids", new { controller = "Bag", Action = "Catalog", id = item.Id, name = "Material" });

#line default
#line hidden
            BeginContext(574, 48, true);
            WriteLiteral("                                <a class=\"CardA\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 622, "\"", 635, 1);
#line 14 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 629, link1, 629, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(636, 122, true);
            WriteLiteral(">\r\n                                    <label class=\"control control--checkbox\">\r\n                                        ");
            EndContext();
            BeginContext(759, 9, false);
#line 16 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(768, 233, true);
            WriteLiteral("\r\n                                        <input type=\"checkbox\" />\r\n                                        <div class=\"control__indicator\"></div>\r\n                                    </label>\r\n                                </a>\r\n");
            EndContext();
#line 21 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1059, 243, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col\">\r\n                <h5 class=\"pl-2\">Type</h5>\r\n                <div class=\"container p-0\">\r\n                    <div class=\"control-group\">\r\n");
            EndContext();
#line 31 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                          
                            foreach (var item in Model.TypeOfProducts)
                            {
                                var link1 = Url.RouteUrl("twoids", new { controller = "Bag", Action = "Catalog", id = item.Id, name = "Type" });

#line default
#line hidden
            BeginContext(1579, 48, true);
            WriteLiteral("                                <a class=\"CardA\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1627, "\"", 1640, 1);
#line 35 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 1634, link1, 1634, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1641, 124, true);
            WriteLiteral(">\r\n\r\n                                    <label class=\"control control--checkbox\">\r\n                                        ");
            EndContext();
            BeginContext(1766, 9, false);
#line 38 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1775, 235, true);
            WriteLiteral("\r\n                                        <input type=\"checkbox\" />\r\n                                        <div class=\"control__indicator\"></div>\r\n                                    </label>\r\n\r\n                                </a>\r\n");
            EndContext();
#line 44 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"

                            }
                        

#line default
#line hidden
            BeginContext(2070, 244, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h5 class=\"pl-2\">Model</h5>\r\n                <div class=\"container p-0\">\r\n                    <div class=\"control-group\">\r\n");
            EndContext();
#line 55 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                          
                            foreach (var item in Model.ProductModels)
                            {
                                var link1 = Url.RouteUrl("twoids", new { controller = "Bag", Action = "Catalog", id = item.Id, name = "Model" });

#line default
#line hidden
            BeginContext(2591, 48, true);
            WriteLiteral("                                <a class=\"CardA\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2639, "\"", 2652, 1);
#line 59 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2646, link1, 2646, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2653, 124, true);
            WriteLiteral(">\r\n\r\n                                    <label class=\"control control--checkbox\">\r\n                                        ");
            EndContext();
            BeginContext(2778, 9, false);
#line 62 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2787, 233, true);
            WriteLiteral("\r\n                                        <input type=\"checkbox\" />\r\n                                        <div class=\"control__indicator\"></div>\r\n                                    </label>\r\n                                </a>\r\n");
            EndContext();
#line 67 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(3078, 134, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"range-slider\">\r\n");
            EndContext();
#line 76 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
          
            var addition = (@Model.MaxPrice + @Model.MinPrice) / 2;
            var Fval = @Model.MinPrice + (addition - @Model.MinPrice) / 2;
            var Sval = addition;

            

#line default
#line hidden
            BeginContext(3417, 683, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcafde79e4eb47e788285ec904180618", async() => {
                BeginContext(3465, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3483, 126, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78b69d440ac54c86b43dfa6bbf5450f6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 82 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstPrice);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 82 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                                                                             WriteLiteral(Fval);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "min", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 82 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
AddHtmlAttributeValue("", 3568, Model.MinPrice, 3568, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "max", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 82 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
AddHtmlAttributeValue("", 3590, Model.MaxPrice, 3590, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3609, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3627, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "878eb20db1544666b3d5148797c4c91d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 83 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SecondPrice);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 83 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                                                                              WriteLiteral(Sval);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "min", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 83 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
AddHtmlAttributeValue("", 3713, Model.MinPrice, 3713, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "max", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 83 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
AddHtmlAttributeValue("", 3735, Model.MaxPrice, 3735, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3754, 24, true);
                WriteLiteral("\r\n                <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3778, "\"", 3791, 1);
#line 84 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3786, Fval, 3786, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("min", " min=\"", 3792, "\"", 3813, 1);
#line 84 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3798, Model.MinPrice, 3798, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("max", " max=\"", 3814, "\"", 3835, 1);
#line 84 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3820, Model.MaxPrice, 3820, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3836, 51, true);
                WriteLiteral(" step=\"100\" type=\"range\" />\r\n                <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3887, "\"", 3900, 1);
#line 85 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3895, Sval, 3895, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("min", " min=\"", 3901, "\"", 3922, 1);
#line 85 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3907, Model.MinPrice, 3907, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("max", " max=\"", 3923, "\"", 3944, 1);
#line 85 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3929, Model.MaxPrice, 3929, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3945, 148, true);
                WriteLiteral(" step=\"100\" type=\"range\" />\r\n                <p class=\"mt-5\"><button class=\"btn btn-info btn-block \" type=\"submit\">Choose</button></p>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4113, 16, true);
            WriteLiteral("    </div>\r\n    ");
            EndContext();
            BeginContext(4129, 562, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d603db4a001d4f4fbe47c540d4537a12", async() => {
                BeginContext(4156, 123, true);
                WriteLiteral("\r\n        <input class=\"chosen-value\" type=\"text\" value=\"\" placeholder=\"Type to filter\">\r\n        <ul class=\"value-list\">\r\n");
                EndContext();
#line 93 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
              
                foreach (var item in Model.Producers)
                {
                    var link1 = Url.RouteUrl("twoids", new { controller = "Bag", Action = "Catalog", id = item.Id, name = "Producer" });

#line default
#line hidden
                BeginContext(4507, 36, true);
                WriteLiteral("                    <a class=\"CardA\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4543, "\"", 4556, 1);
#line 97 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 4550, link1, 4550, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4557, 31, true);
                WriteLiteral(">\r\n                        <li>");
                EndContext();
                BeginContext(4589, 9, false);
#line 98 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                       Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4598, 33, true);
                WriteLiteral("</li>\r\n                    </a>\r\n");
                EndContext();
#line 100 "C:\Users\marty\OneDrive\Desktop\ШАГ\asp.net\MyOwn\MyOwnApp\MyOwnApp\Views\Shared\Components\Category\Default.cshtml"
                }
            

#line default
#line hidden
                BeginContext(4665, 19, true);
                WriteLiteral("        </ul>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4691, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyOwnApp.ComponentModels.SideBarModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
