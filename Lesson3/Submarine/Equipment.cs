namespace SUBMARINE
{
    class Equipment : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0;
            }
        }
        public string GatherData()
        {
            string ans = "";
            for (int i = 0; i < 10; i++) ans += (char)(new Random()).Next(128);
            return "Important data gathered: " + ans;
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