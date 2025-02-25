namespace SUBMARINE
{
    class FoodContainer : IVisitPort
    {
        public double MaxCapacity { get; set; }
        public FoodContainer(double capacity)
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
                weight = value * 3.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 3.0;
            }
        }
        public double VisitPort()
        {
            double current = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return 950 * current;
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