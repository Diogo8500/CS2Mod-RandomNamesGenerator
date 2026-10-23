import { ModRegistrar } from "cs2/modding";
import { PanelTitleBarExtension } from "mods/random-name-button";

const register: ModRegistrar = (moduleRegistry) => {
    // The selected info panel shows the object's name inside a PanelTitleBar.
    moduleRegistry.extend("game-ui/common/panel/panel-title-bar.tsx", "PanelTitleBar", PanelTitleBarExtension);
};

export default register;
