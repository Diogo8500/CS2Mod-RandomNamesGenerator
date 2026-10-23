# Roll a Name (Cities: Skylines II mod)

Adds a dice button next to a street's or district's name in its info panel. Click it to give it a random name.
Optionally (off by default), newly built streets and newly drawn districts get a random name automatically.
Random names for buildings, citizens, vehicles, animals and transit lines are planned for future updates.

In **Options > Roll a Name**, tick any combination of name sources, separately for streets and for
districts. Each name comes from one of the ticked sources, picked at random:

- **Vanilla names**: picks from the game's own names, the same lists it uses to name new streets and
  districts, in the language you're playing in. (Portuguese has no district names, so the game falls
  back to English ones.)
- **Curated names**: generates names from pre-built prefixes, names and suffixes, like "Oakbrook Avenue",
  "Harrington Lane", "Old Ashford" or "Maple Heights". Think of it as an extension pack for the vanilla names.
- **Custom names files**: picks lines at random from `StreetNames.txt` or `DistrictNames.txt` in
  `%USERPROFILE%\AppData\LocalLow\Colossal Order\Cities Skylines II\ModsData\RandomNames\`.

The mod saves these names as normal custom names, so they stay in your save if you remove the mod.
Automatic naming only applies to new streets and districts: editing a road or district keeps its current name.

## Building

1. Install the game, start it, and go to **Options > Modding**. Install the modding toolchain
   (it installs .NET, the `CSII_*` environment variables, and so on), then restart your PC.
2. Install Node.js 18 or later (needed for the UI module in `UI/`).
3. Open `RandomNames.csproj` in Visual Studio 2022 or Rider, or run `dotnet build -c Release`.
   The toolchain's `Mod.targets` copies the built mod into your local Mods folder, then the `BuildUI`
   target runs `npm install` (first time only) and `npm run build` to add `RandomNames.mjs`.
   While working on the UI only, `npm run dev` in `UI/` rebuilds it on every save.
4. Start the game. The mod's settings appear in the Options menu.

## Translations

All user-facing text lives in `Locale/Translations.<locale>.cs`, one file per game language, with English
(`Translations.en-US.cs`) as the reference. Keys are short names (`Label.RenameStreets`, `Desc.RenameStreets`,
`Group.Streets`, `UI.RandomName`, ...) that `LocaleSource` turns into the game's localization IDs; `UI.X` keys become
`RandomNames.X` for the UI module. A key missing from a language falls back to English. To add a string, add it to
every file; to add a language, add a file and register it in `Translations.ByLocale`.

## Adding more name types later

1. Add a value to `NameCategory` (for example `TransitLine`), and handle it in `SyllableSource` and
   `CustomFileSource` (which needs a names file for it). `VanillaSource` needs no changes: it uses
   whatever `RandomLocalization` the entity's prefab has.
2. Add a system under `Systems/` that finds the new entities and calls `NameSystem.SetCustomName`.
   Use `DistrictNameSystem` as the pattern.
3. Recognise the new entity in `RandomNameUISystem.TryGetSelectedCategory` so the dice button shows up.
4. Add a group with an auto-name toggle and source checkboxes for the new type in `Setting.cs`
   (handled in `GetSources`), and register the system in `Mod.OnLoad`.

## License

[MIT](LICENSE)
