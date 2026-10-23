using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> German = new Dictionary<string, string>
        {
            { "Title", "Random Names Generator" },
            { "Tab.Main", "Allgemein" },

            { "Group.Streets", "Straßen" },
            { "Group.Districts", "Bezirke" },
            { "Group.CustomFile", "Eigene Namensdateien" },

            { "Label.RenameStreets", "Neue Straßen automatisch benennen" },
            { "Desc.RenameStreets", "Gibt neu gebauten Straßen einen zufälligen Namen aus den ausgewählten Namensquellen." },

            { "Label.RenameDistricts", "Neue Bezirke automatisch benennen" },
            { "Desc.RenameDistricts", "Gibt neu gezeichneten Bezirken einen zufälligen Namen aus den ausgewählten Namensquellen." },

            { "Label.StreetWordLists", "Vanilla-Namen" },
            { "Desc.StreetWordLists", "Wählt aus den originalen Straßennamen des Spiels." },

            { "Label.StreetSyllables", "Kuratierte Namen" },
            { "Desc.StreetSyllables", "Erzeugt Namen aus vorgefertigten eigenen Präfixen, Namen und Suffixen. Stell es dir als Erweiterungspaket für Straßennamen vor." },

            { "Label.StreetCustomFile", "Eigene Namensdatei" },
            { "Desc.StreetCustomFile", "Wählt Straßennamen aus StreetNames.txt. Wird übersprungen, solange die Datei leer ist. Klicke unten auf „Namensordner öffnen“, um die Datei zu bearbeiten und eigene Namen hinzuzufügen." },

            { "Label.DistrictWordLists", "Vanilla-Namen" },
            { "Desc.DistrictWordLists", "Wählt aus den originalen Bezirksnamen des Spiels." },

            { "Label.DistrictSyllables", "Kuratierte Namen" },
            { "Desc.DistrictSyllables", "Erzeugt Namen aus vorgefertigten eigenen Präfixen, Namen und Suffixen. Stell es dir als Erweiterungspaket für Bezirksnamen vor." },

            { "Label.DistrictCustomFile", "Eigene Namensdatei" },
            { "Desc.DistrictCustomFile", "Wählt Bezirksnamen aus DistrictNames.txt. Wird übersprungen, solange die Datei leer ist. Klicke unten auf „Namensordner öffnen“, um die Datei zu bearbeiten und eigene Namen hinzuzufügen." },

            { "Label.OpenNamesFolder", "Namensordner öffnen" },
            { "Desc.OpenNamesFolder", "Öffnet den Ordner mit StreetNames.txt und DistrictNames.txt. Ein Name pro Zeile; Zeilen, die mit # beginnen, werden ignoriert." },

            { "Label.ReloadNamesFile", "Namensdateien neu laden" },
            { "Desc.ReloadNamesFile", "Liest StreetNames.txt und DistrictNames.txt neu ein, nachdem du sie bearbeitet hast." },

            { "UI.RandomName", "Zufälliger Name" },
        };
    }
}
