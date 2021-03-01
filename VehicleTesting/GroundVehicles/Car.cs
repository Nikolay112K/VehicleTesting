using System;
using VehicleTesting.SpareParts;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Car : TechnicalVehicle
    {
        public Wheels WheelsObj { get; set; }
        public Roof RoofObj { get; set; }
        public WaterProof WaterProofObj { get; set; }
        public Doors DoorsObj { get; set; }
        public Seats SeatsObj { get; set; }
        public Odometr OdometrObj { get; set; }
        public Mirrors MirrorsObj { get; set; }
        public static int CountOfRam = 1;
        public string EngineHealth;
        public string Transmission;
        public double MaxSpeed;
        public double TankCapacity;
        public string QualityOfSparkPlug;
        public byte BatteryChargeInPercent;
        //public Car() : this("Unknown", "Unknown", 100, 1.5, "100", 100, 4) { }
        public Car(string EngineHealth, string Transmission, double MaxSpeed, double TankCapacity, string QualityOfSparkPlug, byte BatteryChargeInPercent,int nubmerOfWheels)
        {
            this.EngineHealth = EngineHealth;
            this.Transmission = Transmission;
            this.MaxSpeed = MaxSpeed;
            this.TankCapacity = TankCapacity;
            this.QualityOfSparkPlug = QualityOfSparkPlug;
            this.BatteryChargeInPercent = BatteryChargeInPercent;

            this.MirrorsObj = new Mirrors();
            this.OdometrObj = new Odometr();
            this.SeatsObj = new Seats();
            this.DoorsObj = new Doors();
            this.WaterProofObj = new WaterProof();
            this.RoofObj = new Roof();
            this.WheelsObj = new Wheels(nubmerOfWheels);
        }

        public void HowManyWheels()
        {
            WheelsObj.GetNumberOFWheels();
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
