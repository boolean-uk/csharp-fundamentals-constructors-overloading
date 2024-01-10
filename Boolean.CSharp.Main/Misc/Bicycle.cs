using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {

        public Bicycle() {
            
        
        }

        public Bicycle(int WheelCount)
        {
            _wheelCount = WheelCount;
        }

        private int _wheelCount;

        public int WheelCount { get; set; }
    }
}
