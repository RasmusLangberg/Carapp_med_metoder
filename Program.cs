using System;
using System.Collections.Concurrent;

namespace MenuTutorial
{
    class Program
    {
        //Evt alle variabler der skal bruges
        static string brand;
        static string model;
        static int year;
        static char gearType;
        static char brændstof;
        static int kmt;
        static double kmL;
        static int distance;
        static int nyDistance;
        static string udskrivBilData;
        static double pris;
        static double fuelneeded;

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
                        PrintCarDetails();
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
            brand = Console.ReadLine();

            Console.WriteLine("Indtast bilmodel");
            model = Console.ReadLine();

            Console.WriteLine("Indtast årgang");
            year = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Indtast geartype, manuel (m), eller automatisk (a)");
            gearType = Console.ReadLine()[0];

            Console.WriteLine("Indtast om det er benzin(b) eller diesel(d)");
            brændstof = Console.ReadLine()[0];
            bool dOrb = false;

            while (!dOrb)
            {

                Console.WriteLine("Indtast om det er benzin(b) eller diesel(d)");
                brændstof = Console.ReadLine().ToLower()[0];

                if (brændstof == 'd')
                    dOrb = true;
                else if (brændstof == 'b')
                    dOrb = true;
                else
                    Console.WriteLine("ugyldigt valg. du kan kun skrive d eller b");

            }

            Console.WriteLine("Hvad er bilens nuværende km-tilstand");
            kmt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor langt kan bilen køre på en liter brændstof");
            kmL = Convert.ToDouble(Console.ReadLine());

            udskrivBilData = String.Format("Din bil er en {0} i modellen {1} fra årgang {2} der bruger geartype {3}. Din bil bruger {4} og har kørt {5} km. Din bil kan køre {6}km pr l.", brand, model, year, gearType, brændstof, kmt, kmL);

            Console.WriteLine(udskrivBilData);

            Console.WriteLine("_______________________________");

            Console.ReadLine();


        }
        static void Drive()
        {

            if (kmt == 0) 
            {
                Console.WriteLine("du har ikke intastet dine biloplysninger (option 2)");
                return;

            }

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

            if (isEngineOn == true)
            {
                Console.WriteLine("hvor langt skal du køre?");
                distance = Convert.ToInt32(Console.ReadLine());

                nyDistance = distance + kmt;

                Console.WriteLine($"Du har nu kørt {nyDistance} km med bil");
                Console.ReadLine();

            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("_______________________________");

            Console.ReadLine();


        }
        static void CalculateTripPrice()
        {
            if (kmL == 0)
            {
                Console.WriteLine("du har ikke intastet dine biloplysninger (option 2)");
                return;

            }
            if (distance == 0)
            {
                Console.WriteLine("du har ikke intastet dine distance i option 3");
                return;

            }

            double fuelPrice = 0;
            if (brændstof == 'd')
                fuelPrice = 12.29;
            else if (brændstof == 'b')
                fuelPrice = 13.49;


            Console.WriteLine($"Du har forhen skrevet at du vil tage en tur der er {distance} km lang og at du bruger {brændstof}");
            Console.ReadLine();

            fuelneeded = distance / kmL;
            pris = fuelneeded * fuelPrice;


            Console.WriteLine($"Du bruger derfor {fuelneeded} brandstof til at komme derhend og prisen vil vaere {pris} kr");
            Console.WriteLine($"Bilmærke: {brand}");


            Console.WriteLine("_______________________________");

            Console.ReadLine();



        }
        static void IsPalidrome()
        {

            Console.WriteLine("nej tak <3");


        }
        static void PrintCarDetails()
        {
            if (kmL == 0)
            {
                Console.WriteLine("du har ikke intastet dine biloplysninger (option 2)");
                return;

            }
            if (fuelneeded == 0)
            {
                Console.WriteLine("du har ikke intastet dine distanceoplysninger (option 4)");
                return;

            }

            Console.WriteLine(udskrivBilData);
            Console.WriteLine($"Derudover er der beregnet at du skal bruge {fuelneeded} brandstof og at det koster dig {pris} kr ");

            Console.WriteLine();

            Console.WriteLine("_______________________________");

            Console.ReadLine();

        }
        static void PrintAllTeamCars()
        {



        }
    }
}
