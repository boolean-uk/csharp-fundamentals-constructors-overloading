using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount = 0;

        public Bicycle(int Wheelcount)
        {
            _wheelCount = Wheelcount;
        }


        public int WheelCount { get => _wheelCount; set => _wheelCount = value; }
    }
}
