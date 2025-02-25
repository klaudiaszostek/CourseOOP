namespace SUBMARINE
{
    class FuelNuclear : Fuel
    {
        protected string type = "nuclear";
        public override string Type
        {
            get { return type; }
            set { type = value; }
        }
        protected double volume, weight, density = 5.0;
        public override double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * density;
            }
        }
        public override double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / density;
            }
        }
        public override string GetType()
        {
            return "Fuel type: " + type + ".";
        }
    }
}