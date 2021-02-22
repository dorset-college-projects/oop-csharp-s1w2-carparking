using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingCharges.Models
{
    public partial class CarParkCharge
    {

        public override string ToString()
        {

            return $"Charges: feedMinimum {feeMinimum} feeMaximum{feeMaximum}";
        }
    }
}
