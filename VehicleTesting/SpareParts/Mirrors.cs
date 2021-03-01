using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Mirrors
    {
        public byte HowManyMirrors = 3;
        public bool MirrorIsClear = true;
        public void StatusOfMirror()
        {
            Console.WriteLine(MirrorIsClear);
        }
        public Mirrors()
        {

        }
    }
}
