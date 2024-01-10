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
        private int _cc = 0;
            

        public Motorbike()
        {
            _cc = 373;
            _make = string.Empty;
            _model = string.Empty;
        }
        public Motorbike(int CC, string Make, string Model)
        {
            _cc = CC;
            _make = Make;
            _model = Model;         
            
        }
        public string Make { get { return _make; } set { _make = value; } }
        public string Model { get { return _model;  } set { _model = value; } }
        public int CC { get { return _cc; } set { _cc = value; } }

    }
}
