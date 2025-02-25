namespace SUBMARINE
{
    abstract class Human : ITransportable
    {
        public abstract double Volume { get; set; }
        public abstract double Weight { get; set; }

        /*public abstract double GetVolume();
        public abstract void SetVolume(double v);
        public abstract double GetWeight();
        public abstract void SetWeight(double w);*/

    }
}