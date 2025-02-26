namespace SPACESHIP
{
    class CannonDecorator : SpaceshipDecorator
    {
        public CannonDecorator(Spaceship spaceship) : base(spaceship)
        {
            
           
        }
        public override int GetNextAttack()
        {
            Random RNG = new Random();
            if (RNG.Next(2) == 0) return base.GetNextAttack();
            else return base.GetNextAttack() + base.GetNextAttack();
        }
        public override string Type()
        {
            return spaceship.Type() + " with bonus cannon";
        }
    }
}