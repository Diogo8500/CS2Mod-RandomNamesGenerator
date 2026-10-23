using Game;
using Game.Areas;
using Game.Common;
using Game.Prefabs;
using Game.Tools;
using Game.UI;
using RandomNames.Naming;
using Unity.Collections;
using Unity.Entities;

namespace RandomNames.Systems
{
    /// <summary>
    /// Gives every newly drawn district a random custom name.
    /// Custom names are stored in the save, so cities keep their names if the mod is removed.
    /// </summary>
    public partial class DistrictNameSystem : GameSystemBase
    {
        private NameSystem m_NameSystem;
        private PrefabSystem m_PrefabSystem;
        private EntityQuery m_CreatedDistrictQuery;

        protected override void OnCreate()
        {
            base.OnCreate();
            m_NameSystem = World.GetOrCreateSystemManaged<NameSystem>();
            m_PrefabSystem = World.GetOrCreateSystemManaged<PrefabSystem>();
            m_CreatedDistrictQuery = GetEntityQuery(
                ComponentType.ReadOnly<District>(),
                ComponentType.ReadOnly<Created>(),
                ComponentType.Exclude<Temp>(),
                ComponentType.Exclude<Deleted>());
            RequireForUpdate(m_CreatedDistrictQuery);
        }

        protected override void OnUpdate()
        {
            if (Mod.Settings == null || !Mod.Settings.RenameDistricts)
                return;

            using var entities = m_CreatedDistrictQuery.ToEntityArray(Allocator.Temp);
            foreach (var entity in entities)
            {
                if (m_NameSystem.TryGetCustomName(entity, out _))
                    continue;

                var vanillaId = VanillaSource.GetLocalizationId(EntityManager, m_PrefabSystem, entity);
                var name = Mod.Generator.Generate(Mod.Settings.GetSources(NameCategory.District), NameCategory.District, vanillaId);
                m_NameSystem.SetCustomName(entity, name);
            }
        }
    }
}
