using iScent.Models;

namespace iScent.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Parfums.Any()) return; // Bereits befüllt

            var parfums = new List<Parfum>
            {
                new Parfum
                {
                    Name = "Dior Sauvage",
                    Marke = "Dior",
                    Beschreibung = "Frischer, würziger Herrenduft mit einem modernen Twist.",
                    Kopfnote = "Bergamotte, Pfeffer",
                    Herznote = "Lavendel, Sichuanpfeffer",
                    Basisnote = "Ambroxan, Vetiver",
                    BildUrl = "/images/sauvage.svg"
                },
                new Parfum
                {
                    Name = "Miss Dior Eau de Parfum",
                    Marke = "Dior",
                    Beschreibung = "Romantischer, blumiger Damenduft mit Noten von Rose und Pfingstrose.",
                    Kopfnote = "Pfingstrose, Bergamotte",
                    Herznote = "Rose, Iris",
                    Basisnote = "Vanille, Moschus",
                    BildUrl = "/images/missdior.svg"
                },
               new Parfum
                {
                    Name = "Bleu de Chanel",
                    Marke = "Chanel",
                    Beschreibung = "Eleganter, holziger Duft für moderne Männer.",
                    Kopfnote = "Zitrone, Minze",
                    Herznote = "Ingwer, Muskat",
                    Basisnote = "Sandelholz, Weihrauch",
                    BildUrl = "/images/bleudechanel.svg"
                },
                new Parfum
                {
                    Name = "La Vie Est Belle",
                    Marke = "Lancôme",
                    Beschreibung = "Süßer, femininer Duft mit floralen Noten.",
                    Kopfnote = "Birne, schwarze Johannisbeere",
                    Herznote = "Iris, Jasmin, Orangenblüte",
                    Basisnote = "Vanille, Praline, Tonkabohne",
                    BildUrl = "/images/lavieestbelle.svg"
                },
                new Parfum
                {
                    Name = "YSL Libre",
                    Marke = "Yves Saint Laurent",
                    Beschreibung = "Blumig-frischer Damenduft mit Lavendel und Orange.",
                    Kopfnote = "Mandarine, Lavendel",
                    Herznote = "Jasmin, Orangenblüte",
                    Basisnote = "Zedernholz, Moschus",
                    BildUrl = "/images/ysl-libre.svg"
                },
                new Parfum
                {
                    Name = "Acqua di Gio Profumo",
                    Marke = "Giorgio Armani",
                    Beschreibung = "Frisch-aquatischer Herrenduft mit tiefen, maskulinen Noten.",
                    Kopfnote = "Bergamotte, Meeresnoten",
                    Herznote = "Rosmarin, Geranie",
                    Basisnote = "Patchouli, Weihrauch",
                    BildUrl = "/images/acquadigio.svg"
                },
                new Parfum
                {
                    Name = "Black Opium",
                    Marke = "Yves Saint Laurent",
                    Beschreibung = "Sinnlicher, süß-würziger Damenduft mit Kaffeenoten.",
                    Kopfnote = "Rosa Pfeffer, Birne",
                    Herznote = "Kaffee, Jasmin",
                    Basisnote = "Vanille, Zeder, Patchouli",
                    BildUrl = "/images/blackopium.svg"
                },
                 new Parfum
                {
                    Name = "Tom Ford Oud Wood",
                    Marke = "Tom Ford",
                    Beschreibung = "Exotischer, holziger Duft mit edlem Oud.",
                    Kopfnote = "Rosenholz, Kardamom",
                    Herznote = "Oud, Sandelholz",
                    Basisnote = "Vanille, Tonkabohne, Amber",
                    BildUrl = "/images/oudwood.svg"
                },
                new Parfum
                {
                    Name = "Chanel Chance Eau Tendre",
                    Marke = "Chanel",
                    Beschreibung = "Zarter, fruchtig-blumiger Duft für Frauen.",
                    Kopfnote = "Grapefruit, Quitte",
                    Herznote = "Jasmin, Hyazinthe",
                    Basisnote = "Moschus, Iris, Zeder",
                    BildUrl = "/images/chance.svg"
                },
                new Parfum
                {
                    Name = "Jean Paul Gaultier Le Male",
                    Marke = "Jean Paul Gaultier",
                    Beschreibung = "Charismatischer Duft mit Lavendel und Vanille.",
                    Kopfnote = "Minze, Lavendel",
                    Herznote = "Zimt, Kreuzkümmel",
                    Basisnote = "Vanille, Tonkabohne, Amber",
                    BildUrl = "/images/lemale.svg"
                },
                new Parfum
                {
                    Name = "Armani My Way",
                    Marke = "Giorgio Armani",
                    Beschreibung = "Moderner, femininer Duft mit weißen Blüten.",
                    Kopfnote = "Bergamotte, Orangenblüte",
                    Herznote = "Tuberose, Jasmin",
                    Basisnote = "Zedernholz, Vanille, Moschus",
                    BildUrl = "/images/myway.svg"
                },
                new Parfum
                {
                    Name = "Versace Eros",
                    Marke = "Versace",
                    Beschreibung = "Intensiver, frischer Herrenduft mit Apfel und Minze.",
                    Kopfnote = "Minze, grüner Apfel, Zitrone",
                    Herznote = "Tonkabohne, Geranie, Ambroxan",
                    Basisnote = "Vanille, Zeder, Vetiver",
                    BildUrl = "/images/eros.svg"
                }
            };
            context.Parfums.AddRange(parfums);
            context.SaveChanges();
        }
    }
}
