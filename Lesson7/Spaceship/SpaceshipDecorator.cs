namespace SPACESHIP
{
    abstract class SpaceshipDecorator : Spaceship
    {
        protected Spaceship spaceship;
        public SpaceshipDecorator(Spaceship spaceship)
        {
            this.spaceship = spaceship;
        }
    }
}