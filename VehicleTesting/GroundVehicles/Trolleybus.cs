using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.SpareParts;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Trolleybus : TechnicalVehicle
    {
        public string DCMotorHealth;
        public int Window;
        public Wheels WheelsObj { get; set; }
        public string ArrowHealth;
        public string EngineHealth;
        public string BodyHealth;
        public int Seats;
        public int Mirrors;
        public int Lights;
    }

}
