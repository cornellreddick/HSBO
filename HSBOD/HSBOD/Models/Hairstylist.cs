﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSBOD.Models
{
    public class Hairstylist
    {
        public int BarberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
