using Klassen_Bestelling_Gasten.Model;

namespace Klassen_Bestelling_Gasten
{
    class Program
    {
        static void Main(string[] args)
        {
            Gast gast1 = new Gast
            {
                GastID = 1,
                Naam = "Chris Joosten"
            };
            Bestelling bestelling1 = new Bestelling
            {
                BestelNummer = 1,
                BestelDatum = new DateOnly(2025, 12, 8),
                BestelTijd = new TimeOnly(17, 38, 05),
                Omschrijving = "Hamburger"
            };

            bestelling1.Gast = gast1;

            gast1.Bestellingen.Add(bestelling1);


            Console.WriteLine($"Gast: {gast1.Naam} (ID: {gast1.GastID})");
            Console.WriteLine($"Bestelling voor {bestelling1.Gast.Naam}:");
            Console.WriteLine($"- {bestelling1.Omschrijving} (Bestelnummer: {bestelling1.BestelNummer})");
        }
    }
}