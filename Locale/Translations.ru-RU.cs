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
            { "Group.CustomFile", "Собственные файлы названий" },

            { "Label.RenameStreets", "Автоматически называть новые улицы" },
            { "Desc.RenameStreets", "Даёт новым улицам случайное название из выбранных источников названий." },

            { "Label.RenameDistricts", "Автоматически называть новые районы" },
            { "Desc.RenameDistricts", "Даёт новым районам случайное название из выбранных источников названий." },

            { "Label.StreetWordLists", "Названия из игры" },
            { "Desc.StreetWordLists", "Выбирает из оригинальных названий улиц игры." },

            { "Label.StreetSyllables", "Подобранные названия" },
            { "Desc.StreetSyllables", "Создаёт названия из готовых префиксов, названий и суффиксов. Это своего рода набор расширения для названий улиц." },

            { "Label.StreetCustomFile", "Собственный файл названий" },
            { "Desc.StreetCustomFile", "Выбирает названия улиц из StreetNames.txt. Пропускается, пока файл пуст. Нажмите «Открыть папку с названиями» ниже, чтобы отредактировать файл и добавить свои названия." },

            { "Label.DistrictWordLists", "Названия из игры" },
            { "Desc.DistrictWordLists", "Выбирает из оригинальных названий районов игры." },

            { "Label.DistrictSyllables", "Подобранные названия" },
            { "Desc.DistrictSyllables", "Создаёт названия из готовых префиксов, названий и суффиксов. Это своего рода набор расширения для названий районов." },

            { "Label.DistrictCustomFile", "Собственный файл названий" },
            { "Desc.DistrictCustomFile", "Выбирает названия районов из DistrictNames.txt. Пропускается, пока файл пуст. Нажмите «Открыть папку с названиями» ниже, чтобы отредактировать файл и добавить свои названия." },

            { "Label.OpenNamesFolder", "Открыть папку с названиями" },
            { "Desc.OpenNamesFolder", "Открывает папку с файлами StreetNames.txt и DistrictNames.txt. Указывайте одно название в строке; строки, начинающиеся с #, игнорируются." },

            { "Label.ReloadNamesFile", "Перезагрузить файлы названий" },
            { "Desc.ReloadNamesFile", "Заново считывает StreetNames.txt и DistrictNames.txt после их редактирования." },

            { "UI.RandomName", "Случайное название" },
        };
    }
}
