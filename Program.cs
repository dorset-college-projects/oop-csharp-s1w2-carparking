using ParkingCharges.Models;
using System;

namespace ParkingCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            CarkPark cp = new CarkPark();

            Customer customer1 = new Customer("BAT1", 2);
            Customer customer2 = new Customer("SPIDER1", 5);
            Customer customer3 = new Customer("SUPER1", 17);
            Customer customer4= new Customer(13);

            cp.customers.Add(customer1);
            cp.customers.Add(customer2);
            cp.customers.Add(customer3);
            cp.customers.Add(customer4);


            double totalDailyCharge = cp.CalculateCharges();

            Console.WriteLine($"Total charge is {totalDailyCharge}");

            CarParkCharge cpc = new CarParkCharge();
            Console.WriteLine(cpc.ToString());

        }
    }
}
