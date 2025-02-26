namespace SIMULATOR
{
    class MoveEast : Move
    {
        public override string Execute(int currentTime)
        {
            string direction = "east direction";
            if (currentTime > 7 && currentTime < 10)
            {
                return direction + ", covering your eyes";
            }
            else
            {
                return direction;
            }
        }
    }
}