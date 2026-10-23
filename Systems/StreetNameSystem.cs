using Game;
using Game.Common;
using Game.Net;
using Game.Prefabs;
using Game.Tools;
using Game.UI;
using RandomNames.Naming;
using Unity.Collections;
using Unity.Entities;

namespace RandomNames.Systems
{
    /// <summary>
    /// Gives every newly created street (a road "aggregate") a random custom name.
    /// Custom names are stored in the save, so cities keep their names if the mod is removed.
    /// </summary>
    public partial class StreetNameSystem : GameSystemBase
    {
        private NameSystem m_NameSystem;
        private PrefabSystem m_PrefabSystem;
        private EntityQuery m_CreatedAggregateQuery;

        protected override void OnCreate()
        {
            base.OnCreate();
            m_NameSystem = World.GetOrCreateSystemManaged<NameSystem>();
            m_PrefabSystem = World.GetOrCreateSystemManaged<PrefabSystem>();
            m_CreatedAggregateQuery = GetEntityQuery(
                ComponentType.ReadOnly<Aggregate>(),
                ComponentType.ReadOnly<Created>(),
                ComponentType.Exclude<Temp>(),
                ComponentType.Exclude<Deleted>());
            RequireForUpdate(m_CreatedAggregateQuery);
        }

        protected override void OnUpdate()
        {
            if (Mod.Settings == null || !Mod.Settings.RenameStreets)
                return;

            using var entities = m_CreatedAggregateQuery.ToEntityArray(Allocator.Temp);
            foreach (var entity in entities)
            {
                if (!IsRoad(entity) || m_NameSystem.TryGetCustomName(entity, out _))
                    continue;

                var vanillaId = VanillaSource.GetLocalizationId(EntityManager, m_PrefabSystem, entity);
                var name = Mod.Generator.Generate(Mod.Settings.GetSources(NameCategory.Street), NameCategory.Street, vanillaId);
                m_NameSystem.SetCustomName(entity, name);
            }
        }

        // Aggregates are normally roads, but skip any whose edges aren't roads, just in case.
        private bool IsRoad(Entity aggregate)
        {
            if (!EntityManager.HasBuffer<AggregateElement>(aggregate))
                return true;

            var elements = EntityManager.GetBuffer<AggregateElement>(aggregate, true);
            return elements.Length == 0 || EntityManager.HasComponent<Road>(elements[0].m_Edge);
        }
    }
}
