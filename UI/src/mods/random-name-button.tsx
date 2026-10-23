import { ComponentType, ReactElement } from "react";
import { bindValue, trigger, useValue } from "cs2/api";
import { useLocalization } from "cs2/l10n";
import { getModule } from "cs2/modding";
import { Button, FOCUS_DISABLED, Tooltip } from "cs2/ui";
import styles from "./random-name-button.module.scss";

// Same theme as the buttons in the info panel's footer, for matching hover and pressed effects.
const actionButtonTheme = getModule(
    "game-ui/game/components/selected-info-panel/selected-info-sections/shared-sections/actions-section/action-button.module.scss",
    "classes"
);

// Set by RandomNameUISystem.cs.
const canRandomizeSelected$ = bindValue<boolean>("RandomNames", "canRandomizeSelected", false);

// Vanilla binding. The selected info panel's title passes "<selectedInfoPanelTitle>+<tag>" as its tutorial uiTag,
// which is how we tell its title bar apart from every other panel's.
const manualUITags$ = bindValue<{ selectedInfoPanelTitle?: string } | null>("prefabs", "manualUITags", null);

const randomizeSelectedName = () => trigger("RandomNames", "randomizeSelectedName");

const isSelectedInfoPanelTitle = (children: unknown, titleTag: string | undefined) => {
    const uiTag = (children as ReactElement | undefined)?.props?.uiTag;
    return !!titleTag && typeof uiTag === "string" && uiTag.startsWith(`${titleTag}+`);
};

// TitleSection itself can't be extended (the game declares it as a const), so we extend the
// PanelTitleBar it renders into and add the button next to the name.
export const PanelTitleBarExtension = (PanelTitleBar: ComponentType<any>) => (props: any) => {
    const canRandomize = useValue(canRandomizeSelected$);
    const tags = useValue(manualUITags$);
    // Strings come from Locale/Translations.*.cs ("UI.RandomName").
    const { translate } = useLocalization();

    if (!canRandomize || !isSelectedInfoPanelTitle(props.children, tags?.selectedInfoPanelTitle))
        return <PanelTitleBar {...props} />;

    return (
        <PanelTitleBar {...props}>
            <div className={styles.row}>
                <div className={styles.title}>{props.children}</div>
                <Tooltip tooltip={translate("RandomNames.RandomName", "Random name")}>
                    <Button
                        variant="icon"
                        src="Media/Glyphs/Dice.svg"
                        tinted
                        focusKey={FOCUS_DISABLED}
                        theme={actionButtonTheme}
                        className={styles.button}
                        onSelect={randomizeSelectedName}
                    />
                </Tooltip>
            </div>
        </PanelTitleBar>
    );
};
