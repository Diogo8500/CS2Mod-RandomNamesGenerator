using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Russian = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "Основное" },

            { "Group.Streets", "Улицы" },
            { "Group.Districts", "Районы" },
            { "Group.TransitLines", "Транспортные линии" },
            { "Group.CustomFile", "Собственные файлы названий" },

            { "Label.RenameStreets", "Автоматически называть новые улицы" },
            { "Desc.RenameStreets", "Даёт новым улицам случайное название из выбранных источников названий." },

            { "Label.RenameDistricts", "Автоматически называть новые районы" },
            { "Desc.RenameDistricts", "Даёт новым районам случайное название из выбранных источников названий." },

            { "Label.StreetWordLists", "Названия из игры" },
            { "Desc.StreetWordLists", "Выбирает из оригинальных названий улиц игры." },

            { "Label.StreetSyllables", "Подобранные названия" },
            { "Desc.StreetSyllables", "Создаёт названия из готовых префиксов, названий и суффиксов. Это своего рода набор расширения для названий улиц. Пока названия только на английском." },

            { "Label.StreetCustomFile", "Собственный файл названий" },
            { "Desc.StreetCustomFile", "Выбирает названия улиц из StreetNames.txt. Пропускается, пока файл пуст. Нажмите «Открыть папку с названиями» ниже, чтобы отредактировать файл и добавить свои названия." },

            { "Label.DistrictWordLists", "Названия из игры" },
            { "Desc.DistrictWordLists", "Выбирает из оригинальных названий районов игры." },

            { "Label.DistrictSyllables", "Подобранные названия" },
            { "Desc.DistrictSyllables", "Создаёт названия из готовых префиксов, названий и суффиксов. Это своего рода набор расширения для названий районов. Пока названия только на английском." },

            { "Label.DistrictCustomFile", "Собственный файл названий" },
            { "Desc.DistrictCustomFile", "Выбирает названия районов из DistrictNames.txt. Пропускается, пока файл пуст. Нажмите «Открыть папку с названиями» ниже, чтобы отредактировать файл и добавить свои названия." },

            { "Label.RenameTransitLines", "Автоматически называть новые транспортные линии" },
            { "Desc.RenameTransitLines", "Даёт новым транспортным линиям случайное название из выбранных источников названий вместо номерных названий игры." },

            { "Label.TransitLineSyllables", "Подобранные названия" },
            { "Desc.TransitLineSyllables", "Создаёт названия вроде «Red Line», «Harbor Express» или «Oakbrook–Ashford Line» из готовых цветов, мест и типов линий, а также названий районов вашего города. Пока названия только на английском." },

            { "Label.TransitLineCustomFile", "Собственный файл названий" },
            { "Desc.TransitLineCustomFile", "Выбирает названия линий из TransitLineNames.txt. Пропускается, пока файл пуст. Нажмите «Открыть папку с названиями» ниже, чтобы отредактировать файл и добавить свои названия." },

            { "Label.OpenNamesFolder", "Открыть папку с названиями" },
            { "Desc.OpenNamesFolder", "Открывает папку с файлами StreetNames.txt, DistrictNames.txt и TransitLineNames.txt. Указывайте одно название в строке; строки, начинающиеся с #, игнорируются." },

            { "Label.ReloadNamesFile", "Перезагрузить файлы названий" },
            { "Desc.ReloadNamesFile", "Заново считывает StreetNames.txt, DistrictNames.txt и TransitLineNames.txt после их редактирования." },

            { "UI.RandomName", "Случайное название" },
        };
    }
}
