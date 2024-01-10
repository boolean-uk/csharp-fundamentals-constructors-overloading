﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount;

        public int WheelCount { get { return _wheelCount; } }

        public Bicycle() { }
        public Bicycle(int wc) 
        {
            _wheelCount = wc;
        }
    }
}
