namespace FACTORY
{
    class ScandinavianDecorator : InteriorDecorator
    {
        
        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            if (priceLimit >= 2500)
            {
                return new ScandinavianWardrobe(2500, "white");
            }
            return null;
        }
        
        public override Desk ProduceDesk(int priceLimit)
        {
            if (priceLimit >= 2000)
            {
                return new ScandinavianDesk(2000, "white");
            }
            return null;
        }
        
        
    }
}