﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YYRA_Team_Project.Models
{
    public class Quote
    {
        /*
         * delivery date
         * gallons requested 
         * address
         * price/gallon
         * 
         * 
         */

        [Display(Name = "Gallons")]
        public int Q_Gallons { get; set; }

        [Display(Name = "Delivery Address")]
        public string Q_Address { get; set; }

        [Display(Name = "Delivery Date")]
        public DateTime Q_Date { get; set; }

    }
}
