internal class Deckhand : Pirate
    {
        public int experienceYears;
        public Deckhand(string name, int age, string pirateNickname, int experienceYears) : base (name, age, pirateNickname)
        {
            this.experienceYears = experienceYears;
        }
        public override void Representation()
        {
            Console.WriteLine("There is a DECKHAND named " + name + " on the ship, " +
               "who is " + age + " years old, has a pirate nickname: " + pirateNickname + " and has been working for pirates for " + experienceYears + " year(s).\n");
        }
    }