using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class KickScooter : TechnicalVehicle
    {
        public string MotorHealth;
        public Wheels Wheels { get; set; }
    }
}
