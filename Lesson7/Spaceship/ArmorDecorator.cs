namespace SPACESHIP
{
    class ArmorDecorator : SpaceshipDecorator
    {
        public ArmorDecorator(Spaceship spaceship) : base(spaceship)
        {
            Health += 150;
        }
        public override string Type()
        {
            return spaceship.Type() + " with bonus armor";
        }
        
    }
}