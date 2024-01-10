namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount;

        public Bicycle(int wheelCount) // Added constructor
        {
            _wheelCount = wheelCount;
        }

        public int WheelCount { get => _wheelCount; set => _wheelCount = value; }
    }
}
