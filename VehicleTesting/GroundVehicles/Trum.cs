using System;
using System.Collections.Generic;
using System.Text;
using VehicleTesting.SpareParts;
using VehicleTesting.Vehicle;

namespace VehicleTesting.GroundVehicles
{
    public class Trum : TechnicalVehicle
    {
        public Odometr OdometrObj { get; set; }
        public Mirrors MirrorsObj { get; set; }
        public WaterProof WaterProofObj { get; set; }
        public Seats SeatsObj { get; set; }
        public Roof RoofObj { get; set; }
        public Doors DoorsObj { get; set; }
        public Wheels WheelsObj { get; set; }
        public string EngineHealth;
        public string BodyHealth;
        public int Lights;
        public Trum(string engineHealth, string bodyHealth, int lights)
        {
            this.EngineHealth = engineHealth;
            this.BodyHealth = bodyHealth;
            this.Lights = lights;

            this.OdometrObj = new Odometr();
            this.MirrorsObj = new Mirrors(3);
            this.WaterProofObj = new WaterProof();
            this.SeatsObj = new Seats(10000);
            this.RoofObj = new Roof(10000);
            this.DoorsObj = new Doors(3,10000);
            this.WheelsObj = new Wheels(8);
        }
    }
}
