namespace SUBMARINE
{
    abstract class Fuel : ITransportable
    {
        public abstract double Volume { get; set; }
        public abstract double Weight { get; set; }
        public abstract string Type { get; set; }
        public new abstract string GetType();

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