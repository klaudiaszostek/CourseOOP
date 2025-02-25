internal class Crossbowman : Guardian
    {
        public Crossbowman(int ration) : base(ration) { }
        public override int Eat()
        {
            return ration;
        }
        public override string ReadyToFight()
        {
            return "Crossbowman is ready to fight!";
        }
        public override string ToString()
        {
            return "Inhabitant type: guardian. Specialization: crossbowman.";
        }
    }