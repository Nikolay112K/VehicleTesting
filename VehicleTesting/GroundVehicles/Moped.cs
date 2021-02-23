using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Moped : TechnicalVehicle
    {
        public Wheels Wheels { get; set; }
        public string Engine;
        public int Seat;
        public int Trunk;
        public int Gear;
    }

}
