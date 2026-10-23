using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> English = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "Main" },

            { "Group.Streets", "Streets" },
            { "Group.Districts", "Districts" },
            { "Group.CustomFile", "Custom names files" },

            { "Label.RenameStreets", "Name new streets automatically" },
            { "Desc.RenameStreets", "Give newly built streets a random name from the selected name sources." },

            { "Label.RenameDistricts", "Name new districts automatically" },
            { "Desc.RenameDistricts", "Give newly drawn districts a random name from the selected name sources." },

            { "Label.StreetWordLists", "Vanilla names" },
            { "Desc.StreetWordLists", "Pick from the game's vanilla street names." },

            { "Label.StreetSyllables", "Curated names" },
            { "Desc.StreetSyllables", "Generate names from pre-built custom prefixes, names, and suffixes. Think of this as an extension pack to street names." },

            { "Label.StreetCustomFile", "Custom names file" },
            { "Desc.StreetCustomFile", "Pick street names from StreetNames.txt. Skipped while the file is empty. Press 'Open names folder' below to edit the file and add your own names." },

            { "Label.DistrictWordLists", "Vanilla names" },
            { "Desc.DistrictWordLists", "Pick from the game's vanilla district names." },

            { "Label.DistrictSyllables", "Curated names" },
            { "Desc.DistrictSyllables", "Generate names from pre-built custom prefixes, names, and suffixes. Think of this as an extension pack to district names." },

            { "Label.DistrictCustomFile", "Custom names file" },
            { "Desc.DistrictCustomFile", "Pick district names from DistrictNames.txt. Skipped while the file is empty. Press 'Open names folder' below to edit the file and add your own names." },

            { "Label.OpenNamesFolder", "Open names folder" },
            { "Desc.OpenNamesFolder", "Open the folder containing StreetNames.txt and DistrictNames.txt. Put one name per line; lines starting with # are ignored." },

            { "Label.ReloadNamesFile", "Reload names files" },
            { "Desc.ReloadNamesFile", "Re-read StreetNames.txt and DistrictNames.txt after you edit them." },

            { "UI.RandomName", "Random name" },
        };
    }
}
