#pragma checksum "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4613ce002bb877aa5ab8e68703d976c653726991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_Index), @"mvc.1.0.view", @"/Views/Properties/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4613ce002bb877aa5ab8e68703d976c653726991", @"/Views/Properties/Index.cshtml")]
    public class Views_Properties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BoBra.Models.Property>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BuildYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HouseType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlotArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BiArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ViewingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BuildYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HouseType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlotArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BiArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ViewingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1967, "\"", 1998, 1);
#nullable restore
#line 70 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
WriteAttributeValue("", 1982, item.PropertyID, 1982, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2051, "\"", 2082, 1);
#nullable restore
#line 71 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
WriteAttributeValue("", 2066, item.PropertyID, 2066, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2137, "\"", 2168, 1);
#nullable restore
#line 72 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
WriteAttributeValue("", 2152, item.PropertyID, 2152, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BoBra.Models.Property>> Html { get; private set; }
    }
}
#pragma warning restore 1591
