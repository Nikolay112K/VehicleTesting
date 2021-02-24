using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.SpareParts;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Bus : TechnicalVehicle
    {
        public string EngineHealth;
        public int Seats;
        public string BodyHealth;
        public Wheels Wheels { get; set; }
        public int Lights;
        public string MirrorsHealth;
    }

}
