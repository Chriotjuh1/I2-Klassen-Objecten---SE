using System.Collections.Generic;

namespace Klassen_Bestelling_Gasten.Model
{
    public class Gast
    {
        // Ik gebruik hier properties om de toegang mee te controleren
        public int GastID { get; set; }
        public string Naam { get; set; }
        public string Telefoonnummer { get; set; }
        public List<Bestelling> Bestellingen { get; set; } = new List<Bestelling>();
    }
}