using ShowroomBooking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ShowroomBooking.RequestObjects
{
    public class BookingRequestObjects
    {
        [Required, EmailAddress(ErrorMessage = "It has to be a valid Email address!"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime AppointStart { get; set; }
        public DateTime AppointEnd { get; set; }

    }
}
