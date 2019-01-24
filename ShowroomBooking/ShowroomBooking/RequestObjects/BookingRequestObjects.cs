using ShowroomBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShowroomBooking.RequestObjects
{
    public class BookingRequestObjects
    {
        public string Email { get; set; }
        public DateTime AppointStart { get; set; }
        public DateTime AppointEnd { get; set; }

    }
}
