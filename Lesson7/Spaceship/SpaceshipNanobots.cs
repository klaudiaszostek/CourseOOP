namespace SPACESHIP
{
    class SpaceshipNanobots : Spaceship
    {
        // spaceship with an army of repairing nanobots - gain 50 health point after each attack
        public override int GetNextAttack()
        {
            Health += 50;
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return "spaceship-nanobots";
        }
    }
}