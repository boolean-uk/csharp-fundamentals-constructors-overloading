﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Unicycle
    {
        private string _nameOfUnicyclist;

        // constructor that accepts the name of the unicyclist
        public Unicycle(string uniCyclist) {
            _nameOfUnicyclist = uniCyclist;
        }

        public string NameOfUnicyclist { get => _nameOfUnicyclist; set => _nameOfUnicyclist = value; }
        public int WheelCount { get; set; } = 1;
    }
}
