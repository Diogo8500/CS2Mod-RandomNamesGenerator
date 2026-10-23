using System.Collections.Generic;

namespace RandomNames.Locale
{
    /// <summary>The mod's strings, one file per language. English (Translations.en-US.cs) is the reference; see LocaleSource for the key format.</summary>
    public static partial class Translations
    {
        // A property, not a field: static fields spread over partial class files have no guaranteed initialization order.
        public static Dictionary<string, Dictionary<string, string>> ByLocale => new Dictionary<string, Dictionary<string, string>>
        {
            ["en-US"] = English,
            ["de-DE"] = German,
            ["es-ES"] = Spanish,
            ["fr-FR"] = French,
            ["it-IT"] = Italian,
            ["ja-JP"] = Japanese,
            ["ko-KR"] = Korean,
            ["pl-PL"] = Polish,
            ["pt-BR"] = Portuguese,
            ["ru-RU"] = Russian,
            ["zh-HANS"] = ChineseSimplified,
            ["zh-HANT"] = ChineseTraditional,
        };
    }
}
