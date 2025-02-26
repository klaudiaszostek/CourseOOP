namespace SPACESHIP
{
    class LaserDecorator : SpaceshipDecorator
    {
        public LaserDecorator(Spaceship spaceship) : base(spaceship)
        {
            Attack += 50;
        }
        public override string Type()
        {
            return spaceship.Type() + " with bonus laser";
        }
    }
}