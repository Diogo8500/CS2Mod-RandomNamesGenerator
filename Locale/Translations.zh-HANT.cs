using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> ChineseTraditional = new Dictionary<string, string>
        {
            { "Title", "Random Names Generator" },
            { "Tab.Main", "主要" },

            { "Group.Streets", "道路" },
            { "Group.Districts", "區域" },
            { "Group.CustomFile", "自訂名稱檔案" },

            { "Label.RenameStreets", "自動命名新道路" },
            { "Desc.RenameStreets", "從所選名稱來源中為新建的道路隨機命名。" },

            { "Label.RenameDistricts", "自動命名新區域" },
            { "Desc.RenameDistricts", "從所選名稱來源中為新繪製的區域隨機命名。" },

            { "Label.StreetWordLists", "原版名稱" },
            { "Desc.StreetWordLists", "從遊戲原版道路名稱中挑選。" },

            { "Label.StreetSyllables", "精選名稱" },
            { "Desc.StreetSyllables", "使用預製的自訂前綴、名稱和後綴產生名稱。可以把它看作道路名稱的擴充包。" },

            { "Label.StreetCustomFile", "自訂名稱檔案" },
            { "Desc.StreetCustomFile", "從 StreetNames.txt 中挑選道路名稱。檔案為空時略過。點擊下方的「開啟名稱資料夾」可編輯該檔案並新增你自己的名稱。" },

            { "Label.DistrictWordLists", "原版名稱" },
            { "Desc.DistrictWordLists", "從遊戲原版區域名稱中挑選。" },

            { "Label.DistrictSyllables", "精選名稱" },
            { "Desc.DistrictSyllables", "使用預製的自訂前綴、名稱和後綴產生名稱。可以把它看作區域名稱的擴充包。" },

            { "Label.DistrictCustomFile", "自訂名稱檔案" },
            { "Desc.DistrictCustomFile", "從 DistrictNames.txt 中挑選區域名稱。檔案為空時略過。點擊下方的「開啟名稱資料夾」可編輯該檔案並新增你自己的名稱。" },

            { "Label.OpenNamesFolder", "開啟名稱資料夾" },
            { "Desc.OpenNamesFolder", "開啟包含 StreetNames.txt 和 DistrictNames.txt 的資料夾。每行一個名稱；以 # 開頭的行會被忽略。" },

            { "Label.ReloadNamesFile", "重新載入名稱檔案" },
            { "Desc.ReloadNamesFile", "編輯後重新讀取 StreetNames.txt 和 DistrictNames.txt。" },

            { "UI.RandomName", "隨機名稱" },
        };
    }
}
