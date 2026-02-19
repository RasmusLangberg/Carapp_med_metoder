namespace BudgetCarApp
{
    internal class Program
    {
        static string Brand;
        static string Model;
        static int Year;
        static char gearType;
        static string fuelType;
        static double kmPerLiter;
        static int kilometerstand;
        static bool Ermotorentændt = false;


        static void Main(string[] args)
        {
            bool running = true;


            while (running)
            {
                Console.WriteLine("\n=== VELKOMMEN TIL HOVEDMENUEN ===");
                Console.WriteLine("1. Indlæs bilinfo");
                Console.WriteLine("2. Start motor");
                Console.WriteLine("3. Kør tur");
                Console.WriteLine("4. Beregn pris for turen");
                Console.WriteLine("5. Tjek palindrom km");
                Console.WriteLine("6. Print bilinfo");
                Console.WriteLine("7. Afslut");

                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        ReadCarDetails();
                        Pause();
                        break;

                    case "2":
                        Ermotorentændt = true;
                        Console.WriteLine("Motoren er tændt");
                        Pause();
                        break;

                    case "3":
                        Drive();
                        Pause();
                        break;

                    case "4":
                        CalculateTripPrice();
                        Pause();
                        break;
                        

                    case "5":
                        CheckPalindrom();
                        Pause();
                        break;

                    case "6":
                        PrintCarDetails();
                        Pause();
                        break;

                    case "7":
                        running = false;
                        Pause();
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg");
                        Pause();
                        break;
                }
            }
        } //  MAIN SLUTTER HER



        // ---- METODER ----

        static void ReadCarDetails()
        {
            Console.WriteLine("Indtast bilmærke ");
            Brand = Console.ReadLine();

            Console.WriteLine("Indtast model");
            Model = Console.ReadLine();

            Console.WriteLine("Indtast årgang (YYYY)");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Indtast geartype (M for manuel , A for automatisk)");
            gearType = Console.ReadLine()[0];

            Console.WriteLine("Brændstoftype (B for Benzin , D for Diesel)");
            fuelType = Console.ReadLine();

            Console.WriteLine("Hvor mange Km pr liter trækker den?");
            kmPerLiter = double.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er bilens Kilometerstand?");
            kilometerstand = int.Parse(Console.ReadLine());
        }


        static void Drive()
        {
            if (!Ermotorentændt)
            {
                Console.WriteLine("Motor er slukket!");
                return;
            }

            Console.WriteLine("Distance:");
            double distance = double.Parse(Console.ReadLine());

            kilometerstand += (int)distance;
            Console.WriteLine($"Du kørte {distance} km");
        }


        static void CalculateTripPrice()
        {
            double distance;

            while (true)
            {
                try
                {
                    Console.Write("Distance: ");
                    distance = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ugyldigt input. Venligst indtast kun tal.");
                }
            }

            double price;

            while (true)
            {
                try
                {
                    Console.Write("Pris pr liter i kr: ");
                    price = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ugyldigt input. Venligst indtast kun tal.. Igen...");
                }
            }

            if (kmPerLiter == 0)
            {
                Console.WriteLine("Km/l kan ikke være 0");
                return;
            }

            double fuelNeeded = distance / kmPerLiter;
            double cost = fuelNeeded * price;

            Console.WriteLine($"Pris for tur: {cost:F2} kr");
        }







        static void CheckPalindrom()
        {
            string text = kilometerstand.ToString();

            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right])
                {
                    Console.WriteLine("Kilometerstand er ikke palindrom");
                    return;
                }

                left++;
                right--;
            }

            Console.WriteLine("Kilometerstand er palindrom!");
        }


        static void PrintCarDetails()

        {
            Console.WriteLine("\n--- BilInfo ---");
            Console.WriteLine($"Mærke: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Årgang: {Year}");
            Console.WriteLine($"Gear: {gearType}");
            Console.WriteLine($"Brændstof: {fuelType}");
            Console.WriteLine($"Km/L: {kmPerLiter}");
            Console.WriteLine($"Km stand: {kilometerstand}");
            Console.WriteLine($"Motor tændt: {Ermotorentændt}");



        }
        static void Pause()
        {
            Console.WriteLine("\nTryk Enter for at fortsætte...");
            Console.ReadLine();


        }
    }
}
   