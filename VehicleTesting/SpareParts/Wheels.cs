﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Wheels
    {
        private int NumberOfWheels = 4;
        public void GetNumberOFWheels()
        {
            Console.WriteLine($"Number of wheels is{NumberOfWheels}");
        }
        public Wheels()
        {

        }
    }
}
