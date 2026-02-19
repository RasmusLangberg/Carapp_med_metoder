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
            double afstand = 0;
            string BrændstofBogstav = "";

            Indtroduktion();
            Console.ReadKey();
            Console.Clear();
            while (programmetKører)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("============== HOVEDMENU ==============");
                Console.WriteLine("=======================================");
                Console.WriteLine(" 1) Indtast Bil information ");
                Console.WriteLine(" 2) Kører simulator ");
                Console.WriteLine(" 3) Brændstof berenger");
                Console.WriteLine(" 4) Er kilometertallet på bilen en palidrome? f.eks 112211");
                Console.WriteLine(" 5) ");
                Console.WriteLine(" 6) Print bil detailer");
                Console.WriteLine(" 7) Afslut program");

                string BrugerInput = Console.ReadLine();
                Console.Clear();

                switch (BrugerInput)
                {
                    case "1":

                        bilinfo(ref Brand, ref Model, ref Year, ref Kilometerstand, ref Kml, ref Geartype, ref Brændstof, ref BilInfoIndtastet, ref BrændstofBogstav);
                        break;

                    case "2":

                        if (BilInfoIndtastet == false)
                        {
                            Console.WriteLine("du skal Indtaste bil information før du kan bruge køre simulatoren");
                            BilInfoIndtastet = true;
                        }
                        else
                        {
                            Køretur(ref Kilometerstand);
                        } 
                               
                        break;

                    case "3":
                        KøreturBeregn(ref Brændstof, ref afstand, ref BrændstofBogstav, ref Kml);
                        break;

                    case "4":
                       
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
                Console.WriteLine("===========================================");
                Console.WriteLine("============== KØRESIMULATER ==============");
                Console.WriteLine("===========================================");
                bool ManglerSvarMotor = false;
                while (ManglerSvarMotor == false)
                {

                  Console.WriteLine("Er din motor tændt?  (JA/NEJ)  ");

                    string Motorsvar = Console.ReadLine().ToLower();

                    if (Motorsvar == "ja")
                    {
                        Console.WriteLine("Hvor Langt er der til din distination? (km)");
                        int afstand = Convert.ToInt32 (Console.ReadLine());

                        int Nyafstand = afstand + Kilometerstand;

                        Console.WriteLine($"Dit Kilometertæller vil nu stå på {Nyafstand}, jeg håber det var en god tur!");
                        Console.WriteLine("");
                        Console.WriteLine("Tyrk på en vilkårlig tast for at komme tilbage til menuen");
                        Console.ReadKey();

                        ManglerSvarMotor = true;
                    }
                }
            }

            static void KøreturBeregn(ref string Brændstof, ref double afstand, ref string BrændstofBogstav, ref double Kml)
            {
                double antalLiterBrændstof = afstand / Kml;

                double d = 12.29; // benzin pris

                double b = 13.49; // diesel pris


                if (afstand >= 0 && (BrændstofBogstav == "d" || BrændstofBogstav == "b") )
                {

                    if (BrændstofBogstav == "b")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("============== RESULTAT ==============");
                        Console.WriteLine($" Din bil kommer til at bruge {antalLiterBrændstof} Diesel. Prisen ville være {antalLiterBrændstof * b }");
                    }

                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("============== RESULTAT ==============");
                        Console.WriteLine($" Din bil kommer til at bruge {antalLiterBrændstof} Diesel. Prisen ville være {antalLiterBrændstof * d }");

                    }


                }

                else
                {
                    Console.WriteLine("Du mangler og indtaste bil information gå tilbage i menuen ");
                   Console.ReadKey();
                    
                }




            }







            static void AfslutProgram()
            {
                Console.WriteLine("Tryk enter for at lukke programmet");
                Console.ReadLine();
                Environment.Exit(0);
            }


            // ref kalder på de variable defineret unde i main -- ref går begge veje så variabler opdatere også ude i main 

            static void bilinfo(ref string Brand, ref string Model, ref int Year, ref int Kilometerstand, ref double Kml, ref string Geartype, ref string Brændstof, ref bool BilInfoIndtastet, ref string BrændstofBogstav)
            {

                Console.WriteLine("==========================================");
                Console.WriteLine("============== BILINFO ==================");
                Console.WriteLine("==========================================");



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
                BrændstofBogstav = Brændstof[0].ToString();

                BilInfoIndtastet = true;
            }

















































        }
    }
}
