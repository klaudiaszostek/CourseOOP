namespace SPACESHIP
{
    class NanobotsDecorator : SpaceshipDecorator
    {
        public NanobotsDecorator(Spaceship spaceship) : base(spaceship)
        {
           
        }
        public override int GetNextAttack()
        {
            Health += 50;
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return spaceship.Type() + " with bonus nanobots";
        }
    }
}