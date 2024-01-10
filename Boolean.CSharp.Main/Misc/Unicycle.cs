namespace Boolean.CSharp.Main.Misc
{
    public class Unicycle
    {
        private string _nameOfUnicyclist;

        public Unicycle(string nameOfUnicyclist)
        {
            _nameOfUnicyclist = nameOfUnicyclist;
        }

        public string NameOfUnicyclist { get => _nameOfUnicyclist; set => _nameOfUnicyclist = value; }
        public int WheelCount { get; set; } = 1;
    }
}
