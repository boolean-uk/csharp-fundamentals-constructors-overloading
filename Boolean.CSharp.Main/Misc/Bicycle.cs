using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount;

        public Bicycle()
        {
            _wheelCount = 1;
        }

        public int WheelCount { get => _wheelCount; set => _wheelCount = value; }   

    }
}
