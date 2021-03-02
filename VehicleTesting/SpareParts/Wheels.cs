using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Wheels
    {
        private int NumberOfWheels;
        public int GetNumberOFWheels()
        {
            return NumberOfWheels;
        }
        public Wheels(int numberOfWheels)
        {
            this.NumberOfWheels = numberOfWheels;
        }
    }
}
