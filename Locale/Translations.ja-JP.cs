using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Japanese = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "メイン" },

            { "Group.Streets", "道路" },
            { "Group.Districts", "地区" },
            { "Group.CustomFile", "カスタム名前ファイル" },

            { "Label.RenameStreets", "新しい道路に自動で名前を付ける" },
            { "Desc.RenameStreets", "新しく建設した道路に、選択した名前ソースからランダムな名前を付けます。" },

            { "Label.RenameDistricts", "新しい地区に自動で名前を付ける" },
            { "Desc.RenameDistricts", "新しく描いた地区に、選択した名前ソースからランダムな名前を付けます。" },

            { "Label.StreetWordLists", "バニラの名前" },
            { "Desc.StreetWordLists", "ゲーム本来の道路名から選びます。" },

            { "Label.StreetSyllables", "厳選された名前" },
            { "Desc.StreetSyllables", "あらかじめ用意された独自の接頭辞・名前・接尾辞から名前を生成します。道路名の拡張パックのようなものです。" },

            { "Label.StreetCustomFile", "カスタム名前ファイル" },
            { "Desc.StreetCustomFile", "StreetNames.txt から道路名を選びます。ファイルが空の間はスキップされます。下の「名前フォルダーを開く」を押してファイルを編集し、独自の名前を追加してください。" },

            { "Label.DistrictWordLists", "バニラの名前" },
            { "Desc.DistrictWordLists", "ゲーム本来の地区名から選びます。" },

            { "Label.DistrictSyllables", "厳選された名前" },
            { "Desc.DistrictSyllables", "あらかじめ用意された独自の接頭辞・名前・接尾辞から名前を生成します。地区名の拡張パックのようなものです。" },

            { "Label.DistrictCustomFile", "カスタム名前ファイル" },
            { "Desc.DistrictCustomFile", "DistrictNames.txt から地区名を選びます。ファイルが空の間はスキップされます。下の「名前フォルダーを開く」を押してファイルを編集し、独自の名前を追加してください。" },

            { "Label.OpenNamesFolder", "名前フォルダーを開く" },
            { "Desc.OpenNamesFolder", "StreetNames.txt と DistrictNames.txt があるフォルダーを開きます。1行に1つの名前を書いてください。# で始まる行は無視されます。" },

            { "Label.ReloadNamesFile", "名前ファイルを再読み込み" },
            { "Desc.ReloadNamesFile", "編集後に StreetNames.txt と DistrictNames.txt を読み込み直します。" },

            { "UI.RandomName", "ランダムな名前" },
        };
    }
}
