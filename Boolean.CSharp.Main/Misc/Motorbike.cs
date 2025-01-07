using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Motorbike
    {
        private string _make;
        private string _model;
        private int _cc = 373;

        public Motorbike()
        {
            _make = string.Empty;
            _model = string.Empty;
        }

        public Motorbike(string Make, string Model)
        {
            _make = Make;
            _model = Model;
        }

        public string Make
        {
            get { return _make; }
        }
        public string Model
        {
            get { return _model; }
        }
        public int CC
        {
            get { return _cc; }
        }
    }
}
