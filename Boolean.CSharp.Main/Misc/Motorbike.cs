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
        public Motorbike(string Make, string Model)
        {
            _cc = 373;
            _make = Make;
            _model = Model;

        }
        public string Make { get; }
        public string Model { get; }
        public int CC { get => _cc; }

    }
}
