using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Seats
    {
        public byte CountOfSeats = 4;
        public int SeatsHealth = 100000;
        public bool BuckledUp = false;
        public void SomebodySeat()
        {
            Console.WriteLine("You sit on the seats.");
            SeatsHealth--;
        }
        public void StatusBuckledUp()
        {
            Console.WriteLine($"Are you buckled up? {BuckledUp}");
        }
        public void BuckleUp()
        {
            BuckledUp = true;
            Console.WriteLine("You are buckled up.");
        }
    }
}
