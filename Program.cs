namespace CarApp3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Indtast bilmærke");
            string brand = Console.ReadLine();

            Console.WriteLine("Indtast bilmodel");
            string model = Console.ReadLine();

            Console.WriteLine("Indtast årgang");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast geartype A for Automatisk eller M for Manuel");
            char gearType = Console.ReadLine()[0];

            Console.WriteLine("Indtast brændstoftype D for Diesel eller B for Benzin");
            char fuelType = Console.ReadLine()[0];

            Console.WriteLine("Indtast Km per liter");
            int kmPerLiter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast kilometerstand");
            int kiloMeterStand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast distance på kørsel");
            double distance = Convert.ToDouble(Console.ReadLine());

            double fuelPrice = 0;
            if (fuelType == 'D')
                fuelPrice = 12.29;
            else if (fuelType == 'B')
                fuelPrice = 13.49;

            double fuelNeeded = distance / kmPerLiter;
            double tripCost = fuelNeeded * fuelPrice;

            string besked = string.Format("Brændstof udgifterne for {0} km er {1} kr.", distance, tripCost);

            Console.WriteLine("BIL INFORMATION");

            Console.WriteLine("Mærke:".PadRight(20) + brand.PadRight(20));
            Console.WriteLine("Model:".PadRight(20) + model.PadRight(20));
            Console.WriteLine("Årgang:".PadRight(20) + year.ToString().PadLeft(20));
            Console.WriteLine("Gear type:".PadRight(20) + gearType.ToString().PadLeft(20));
            Console.WriteLine("Brændstof:".PadRight(20) + fuelType.ToString().PadLeft(20));
            Console.WriteLine("Km/L:".PadRight(20) + kmPerLiter.ToString().PadLeft(20));
            Console.WriteLine("Kilometerstand:".PadRight(20) + kiloMeterStand.ToString().PadLeft(20));
            Console.WriteLine("Distance:".PadRight(20) + distance.ToString("F2").PadLeft(20));
            Console.WriteLine("Brændstof pris:".PadRight(20) + fuelPrice.ToString("F2").PadLeft(20));
            Console.WriteLine("Tur pris:".PadRight(20) + tripCost.ToString("F2").PadLeft(20));

            Console.WriteLine(besked);
            Console.ReadLine();
        }
    }

}