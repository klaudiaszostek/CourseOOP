namespace SPACESHIP
{
    class SpaceshipArmor : Spaceship
    {
        // spaceship with additional armor - more health points
        public SpaceshipArmor() : base()
        {
            Health += 150;
        }
        public override string Type()
        {
            return "spaceship-armor";
        }

    }
}