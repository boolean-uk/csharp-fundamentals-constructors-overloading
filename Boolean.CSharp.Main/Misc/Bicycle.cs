using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount;

        public Bicycle(int wheels=2){
            _wheelCount = wheels;
            }
        public int WheelCount { get { return _wheelCount; } }
    }
}
