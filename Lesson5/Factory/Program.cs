namespace FACTORY
{
    class Program
    {
        static void Main(string[] args)
        { 
            ScandinavianDecorator scandinavianDecorator = new ScandinavianDecorator();
            Wardrobe wardrobe1 = scandinavianDecorator.ProduceWardrobe(4500);
            Desk desk1 = scandinavianDecorator.ProduceDesk(2500);
            Console.WriteLine("In a scandinavian style we offer: ");
            if (wardrobe1 != null)
            {
                Console.WriteLine("- wardrobe");
                Console.WriteLine("Price: " + wardrobe1.Price + ". Color: " + wardrobe1.Color);
            }
            else
            {
                Console.WriteLine("- wardrobe");
                Console.WriteLine("Price limit too low for Scandinavian Wardrobe.");
            }
            if (desk1 != null)
            {
                Console.WriteLine("- desk");
                Console.WriteLine("Price: " + desk1.Price + ". Color: " + desk1.Color);
            }
            else
            {
                Console.WriteLine("- desk");
                Console.WriteLine("Price limit too low for Scandinavian Desk.");
            }
            Console.WriteLine("\n");

            ModernDecorator modernDecorator = new ModernDecorator();
            Wardrobe wardrobe2 = modernDecorator.ProduceWardrobe(5000);
            Desk desk2 = modernDecorator.ProduceDesk(3000);
            Console.WriteLine("In a modern style we offer: ");
            if (wardrobe2 != null)
            {
                Console.WriteLine("- wardrobe");
                Console.WriteLine("Price: " + wardrobe2.Price + ". Color: " + wardrobe2.Color);
            }
            else
            {
                Console.WriteLine("- wardrobe");
                Console.WriteLine("Price limit too low for Modern Wardrobe.");
            }
            if (desk2 != null)
            {
                Console.WriteLine("- desk");
                Console.WriteLine("Price: " + desk2.Price + ". Color: " + desk2.Color);
            }
            else
            {
                Console.WriteLine("- desk");
                Console.WriteLine("Price limit too low for Modern Desk.");
            }
            Console.WriteLine("\n");

            ClassicDecorator classicDecorator = new ClassicDecorator();
            Wardrobe wardrobe3 = classicDecorator.ProduceWardrobe(2000);
            Desk desk3 = classicDecorator.ProduceDesk(900);
            Console.WriteLine("In a classic style we offer: ");
            if (wardrobe3 != null)
            {
                Console.WriteLine("- wardrobe");
                Console.WriteLine("Price: " + wardrobe3.Price + ". Color: " + wardrobe3.Color);
            }
            else
            {
                Console.WriteLine("- wardrobe");
                Console.WriteLine("Price limit too low for Classic Wardrobe.");
            }
            if (desk3 != null)
            {
                Console.WriteLine("- desk");
                Console.WriteLine("Price: " + desk3.Price + ". Color: " + desk3.Color);
            }
            else
            {
                Console.WriteLine("- desk");
                Console.WriteLine("Price limit too low for Classic Desk.");
            }
            Console.ReadKey();
        }
    }
}