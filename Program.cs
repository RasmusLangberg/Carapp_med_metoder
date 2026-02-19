using System;
using System.Reflection;
using System.Xml.Schema;

namespace hest
{
    internal class Program
    {


        static void Main(string[] args)
        {

            bool programmetKører = true;

            string Brand = "brand";
            string Model = "model";
            int Year = 0;
            int Kilometerstand = 0;
            double Kml = 0;
            string Geartype = "geartype";
            string Brændstof = "brændstof";
            bool BilInfoIndtastet = false;

            Indtroduktion();

            while (programmetKører)
            {
                BilInfoIndtastet = false;
                Console.WriteLine("=======================================");
                Console.WriteLine("============== HOVEDMENU ==============");
                Console.WriteLine("=======================================");
                Console.WriteLine(" 1) Indtast Bil information ");
                Console.WriteLine(" 2) Køre simulator ");
                Console.WriteLine(" 3) Køretur simulator");
                Console.WriteLine(" 4) Køreturs berenger");
                Console.WriteLine(" 5) Er kilometertallet på bilen en palidrome? f.eks 112211");
                Console.WriteLine(" 6) Print bil detailer");
                Console.WriteLine(" 7) Afslut program");

                string BrugerInput = Console.ReadLine();

                switch (BrugerInput)
                {
                    case "1":
                        bilinfo(ref Brand, ref Model, ref Year, ref Kilometerstand, ref Kml, ref Geartype, ref Brændstof);
                        break;

                    case "2":
                        if (BilInfoIndtastet == false)
                        {
                            Console.WriteLine("du skal Indtaste bil information før du kan bruge køre simulatoren");
                            BilInfoIndtastet = true;
                        }
                        else if (BilInfoIndtastet = false) ;
                
                            Køretur(ref Kilometerstand);
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

                        break;
                }

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

            static void Køretur(ref int Kilometerstand)
            {
                
                bool ManglerSvarMotor = false;
                while (ManglerSvarMotor == false)
                {

                  Console.WriteLine("Er din motor tændt?  (JA/NEJ)  ");

                    string Motorsvar = Console.ReadLine();

                    if (Motorsvar == "ja")
                    {
                        Console.WriteLine("Hvor mange kilometer køre du?");
                        int afstand = Convert.ToInt32 (Console.ReadLine());

                        int Nyafstand = afstand + Kilometerstand;


                    }



                }
                

            
            
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


            // ref kalder på de variable defineret unde i main -- ref går begge veje så variabler opdatere også ude i main 

            static void bilinfo(ref string Brand, ref string Model, ref int Year, ref int Kilometerstand, ref double Kml, ref string Geartype, ref string Brændstof)
            {

                Console.WriteLine(" ");
                Console.Write("  Indtast dit bilmærke:");
                Brand = Console.ReadLine();


                Console.Write("  Indtast din bilmodel:");
                Model = Console.ReadLine();

                Console.Write("  Indtast bilens årgang (YYYY):");
                Year = Convert.ToInt32(Console.ReadLine());

                Console.Write("  Indtast hvor langt bilen har kørt:");
                Kilometerstand = Convert.ToInt32(Console.ReadLine());

                Console.Write("  Indtast brændstofforbrug i km/l (XX,X):");
                Kml = (Convert.ToDouble(Console.ReadLine()));


                Console.Write("  Indtast bilens geartype (Manuel/Automatisk):");
                Geartype = Console.ReadLine();


                Console.Write("  Indtast brændstof type (Benzin/Diesel):");
                Brændstof = (Console.ReadLine().ToLower());

                
            }

















































        }
    }
}
