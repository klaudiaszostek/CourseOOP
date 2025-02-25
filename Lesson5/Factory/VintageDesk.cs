namespace FACTORY
{
    class VintageDesk : Desk
    {
        private int originYears;
        public int OriginYears
        {
            get { return originYears; }
            set { originYears = value; }
        }
        public VintageDesk(int price, string color, int originYears) : base(price, color)
        {
            OriginYears = originYears;
        }
    }
}