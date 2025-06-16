namespace Klassen_Bestelling_Gasten.Model
{
    public class Bestelling
    {
        // Properties voor gecontroleerde toegang
        public int BestelNummer { get; set; }
        public DateOnly BestelDatum { get; set; }
        public TimeOnly BestelTijd { get; set; }
        public string Omschrijving { get; set; }
        public decimal TotaalBedrag { get; set; }
        public Gast Gast { get; set; }
    }
}