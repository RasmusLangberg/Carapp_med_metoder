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
            double antalLiterBrændstof = 0;
            double d = 12.29;
            double b = 13.49;

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
                Console.WriteLine(" 5) Print bil detailer");
                Console.WriteLine(" 6) Afslut program");

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
                            Køretur(ref Kilometerstand, ref afstand);
                        } 
                               
                        break;

                    case "3":
                        KøreturBeregn(ref Brændstof, ref afstand, ref BrændstofBogstav, ref Kml, ref antalLiterBrændstof, ref d, ref b);
                        break;

                    case "4":
                       
                        break;
                    case "5":
                        Print(ref Brand, ref Model, ref Year, ref Kilometerstand, ref Kml, ref Geartype, ref Brændstof, ref BilInfoIndtastet, ref BrændstofBogstav, ref afstand);
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
                Console.WriteLine("");
                Console.WriteLine("Velkommen til denne bilapp. Med denne applikation \nkan du indtaste info om din bil, simulere kørsel,\nberegne brændstofpris, og meget mere");
                Console.WriteLine("");
                Console.WriteLine("tryk på en vilkårlig tast for at forsætte...");

            }





            static void Køretur(ref int Kilometerstand, ref double afstand)
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
                        afstand = Convert.ToDouble (Console.ReadLine());

                        double Nyafstand = afstand + Kilometerstand;

                        Console.WriteLine($"Dit Kilometertæller vil nu stå på {Nyafstand}, jeg håber det var en god tur!");
                        Console.WriteLine("");
                        Console.WriteLine("Tyrk på en vilkårlig tast for at komme tilbage til menuen");
                        Console.ReadKey();

                        ManglerSvarMotor = true;
                    }
                }
            }

            static void KøreturBeregn(ref string Brændstof, ref double afstand, ref string BrændstofBogstav, ref double Kml, ref double antalLiterBrændstof, ref double d, ref double b)
            {
                
                    antalLiterBrændstof = (afstand / Kml);

                if (BrændstofBogstav == "d" || BrændstofBogstav == "b")
                {

                    if (BrændstofBogstav == "b")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("============== RESULTAT ==============");
                        Console.WriteLine($" Din bil kommer til at bruge {antalLiterBrændstof} liter Benzin. Prisen ville være {antalLiterBrændstof * b }");
                        Console.ReadKey();
                    }

                    else if (BrændstofBogstav == "d")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("============== RESULTAT ==============");
                        Console.WriteLine($" Din bil kommer til at bruge {antalLiterBrændstof} Liter Diesel. Prisen ville være {antalLiterBrændstof * d }");
                        Console.ReadKey();
                    }


                }

                else
                {
                    Console.WriteLine("Du mangler og indtaste bil information gå tilbage i menuen ");
                   Console.ReadKey();
                    
                }




            }

            static void Print(ref string Brand, ref string Model, ref int Year, ref int Kilometerstand, ref double Kml, ref string Geartype, ref string Brændstof, ref bool BilInfoIndtastet, ref string BrændstofBogstav, ref double afstand)
            {

                // det her er kun til den øveste del af tabellen

                string BrandTabel1 = "BilMærke".PadLeft(18).PadRight(18);
                string ModelTabel1 = "Bilmodel".PadLeft(18).PadRight(18);
                string årTabel1 = "Årgang".PadLeft(18).PadRight(18);
                string GearTabel1 = "Geartype".PadLeft(18).PadRight(18);
                string BrændstofTabel1 = "Brændstof-type".ToString().PadLeft(18).PadRight(18);
                string kmlTabel1 = "km/l".PadLeft(18).PadRight(18);
                string kilometerstandTabel1 = "Kilometertal før".PadLeft(18).PadRight(18);
                string NyeKilometertalTabel1 = "Kilometertal efter".PadLeft(18).PadRight(18);


                // nu skal jeg så lave den nederste del af tabellen

                string BrandTabel2 = Brand.PadLeft(18).PadRight(18);
                string ModelTabel2 = Model.PadLeft(18).PadRight(18);
                string årTabel2 = Year.ToString("F0").PadLeft(18).PadRight(18);
                string GearTabel2 = Geartype.ToString().PadLeft(18).PadRight(18);
                string BrændstofTabel2 = Brændstof.ToString().PadLeft(18).PadRight(18);
                string kmlTabel2 = Kml.ToString("F1").PadLeft(18).PadRight(18);
                string kilometerstandTabel2 = Kilometerstand.ToString("F0").PadLeft(18).PadRight(18);
                



                // mellemrum til tilpasning
                string m = "".PadLeft(2).PadRight(2);

                Console.WriteLine($"|{BrandTabel1}|{m}|{ModelTabel1}|{m}|{årTabel1}|{m}|{GearTabel1}|{m}|{BrændstofTabel1}|{m}|{kmlTabel1}|{m}|{kilometerstandTabel1}|{m}|");
                Console.WriteLine("=============================================================================================================================================================================");
                Console.WriteLine($"|{BrandTabel2}|{m}|{ModelTabel2}|{m}|{årTabel2}|{m}|{GearTabel2.ToUpper()}|{m}|{BrændstofTabel2.ToUpper()}|{m}|{kmlTabel2}|{m}|{kilometerstandTabel2}|{m}|");
                Console.WriteLine("");
                Console.WriteLine($"{afstand}");
                Console.WriteLine("Tryk enter for at vende tilbage til hovedmenuen");
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
