using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _WheelCount;
        public Bicycle()
        {
            _WheelCount = 2;
        }

        public int WheelCount { get { return _WheelCount; } set { _WheelCount = value; } }
    }
}