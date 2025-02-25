internal class Pikeman : Guardian
    {
        public Pikeman(int ration) : base(ration) { }
        public override int Eat()
        {
            return ration;
        }
        public override string ReadyToFight()
        {
            return "Pikeman is ready to fight!";
        }
        public override string ToString()
        {
            return "Inhabitant type: guardian. Specialization: pikeman.";
        }
    }