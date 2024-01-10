namespace Boolean.CSharp.Main.Misc
{
    public class Car
    {
        private string _model;
        private string _make;

        public Car()
        {
            _model = string.Empty;
            _make = string.Empty;
        }
        public Car(string Make, string v)
        {
            _make = Make;
            _model = v;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

    }
}
