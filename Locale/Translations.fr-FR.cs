using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> French = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "Général" },

            { "Group.Streets", "Rues" },
            { "Group.Districts", "Quartiers" },
            { "Group.TransitLines", "Lignes de transport" },
            { "Group.CustomFile", "Fichiers de noms personnalisés" },

            { "Label.RenameStreets", "Nommer automatiquement les nouvelles rues" },
            { "Desc.RenameStreets", "Donne aux rues nouvellement construites un nom aléatoire tiré des sources de noms sélectionnées." },

            { "Label.RenameDistricts", "Nommer automatiquement les nouveaux quartiers" },
            { "Desc.RenameDistricts", "Donne aux quartiers nouvellement tracés un nom aléatoire tiré des sources de noms sélectionnées." },

            { "Label.StreetWordLists", "Noms d'origine" },
            { "Desc.StreetWordLists", "Choisit parmi les noms de rues d'origine du jeu." },

            { "Label.StreetSyllables", "Noms sélectionnés" },
            { "Desc.StreetSyllables", "Génère des noms à partir de préfixes, noms et suffixes personnalisés prédéfinis. Voyez-le comme un pack d'extension pour les noms de rues. Pour l'instant, les noms sont en anglais." },

            { "Label.StreetCustomFile", "Fichier de noms personnalisé" },
            { "Desc.StreetCustomFile", "Choisit des noms de rues dans StreetNames.txt. Ignoré tant que le fichier est vide. Cliquez sur « Ouvrir le dossier des noms » ci-dessous pour modifier le fichier et ajouter vos propres noms." },

            { "Label.DistrictWordLists", "Noms d'origine" },
            { "Desc.DistrictWordLists", "Choisit parmi les noms de quartiers d'origine du jeu." },

            { "Label.DistrictSyllables", "Noms sélectionnés" },
            { "Desc.DistrictSyllables", "Génère des noms à partir de préfixes, noms et suffixes personnalisés prédéfinis. Voyez-le comme un pack d'extension pour les noms de quartiers. Pour l'instant, les noms sont en anglais." },

            { "Label.DistrictCustomFile", "Fichier de noms personnalisé" },
            { "Desc.DistrictCustomFile", "Choisit des noms de quartiers dans DistrictNames.txt. Ignoré tant que le fichier est vide. Cliquez sur « Ouvrir le dossier des noms » ci-dessous pour modifier le fichier et ajouter vos propres noms." },

            { "Label.RenameTransitLines", "Nommer automatiquement les nouvelles lignes de transport" },
            { "Desc.RenameTransitLines", "Donne aux lignes de transport nouvellement créées un nom aléatoire tiré des sources de noms sélectionnées, au lieu des noms numérotés du jeu." },

            { "Label.TransitLineSyllables", "Noms sélectionnés" },
            { "Desc.TransitLineSyllables", "Génère des noms comme « Red Line », « Harbor Express » ou « Oakbrook–Ashford Line » à partir de couleurs, de lieux et de types de lignes prédéfinis, ainsi que des noms des quartiers de votre ville. Pour l'instant, les noms sont en anglais." },

            { "Label.TransitLineCustomFile", "Fichier de noms personnalisé" },
            { "Desc.TransitLineCustomFile", "Choisit des noms de lignes dans TransitLineNames.txt. Ignoré tant que le fichier est vide. Cliquez sur « Ouvrir le dossier des noms » ci-dessous pour modifier le fichier et ajouter vos propres noms." },

            { "Label.OpenNamesFolder", "Ouvrir le dossier des noms" },
            { "Desc.OpenNamesFolder", "Ouvre le dossier contenant StreetNames.txt, DistrictNames.txt et TransitLineNames.txt. Mettez un nom par ligne ; les lignes commençant par # sont ignorées." },

            { "Label.ReloadNamesFile", "Recharger les fichiers de noms" },
            { "Desc.ReloadNamesFile", "Relit StreetNames.txt, DistrictNames.txt et TransitLineNames.txt après que vous les avez modifiés." },

            { "UI.RandomName", "Nom aléatoire" },
        };
    }
}
