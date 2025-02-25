namespace SUBMARINE
{
    class LifeSupportSystem
    {
        
        private List<OxygenBottle> oxygenBottles = new List<OxygenBottle>();
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew = new List<Human>();

        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste, List<Human> crew)
        {
            oxygenBottles = bottles;
            foodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }
        public bool CheckSuppliesBeforeTravel(double travelTime)
        {     
            if(oxygenBottles.Count < travelTime * 750)
            {
                return false;
            }
            
            if (foodContainer.Volume < travelTime * 950)
            {
                return false;
            }
            return true;
        }
        public void Run(double travelTime)
        {
            foodContainer.Weight -= travelTime * 950;
            waste.Weight += travelTime * 100;

            foreach (OxygenBottle oxygen in oxygenBottles)
            {
                oxygen.Weight -= travelTime * 750;
            }
        }
    }
}