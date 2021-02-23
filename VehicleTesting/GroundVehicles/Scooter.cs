using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Scooter : TechnicalVehicle
    {
        public Wheels Wheels { get; set; }
        public string EngineHealth;
        public int Seat;
        public int Trunk;
        public int Gear;

    }
}
