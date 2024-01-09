using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Boolean.CSharp.Main.Misc
{
    public class Unicycle
    {
        private string _nameOfUnicyclist;

        public Unicycle()
        {
            _nameOfUnicyclist = string.Empty;
        }
        public Unicycle(string NameOfUnicyclist)
        {
            _nameOfUnicyclist = NameOfUnicyclist;
        }

        public string NameOfUnicyclist { get => _nameOfUnicyclist; set => _nameOfUnicyclist = value; }
        public int WheelCount { get; set; } = 1;
    }
}
