#pragma checksum "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68770dbf5939194913ae147f456f843aba63defd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_Details), @"mvc.1.0.view", @"/Views/Properties/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68770dbf5939194913ae147f456f843aba63defd", @"/Views/Properties/Details.cshtml")]
    public class Views_Properties_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BoBra.Models.Property>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Property</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HouseType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.HouseType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlotArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlotArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BiArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.BiArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ViewingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.ViewingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1899, "\"", 1931, 1);
#nullable restore
#line 64 "C:\Users\Joe\source\repos\BoBraProject\BoBra\BoBra\Views\Properties\Details.cshtml"
WriteAttributeValue("", 1914, Model.PropertyID, 1914, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
