using ModShardLauncher;
using ModShardLauncher.Mods;

namespace RunawayEnchanter;
public static class Localization
{
    public static void PatchDialogs()
    {

    }

    public static void PatchNames()
    {
        Msl.InjectTableOccupationNamesLocalization(
            new LocalizationOccupationName(
                id: "npc_runaway_enchanter",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Elm"},
                    {ModLanguage.Chinese, "埃尔姆"}
                }
            )
        );
    }
}