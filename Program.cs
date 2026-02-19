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
                Console.WriteLine("2) Lav en beregning");
                Console.WriteLine("3) Afslut");
                Console.Write("\nVælg en mulighed: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowIntro();
                        break;
                    case "2":
                        PerformCalculation();
                        break;
                    case "3":
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

        static void PerformCalculation()
        {
            try
            {
                Console.Write("Indtast tal A: ");
                double numberA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Indtast tal B: ");
                double numberB = Convert.ToDouble(Console.ReadLine());

                double result = numberA + numberB;
                Console.WriteLine($"Resultatet af {numberA} + {numberB} er: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Fejl: Indtast venligst et gyldigt tal.");
            }
        }
    }
}
