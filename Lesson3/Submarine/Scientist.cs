namespace SUBMARINE
{
    class Scientist : Human
    {
        private Equipment equipment;
        protected double volume, weight;
        public override double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 1.05;
            }
        }
        public override double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 1.05;
            }
        }
        public Scientist(Equipment equipment)
        {
            this.equipment = equipment;
        }
        public void Work(double time)
        {
            for (int i = 0; i < time; i++)
            {
                Console.WriteLine(equipment.GatherData());
            }
        }
        /*public override double GetVolume()
        {
            return volume;
        }
        public override void SetVolume(double v)
        {
            volume = v;
        }
        public override double GetWeight()
        {
            return weight;
        }
        public override void SetWeight(double w)
        {
            weight = w;
        }*/
    }
}