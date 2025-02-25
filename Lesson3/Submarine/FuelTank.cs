namespace SUBMARINE
{
    class FuelTank : IVisitPort
    {
        public double MaxCapacity { get; set; }
        private Fuel fuel;
        public FuelTank(double capacity, Fuel fuel)
        {
            MaxCapacity = capacity;
            this.fuel =  fuel;
            
        }
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.8; 
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.8;
            }
        }
        public double VisitPort()
        { 
            double current = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return 550 * current;
        }
        public double GetCapacity()
        {
            return Volume;
        }
        public string GetFuelType()
        {
            return fuel.GetType();
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