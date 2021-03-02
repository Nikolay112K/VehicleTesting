using System;
using VehicleTesting.SpareParts;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Car : TechnicalVehicle
    {
        private Wheels WheelsObj { get; set; }
        private Roof RoofObj { get; set; }
        private WaterProof WaterProofObj { get; set; }
        private Doors DoorsObj { get; set; }
        private Seats SeatsObj { get; set; }
        private Odometr OdometrObj { get; set; }
        private Mirrors MirrorsObj { get; set; }
        private static int CountOfRam = 1;
        private string EngineHealth;
        private string Transmission;
        private double MaxSpeed;
        private double TankCapacity;
        private string QualityOfSparkPlug;
        private byte BatteryChargeInPercent;
        //public Car() : this("Unknown", "Unknown", 100, 1.5, "100", 100, 4) { }
        public Car(string EngineHealth, string Transmission, double MaxSpeed, double TankCapacity, string QualityOfSparkPlug, byte BatteryChargeInPercent,int nubmerOfWheels,int seatsHealth, int roofHealth, byte howManyMirrors,int countOfDoors,int doorsHealth,byte countOfSeats)
        {
            this.EngineHealth = EngineHealth;
            this.Transmission = Transmission;
            this.MaxSpeed = MaxSpeed;
            this.TankCapacity = TankCapacity;
            this.QualityOfSparkPlug = QualityOfSparkPlug;
            this.BatteryChargeInPercent = BatteryChargeInPercent;

            this.MirrorsObj = new Mirrors(howManyMirrors);
            this.OdometrObj = new Odometr();
            this.SeatsObj = new Seats(seatsHealth, countOfSeats);
            this.DoorsObj = new Doors(countOfDoors,doorsHealth);
            this.WaterProofObj = new WaterProof();
            this.RoofObj = new Roof(roofHealth);
            this.WheelsObj = new Wheels(nubmerOfWheels);
        }

        public void IsThatATruck()
        {
            if (MaxSpeed < 100 && TankCapacity > 2.5 && WheelsObj.GetNumberOFWheels() > 4 && DoorsObj.GetNumberOfDoors() >= 2)
            {
                Console.WriteLine("This is a TRUCK");
            }
            else
            {
                Console.WriteLine("It's not a truck... :(");
            }
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
