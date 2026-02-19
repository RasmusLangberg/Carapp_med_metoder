using System;

namespace MenuTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the new intro method
            ShowWelcome();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n--- HOVEDMENU ---");
                Console.WriteLine("1) Introduktion");
                Console.WriteLine("2) program that read your car's information");
                Console.WriteLine("3) simulate a trip with collected data");
                Console.WriteLine("4) calculating a trip");
                Console.WriteLine("5) er din km palindrom");
                Console.WriteLine("6) printer dine nyeste informationer");
                Console.WriteLine("7) skriv information om alle teammedlemmer og printer det");
                Console.WriteLine("8) Afslut");
                Console.Write("\nVælg en mulighed: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowIntro();
                        break;
                    case "2":
                        ReadCarDetails();
                        break;
                    case "3":
                        Drive();
                        break;
                    case "4":
                        CalculateTripPrice();
                        break;
                    case "5":
                        IsPalidrome();
                        break;
                    case "6":
                        PrintAllTeamCars();
                        break;
                    case "7":
                        PrintAllTeamCars();
                        break;
                    case "8":
                        isRunning = false;
                        Console.WriteLine("Programmet afsluttes...");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }
            }
        }

        static void ShowWelcome()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================");
            Console.WriteLine("    VELKOMMEN TIL MIN SOFTWARE TUTORIAL   ");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("\nTryk på en tast for at starte...");
            Console.ReadKey();
        }

        static void ShowIntro()
        {
            Console.WriteLine("\nDette program lærer dig at bruge switch-statements og loops i C#.");
        }

        static void ReadCarDetails()
        {
            Console.WriteLine("Indtast bilmærke");
            string brand = Console.ReadLine();

            Console.WriteLine("Indtast bilmodel");
            string model = Console.ReadLine();

            Console.WriteLine("Indtast årgang");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast geartype");
            char gearType = Console.ReadLine()[0];

            Console.WriteLine("Indtast om det er benzin(b) eller diesel(d)");
            char brændstof = Console.ReadLine()[0];

            Console.WriteLine("Hvad er bilens nuværende km-tilstand");
            int kmt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor langt kan bilen køre på en liter brændstof");
            double kmL = Convert.ToDouble(Console.ReadLine());

            string udskrivBilData = String.Format("Din bil er en {0} i modellen {1} fra årgang {2} der bruger geartype {3}. Din bil bruger {4} og har kørt {5} km. Din bil kan køre {6}km pr l.", brand, model, year, gearType, brændstof, kmt, kmL);

            return;

        }
        static void Drive()
        {
            bool isEngineOn = false;
            while (isEngineOn == false) 
            {
                Console.WriteLine("Er din bil tændt?");
                string engineStatus = Console.ReadLine().ToLower();

                if (engineStatus == "ja")
                {
                    isEngineOn = true;

                }
               


            } 
            

           


                Console.WriteLine("Indtast om det er benzin(b) eller diesel(d)");
            char brændstof = Console.ReadLine()[0];


            Console.WriteLine("er din bil tændt?");


        }
        static void CalculateTripPrice()
        {


        }
        static void IsPalidrome()
        {



        }
        static void PrintCarDetails()
        {



        }
        static void PrintAllTeamCars()
        {



        }
    }
}
