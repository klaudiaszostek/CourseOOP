namespace FACTORY
{
    abstract class InteriorDecorator
    {
        public abstract Wardrobe ProduceWardrobe(int priceLimit);
        public abstract Desk ProduceDesk(int priceLimit);
    }
}