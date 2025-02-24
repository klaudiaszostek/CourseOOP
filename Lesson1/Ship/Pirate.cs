abstract internal class Pirate : HumanOnBoard
    {
        public string pirateNickname;
        public Pirate(string name, int age, string pirateNickname) : base (name, age)
        {
            this.pirateNickname = pirateNickname;
        }
    }