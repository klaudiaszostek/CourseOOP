namespace SIMULATOR
{
    class MoveWest : Move
    {
        public override string Execute(int currentTime)
        {
            string direction = "west direction";
            if (currentTime >= 14 && currentTime < 16)
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