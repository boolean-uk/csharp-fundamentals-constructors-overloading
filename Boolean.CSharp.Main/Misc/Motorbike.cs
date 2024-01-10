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
        private int _cc;
            

        public Motorbike()
        {
            _cc = 373;
            _make = string.Empty;
            _model = string.Empty;
        }
        public Motorbike(string Make, string Model, int cc)
        {            
            _make = Make;
            _model = Model;         
            _cc = cc;
        }
        public string Make { get; }
        public string Model { get; }
        public int CC { get => _cc; }

    }
}
