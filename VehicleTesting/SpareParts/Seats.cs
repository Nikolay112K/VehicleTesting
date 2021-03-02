using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Seats
    {
        private byte CountOfSeats;
        private int SeatsHealth;
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
        public Seats(int seatsHealth, byte countOfSeats)
        {
            this.CountOfSeats = countOfSeats;
            this.SeatsHealth = seatsHealth;
        }
    }
}
