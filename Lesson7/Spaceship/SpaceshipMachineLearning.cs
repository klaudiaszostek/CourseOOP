namespace SPACESHIP
{
    class SpaceshipMachineLearning : Spaceship
    {
        // spaceship with machine learning callibration - becomes stronger with every attack
        public override int GetNextAttack()
        {
            Attack += 25;
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return "spaceship-AI";
        }
    }
}