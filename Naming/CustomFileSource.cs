using System;
using System.Collections.Generic;
using System.IO;
using Colossal.PSI.Environment;

namespace RandomNames.Naming
{
    /// <summary>Picks names, used as-is, from user-editable files like StreetNames.txt and DistrictNames.txt.</summary>
    public class CustomFileSource : INameSource
    {
        // GetFullPath turns the game's forward slashes into backslashes; Explorer can't open a mixed path.
        public static readonly string Folder = Path.GetFullPath(Path.Combine(EnvPath.kUserDataPath, "ModsData", nameof(RandomNames)));

        private class NamesFile
        {
            public string FilePath;
            public string[] Samples;
            public readonly List<string> Names = new List<string>();
        }

        private readonly Dictionary<NameCategory, NamesFile> m_Files = new Dictionary<NameCategory, NamesFile>
        {
            [NameCategory.Street] = new NamesFile
            {
                FilePath = Path.Combine(Folder, "StreetNames.txt"),
                Samples = new[] { "Abbey Road", "Baker Street", "Sesame Street", "Elm Street", "Wisteria Lane" },
            },
            [NameCategory.District] = new NamesFile
            {
                FilePath = Path.Combine(Folder, "DistrictNames.txt"),
                Samples = new[] { "Greenwich Village", "Notting Hill", "Montmartre", "Soho", "Brooklyn Heights" },
            },
        };

        public bool IsAvailable(NameRequest request) => m_Files[request.Category].Names.Count > 0;

        public string Generate(Random random, NameRequest request)
        {
            var names = m_Files[request.Category].Names;
            return names[random.Next(names.Count)];
        }

        public void Load()
        {
            foreach (var pair in m_Files)
                Load(pair.Key, pair.Value);
        }

        private void Load(NameCategory category, NamesFile file)
        {
            file.Names.Clear();
            try
            {
                EnsureFileExists(category, file);
                foreach (var line in File.ReadAllLines(file.FilePath))
                {
                    var name = line.Trim();
                    if (name.Length > 0 && !name.StartsWith("#"))
                        file.Names.Add(name);
                }
                Mod.Log.Info($"Loaded {file.Names.Count} names from {file.FilePath}");
            }
            catch (Exception e)
            {
                Mod.Log.Error(e, $"Could not read {file.FilePath}");
            }
        }

        public void EnsureFilesExist()
        {
            foreach (var pair in m_Files)
                EnsureFileExists(pair.Key, pair.Value);
        }

        private static void EnsureFileExists(NameCategory category, NamesFile file)
        {
            if (File.Exists(file.FilePath))
                return;

            Directory.CreateDirectory(Folder);
            var lines = new List<string>
            {
                $"# One {category.ToString().ToLowerInvariant()} name per line. Lines starting with # are ignored.",
                "# Click 'Reload names files' in the mod settings after editing.",
            };
            lines.AddRange(file.Samples);
            File.WriteAllLines(file.FilePath, lines);
        }
    }
}
