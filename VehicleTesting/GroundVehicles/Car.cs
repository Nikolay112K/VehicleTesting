using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Car : TechnicalVehicle
    {
        public Wheels Wheels { get; set; }
        public static int CountOfRam = 1;
        public string EngineHealth;
        public string Transmission;
        public int Doors;
        public double Odometer;
        public byte Seats;
        public bool Roof;
        public bool WaterProof;
        public double MaxSpeed;
        public double TankCapacity;
        public string QualityOfSparkPlug;
        public byte BatteryChargeInPercent;
        public Car() : this("Unknown", "Unknown", 2, 0, 2, true, true, 100, 1.5, "100", 100) { }
        public Car(string EngineHealth, string Transmission, int Doors, double Odometer, byte Seats, bool Roof, bool WaterProof, double MaxSpeed, double TankCapacity, string QualityOfSparkPlug, byte BatteryChargeInPercent)
        {
            this.EngineHealth = EngineHealth;
            this.Transmission = Transmission;
            this.Odometer = Odometer;
            this.Doors = Doors;
            this.Seats = Seats;
            this.Roof = Roof;
            this.WaterProof = WaterProof;
            this.MaxSpeed = MaxSpeed;
            this.TankCapacity = TankCapacity;
            this.QualityOfSparkPlug = QualityOfSparkPlug;
            this.BatteryChargeInPercent = BatteryChargeInPercent;
        }
        public void CarTesting()
        {
            bool WillTheCarStart;
            double DistanceInKM;

            if (QualityOfSparkPlug == "100" && BatteryChargeInPercent == 100)
            {
                WillTheCarStart = true;
                Console.WriteLine($"Will The car Start? :{WillTheCarStart}");
            }
            else
            {
                WillTheCarStart = false;
                Console.WriteLine($"Will The car Start? :{WillTheCarStart}");
            }
            if (WillTheCarStart == true)
            {
                DistanceInKM = MaxSpeed / TankCapacity;
                Console.WriteLine($"How many kilometers this car will go? :{DistanceInKM}");
            }
        }
    }

}
