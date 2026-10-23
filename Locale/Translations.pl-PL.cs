using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Polish = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "Główne" },

            { "Group.Streets", "Ulice" },
            { "Group.Districts", "Dzielnice" },
            { "Group.TransitLines", "Linie komunikacyjne" },
            { "Group.CustomFile", "Własne pliki nazw" },

            { "Label.RenameStreets", "Automatycznie nazywaj nowe ulice" },
            { "Desc.RenameStreets", "Nadaje nowo zbudowanym ulicom losową nazwę z wybranych źródeł nazw." },

            { "Label.RenameDistricts", "Automatycznie nazywaj nowe dzielnice" },
            { "Desc.RenameDistricts", "Nadaje nowo wyznaczonym dzielnicom losową nazwę z wybranych źródeł nazw." },

            { "Label.StreetWordLists", "Nazwy z gry" },
            { "Desc.StreetWordLists", "Wybiera spośród oryginalnych nazw ulic z gry." },

            { "Label.StreetSyllables", "Wyselekcjonowane nazwy" },
            { "Desc.StreetSyllables", "Tworzy nazwy z gotowych, własnych przedrostków, nazw i przyrostków. Potraktuj to jako dodatek rozszerzający nazwy ulic. Na razie nazwy są po angielsku." },

            { "Label.StreetCustomFile", "Własny plik nazw" },
            { "Desc.StreetCustomFile", "Wybiera nazwy ulic z pliku StreetNames.txt. Pomijane, dopóki plik jest pusty. Kliknij „Otwórz folder z nazwami” poniżej, aby edytować plik i dodać własne nazwy." },

            { "Label.DistrictWordLists", "Nazwy z gry" },
            { "Desc.DistrictWordLists", "Wybiera spośród oryginalnych nazw dzielnic z gry." },

            { "Label.DistrictSyllables", "Wyselekcjonowane nazwy" },
            { "Desc.DistrictSyllables", "Tworzy nazwy z gotowych, własnych przedrostków, nazw i przyrostków. Potraktuj to jako dodatek rozszerzający nazwy dzielnic. Na razie nazwy są po angielsku." },

            { "Label.DistrictCustomFile", "Własny plik nazw" },
            { "Desc.DistrictCustomFile", "Wybiera nazwy dzielnic z pliku DistrictNames.txt. Pomijane, dopóki plik jest pusty. Kliknij „Otwórz folder z nazwami” poniżej, aby edytować plik i dodać własne nazwy." },

            { "Label.RenameTransitLines", "Automatycznie nazywaj nowe linie komunikacyjne" },
            { "Desc.RenameTransitLines", "Nadaje nowo utworzonym liniom komunikacyjnym losową nazwę z wybranych źródeł nazw zamiast numerowanych nazw z gry." },

            { "Label.TransitLineSyllables", "Wyselekcjonowane nazwy" },
            { "Desc.TransitLineSyllables", "Tworzy nazwy takie jak „Red Line”, „Harbor Express” czy „Oakbrook–Ashford Line” z gotowych kolorów, miejsc i typów linii oraz nazw dzielnic twojego miasta. Na razie nazwy są po angielsku." },

            { "Label.TransitLineCustomFile", "Własny plik nazw" },
            { "Desc.TransitLineCustomFile", "Wybiera nazwy linii z pliku TransitLineNames.txt. Pomijane, dopóki plik jest pusty. Kliknij „Otwórz folder z nazwami” poniżej, aby edytować plik i dodać własne nazwy." },

            { "Label.OpenNamesFolder", "Otwórz folder z nazwami" },
            { "Desc.OpenNamesFolder", "Otwiera folder zawierający StreetNames.txt, DistrictNames.txt i TransitLineNames.txt. Wpisz jedną nazwę w wierszu; wiersze zaczynające się od # są pomijane." },

            { "Label.ReloadNamesFile", "Wczytaj ponownie pliki nazw" },
            { "Desc.ReloadNamesFile", "Ponownie wczytuje StreetNames.txt, DistrictNames.txt i TransitLineNames.txt po ich edycji." },

            { "UI.RandomName", "Losowa nazwa" },
        };
    }
}
