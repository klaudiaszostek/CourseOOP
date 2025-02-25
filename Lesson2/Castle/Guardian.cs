internal abstract class Guardian : Inhabitant
    {
        public Guardian(int ration) : base(ration) { }
        public override int Eat()
        {
            return ration;
        }
        public abstract string ReadyToFight();
        public override string ToString()
        {
            return "Inhabitant type: guardian.";
        }
    }