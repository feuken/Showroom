#pragma checksum "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43be6f3047bea8eeb3e2d55efadff2717eb57fe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Booking), @"mvc.1.0.view", @"/Views/Booking/Booking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Booking.cshtml", typeof(AspNetCore.Views_Booking_Booking))]
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
#line 1 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\_ViewImports.cshtml"
using ShowroomBooking;

#line default
#line hidden
#line 2 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\_ViewImports.cshtml"
using ShowroomBooking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43be6f3047bea8eeb3e2d55efadff2717eb57fe8", @"/Views/Booking/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94ac65b1d3c5f9defc3882d1ce4a3cb4dd5eb30", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vecka>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
  
    ViewData["Title"] = "Booking";

#line default
#line hidden
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(446, 398, true);
            WriteLiteral(@"
<h2>Booking</h2>


<table style=""width: 800px; height: 400px;"">

    <tr>
        <td style=""width: 160px;"">V.4</td>

    </tr>
    <tr>
        <td style=""width: 160px;"">Måndag</td>
        <td style=""width: 160px;"">Tisdag</td>
        <td style=""width: 160px;"">Onsdag</td>
        <td style=""width: 160px;"">Torsdag</td>
        <td style=""width: 160px;"">Fredag</td>
    </tr>

");
            EndContext();
#line 52 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
      for (int j = 0; j < Model.Dagar[0].Tider.Count; j++)
        {

#line default
#line hidden
            BeginContext(915, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 55 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
                 for (int i = 0; i < Model.Dagar.Count; i++)
                {
                    string str = j.ToString();

#line default
#line hidden
            BeginContext(1062, 44, true);
            WriteLiteral("                <td style=\"width: 160px;\">\r\n");
            EndContext();
            BeginContext(1402, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1424, "\"", 1453, 5);
            WriteAttributeValue("", 1431, "Appointment?i=", 1431, 14, true);
#line 62 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 1445, i, 1445, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 1447, "&j=", 1447, 3, true);
#line 62 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 1450, j, 1450, 2, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1452, "", 1453, 1, true);
            EndWriteAttribute();
            BeginContext(1454, 47, true);
            WriteLiteral(">\r\n                        <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1501, "", 1624, 1);
#line 63 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 1508, Model.Dagar[i].Tider[j].StartTime.ToShortTimeString() + "-" + Model.Dagar[i].Tider[j].EndTime.ToShortTimeString(), 1508, 116, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1624, 54, true);
            WriteLiteral(" />\r\n                    </a>\r\n                </td>\r\n");
            EndContext();
#line 66 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
                }

#line default
#line hidden
            BeginContext(1697, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 68 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
        }

#line default
#line hidden
            BeginContext(1727, 32, true);
            WriteLiteral("    \r\n\r\n\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2320, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vecka> Html { get; private set; }
    }
}
#pragma warning restore 1591
