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
            { "Group.CustomFile", "Fichiers de noms personnalisés" },

            { "Label.RenameStreets", "Nommer automatiquement les nouvelles rues" },
            { "Desc.RenameStreets", "Donne aux rues nouvellement construites un nom aléatoire tiré des sources de noms sélectionnées." },

            { "Label.RenameDistricts", "Nommer automatiquement les nouveaux quartiers" },
            { "Desc.RenameDistricts", "Donne aux quartiers nouvellement tracés un nom aléatoire tiré des sources de noms sélectionnées." },

            { "Label.StreetWordLists", "Noms d'origine" },
            { "Desc.StreetWordLists", "Choisit parmi les noms de rues d'origine du jeu." },

            { "Label.StreetSyllables", "Noms sélectionnés" },
            { "Desc.StreetSyllables", "Génère des noms à partir de préfixes, noms et suffixes personnalisés prédéfinis. Voyez-le comme un pack d'extension pour les noms de rues." },

            { "Label.StreetCustomFile", "Fichier de noms personnalisé" },
            { "Desc.StreetCustomFile", "Choisit des noms de rues dans StreetNames.txt. Ignoré tant que le fichier est vide. Cliquez sur « Ouvrir le dossier des noms » ci-dessous pour modifier le fichier et ajouter vos propres noms." },

            { "Label.DistrictWordLists", "Noms d'origine" },
            { "Desc.DistrictWordLists", "Choisit parmi les noms de quartiers d'origine du jeu." },

            { "Label.DistrictSyllables", "Noms sélectionnés" },
            { "Desc.DistrictSyllables", "Génère des noms à partir de préfixes, noms et suffixes personnalisés prédéfinis. Voyez-le comme un pack d'extension pour les noms de quartiers." },

            { "Label.DistrictCustomFile", "Fichier de noms personnalisé" },
            { "Desc.DistrictCustomFile", "Choisit des noms de quartiers dans DistrictNames.txt. Ignoré tant que le fichier est vide. Cliquez sur « Ouvrir le dossier des noms » ci-dessous pour modifier le fichier et ajouter vos propres noms." },

            { "Label.OpenNamesFolder", "Ouvrir le dossier des noms" },
            { "Desc.OpenNamesFolder", "Ouvre le dossier contenant StreetNames.txt et DistrictNames.txt. Mettez un nom par ligne ; les lignes commençant par # sont ignorées." },

            { "Label.ReloadNamesFile", "Recharger les fichiers de noms" },
            { "Desc.ReloadNamesFile", "Relit StreetNames.txt et DistrictNames.txt après que vous les avez modifiés." },

            { "UI.RandomName", "Nom aléatoire" },
        };
    }
}
