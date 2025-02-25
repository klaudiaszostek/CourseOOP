namespace FACTORY
{
    class ModernDecorator : InteriorDecorator
    {
        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            if (priceLimit >= 3500)
            {
                return new ModernWardrobe(3500, "black");
            }
            return null;
        }

        public override Desk ProduceDesk(int priceLimit)
        {
            if (priceLimit >= 3000)
            {
                return new ModernDesk(3000, "black");
            }
            return null;
        }
    }
}