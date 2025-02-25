internal class Civilian : Inhabitant
    {
        public Civilian(int ration) : base(ration) { }
        public override int Eat()
        {
            return ration;
        }
        public override string ToString()
        {
            return "Inhabitant type: civilian.";
        }
    }