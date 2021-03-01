using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Doors
    {
        public int CountOfDoors = 4;
        public int DoorsHealth = 1000;
        public void DoorIsOpen()
        {
            Console.WriteLine("Door is Opend.");
        }
        public void DoorIsClosed()
        {
            Console.WriteLine("Door is Closed");
            DoorsHealth--;
        }
    }
}
