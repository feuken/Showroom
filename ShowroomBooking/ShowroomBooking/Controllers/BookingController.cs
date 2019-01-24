using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using ShowroomBooking.Models;
using ShowroomBooking.RequestObjects;

namespace ShowroomBooking.Controllers
{
    public class BookingController : Controller
    {
        private ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2013_SP1);

        public IActionResult Index()
        {
            var mailbox = "felix.feuk@cybercom.com";

            service.Credentials = new WebCredentials("felix.feuk@cybercom.com", "Sommar23", "cybercom.com");
            service.EnableScpLookup = false;
            //service.AutodiscoverUrl("felix@feukit.onmicrosoft.com", RedirectionUrlValidationCallback);
            service.Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx");


            List<AttendeeInfo> attendees = new List<AttendeeInfo>();
            attendees.Add(new AttendeeInfo(mailbox, MeetingAttendeeType.Required, false));
            //service.TraceEnabled = true;
            GetUserAvailabilityResults result = service.GetUserAvailability(attendees, new TimeWindow(DateTime.Now, DateTime.Now.AddDays(1)), AvailabilityData.FreeBusy);

            List<Events> model = new List<Events>();

            foreach (var a in result.AttendeesAvailability)
            {
                foreach (var b in a.CalendarEvents)
                {
                    Events events = new Events();
                    events.EventStart = b.StartTime;
                    events.EventEnd = b.EndTime;

                    model.Add(events);
                }
            }

            return View(model);
        }
        

        public IActionResult Booking()
        {
            var idag = DateTime.Now;

            List<Tid> Tider = new List<Tid>();

            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 09:00:00"), EndTime = DateTime.Parse("12/12/2012 10:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 10:00:00"), EndTime = DateTime.Parse("12/12/2012 11:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 11:00:00"), EndTime = DateTime.Parse("12/12/2012 12:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 12:00:00"), EndTime = DateTime.Parse("12/12/2012 13:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 13:00:00"), EndTime = DateTime.Parse("12/12/2012 14:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 14:00:00"), EndTime = DateTime.Parse("12/12/2012 15:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 15:00:00"), EndTime = DateTime.Parse("12/12/2012 16:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 16:00:00"), EndTime = DateTime.Parse("12/12/2012 17:00:00") });
            Tider.Add(new Tid() { StartTime = DateTime.Parse("12/12/2012 17:00:00"), EndTime = DateTime.Parse("12/12/2012 18:00:00") });

            Vecka vecka1 = new Vecka();
            vecka1.VeckoNummer = 1;
            Dag måndag = new Dag();
            Dag tisdag = new Dag();
            Dag onsdag = new Dag();
            Dag torsdag = new Dag();
            Dag fredag = new Dag();


            måndag.Tider = Tider;
            tisdag.Tider = Tider;
            onsdag.Tider = Tider;
            torsdag.Tider = Tider;
            fredag.Tider = Tider;

            int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            if (dayOfWeek == 4)
            {
                måndag.Datum = idag.Date.AddDays(-3);
                tisdag.Datum = idag.Date.AddDays(-2);
                onsdag.Datum = idag.Date.AddDays(-1);
                torsdag.Datum = idag.Date;
                fredag.Datum = idag.Date.AddDays(1);

            }

            if (dayOfWeek == 5)
            {
                måndag.Datum = idag.Date.AddDays(-4);
                tisdag.Datum = idag.Date.AddDays(-3);
                onsdag.Datum = idag.Date.AddDays(-2);
                torsdag.Datum = idag.Date.AddDays(-1);
                fredag.Datum = idag.Date;

            }
            


            vecka1.Dagar = new List<Dag> { måndag, tisdag, onsdag, torsdag, fredag };

            

            return View(vecka1);
        }


        [HttpPost]
        public IActionResult Booking(BookingRequestObjects request)
        {

            service.Credentials = new WebCredentials("felix.feuk@cybercom.com", "Sommar23", "cybercom.com");
            service.EnableScpLookup = false;
            //service.AutodiscoverUrl("felix@feukit.onmicrosoft.com", RedirectionUrlValidationCallback);
            service.Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx");


            Appointment appointment = new Appointment(service);
            // Set the properties on the appointment object to create the appointment.
            appointment.Subject = request.AppointSubject;
            appointment.Start = DateTime.Now;//request.AppointStart;
            appointment.End = DateTime.Now.AddHours(1);//request.AppointEnd;
            appointment.Location = "Showroom";
            appointment.ReminderDueBy = DateTime.Now;
            // Save the appointment to your calendar.
            appointment.Save(SendInvitationsMode.SendToNone);

            

            return RedirectToAction("Index");

        }

        public ActionResult Appointment(string i,string j)
        {

            return View();
        }

        [HttpPost]
        public IActionResult Appointment(BookingRequestObjects request)
        {

            Appointment meeting = new Appointment(service);
            // Set the properties on the meeting object to create the meeting.
            meeting.Subject = "Team building exercise";
            meeting.Body = "Let's learn to really work as a team and then have lunch!";
            meeting.Start = DateTime.Now.AddDays(2);
            meeting.End = meeting.Start.AddHours(4);
            meeting.Location = "Conference Room 12";
            meeting.RequiredAttendees.Add("Mack@contoso.com");
            meeting.RequiredAttendees.Add("Sadie@contoso.com");
            meeting.OptionalAttendees.Add("Magdalena@contoso.com");
            meeting.ReminderMinutesBeforeStart = 60;
            // Save the meeting to the Calendar folder and send the meeting request.
            meeting.Save(SendInvitationsMode.SendToAllAndSaveCopy);


            return RedirectToAction("Index");
        }
    }
}