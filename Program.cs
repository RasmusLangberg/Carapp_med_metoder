namespace CarMenuApp
{
    internal class Program

    static string brand;
    static string model;
    static int year;
    static int odometer;
    static double kmPerLiter;
    static bool isEngineOn = false;

    {
        static void Main(string[] args)
    {
        ShowWelcome();






        bool IsRunning = true;

        while (IsRunning)
        {
            Console.WriteLine("\n------- HOVEDMENU -------");
            Console.WriteLine("1) Introduktion");
            Console.WriteLine("2) Indlæs Bil info");
            Console.WriteLine("3) Start motor");
            Console.WriteLine("4) Beregn tur pris");
            Console.WriteLine("5) Tjek palindrom km");
            Console.WriteLine("6) Afslut");

            Console.Write("\nVælg:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReadCarDetails();
                    break;

                case "2":
                    isEngineOn = true;
                    Console.WriteLine("Motor started");
                    break;

                case "3":
                    DriveInfo();
                    break;

                case "4":
                    CalculaterTripPrice();
                    break;

                case "5":
                    CheckPalindrome();
                    break;
                case "6":
                    PrintCarDetails();
                case "7":
                    PrintAllTeamCars();
                    break;
                case "8":
                    IsRunning = false;
                    Console.WriteLine("Program afsluttes..");
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;

                    }
                 // --- STARTSKÆRMEN---

            static void ShowWelcome()



            }

















        }
    }
}
