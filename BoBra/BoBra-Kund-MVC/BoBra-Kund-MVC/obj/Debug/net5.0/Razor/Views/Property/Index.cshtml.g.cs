#pragma checksum "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e39ca189dbb18c91f25fe8a114ab7c44b79aeb4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Property_Index), @"mvc.1.0.view", @"/Views/Property/Index.cshtml")]
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
#line 1 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\_ViewImports.cshtml"
using BoBra_Kund_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\_ViewImports.cshtml"
using BoBra_Kund_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39ca189dbb18c91f25fe8a114ab7c44b79aeb4e", @"/Views/Property/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a1cc41b72cae7e170bc00de31c77f87b126152", @"/Views/_ViewImports.cshtml")]
    public class Views_Property_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BoBra_Kund_MVC.Models.PropertyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BuildYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HouseType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlotArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BiArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ViewingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PropertyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BuildYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HouseType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlotArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BiArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ViewingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 74 "D:\Code\BoBra-Kund-MVC\BoBra-Kund-MVC\Views\Property\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BoBra_Kund_MVC.Models.PropertyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591