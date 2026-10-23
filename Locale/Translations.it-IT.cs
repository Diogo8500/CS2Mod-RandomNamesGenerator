using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Italian = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "Generale" },

            { "Group.Streets", "Strade" },
            { "Group.Districts", "Distretti" },
            { "Group.TransitLines", "Linee di trasporto" },
            { "Group.CustomFile", "File di nomi personalizzati" },

            { "Label.RenameStreets", "Assegna automaticamente un nome alle nuove strade" },
            { "Desc.RenameStreets", "Assegna alle strade appena costruite un nome casuale dalle fonti di nomi selezionate." },

            { "Label.RenameDistricts", "Assegna automaticamente un nome ai nuovi distretti" },
            { "Desc.RenameDistricts", "Assegna ai distretti appena tracciati un nome casuale dalle fonti di nomi selezionate." },

            { "Label.StreetWordLists", "Nomi originali" },
            { "Desc.StreetWordLists", "Sceglie tra i nomi di strade originali del gioco." },

            { "Label.StreetSyllables", "Nomi selezionati" },
            { "Desc.StreetSyllables", "Genera nomi da prefissi, nomi e suffissi personalizzati già pronti. Consideralo un pacchetto di espansione per i nomi delle strade. Per ora i nomi sono in inglese." },

            { "Label.StreetCustomFile", "File di nomi personalizzato" },
            { "Desc.StreetCustomFile", "Sceglie nomi di strade da StreetNames.txt. Ignorato finché il file è vuoto. Premi \"Apri cartella dei nomi\" qui sotto per modificare il file e aggiungere i tuoi nomi." },

            { "Label.DistrictWordLists", "Nomi originali" },
            { "Desc.DistrictWordLists", "Sceglie tra i nomi di distretti originali del gioco." },

            { "Label.DistrictSyllables", "Nomi selezionati" },
            { "Desc.DistrictSyllables", "Genera nomi da prefissi, nomi e suffissi personalizzati già pronti. Consideralo un pacchetto di espansione per i nomi dei distretti. Per ora i nomi sono in inglese." },

            { "Label.DistrictCustomFile", "File di nomi personalizzato" },
            { "Desc.DistrictCustomFile", "Sceglie nomi di distretti da DistrictNames.txt. Ignorato finché il file è vuoto. Premi \"Apri cartella dei nomi\" qui sotto per modificare il file e aggiungere i tuoi nomi." },

            { "Label.RenameTransitLines", "Assegna automaticamente un nome alle nuove linee di trasporto" },
            { "Desc.RenameTransitLines", "Assegna alle linee di trasporto appena create un nome casuale dalle fonti di nomi selezionate, al posto dei nomi numerati del gioco." },

            { "Label.TransitLineSyllables", "Nomi selezionati" },
            { "Desc.TransitLineSyllables", "Genera nomi come \"Red Line\", \"Harbor Express\" o \"Oakbrook–Ashford Line\" da colori, luoghi e tipi di linea già pronti e dai nomi dei distretti della tua città. Per ora i nomi sono in inglese." },

            { "Label.TransitLineCustomFile", "File di nomi personalizzato" },
            { "Desc.TransitLineCustomFile", "Sceglie nomi di linee da TransitLineNames.txt. Ignorato finché il file è vuoto. Premi \"Apri cartella dei nomi\" qui sotto per modificare il file e aggiungere i tuoi nomi." },

            { "Label.OpenNamesFolder", "Apri cartella dei nomi" },
            { "Desc.OpenNamesFolder", "Apre la cartella che contiene StreetNames.txt, DistrictNames.txt e TransitLineNames.txt. Inserisci un nome per riga; le righe che iniziano con # vengono ignorate." },

            { "Label.ReloadNamesFile", "Ricarica file dei nomi" },
            { "Desc.ReloadNamesFile", "Rilegge StreetNames.txt, DistrictNames.txt e TransitLineNames.txt dopo averli modificati." },

            { "UI.RandomName", "Nome casuale" },
        };
    }
}
