using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTesting.SpareParts
{
    public class Mirrors
    {
        private byte HowManyMirrors;
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
