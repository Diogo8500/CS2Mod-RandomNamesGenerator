using System.Diagnostics;
using Colossal.IO.AssetDatabase;
using Game.Modding;
using Game.Settings;
using RandomNames.Naming;

namespace RandomNames
{
    [FileLocation(nameof(RandomNames))]
    [SettingsUIGroupOrder(kStreetsGroup, kDistrictsGroup, kCustomFileGroup)]
    [SettingsUIShowGroupName(kStreetsGroup, kDistrictsGroup, kCustomFileGroup)]
    public class Setting : ModSetting
    {
        public const string kSection = "Main";
        public const string kStreetsGroup = "Streets";
        public const string kDistrictsGroup = "Districts";
        public const string kCustomFileGroup = "CustomFile";

        public Setting(IMod mod) : base(mod)
        {
        }

        [SettingsUISection(kSection, kStreetsGroup)]
        public bool RenameStreets { get; set; } = false;

        [SettingsUISection(kSection, kStreetsGroup)]
        public bool StreetWordLists { get; set; } = true;

        [SettingsUISection(kSection, kStreetsGroup)]
        public bool StreetSyllables { get; set; } = true;

        [SettingsUISection(kSection, kStreetsGroup)]
        public bool StreetCustomFile { get; set; } = true;

        [SettingsUISection(kSection, kDistrictsGroup)]
        public bool RenameDistricts { get; set; } = false;

        [SettingsUISection(kSection, kDistrictsGroup)]
        public bool DistrictWordLists { get; set; } = true;

        [SettingsUISection(kSection, kDistrictsGroup)]
        public bool DistrictSyllables { get; set; } = true;

        [SettingsUISection(kSection, kDistrictsGroup)]
        public bool DistrictCustomFile { get; set; } = true;

        public NameSources GetSources(NameCategory category)
        {
            return category == NameCategory.District
                ? ToSources(DistrictWordLists, DistrictSyllables, DistrictCustomFile)
                : ToSources(StreetWordLists, StreetSyllables, StreetCustomFile);
        }

        private static NameSources ToSources(bool wordLists, bool syllables, bool customFile) =>
            (wordLists ? NameSources.Vanilla : NameSources.None) |
            (syllables ? NameSources.Syllables : NameSources.None) |
            (customFile ? NameSources.CustomFile : NameSources.None);

        [SettingsUIButton]
        [SettingsUISection(kSection, kCustomFileGroup)]
        public bool OpenNamesFolder
        {
            set
            {
                Mod.Generator.CustomFile.EnsureFilesExist();
                Process.Start("explorer.exe", $"\"{CustomFileSource.Folder}\"");
            }
        }

        [SettingsUIButton]
        [SettingsUISection(kSection, kCustomFileGroup)]
        public bool ReloadNamesFile
        {
            set { Mod.Generator.CustomFile.Load(); }
        }

        public override void SetDefaults()
        {
            RenameStreets = false;
            StreetWordLists = true;
            StreetSyllables = true;
            StreetCustomFile = true;
            RenameDistricts = false;
            DistrictWordLists = true;
            DistrictSyllables = true;
            DistrictCustomFile = true;
        }
    }
}
