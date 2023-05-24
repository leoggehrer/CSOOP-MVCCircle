namespace MVCCircle.Logic
{
    internal class CircelModel : ICircelModel
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            internal set
            {
                if (value >= 0)
                {
                    _radius = value;
                    Changed?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler? Changed;
    }
}