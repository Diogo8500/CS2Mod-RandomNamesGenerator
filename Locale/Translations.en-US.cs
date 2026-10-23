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
            { "Group.TransitLines", "Transit lines" },
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

            { "Label.RenameTransitLines", "Name new transit lines automatically" },
            { "Desc.RenameTransitLines", "Give newly created transit lines a random name from the selected name sources, instead of the game's numbered names like \"Bus Line 3\"." },

            { "Label.TransitLineSyllables", "Curated names" },
            { "Desc.TransitLineSyllables", "Generate names like \"Red Line\", \"Harbor Express\" or \"Oakbrook–Ashford Line\" from pre-built colors, places and line types, and your city's district names." },

            { "Label.TransitLineCustomFile", "Custom names file" },
            { "Desc.TransitLineCustomFile", "Pick transit line names from TransitLineNames.txt. Skipped while the file is empty. Press 'Open names folder' below to edit the file and add your own names." },

            { "Label.OpenNamesFolder", "Open names folder" },
            { "Desc.OpenNamesFolder", "Open the folder containing StreetNames.txt, DistrictNames.txt and TransitLineNames.txt. Put one name per line; lines starting with # are ignored." },

            { "Label.ReloadNamesFile", "Reload names files" },
            { "Desc.ReloadNamesFile", "Re-read StreetNames.txt, DistrictNames.txt and TransitLineNames.txt after you edit them." },

            { "UI.RandomName", "Random name" },
        };
    }
}
