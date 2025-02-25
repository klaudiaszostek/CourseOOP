namespace SUBMARINE
{
    class Waste : IVisitPort
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 2.5;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 2.5;
            }
        }
        
        public double VisitPort()
        {
            double current = Volume;
            Volume = 0;
            return 100 * current;
            
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