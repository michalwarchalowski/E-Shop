#pragma checksum "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "911dfdf09ff94f329d8620f12ebc61a36bc21830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\_ViewImports.cshtml"
using CandyShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\_ViewImports.cshtml"
using CandyShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911dfdf09ff94f329d8620f12ebc61a36bc21830", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00f6f8ae5e381927d571e25738eb92739d30b050", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Shopping Cart: all your candy you love </h2>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Selected AMount</th>
            <th>Candy</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml"
         foreach(var item in Model.ShoppingCart.ShoppingCartItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
#nullable restore
#line 17 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml"
                               Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
#nullable restore
#line 18 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml"
                             Write(item.Candy.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 19 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml"
                              Write(item.Candy.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 21 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml"
            Write((item.Amount*item.Candy.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <td colspan=\"3\" class=\"text-right\">Total</td>\r\n        <td class=\"text-right\">");
#nullable restore
#line 28 "D:\c#\ASP NET CORE\E-Shop\E-Shop\CandyShop\CandyShop\Views\ShoppingCart\Index.cshtml"
                          Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
