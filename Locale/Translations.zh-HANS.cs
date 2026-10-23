using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> ChineseSimplified = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "主要" },

            { "Group.Streets", "道路" },
            { "Group.Districts", "区域" },
            { "Group.TransitLines", "交通线路" },
            { "Group.CustomFile", "自定义名称文件" },

            { "Label.RenameStreets", "自动命名新道路" },
            { "Desc.RenameStreets", "从所选名称来源中为新建的道路随机命名。" },

            { "Label.RenameDistricts", "自动命名新区域" },
            { "Desc.RenameDistricts", "从所选名称来源中为新绘制的区域随机命名。" },

            { "Label.StreetWordLists", "原版名称" },
            { "Desc.StreetWordLists", "从游戏原版道路名称中挑选。" },

            { "Label.StreetSyllables", "精选名称" },
            { "Desc.StreetSyllables", "使用预制的自定义前缀、名称和后缀生成名称。可以把它看作道路名称的扩展包。目前名称仅为英文。" },

            { "Label.StreetCustomFile", "自定义名称文件" },
            { "Desc.StreetCustomFile", "从 StreetNames.txt 中挑选道路名称。文件为空时跳过。点击下方的“打开名称文件夹”可编辑该文件并添加你自己的名称。" },

            { "Label.DistrictWordLists", "原版名称" },
            { "Desc.DistrictWordLists", "从游戏原版区域名称中挑选。" },

            { "Label.DistrictSyllables", "精选名称" },
            { "Desc.DistrictSyllables", "使用预制的自定义前缀、名称和后缀生成名称。可以把它看作区域名称的扩展包。目前名称仅为英文。" },

            { "Label.DistrictCustomFile", "自定义名称文件" },
            { "Desc.DistrictCustomFile", "从 DistrictNames.txt 中挑选区域名称。文件为空时跳过。点击下方的“打开名称文件夹”可编辑该文件并添加你自己的名称。" },

            { "Label.RenameTransitLines", "自动命名新交通线路" },
            { "Desc.RenameTransitLines", "从所选名称来源中为新建的交通线路随机命名，取代游戏的编号名称。" },

            { "Label.TransitLineSyllables", "精选名称" },
            { "Desc.TransitLineSyllables", "使用预制的颜色、地名和线路类型以及你城市的区域名称生成“Red Line”“Harbor Express”“Oakbrook–Ashford Line”之类的名称。目前名称仅为英文。" },

            { "Label.TransitLineCustomFile", "自定义名称文件" },
            { "Desc.TransitLineCustomFile", "从 TransitLineNames.txt 中挑选线路名称。文件为空时跳过。点击下方的“打开名称文件夹”可编辑该文件并添加你自己的名称。" },

            { "Label.OpenNamesFolder", "打开名称文件夹" },
            { "Desc.OpenNamesFolder", "打开包含 StreetNames.txt、DistrictNames.txt 和 TransitLineNames.txt 的文件夹。每行一个名称；以 # 开头的行会被忽略。" },

            { "Label.ReloadNamesFile", "重新加载名称文件" },
            { "Desc.ReloadNamesFile", "编辑后重新读取 StreetNames.txt、DistrictNames.txt 和 TransitLineNames.txt。" },

            { "UI.RandomName", "随机名称" },
        };
    }
}
