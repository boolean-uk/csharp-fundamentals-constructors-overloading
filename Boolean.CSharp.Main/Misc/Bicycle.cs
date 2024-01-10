namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount;

        public int WheelCount { get => _wheelCount; set => _wheelCount = value; }

        public Bicycle(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        public Bicycle()
        {
            _wheelCount = 2;
        }
    }
}
