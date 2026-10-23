using System.Collections.Generic;
using Game;
using Game.Areas;
using Game.Common;
using Game.Prefabs;
using Game.Routes;
using Game.Tools;
using Game.UI;
using RandomNames.Naming;
using Unity.Collections;
using Unity.Entities;

namespace RandomNames.Systems
{
    /// <summary>
    /// Gives every newly created transit line a random custom name.
    /// Custom names are stored in the save, so cities keep their names if the mod is removed.
    /// </summary>
    public partial class TransitLineNameSystem : GameSystemBase
    {
        private NameSystem m_NameSystem;
        private PrefabSystem m_PrefabSystem;
        private EntityQuery m_CreatedLineQuery;
        private EntityQuery m_DistrictQuery;

        protected override void OnCreate()
        {
            base.OnCreate();
            m_NameSystem = World.GetOrCreateSystemManaged<NameSystem>();
            m_PrefabSystem = World.GetOrCreateSystemManaged<PrefabSystem>();
            m_CreatedLineQuery = GetEntityQuery(
                ComponentType.ReadOnly<TransportLine>(),
                ComponentType.ReadOnly<Created>(),
                ComponentType.Exclude<Temp>(),
                ComponentType.Exclude<Deleted>());
            m_DistrictQuery = GetEntityQuery(
                ComponentType.ReadOnly<District>(),
                ComponentType.Exclude<Temp>(),
                ComponentType.Exclude<Deleted>());
            RequireForUpdate(m_CreatedLineQuery);
        }

        public string GenerateName(Entity line)
        {
            var vanillaId = VanillaSource.GetLocalizationId(EntityManager, m_PrefabSystem, line);
            return Mod.Generator.Generate(Mod.Settings.GetSources(NameCategory.TransitLine), NameCategory.TransitLine, vanillaId, GetDistrictNames());
        }

        // The names the districts show on the map: custom names, or the game's own in the active language.
        private List<string> GetDistrictNames()
        {
            using var districts = m_DistrictQuery.ToEntityArray(Allocator.Temp);
            var names = new List<string>(districts.Length);
            foreach (var district in districts)
                names.Add(m_NameSystem.GetRenderedLabelName(district));
            return names;
        }

        protected override void OnUpdate()
        {
            if (Mod.Settings == null || !Mod.Settings.RenameTransitLines)
                return;

            using var entities = m_CreatedLineQuery.ToEntityArray(Allocator.Temp);
            foreach (var entity in entities)
            {
                if (m_NameSystem.TryGetCustomName(entity, out _))
                    continue;

                m_NameSystem.SetCustomName(entity, GenerateName(entity));
            }
        }
    }
}
