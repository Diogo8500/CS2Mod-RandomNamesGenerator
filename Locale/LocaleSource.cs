using System;
using System.Collections.Generic;
using System.Linq;
using Colossal;

namespace RandomNames.Locale
{
    /// <summary>
    /// Feeds one language's strings (see Translations.*.cs) to the game, turning the short keys used there into the game's localization IDs:
    /// "Title", "Tab.X", "Group.X", "Label.X" and "Desc.X" for the options page, "UI.X" for the UI module (as "RandomNames.X").
    /// Keys missing from a language fall back to English.
    /// </summary>
    public class LocaleSource : IDictionarySource
    {
        public const string kUIPrefix = nameof(RandomNames) + ".";

        private readonly Setting m_Setting;
        private readonly Dictionary<string, string> m_Strings;

        public LocaleSource(Setting setting, Dictionary<string, string> strings)
        {
            m_Setting = setting;
            m_Strings = strings;
        }

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return m_Strings.Select(pair => new KeyValuePair<string, string>(ToLocaleId(pair.Key), pair.Value));
        }

        private string ToLocaleId(string key)
        {
            if (key == "Title")
                return m_Setting.GetSettingsLocaleID();

            var dot = key.IndexOf('.');
            var name = key.Substring(dot + 1);
            switch (dot < 0 ? key : key.Substring(0, dot))
            {
                case "Tab": return m_Setting.GetOptionTabLocaleID(name);
                case "Group": return m_Setting.GetOptionGroupLocaleID(name);
                case "Label": return m_Setting.GetOptionLabelLocaleID(name);
                case "Desc": return m_Setting.GetOptionDescLocaleID(name);
                case "UI": return kUIPrefix + name;
                default: throw new ArgumentException($"Unknown localization key \"{key}\"");
            }
        }

        public void Unload()
        {
        }
    }
}
