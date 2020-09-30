using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Du är den enda som överlevde krashlandningen och du befinner dig på en öde ö, du har ingen mat eller vatten men du landade på stranden. Ska du 1. gå ut och leta efter mat och vatten eller 2. stanna vid flyget? (skriv endast i nummer)");
            string val = Console.ReadLine();
            val = val.ToLower();
            if (val == "1")
            {
                Console.WriteLine("Du bestämmer dig för att gå ut och leta efter mat och vatten, tyvärr så missade du ett fartyg som åkte förbi ön och för att göra saker värre så hitta du inget ätbart. Hungrig och trött så går du tillbaka in i flyget nu när det är mörkt. ska du 1. begrava alla de döda i flyget och sen sova i flyget, eller 2. bygga en brasa vid stranden för att fånga de förbipasserande fartygens uppmärksamhet?");
                string döende = Console.ReadLine();
                döende = döende.ToLower();
                if (döende == "1")
                {
                    Console.WriteLine("Det kräver för mycket energi av dig för att begrava alla kroppar, du bestämmer dig därför att sova på stranden. Du dör av hypertermi");
                }
                if (döende == "2")
                {
                    Console.WriteLine("Du bygger brasan men du har inte verktygen för att tända den, du spenderar den kommande veckan på Ön där du eventuellt dör utav svält.");
                }
            }
            if (val == "2")
            {
                Console.WriteLine("Du bestämmer dig för att stanna vid flyget. Ska du 1. bygga en S.O.S. markering på stranden eller ska du 2. försöka göra rent vatten utav saltvatten?");
                string val2 = Console.ReadLine();
                val2 = val2.ToLower();
                if (val2 == "1")
                {
                Console.WriteLine("Ett fartyg åker förbi ön och märker till din snygga S.O.S. markerig på stranden och räddar dig.");
                }
                if (val2 == "2")
                {
                Console.WriteLine("Du hinner dö av törst innan du lyckas göra rent vatten");
                }
            }
        }
    }
}
