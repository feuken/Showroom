﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShowroomBooking.Models
{
    public class Tid
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh mm}")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh mm}")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        //public int StartTidTimme { get; set; }
        //public int StartTidMinut { get; set; }
        //public int SlutTidTimme { get; set; }
        //public int SlutTidMinut { get; set; }
        public DateTime Datum { get; set; }
    }
}
