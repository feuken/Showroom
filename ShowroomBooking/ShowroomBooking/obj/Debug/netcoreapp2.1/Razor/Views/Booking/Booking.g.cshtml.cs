#pragma checksum "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5363728569efd30469f3503188792fe14e70b253"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5363728569efd30469f3503188792fe14e70b253", @"/Views/Booking/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94ac65b1d3c5f9defc3882d1ce4a3cb4dd5eb30", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vecka>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
  
    ViewData["Title"] = "Booking";

#line default
#line hidden
            BeginContext(59, 1106, true);
            WriteLiteral(@"
<style>
    .button.disabled {
        opacity: 0.65;
        cursor: not-allowed;
    }
<<<<<<< HEAD

=======
>>>>>>> a14606cec316b8b0125982d0e4d905983ba391f4
    div#first {
        border: 1px solid black;
    }
    th {
        text-align: center;
        height: 40px;
    }
    td {
        text-align: center;
        height: 40px;
    }

    /*

    th {
        text-align: center;
        height: 40px;
    }

    td {
        text-align: center;
        height: 40px;
    }

    /*

    table {
        border-collapse: collapse;
        width: 20%;
    }

    td {
        text-align: center;
        height: 40px;
    }

    tr {
        background-color: lightblue;
        color: black;
    }

    td:hover {
        background-color: #267aa6;
    }*/

<<<<<<< HEAD
=======
   
</style>
>>>>>>> a14606cec316b8b0125982d0e4d905983ba391f4

</style>

<<<<<<< HEAD
<h2>Booking</h2>

<div id=""first"" style=""width: 880px;"">
    <table cellspacing=""");
            WriteLiteral("20\" style=\"width: 850px; height: 400px;align-content:center;margin-left:10px\">\r\n\r\n");
            EndContext();
            BeginContext(1268, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
#line 80 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
             for (int i = 0; i < Model.Dagar.Count; i++)
            {

#line default
#line hidden
            BeginContext(1355, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1398, 40, false);
#line 83 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
               Write(Model.Dagar[i].Datum.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1438, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 85 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
            }

#line default
#line hidden
            BeginContext(1478, 29, true);
            WriteLiteral("        </tr>\r\n        <tr>\r\n");
            EndContext();
#line 88 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
             for (int i = 0; i < Model.Dagar.Count; i++)
            {

#line default
#line hidden
            BeginContext(1580, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1623, 30, false);
#line 91 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
               Write(Model.Dagar[i].Datum.DayOfWeek);

#line default
#line hidden
            EndContext();
            BeginContext(1653, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 93 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
            }

#line default
#line hidden
            BeginContext(1693, 17, true);
            WriteLiteral("        </tr>\r\n\r\n");
            EndContext();
#line 96 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
         for (int j = 0; j < Model.Dagar[0].Tider.Count; j++)
        {

#line default
#line hidden
            BeginContext(1784, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 99 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
                 for (int i = 0; i < Model.Dagar.Count; i++)
                {
                    string str = j.ToString();

#line default
#line hidden
            BeginContext(1931, 28, true);
            WriteLiteral("                    <td>\r\n\r\n");
            EndContext();
#line 104 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
                         if (Model.Dagar[i].Datum.Date >= DateTime.Now.Date)
                        {

#line default
#line hidden
            BeginContext(2064, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2094, "\"", 2123, 5);
            WriteAttributeValue("", 2101, "Appointment?i=", 2101, 14, true);
#line 106 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 2115, i, 2115, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 2117, "&j=", 2117, 3, true);
#line 106 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 2120, j, 2120, 2, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2122, "", 2123, 1, true);
            EndWriteAttribute();
            BeginContext(2124, 94, true);
            WriteLiteral(">\r\n                                <input type=\"button\" style=\"background-color : lightgreen;\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2218, "", 2341, 1);
#line 107 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 2225, Model.Dagar[i].Tider[j].StartTime.ToShortTimeString() + "-" + Model.Dagar[i].Tider[j].EndTime.ToShortTimeString(), 2225, 116, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2341, 39, true);
            WriteLiteral(" />\r\n                            </a>\r\n");
            EndContext();
#line 109 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2466, 143, true);
            WriteLiteral("                            <a>\r\n                                <input type=\"button\" style=\"background-color : lightpink;\" disabled=\"disabled\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2609, "", 2732, 1);
#line 114 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 2616, Model.Dagar[i].Tider[j].StartTime.ToShortTimeString() + "-" + Model.Dagar[i].Tider[j].EndTime.ToShortTimeString(), 2616, 116, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2732, 39, true);
            WriteLiteral(" />\r\n                            </a>\r\n");
            EndContext();
#line 116 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"

                        }

#line default
#line hidden
            BeginContext(2800, 27, true);
            WriteLiteral("                    </td>\r\n");
            EndContext();
#line 119 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
                }

#line default
#line hidden
            BeginContext(2846, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 121 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
        }

#line default
#line hidden
            BeginContext(2876, 173, true);
            WriteLiteral("\r\n\r\n\r\n    </table>\r\n=======\r\n<div id=\"first\"  style=\"width: 880px;\">\r\n<table cellspacing=\"20\" style=\"width: 850px; height: 400px;align-content:center;margin-left:10px\" >\r\n\r\n");
            EndContext();
            BeginContext(3132, 10, true);
            WriteLiteral("    <tr>\r\n");
            EndContext();
#line 135 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
         for (int i = 0; i < Model.Dagar.Count; i++)
        {

#line default
#line hidden
            BeginContext(3207, 35, true);
            WriteLiteral("            <th >\r\n                ");
            EndContext();
            BeginContext(3243, 40, false);
#line 138 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
           Write(Model.Dagar[i].Datum.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3283, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 140 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
        }

#line default
#line hidden
            BeginContext(3315, 21, true);
            WriteLiteral("    </tr>\r\n    <tr>\r\n");
            EndContext();
#line 143 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
         for (int i = 0; i < Model.Dagar.Count; i++)
        {

#line default
#line hidden
            BeginContext(3401, 35, true);
            WriteLiteral("            <th >\r\n                ");
            EndContext();
            BeginContext(3437, 30, false);
#line 146 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
           Write(Model.Dagar[i].Datum.DayOfWeek);

#line default
#line hidden
            EndContext();
            BeginContext(3467, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 148 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
        }

#line default
#line hidden
            BeginContext(3499, 13, true);
            WriteLiteral("    </tr>\r\n\r\n");
            EndContext();
#line 151 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
     for (int j = 0; j < Model.Dagar[0].Tider.Count; j++)
    {

#line default
#line hidden
            BeginContext(3578, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
#line 154 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
             for (int i = 0; i < Model.Dagar.Count; i++)
            {
                string str = j.ToString();

#line default
#line hidden
            BeginContext(3709, 34, true);
            WriteLiteral("            <td >\r\n             \r\n");
            EndContext();
#line 159 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
                 if (Model.Dagar[i].Datum.Date >= DateTime.Now.Date)
                {

#line default
#line hidden
            BeginContext(3832, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3854, "\"", 3883, 5);
            WriteAttributeValue("", 3861, "Appointment?i=", 3861, 14, true);
#line 161 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 3875, i, 3875, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3877, "&j=", 3877, 3, true);
#line 161 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 3880, j, 3880, 2, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3882, "", 3883, 1, true);
            EndWriteAttribute();
            BeginContext(3884, 86, true);
            WriteLiteral(">\r\n                        <input type=\"button\" style=\"background-color : lightgreen;\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3970, "", 4093, 1);
#line 162 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 3977, Model.Dagar[i].Tider[j].StartTime.ToShortTimeString() + "-" + Model.Dagar[i].Tider[j].EndTime.ToShortTimeString(), 3977, 116, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4093, 31, true);
            WriteLiteral(" />\r\n                    </a>\r\n");
            EndContext();
#line 164 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(4186, 129, true);
            WriteLiteral("                    <a >\r\n                        <input type=\"button\" style=\"background-color : lightpink;\"  disabled=\"disabled\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 4315, "", 4438, 1);
#line 169 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
WriteAttributeValue("", 4322, Model.Dagar[i].Tider[j].StartTime.ToShortTimeString() + "-" + Model.Dagar[i].Tider[j].EndTime.ToShortTimeString(), 4322, 116, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4438, 31, true);
            WriteLiteral(" />\r\n                    </a>\r\n");
            EndContext();
#line 171 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"

                }

#line default
#line hidden
            BeginContext(4490, 19, true);
            WriteLiteral("            </td>\r\n");
            EndContext();
#line 174 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
            }

#line default
#line hidden
            BeginContext(4524, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 176 "C:\Users\fefeu1\Documents\GitHub\Showroom\ShowroomBooking\ShowroomBooking\Views\Booking\Booking.cshtml"
    }

#line default
#line hidden
            BeginContext(4546, 84, true);
            WriteLiteral("\r\n\r\n\r\n</table>\r\n>>>>>>> a14606cec316b8b0125982d0e4d905983ba391f4\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(5187, 6, true);
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
