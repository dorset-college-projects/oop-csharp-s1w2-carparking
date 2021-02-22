using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingCharges.Models
{
    public class Customer
    {
        public int hours { get; set;  }

        public string registration { get; set; }

        public Customer(string _registration, int _hours)
        {
            registration = _registration;
            hours = _hours;

        }
    }
}
