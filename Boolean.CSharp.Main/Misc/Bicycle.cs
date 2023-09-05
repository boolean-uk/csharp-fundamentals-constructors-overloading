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
        private int _wheelCount = 2;

        public Bicycle()
        {
            _wheelCount = 2;
        }

        public Bicycle(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        public int WheelCount { get; set; } = 2;
    }

}