using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Unicycle
    {
        public Unicycle(string nameOfUnicyclist)
        {
            _nameOfUnicyclist = nameOfUnicyclist;
        }

        private string _nameOfUnicyclist;

        public string NameOfUnicyclist { get => _nameOfUnicyclist; set => _nameOfUnicyclist = value; }
        public int WheelCount { get; set; } = 1;
    }
}
