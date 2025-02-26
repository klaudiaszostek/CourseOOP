namespace SPACESHIP
{
    class AIDecorator : SpaceshipDecorator
    {
        public AIDecorator(Spaceship spaceship) : base(spaceship)
        {

        }
        public override int GetNextAttack()
        {
            Attack += 25;
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return spaceship.Type() + " with bonus AI";
        }
    }
}