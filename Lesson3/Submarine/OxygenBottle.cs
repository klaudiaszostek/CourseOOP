namespace SUBMARINE
{
    class OxygenBottle : IVisitPort 
    {
        public double MaxCapacity { get; set; }
        public OxygenBottle(double capacity)
        {
            MaxCapacity = capacity;
        }
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 10.5; 
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 10.5; 
            }
        }
        public double VisitPort()
        {
            double current = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return 750 * current;
        }
        public double GetCapacity()
        {
            return Volume;
        }
        /*public double GetVolume()
        {
            return volume;
        }
        public void SetVolume(double v)
        {
            volume = v;
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double w)
        {
            weight = w;
        }*/
    }
}