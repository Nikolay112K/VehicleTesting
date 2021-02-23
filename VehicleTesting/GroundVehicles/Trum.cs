using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Trum : TechnicalVehicle
    {
        public Wheels Wheels { get; set; }
        public string EngineHealth;
        public int Seats;
        public string BodyHealth;
        public int Lights;
    }

}
