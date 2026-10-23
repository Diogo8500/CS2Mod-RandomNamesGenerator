using System.Collections.Generic;

namespace RandomNames.Locale
{
    public static partial class Translations
    {
        private static readonly Dictionary<string, string> Portuguese = new Dictionary<string, string>
        {
            { "Title", "Roll a Name" },
            { "Tab.Main", "Geral" },

            { "Group.Streets", "Ruas" },
            { "Group.Districts", "Distritos" },
            { "Group.TransitLines", "Linhas de transporte" },
            { "Group.CustomFile", "Arquivos de nomes personalizados" },

            { "Label.RenameStreets", "Nomear novas ruas automaticamente" },
            { "Desc.RenameStreets", "Dá às ruas recém-construídas um nome aleatório das fontes de nomes selecionadas." },

            { "Label.RenameDistricts", "Nomear novos distritos automaticamente" },
            { "Desc.RenameDistricts", "Dá aos distritos recém-desenhados um nome aleatório das fontes de nomes selecionadas." },

            { "Label.StreetWordLists", "Nomes originais" },
            { "Desc.StreetWordLists", "Escolhe entre os nomes de ruas originais do jogo." },

            { "Label.StreetSyllables", "Nomes selecionados" },
            { "Desc.StreetSyllables", "Gera nomes a partir de prefixos, nomes e sufixos personalizados predefinidos. Pense nisso como um pacote de expansão de nomes de ruas. Por enquanto, os nomes estão em inglês." },

            { "Label.StreetCustomFile", "Arquivo de nomes personalizado" },
            { "Desc.StreetCustomFile", "Escolhe nomes de ruas em StreetNames.txt. Ignorado enquanto o arquivo estiver vazio. Clique em \"Abrir pasta de nomes\" abaixo para editar o arquivo e adicionar seus próprios nomes." },

            { "Label.DistrictWordLists", "Nomes originais" },
            { "Desc.DistrictWordLists", "Escolhe entre os nomes de distritos originais do jogo." },

            { "Label.DistrictSyllables", "Nomes selecionados" },
            { "Desc.DistrictSyllables", "Gera nomes a partir de prefixos, nomes e sufixos personalizados predefinidos. Pense nisso como um pacote de expansão de nomes de distritos. Por enquanto, os nomes estão em inglês." },

            { "Label.DistrictCustomFile", "Arquivo de nomes personalizado" },
            { "Desc.DistrictCustomFile", "Escolhe nomes de distritos em DistrictNames.txt. Ignorado enquanto o arquivo estiver vazio. Clique em \"Abrir pasta de nomes\" abaixo para editar o arquivo e adicionar seus próprios nomes." },

            { "Label.RenameTransitLines", "Nomear novas linhas de transporte automaticamente" },
            { "Desc.RenameTransitLines", "Dá às linhas de transporte recém-criadas um nome aleatório das fontes de nomes selecionadas, em vez dos nomes numerados do jogo." },

            { "Label.TransitLineSyllables", "Nomes selecionados" },
            { "Desc.TransitLineSyllables", "Gera nomes como \"Red Line\", \"Harbor Express\" ou \"Oakbrook–Ashford Line\" a partir de cores, lugares e tipos de linha predefinidos e dos nomes dos distritos da sua cidade. Por enquanto, os nomes estão em inglês." },

            { "Label.TransitLineCustomFile", "Arquivo de nomes personalizado" },
            { "Desc.TransitLineCustomFile", "Escolhe nomes de linhas em TransitLineNames.txt. Ignorado enquanto o arquivo estiver vazio. Clique em \"Abrir pasta de nomes\" abaixo para editar o arquivo e adicionar seus próprios nomes." },

            { "Label.OpenNamesFolder", "Abrir pasta de nomes" },
            { "Desc.OpenNamesFolder", "Abre a pasta que contém StreetNames.txt, DistrictNames.txt e TransitLineNames.txt. Coloque um nome por linha; linhas que começam com # são ignoradas." },

            { "Label.ReloadNamesFile", "Recarregar arquivos de nomes" },
            { "Desc.ReloadNamesFile", "Lê novamente StreetNames.txt, DistrictNames.txt e TransitLineNames.txt depois que você os editar." },

            { "UI.RandomName", "Nome aleatório" },
        };
    }
}
