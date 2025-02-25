namespace FACTORY
{
    internal class ClassicDecorator : InteriorDecorator
    {
        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            if (priceLimit >= 1500)
            {
                return new ClassicWardrobe(1500, "oak");
            }
            return null;
        }

        public override Desk ProduceDesk(int priceLimit)
        {
            if (priceLimit >= 1000)
            {
                return new ClassicDesk(1000, "oak");
            }
            return null;
        }
        

    }
}