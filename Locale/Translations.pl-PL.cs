using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Polish = new Dictionary<string, string>
        {
            { "Title", "Random Names Generator" },
            { "Tab.Main", "Główne" },

            { "Group.Streets", "Ulice" },
            { "Group.Districts", "Dzielnice" },
            { "Group.CustomFile", "Własne pliki nazw" },

            { "Label.RenameStreets", "Automatycznie nazywaj nowe ulice" },
            { "Desc.RenameStreets", "Nadaje nowo zbudowanym ulicom losową nazwę z wybranych źródeł nazw." },

            { "Label.RenameDistricts", "Automatycznie nazywaj nowe dzielnice" },
            { "Desc.RenameDistricts", "Nadaje nowo wyznaczonym dzielnicom losową nazwę z wybranych źródeł nazw." },

            { "Label.StreetWordLists", "Nazwy z gry" },
            { "Desc.StreetWordLists", "Wybiera spośród oryginalnych nazw ulic z gry." },

            { "Label.StreetSyllables", "Wyselekcjonowane nazwy" },
            { "Desc.StreetSyllables", "Tworzy nazwy z gotowych, własnych przedrostków, nazw i przyrostków. Potraktuj to jako dodatek rozszerzający nazwy ulic." },

            { "Label.StreetCustomFile", "Własny plik nazw" },
            { "Desc.StreetCustomFile", "Wybiera nazwy ulic z pliku StreetNames.txt. Pomijane, dopóki plik jest pusty. Kliknij „Otwórz folder z nazwami” poniżej, aby edytować plik i dodać własne nazwy." },

            { "Label.DistrictWordLists", "Nazwy z gry" },
            { "Desc.DistrictWordLists", "Wybiera spośród oryginalnych nazw dzielnic z gry." },

            { "Label.DistrictSyllables", "Wyselekcjonowane nazwy" },
            { "Desc.DistrictSyllables", "Tworzy nazwy z gotowych, własnych przedrostków, nazw i przyrostków. Potraktuj to jako dodatek rozszerzający nazwy dzielnic." },

            { "Label.DistrictCustomFile", "Własny plik nazw" },
            { "Desc.DistrictCustomFile", "Wybiera nazwy dzielnic z pliku DistrictNames.txt. Pomijane, dopóki plik jest pusty. Kliknij „Otwórz folder z nazwami” poniżej, aby edytować plik i dodać własne nazwy." },

            { "Label.OpenNamesFolder", "Otwórz folder z nazwami" },
            { "Desc.OpenNamesFolder", "Otwiera folder zawierający StreetNames.txt i DistrictNames.txt. Wpisz jedną nazwę w wierszu; wiersze zaczynające się od # są pomijane." },

            { "Label.ReloadNamesFile", "Wczytaj ponownie pliki nazw" },
            { "Desc.ReloadNamesFile", "Ponownie wczytuje StreetNames.txt i DistrictNames.txt po ich edycji." },

            { "UI.RandomName", "Losowa nazwa" },
        };
    }
}
