using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingCharges.Models
{
    public class CarParkCharge
    {
        public static double feeMinimum = 2;
        public static double feeMaximum = 10;
        public static double feeHour = .5;

        public static int minHours = 3;
        public static int maxHours = 24;


        public static double CalculateCharge(int hours)
        {

            double charge = 0;

            if (hours < minHours)
            {
                charge = feeMinimum;
            }
            else if (hours > maxHours)
            {
                charge = feeMaximum;
            }
            else
            {
                int additionalTime = hours - minHours;

                charge = feeMinimum + (additionalTime * feeHour);

            }

            return feeMinimum;

        }


    }
}
