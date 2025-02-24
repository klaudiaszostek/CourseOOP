internal class Captain : Pirate
    {
        public int ownedShips;
        public Captain(string name, int age, string pirateNickname, int ownedShips) : base (name, age, pirateNickname)
        {
            this.ownedShips = ownedShips;
        }
        public override void Representation()
        {
            Console.WriteLine("There is a CAPTAIN named " + name + " on the ship, " +
                "who is " + age + " years old, has a pirate nickname: " + pirateNickname + " and " + ownedShips + " ship(s).\n");
 
        }   
    }