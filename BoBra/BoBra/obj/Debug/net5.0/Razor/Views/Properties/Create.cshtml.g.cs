#pragma checksum "C:\Users\filip\Documents\GitHub\BoBraProject\BoBra\BoBra\Views\Properties\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c79bf4b3139a4f84464c59f396c49b6521826e52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_Create), @"mvc.1.0.view", @"/Views/Properties/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79bf4b3139a4f84464c59f396c49b6521826e52", @"/Views/Properties/Create.cshtml")]
    public class Views_Properties_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BoBra.Models.Property>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\filip\Documents\GitHub\BoBraProject\BoBra\BoBra\Views\Properties\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Property</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Adress"" class=""control-label""></label>
                <input asp-for=""Adress"" class=""form-control"" />
                <span asp-validation-for=""Adress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LivingArea"" class=""control-label""></label>
                <input asp-for=""LivingArea"" class=""form-control"" />
                <span asp-validation-for=""LivingArea"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Rooms"" class=""control-label""></label>
                <input asp-for=""Rooms"" class=""form-control"" />
                <span asp-validation-for=""Rooms"" class=""text-danger""></span>
  ");
            WriteLiteral(@"          </div>
            <div class=""form-group"">
                <label asp-for=""BuildYear"" class=""control-label""></label>
                <input asp-for=""BuildYear"" class=""form-control"" />
                <span asp-validation-for=""BuildYear"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""HouseType"" class=""control-label""></label>
                <input asp-for=""HouseType"" class=""form-control"" />
                <span asp-validation-for=""HouseType"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PlotArea"" class=""control-label""></label>
                <input asp-for=""PlotArea"" class=""form-control"" />
                <span asp-validation-for=""PlotArea"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BiArea"" class=""control-label""></label>
                <input asp-for=""BiArea"" class=""for");
            WriteLiteral(@"m-control"" />
                <span asp-validation-for=""BiArea"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ViewingDate"" class=""control-label""></label>
                <input asp-for=""ViewingDate"" class=""form-control"" />
                <span asp-validation-for=""ViewingDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\filip\Documents\GitHub\BoBraProject\BoBra\BoBra\Views\Properties\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BoBra.Models.Property> Html { get; private set; }
    }
}
#pragma warning restore 1591