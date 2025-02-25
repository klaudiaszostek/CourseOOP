namespace SUBMARINE
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;
        public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }
        public double GetVelocity(double submatineWeight)
        {
            Random rnd = new Random();
            double momentum = rnd.Next(1, 100);
            double velocity = submatineWeight * momentum;
            return velocity;
        }
        public bool CheckFuelBeforeTravel(double travelTime)
        {
            if(tank.Volume < travelTime * 550)
            {
                return false;
            }
            return true;
        }
        public void Travel(double travelTime)
        {
            waste.Weight += travelTime * 100;
            tank.Weight -= travelTime * 550;
        }
    }
}