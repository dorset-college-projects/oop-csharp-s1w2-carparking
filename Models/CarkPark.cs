using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingCharges.Models
{
    public class CarkPark
    {
        public List<Customer> customers { get; set; }

        public CarkPark()
        {
            customers = new List<Customer>();
        }

        public double CalculateCharges()
        {

            double total = 0;

            foreach(Customer currentCustomer in customers)
            {
               

                total += CarParkCharge.CalculateCharge(currentCustomer.hours);


            }

            return total;
        }

    }
}
