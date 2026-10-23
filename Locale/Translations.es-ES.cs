using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Spanish = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "General" },

            { "Group.Streets", "Calles" },
            { "Group.Districts", "Distritos" },
            { "Group.TransitLines", "Líneas de transporte" },
            { "Group.CustomFile", "Archivos de nombres personalizados" },

            { "Label.RenameStreets", "Nombrar automáticamente las calles nuevas" },
            { "Desc.RenameStreets", "Da a las calles recién construidas un nombre aleatorio de las fuentes de nombres seleccionadas." },

            { "Label.RenameDistricts", "Nombrar automáticamente los distritos nuevos" },
            { "Desc.RenameDistricts", "Da a los distritos recién dibujados un nombre aleatorio de las fuentes de nombres seleccionadas." },

            { "Label.StreetWordLists", "Nombres originales" },
            { "Desc.StreetWordLists", "Elige entre los nombres de calles originales del juego." },

            { "Label.StreetSyllables", "Nombres seleccionados" },
            { "Desc.StreetSyllables", "Genera nombres a partir de prefijos, nombres y sufijos personalizados ya preparados. Piensa en ello como un paquete de expansión de nombres de calles. Por ahora, los nombres están en inglés." },

            { "Label.StreetCustomFile", "Archivo de nombres personalizado" },
            { "Desc.StreetCustomFile", "Elige nombres de calles de StreetNames.txt. Se omite mientras el archivo esté vacío. Pulsa «Abrir carpeta de nombres» abajo para editar el archivo y añadir tus propios nombres." },

            { "Label.DistrictWordLists", "Nombres originales" },
            { "Desc.DistrictWordLists", "Elige entre los nombres de distritos originales del juego." },

            { "Label.DistrictSyllables", "Nombres seleccionados" },
            { "Desc.DistrictSyllables", "Genera nombres a partir de prefijos, nombres y sufijos personalizados ya preparados. Piensa en ello como un paquete de expansión de nombres de distritos. Por ahora, los nombres están en inglés." },

            { "Label.DistrictCustomFile", "Archivo de nombres personalizado" },
            { "Desc.DistrictCustomFile", "Elige nombres de distritos de DistrictNames.txt. Se omite mientras el archivo esté vacío. Pulsa «Abrir carpeta de nombres» abajo para editar el archivo y añadir tus propios nombres." },

            { "Label.RenameTransitLines", "Nombrar automáticamente las líneas de transporte nuevas" },
            { "Desc.RenameTransitLines", "Da a las líneas de transporte recién creadas un nombre aleatorio de las fuentes de nombres seleccionadas, en lugar de los nombres numerados del juego." },

            { "Label.TransitLineSyllables", "Nombres seleccionados" },
            { "Desc.TransitLineSyllables", "Genera nombres como «Red Line», «Harbor Express» u «Oakbrook–Ashford Line» a partir de colores, lugares y tipos de línea ya preparados, y de los nombres de los distritos de tu ciudad. Por ahora, los nombres están en inglés." },

            { "Label.TransitLineCustomFile", "Archivo de nombres personalizado" },
            { "Desc.TransitLineCustomFile", "Elige nombres de líneas de TransitLineNames.txt. Se omite mientras el archivo esté vacío. Pulsa «Abrir carpeta de nombres» abajo para editar el archivo y añadir tus propios nombres." },

            { "Label.OpenNamesFolder", "Abrir carpeta de nombres" },
            { "Desc.OpenNamesFolder", "Abre la carpeta que contiene StreetNames.txt, DistrictNames.txt y TransitLineNames.txt. Escribe un nombre por línea; las líneas que empiezan por # se ignoran." },

            { "Label.ReloadNamesFile", "Recargar archivos de nombres" },
            { "Desc.ReloadNamesFile", "Vuelve a leer StreetNames.txt, DistrictNames.txt y TransitLineNames.txt después de editarlos." },

            { "UI.RandomName", "Nombre aleatorio" },
        };
    }
}
