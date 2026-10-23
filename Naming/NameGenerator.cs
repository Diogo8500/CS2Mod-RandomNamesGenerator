using System;
using System.Collections.Generic;

namespace RandomNames.Naming
{
    [Flags]
    public enum NameSources
    {
        None = 0,
        Vanilla = 1,
        Syllables = 2,
        CustomFile = 4,
    }

    // Add Building, TransitLine, etc. here when the mod grows.
    public enum NameCategory
    {
        Street,
        District,
    }

    public struct NameRequest
    {
        public NameCategory Category;

        // The prefab's RandomLocalization ID (see VanillaSource.GetLocalizationId), or null if it has none.
        public string VanillaId;
    }

    public interface INameSource
    {
        bool IsAvailable(NameRequest request);
        string Generate(Random random, NameRequest request);
    }

    public class NameGenerator
    {
        private const int kMaxAttempts = 10;

        private readonly Random m_Random = new Random();
        private readonly HashSet<string> m_UsedNames = new HashSet<string>();
        private readonly VanillaSource m_Vanilla = new VanillaSource();
        private readonly SyllableSource m_Syllables = new SyllableSource();

        public CustomFileSource CustomFile { get; } = new CustomFileSource();

        public NameGenerator()
        {
            CustomFile.Load();
        }

        public string Generate(NameSources sources, NameCategory category, string vanillaId)
        {
            var request = new NameRequest { Category = category, VanillaId = vanillaId };

            // Retry a few times to avoid handing out the same name twice in a session.
            string name = null;
            for (int i = 0; i < kMaxAttempts; i++)
            {
                name = PickSource(sources, request).Generate(m_Random, request);
                if (m_UsedNames.Add(name))
                    break;
            }
            return name;
        }

        // Picks one of the enabled sources at random.
        private INameSource PickSource(NameSources sources, NameRequest request)
        {
            var available = new List<INameSource>();
            if ((sources & NameSources.Vanilla) != 0)
            {
                if (m_Vanilla.IsAvailable(request))
                    available.Add(m_Vanilla);
                else
                    Mod.Log.Warn($"No game names found for {request.Category} ({request.VanillaId ?? "no ID"}); skipping them.");
            }
            if ((sources & NameSources.Syllables) != 0)
                available.Add(m_Syllables);
            if ((sources & NameSources.CustomFile) != 0)
            {
                if (CustomFile.IsAvailable(request))
                    available.Add(CustomFile);
                else
                    Mod.Log.Warn($"Custom names file for {request.Category} is empty; skipping it.");
            }

            if (available.Count == 0)
                return m_Vanilla.IsAvailable(request) ? m_Vanilla : m_Syllables;
            return available[m_Random.Next(available.Count)];
        }
    }
}
