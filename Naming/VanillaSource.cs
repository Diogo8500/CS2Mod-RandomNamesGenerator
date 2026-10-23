using System;
using Colossal.Entities;
using Game.Common;
using Game.Prefabs;
using Game.SceneFlow;
using Game.UI.Localization;
using Unity.Entities;

namespace RandomNames.Naming
{
    /// <summary>
    /// Picks one of the game's own names, the same way the game names new streets and districts: a random
    /// index into the prefab's RandomLocalization ID, like "Assets.STREET_NAME:12", in the active language.
    /// </summary>
    public class VanillaSource : INameSource
    {
        // Mirrors NameSystem.GetId, minus the index the entity already has.
        public static string GetLocalizationId(EntityManager entityManager, PrefabSystem prefabSystem, Entity entity)
        {
            if (!entityManager.TryGetComponent<PrefabRef>(entity, out var prefabRef) ||
                !prefabSystem.TryGetPrefab<PrefabBase>(prefabRef.m_Prefab, out var prefab))
                return null;

            return prefab.TryGet<Game.Prefabs.Localization>(out var localization) && localization is RandomLocalization
                ? localization.m_LocalizationID
                : null;
        }

        public bool IsAvailable(NameRequest request) => GetCount(request.VanillaId) > 0;

        public string Generate(Random random, NameRequest request)
        {
            var index = new RandomLocalizationIndex(random.Next(GetCount(request.VanillaId)));
            var id = LocalizationUtils.AppendIndex(request.VanillaId, index);
            return GameManager.instance.localizationManager.activeDictionary.TryGetValue(id, out var name) ? name : id;
        }

        private static int GetCount(string id)
        {
            if (id == null)
                return 0;
            return GameManager.instance.localizationManager.activeDictionary.indexCounts.TryGetValue(id, out var count) ? count : 0;
        }
    }
}
