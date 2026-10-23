using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Korean = new Dictionary<string, string>
        {
            { "Title", "Random Names Generator" },
            { "Tab.Main", "일반" },

            { "Group.Streets", "도로" },
            { "Group.Districts", "지구" },
            { "Group.CustomFile", "사용자 지정 이름 파일" },

            { "Label.RenameStreets", "새 도로에 자동으로 이름 붙이기" },
            { "Desc.RenameStreets", "새로 건설한 도로에 선택한 이름 소스에서 무작위 이름을 붙입니다." },

            { "Label.RenameDistricts", "새 지구에 자동으로 이름 붙이기" },
            { "Desc.RenameDistricts", "새로 그린 지구에 선택한 이름 소스에서 무작위 이름을 붙입니다." },

            { "Label.StreetWordLists", "기본 이름" },
            { "Desc.StreetWordLists", "게임의 기본 도로 이름에서 고릅니다." },

            { "Label.StreetSyllables", "엄선된 이름" },
            { "Desc.StreetSyllables", "미리 준비된 사용자 지정 접두사, 이름, 접미사를 조합해 이름을 생성합니다. 도로 이름 확장팩이라고 생각하면 됩니다." },

            { "Label.StreetCustomFile", "사용자 지정 이름 파일" },
            { "Desc.StreetCustomFile", "StreetNames.txt에서 도로 이름을 고릅니다. 파일이 비어 있는 동안에는 건너뜁니다. 아래의 '이름 폴더 열기'를 눌러 파일을 편집하고 원하는 이름을 추가하세요." },

            { "Label.DistrictWordLists", "기본 이름" },
            { "Desc.DistrictWordLists", "게임의 기본 지구 이름에서 고릅니다." },

            { "Label.DistrictSyllables", "엄선된 이름" },
            { "Desc.DistrictSyllables", "미리 준비된 사용자 지정 접두사, 이름, 접미사를 조합해 이름을 생성합니다. 지구 이름 확장팩이라고 생각하면 됩니다." },

            { "Label.DistrictCustomFile", "사용자 지정 이름 파일" },
            { "Desc.DistrictCustomFile", "DistrictNames.txt에서 지구 이름을 고릅니다. 파일이 비어 있는 동안에는 건너뜁니다. 아래의 '이름 폴더 열기'를 눌러 파일을 편집하고 원하는 이름을 추가하세요." },

            { "Label.OpenNamesFolder", "이름 폴더 열기" },
            { "Desc.OpenNamesFolder", "StreetNames.txt와 DistrictNames.txt가 들어 있는 폴더를 엽니다. 한 줄에 이름 하나씩 입력하세요. #으로 시작하는 줄은 무시됩니다." },

            { "Label.ReloadNamesFile", "이름 파일 다시 불러오기" },
            { "Desc.ReloadNamesFile", "편집한 후 StreetNames.txt와 DistrictNames.txt를 다시 읽습니다." },

            { "UI.RandomName", "무작위 이름" },
        };
    }
}
