using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Italian = new Dictionary<string, string>
        {
            { "Title", "Random Names Generator" },
            { "Tab.Main", "Generale" },

            { "Group.Streets", "Strade" },
            { "Group.Districts", "Distretti" },
            { "Group.CustomFile", "File di nomi personalizzati" },

            { "Label.RenameStreets", "Assegna automaticamente un nome alle nuove strade" },
            { "Desc.RenameStreets", "Assegna alle strade appena costruite un nome casuale dalle fonti di nomi selezionate." },

            { "Label.RenameDistricts", "Assegna automaticamente un nome ai nuovi distretti" },
            { "Desc.RenameDistricts", "Assegna ai distretti appena tracciati un nome casuale dalle fonti di nomi selezionate." },

            { "Label.StreetWordLists", "Nomi originali" },
            { "Desc.StreetWordLists", "Sceglie tra i nomi di strade originali del gioco." },

            { "Label.StreetSyllables", "Nomi selezionati" },
            { "Desc.StreetSyllables", "Genera nomi da prefissi, nomi e suffissi personalizzati già pronti. Consideralo un pacchetto di espansione per i nomi delle strade." },

            { "Label.StreetCustomFile", "File di nomi personalizzato" },
            { "Desc.StreetCustomFile", "Sceglie nomi di strade da StreetNames.txt. Ignorato finché il file è vuoto. Premi \"Apri cartella dei nomi\" qui sotto per modificare il file e aggiungere i tuoi nomi." },

            { "Label.DistrictWordLists", "Nomi originali" },
            { "Desc.DistrictWordLists", "Sceglie tra i nomi di distretti originali del gioco." },

            { "Label.DistrictSyllables", "Nomi selezionati" },
            { "Desc.DistrictSyllables", "Genera nomi da prefissi, nomi e suffissi personalizzati già pronti. Consideralo un pacchetto di espansione per i nomi dei distretti." },

            { "Label.DistrictCustomFile", "File di nomi personalizzato" },
            { "Desc.DistrictCustomFile", "Sceglie nomi di distretti da DistrictNames.txt. Ignorato finché il file è vuoto. Premi \"Apri cartella dei nomi\" qui sotto per modificare il file e aggiungere i tuoi nomi." },

            { "Label.OpenNamesFolder", "Apri cartella dei nomi" },
            { "Desc.OpenNamesFolder", "Apre la cartella che contiene StreetNames.txt e DistrictNames.txt. Inserisci un nome per riga; le righe che iniziano con # vengono ignorate." },

            { "Label.ReloadNamesFile", "Ricarica file dei nomi" },
            { "Desc.ReloadNamesFile", "Rilegge StreetNames.txt e DistrictNames.txt dopo averli modificati." },

            { "UI.RandomName", "Nome casuale" },
        };
    }
}
