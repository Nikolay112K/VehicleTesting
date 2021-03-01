using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Doors
    {
        private int CountOfDoors;
        private int DoorsHealth;
        public void DoorIsOpen()
        {
            Console.WriteLine("Door is Opend.");
        }
        public void DoorIsClosed()
        {
            Console.WriteLine("Door is Closed");
            DoorsHealth--;
        }
        public Doors()
        {

        }
    }
}
