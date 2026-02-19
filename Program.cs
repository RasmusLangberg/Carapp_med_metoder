namespace hest
// Kats version
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool programmetKører = true;

            while (programmetKører)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("============== HOVEDMENU ==============");
                Console.WriteLine("=======================================");
                Console.WriteLine(" 1) Introduktion");
                Console.WriteLine(" 2) Indtast bil oplysninger på kunden");
                Console.WriteLine(" 3) Afslut programmet");

                string BrugerInput = Console.ReadLine();

                switch (BrugerInput)
                {
                    case "1":
                        Indtroduktion();
                        break;

                    case "2":

                        Bilapp();
                        break;

                    case "3":
                        AfslutProgram();
                        break;
                }


                static void Indtroduktion()
                {

                    Console.WriteLine("Velkommen til denne bilapp. \nmed bilappen kan du indtaste data fra kundens bil \nog hvad problemet var så du kan huske det når du har tid på bærkstedet");
                    Console.WriteLine("tryk enter for at at vende tilbage til hovedmenuen");


                }

                static void AfslutProgram()
                {
                    Console.WriteLine("Tryk enter for at lukke programmet");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                static void Bilapp()
                {



                    Console.WriteLine(" ");
                    Console.Write("  Indtast dit bilmærke:");
                    string brand = Console.ReadLine();

                    Console.Write("  Indtast din bilmodel:");
                    string model = Console.ReadLine();


                    int year = 0;
                    bool ManglerInputÅr = true;

                    Console.Write("  Indtast bilens årgang (YYYY):");

                    while (ManglerInputÅr == true)
                    {
                        try
                        {
                            Console.Write("  Indtast bilens årgang (YYYY):");
                            year = Convert.ToInt32(Console.ReadLine());
                            ManglerInputÅr = false;
                        }
                        catch { }
                        Console.WriteLine("Ugyldigt input! Indtast venligst et tal (f.eks. 1997):");
                    }



                    Console.Write("  Indtast bilens geartype (Manuel/Automatisk):");
                    string gearType = Console.ReadLine();

                    // Oprindligt char men skiftet til string fordi det ikke var nogen grund - skal bruge det fulde navn i tabellen
                    Console.Write("  Indtast brændstof type (Benzin/Diesel):");
                    string brændstof = (Console.ReadLine().ToLower());

                    Console.Write("  Indtast brændstofforbrug i km/l (XX,X):");
                    double kml = (Convert.ToDouble(Console.ReadLine()));

                    Console.Write("  Indtast hvor langt bilen har kørt:");
                    int Kilometerstand = Convert.ToInt32(Console.ReadLine());







                    //liste over data til brugeren med mellemrum, så det ikke flyder sammen med det ovenover
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("============== INDTASTET DATA ==============");
                    Console.WriteLine($"  Bilmærke: {brand.ToUpper()}");
                    Console.WriteLine($"  Bilmodel: {model.ToUpper()}");
                    Console.WriteLine($"  Årgang: {year}");
                    Console.WriteLine($"  Geartype: {gearType.ToUpper()}");
                    Console.WriteLine($"  Brændstof: {brændstof.ToUpper()}");
                    Console.WriteLine($"  Km/l: {kml}");
                    Console.WriteLine($"  Kilometerstand: {Kilometerstand}");


                    // Test om data er korrekt 
                    Console.WriteLine(" ");
                    Console.WriteLine("Har du indtastet det korrekte data? (Ja/nej)");
                    String Svar = Console.ReadLine().ToLower();

                    if (Svar == "nej")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Programmet Lukker... Prøv igen");
                        Environment.Exit(0);
                    }

                    // hvis data er korrekt forsætter man
                    else
                    {

                        //brændstofprisernes variables datatyper defineret



                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("============== AFSTANDS BEREGNER==============");
                        Console.Write("  Indtast afstand til destinationen i km:");
                        double Afstand = Convert.ToDouble(Console.ReadLine());


                        // Opgave 4  ---------------------------------------------------------------------------------------------------------------------

                        // konvertere string brændstof til char (første bogstav) og beregner antal liter, og definere brændstof priser
                        char BrændstofChar = brændstof[0];

                        double antalLiterBrændstof = Afstand / kml;

                        double d = 12.29;

                        double b = 13.49;

                        // vi sætter før og nu afstand sammen 
                        int NyKilometerTal = Kilometerstand + (int)Afstand;


                        // her bruger jeg logic gates - oversat: afstand støøre end 0 OG brændstof er LIG 'd' ELLER 'b' (statement)
                        if (Afstand >= 0 && BrændstofChar == 'd' || BrændstofChar == 'b')
                        {

                            if (BrændstofChar == 'b')
                            {
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("============== RESULTAT ==============");
                                string formattest1 = String.Format("  Din bil kommer til at bruge {0:F2} liter benzin. Det kommer til at koste: {1:F2}\n   Den oprindlige kilometertal var {2}, og det nye kilometertal er nu {3}"
                                    , antalLiterBrændstof, antalLiterBrændstof * b, Kilometerstand, NyKilometerTal);
                                Console.WriteLine(formattest1);
                                Console.WriteLine("");
                                Console.WriteLine("");
                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("============== RESULTAT ==============");
                                string formattest1 = String.Format("  Din bil kommer til at bruge {0:F2} liter diesel. Det kommer til at koste: {1:F2}\n   Den oprindlige kilometertal var {2}, og det nye kilometertal er nu {3}"
                                    , antalLiterBrændstof, antalLiterBrændstof * d, Kilometerstand, NyKilometerTal);
                                Console.WriteLine(formattest1);
                                Console.WriteLine("");
                                Console.WriteLine("");

                            }


                        }

                        else
                        {
                            Console.WriteLine("Fejl... Programmet lukker");
                            Environment.Exit(0);
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }


                        // 4.2 lav tabel med pads (padleft og padright) --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



                        // pads virker kun på stirng --> datayper skal konverteres 
                        // pads skal være lidt større end det længeste tal (16) jeg har valgt 18



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

                        string BrandTabel2 = brand.PadLeft(18).PadRight(18);
                        string ModelTabel2 = model.PadLeft(18).PadRight(18);
                        string årTabel2 = year.ToString("F0").PadLeft(18).PadRight(18);
                        string GearTabel2 = gearType.ToString().PadLeft(18).PadRight(18);
                        string BrændstofTabel2 = brændstof.ToString().PadLeft(18).PadRight(18);
                        string kmlTabel2 = kml.ToString("F1").PadLeft(18).PadRight(18);
                        string kilometerstandTabel2 = Kilometerstand.ToString("F0").PadLeft(18).PadRight(18);
                        string NyeKilometertalTabel2 = NyKilometerTal.ToString().PadLeft(18).PadRight(18);



                        // mellemrum til tilpasning
                        string m = "".PadLeft(2).PadRight(2);

                        Console.WriteLine($"|{BrandTabel1}|{m}|{ModelTabel1}|{m}|{årTabel1}|{m}|{GearTabel1}|{m}|{BrændstofTabel1}|{m}|{kmlTabel1}|{m}|{kilometerstandTabel1}|{m}|{NyeKilometertalTabel1}|");
                        Console.WriteLine("=============================================================================================================================================================================");
                        Console.WriteLine($"|{BrandTabel2}|{m}|{ModelTabel2}|{m}|{årTabel2}|{m}|{GearTabel2.ToUpper()}|{m}|{BrændstofTabel2.ToUpper()}|{m}|{kmlTabel2}|{m}|{kilometerstandTabel2}|{m}|{NyeKilometertalTabel2}|");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Tryk enter for at vende tilbage til hovedmenuen");

                    }



                }


                Console.ReadLine();
            }
        }
    }
}
