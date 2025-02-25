namespace FACTORY
{
    class VintageWardrobe : Wardrobe
    {
        private int originYears;
        public int OriginYears 
        { 
            get { return originYears; } 
            set { originYears = value; }
        }
        public VintageWardrobe(int price, string color, int originYears) : base(price, color) 
        { 
            OriginYears = originYears;
        }
    }
}