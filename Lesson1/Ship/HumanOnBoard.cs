abstract internal class HumanOnBoard
    {
        public string name;
        public int age;

        public HumanOnBoard(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void Representation(); //abstract
    }