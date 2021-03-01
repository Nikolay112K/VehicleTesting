using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Roof
    {
        public int RoofHealth = 10000;
        public void RoofIsOpend()
        {
            Console.WriteLine("Roof is opend.");
            RoofHealth--;
        }
        public void RoofIsClosed()
        {
            Console.WriteLine("Roof is closed.");
            RoofHealth--;
        }
        public void RoofStatus()
        {
            Console.WriteLine($"Roof have {RoofHealth} Health point");
        }
    }
}
