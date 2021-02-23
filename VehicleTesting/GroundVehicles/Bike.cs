using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Bike : TechnicalVehicle
    {
        public Wheels Wheels { get; set; }
        public int Gears;
        public int Seat;
        public string RamHealth;
        public int Pedals;
        public string ChainHealth;
        public string SpokesHealth;
        public int Tire;
    }
}
