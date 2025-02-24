internal class Hostage : HumanOnBoard
    {
        public int daysLeft;
        public Hostage(string name, int age, int daysLeft) : base(name, age)
        {
            this.daysLeft = daysLeft;
        }
        public override void Representation()
        {
            Console.WriteLine("There is a HOSTAGE named " + name + " on the ship, " +
               "who is " + age + " years old, and he/she only has " + daysLeft + " day(s) to live.\n");
        }
    }