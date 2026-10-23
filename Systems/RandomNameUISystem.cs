using Colossal.UI.Binding;
using Game.Areas;
using Game.Net;
using Game.Prefabs;
using Game.UI;
using Game.UI.InGame;
using RandomNames.Naming;
using Unity.Entities;

namespace RandomNames.Systems
{
    /// <summary>
    /// Handles the dice button next to the name in the selected info panel (see UI/src/mods/random-name-button.tsx).
    /// </summary>
    public partial class RandomNameUISystem : UISystemBase
    {
        private const string kGroup = "RandomNames";

        private NameSystem m_NameSystem;
        private PrefabSystem m_PrefabSystem;
        private SelectedInfoUISystem m_SelectedInfoUISystem;

        protected override void OnCreate()
        {
            base.OnCreate();
            m_NameSystem = World.GetOrCreateSystemManaged<NameSystem>();
            m_PrefabSystem = World.GetOrCreateSystemManaged<PrefabSystem>();
            m_SelectedInfoUISystem = World.GetOrCreateSystemManaged<SelectedInfoUISystem>();
            AddUpdateBinding(new GetterValueBinding<bool>(kGroup, "canRandomizeSelected", () => TryGetSelectedCategory(out _)));
            AddBinding(new TriggerBinding(kGroup, "randomizeSelectedName", RandomizeSelectedName));
        }

        // Streets are road aggregates; the info panel selects the aggregate when you click a road.
        private bool TryGetSelectedCategory(out NameCategory category)
        {
            var entity = m_SelectedInfoUISystem.selectedEntity;
            category = default;
            if (entity == Entity.Null)
                return false;

            if (EntityManager.HasComponent<Aggregate>(entity))
                category = NameCategory.Street;
            else if (EntityManager.HasComponent<District>(entity))
                category = NameCategory.District;
            else
                return false;
            return true;
        }

        private void RandomizeSelectedName()
        {
            if (!TryGetSelectedCategory(out var category))
                return;

            var entity = m_SelectedInfoUISystem.selectedEntity;
            var vanillaId = VanillaSource.GetLocalizationId(EntityManager, m_PrefabSystem, entity);
            var name = Mod.Generator.Generate(Mod.Settings.GetSources(category), category, vanillaId);
            m_NameSystem.SetCustomName(entity, name);
            m_SelectedInfoUISystem.RequestUpdate();
        }
    }
}
