﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        public Bicycle(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        private int _wheelCount;

        public int WheelCount { get => _wheelCount; set => _wheelCount = value; }
    }
}
