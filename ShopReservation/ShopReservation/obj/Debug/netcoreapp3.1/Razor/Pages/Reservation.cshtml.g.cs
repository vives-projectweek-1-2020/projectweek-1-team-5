#pragma checksum "D:\School\Minor\ShopReservation\ShopReservation\Pages\Reservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6cb50657c21d9e1295b20cd8d0aee1013ced39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShopReservation.Pages.Pages_Reservation), @"mvc.1.0.razor-page", @"/Pages/Reservation.cshtml")]
namespace ShopReservation.Pages
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
#line 1 "D:\School\Minor\ShopReservation\ShopReservation\Pages\_ViewImports.cshtml"
using ShopReservation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6cb50657c21d9e1295b20cd8d0aee1013ced39", @"/Pages/Reservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0aa81335193e241fff1fadde7de1cae640d2c5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reservation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\School\Minor\ShopReservation\ShopReservation\Pages\Reservation.cshtml"
  
    ViewData["Title"] = "Reservation";
    List<string> testList = new List<string> {"test", "string", "List", "for", "reservation" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Reservation</h1>\r\n   \r\n");
#nullable restore
#line 10 "D:\School\Minor\ShopReservation\ShopReservation\Pages\Reservation.cshtml"
   
    foreach (string i in testList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <lu>\r\n            <h2>Reserve a spot at shop: ");
#nullable restore
#line 14 "D:\School\Minor\ShopReservation\ShopReservation\Pages\Reservation.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2> \r\n        </lu>\r\n");
#nullable restore
#line 16 "D:\School\Minor\ShopReservation\ShopReservation\Pages\Reservation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SupermarkCheck.Pages.ReservationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SupermarkCheck.Pages.ReservationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SupermarkCheck.Pages.ReservationModel>)PageContext?.ViewData;
        public SupermarkCheck.Pages.ReservationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
