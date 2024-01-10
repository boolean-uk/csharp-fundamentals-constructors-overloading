using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Unicycle
    {
        private string _nameOfUnicyclist;
        private int _wheelCount = 1;

        public Unicycle(string NameOfUnicyclist)
        {
            _wheelCount = WheelCount;
            _nameOfUnicyclist = NameOfUnicyclist;
        }

        public string NameOfUnicyclist { get => _nameOfUnicyclist; set => _nameOfUnicyclist = value; }
        public int WheelCount { get => _wheelCount; set => _wheelCount = value; }

    }
}
