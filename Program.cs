using System;
using System.Reflection;

namespace hest
{
    internal class Program
    {

        

        static void Main(string[] args)
        {

            bool programmetKører = true;

            string Brand;
            string Model;
            int Year;
            int Kilometerstand;
            double Kml;
            string Geartype;
            string Brændstof;


            while (programmetKører)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("============== HOVEDMENU ==============");
                Console.WriteLine("=======================================");
                Console.WriteLine(" 1) Introduktion");
                Console.WriteLine(" 2) Indtast Bil information");
                Console.WriteLine(" 3) Køretur simulator");
                Console.WriteLine(" 4) Køreturs berenger");
                Console.WriteLine(" 5) Er kilometertallet på bilen en palidrome? f.eks 112211");
                Console.WriteLine(" 6) Print bil detailer");
                Console.WriteLine(" 7) Afslut program");

                string BrugerInput = Console.ReadLine();

                switch (BrugerInput)
                {
                    case "1":
                        Indtroduktion();
                        break;

                    case "2":

                        bilinfo();
                        break;

                    case "3":
                        
                        break;

                    case "4":
                        KøreturBeregn();
                        break;
                    case "5":
                        AfslutProgram();
                        break;
                    case "6":
                        BilTabel();
                        break;
                }


                static void Indtroduktion()
                {
                    Console.WriteLine("==========================================");
                    Console.WriteLine("============== INTRODUKTION ==============");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("Velkommen til denne bilapp. \nmed bilappen kan du indtaste data fra kundens bil");
                    Console.WriteLine("");
                    Console.WriteLine("tryk ENTER for at at vende tilbage til hovedmenuen");
                    
                }

               

                static void KøreturBeregn()
                {
                    Console.WriteLine("Tryk enter for at lukke programmet");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                static void AfslutProgram()
                {
                    Console.WriteLine("Tryk enter for at lukke programmet");
                    Console.ReadLine();
                    Environment.Exit(0);
                }




                static void bilinfo()
                {

                    Console.WriteLine(" ");
                    Console.Write("  Indtast dit bilmærke:");
                    string Brand = Console.ReadLine();


                    Console.Write("  Indtast din bilmodel:");
                    string Model = Console.ReadLine();

                    Console.Write("  Indtast bilens årgang (YYYY):");
                    int Year = Convert.ToInt32(Console.ReadLine());

                    Console.Write("  Indtast hvor langt bilen har kørt:");
                    int Kilometerstand = Convert.ToInt32(Console.ReadLine());

                    Console.Write("  Indtast brændstofforbrug i km/l (XX,X):");
                    double kml = (Convert.ToDouble(Console.ReadLine()));


                    Console.Write("  Indtast bilens geartype (Manuel/Automatisk):");
                    string Geartype = Console.ReadLine();

                   
                    Console.Write("  Indtast brændstof type (Benzin/Diesel):");
                    string Brændstof = (Console.ReadLine().ToLower());

                    

                }
              
                


                static void BilTabel(string Brand)
                {
                    Console.WriteLine($"{Brand}");




                }
















                static void Køretur(string Brand)
                {
                   
                
                
                
                
                
                
                
                
                }

                     







































                
                

            }
         }  
        
    }
}
