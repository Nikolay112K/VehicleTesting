using System;
using VehicleTesting.AirVehicle;
using VehicleTesting.GroundVehicles;
using VehicleTesting.SpareParts;
using VehicleTesting.Vehicle;
using VehicleTesting.WaterVehicle;

namespace VehicleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car("Unknown", "Unknown", 100, 1.5, "100", 100, 4,10000);
            a.CarTesting();
            a.HowManyWheels();
        }
    }
}
