namespace SPACESHIP
{
    class SpaceshipLaser : Spaceship
    {
        // spaceship with extra laser strength - more attack damage
        public SpaceshipLaser() : base()
        {
            Attack += 50;
        }
        public override string Type()
        {
            return "spaceship-laser";
        }

    }
}