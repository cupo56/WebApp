namespace iScent.Models
{
    public class Parfum
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Marke { get; set; }
        public string? Beschreibung { get; set; }

        public string? Kopfnote { get; set; }
        public string? Herznote { get; set; }
        public string? Basisnote { get; set; }

        public string? BildUrl { get; set; }
    }
}
