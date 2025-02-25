internal abstract class Inhabitant
    {
        public int ration;
        public Inhabitant(int ration)
        {
            this.ration = ration;
        }
        public abstract int Eat();
    }