namespace FACTORY
{
    abstract class Desk
    {
        protected int price;
        protected string color = " ";
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
            }
        }
        public Desk(int price, string color)
        {
            Price = price;
            Color = color;
        }
    }
}