using Colossal.IO.AssetDatabase;
using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
using RandomNames.Locale;
using RandomNames.Naming;
using RandomNames.Systems;

namespace RandomNames
{
    public class Mod : IMod
    {
        public static ILog Log = LogManager.GetLogger($"{nameof(RandomNames)}.{nameof(Mod)}").SetShowsErrorsInUI(false);

        public static Setting Settings { get; private set; }
        public static NameGenerator Generator { get; private set; }

        public void OnLoad(UpdateSystem updateSystem)
        {
            Log.Info(nameof(OnLoad));

            Generator = new NameGenerator();

            Settings = new Setting(this);
            Settings.RegisterInOptionsUI();
            foreach (var pair in Translations.ByLocale)
                GameManager.instance.localizationManager.AddSource(pair.Key, new LocaleSource(Settings, pair.Value));
            AssetDatabase.global.LoadSettings(nameof(RandomNames), Settings, new Setting(this));

            // NameSystem.SetCustomName needs EndFrameBarrier, which is locked during the Modification phases.
            // UIUpdate runs after the barrier is unlocked and before the Created tags are cleaned up.
            updateSystem.UpdateAt<StreetNameSystem>(SystemUpdatePhase.UIUpdate);
            updateSystem.UpdateAt<DistrictNameSystem>(SystemUpdatePhase.UIUpdate);
            updateSystem.UpdateAt<TransitLineNameSystem>(SystemUpdatePhase.UIUpdate);
            updateSystem.UpdateAt<RandomNameUISystem>(SystemUpdatePhase.UIUpdate);
        }

        public void OnDispose()
        {
            Log.Info(nameof(OnDispose));
            if (Settings != null)
            {
                Settings.UnregisterInOptionsUI();
                Settings = null;
            }
        }
    }
}
