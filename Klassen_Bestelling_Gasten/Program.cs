using Klassen_Bestelling_Gasten.Model;

namespace Klassen_Bestelling_Gasten
{
    class Program
    {
        static void Main(string[] args)
        {
            Gast gast1 = new Gast();
            gast1.GastID = 1;
            gast1.Naam = "Chris Joosten";

            Console.WriteLine($"Naam: {gast1.Naam}");

            Bestelling bestelling1 = new Bestelling();
            bestelling1.BestelNummer = 1;
            bestelling1.BestelDatum = new DateOnly(2025, 12, 8); // (Jaar-Maand-Dag)
            bestelling1.BestelTijd = new TimeOnly(17, 38, 05);
            bestelling1.Omschrijving = "Hamburger";

            Console.WriteLine($"Besteld gerecht: {bestelling1.Omschrijving}, op {bestelling1.BestelDatum}, om {bestelling1.BestelTijd}.");
        }
    }
}