using ModShardLauncher;
using ModShardLauncher.Mods;

namespace RunawayEnchanter;
public static class Localization
{
    public static void PatchDialogs()
    {
        Msl.InjectTableDialogLocalization(
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_intro",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "*神情明显慌张起来*......三手会的杂种？#...不是，那...嗝...没事别打扰我喝酒。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_who",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What do you do?"},
                    {ModLanguage.Chinese, "你是做什么的？"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_intro_2",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "做什么的？嗝...魔法师，嗯，就这样..."}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_whatmagic",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "你会什么魔法？"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_intro_3",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "*瞟了你一眼*#你看着像个雇佣兵，我会些能加强装备的魔法。#你如果能掏点钱，我可以给你更准更强的附魔。这事儿，市面上的附魔卷轴可做不到。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_welldone",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "那可真不错。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_who",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "你是谁？"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting1",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "铛铛铛，两种魔法碰在一起...哦...是你啊。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting2",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "在这躲着...嗝...也不是个事啊......"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting3",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, ""},
                    {ModLanguage.Chinese, "什么天火...骸骨...嗝...不如一瓶白兰地来的实在！"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_gretting",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What can I do for you?"},
                    {ModLanguage.Chinese, "嗝...有事吗？"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_to_enchant_pc",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I want to enchant an item. ~y~[400 crowns]~/~"},
                    {ModLanguage.Chinese, "我想要为物品附魔。~y~[400冠]~/~"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_extra_enchantment",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I want to add an extra enchantment to enchanted items. ~y~[700 crowns]~/~"},
                    {ModLanguage.Chinese, "我想要为附魔物品追加额外附魔。~y~[700冠]~/~"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_want_to_enchant_pc_discount",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I want to enchant an item. ~y~[200 crowns]~/~"},
                    {ModLanguage.Chinese, "我想要为物品附魔。~y~[200冠]~/~"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_ask_which_metatype",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What type of item do you want to enchant?"},
                    {ModLanguage.Chinese, "什么类型的东西需要附魔？"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_weapon",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Weapon."},
                    {ModLanguage.Chinese, "兵器。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_pc_armor_or_jewelry",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Armor or jewelry."},
                    {ModLanguage.Chinese, "防具或首饰。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_runaway_enchanter_ask_which_enchantment",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Which attribute would you like to add to the item?"},
                    {ModLanguage.Chinese, "呵...想要什么样的附魔？"}
                }
            ),

            // Enchantments
            new LocalizationSentence(
                id: "mod_re_enchantment_Block_Power",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Block Power."},
                    {ModLanguage.Chinese, "格挡力量。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Caustic_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Caustic Damage."},
                    {ModLanguage.Chinese, "腐蚀伤害。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Fire_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Fire Damage."},
                    {ModLanguage.Chinese, "灼烧伤害。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Frost_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Frost Damage."},
                    {ModLanguage.Chinese, "霜冻伤害。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Poison_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Poison Damage."},
                    {ModLanguage.Chinese, "中毒伤害。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Shock_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Shock Damage."},
                    {ModLanguage.Chinese, "电击伤害。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Hit_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Accuracy."},
                    {ModLanguage.Chinese, "准度。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Armor_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Armor Damage."},
                    {ModLanguage.Chinese, "护甲破坏。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Armor_Piercing",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Armor Penetration."},
                    {ModLanguage.Chinese, "护甲穿透。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Bleeding_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Bleed Chance."},
                    {ModLanguage.Chinese, "出血几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_PRR",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Block Chance."},
                    {ModLanguage.Chinese, "格挡几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Bodypart_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Bodypart Damage."},
                    {ModLanguage.Chinese, "肢体伤害。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Cooldown_Reduction",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Cooldowns Duration."},
                    {ModLanguage.Chinese, "冷却时间。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_CTA",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Counter Chance."},
                    {ModLanguage.Chinese, "反击几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_CRT",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Crit Chance."},
                    {ModLanguage.Chinese, "暴击几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_CRTD",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Crit Efficiency."},
                    {ModLanguage.Chinese, "暴击效果。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Daze_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Daze Chance."},
                    {ModLanguage.Chinese, "击晕几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Manasteal",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Energy Drain."},
                    {ModLanguage.Chinese, "精力吸取。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_FMB",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Fumble Chance."},
                    {ModLanguage.Chinese, "失手几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Knockback_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Knockback Chance."},
                    {ModLanguage.Chinese, "击退几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Lifesteal",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Life Drain."},
                    {ModLanguage.Chinese, "生命吸取。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Magic_Power",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Magic Power."},
                    {ModLanguage.Chinese, "法力。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Skills_Energy_Cost",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Skills Energy Cost."},
                    {ModLanguage.Chinese, "技能精力消耗。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Spells_Energy_Cost",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Spells Energy Cost."},
                    {ModLanguage.Chinese, "咒法精力消耗。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Stun_Chance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Stun Chance."},
                    {ModLanguage.Chinese, "硬直几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Weapon_Damage",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Weapon Damage."},
                    {ModLanguage.Chinese, "兵器伤害。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_HP",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Health."},
                    {ModLanguage.Chinese, "生命。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_MP",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Energy."},
                    {ModLanguage.Chinese, "精力。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Health_Restoration",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Health Restoration."},
                    {ModLanguage.Chinese, "生命自动恢复。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_MP_Restoration",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Energy Restoration."},
                    {ModLanguage.Chinese, "精力自动恢复。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_EVS",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Dodge Chance."},
                    {ModLanguage.Chinese, "闪躲几率。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Knockback_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Move Resistance."},
                    {ModLanguage.Chinese, "位移抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Stun_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Control Resistance."},
                    {ModLanguage.Chinese, "控制抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Magic_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Magic Resistance."},
                    {ModLanguage.Chinese, "魔法抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Nature_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Nature Resistance."},
                    {ModLanguage.Chinese, "自然抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Pain_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Pain Resistance."},
                    {ModLanguage.Chinese, "疼痛抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Physical_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Physical Resistance."},
                    {ModLanguage.Chinese, "物理抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Piercing_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Piercing Resistance."},
                    {ModLanguage.Chinese, "穿刺抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Slashing_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Slashing Resistance."},
                    {ModLanguage.Chinese, "劈砍抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Rending_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Rending Resistance."},
                    {ModLanguage.Chinese, "撕裂抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Blunt_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Crushing Resistance."},
                    {ModLanguage.Chinese, "钝击抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Unholy_Resistance",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Unholy Resistance."},
                    {ModLanguage.Chinese, "邪术抗性。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Fortitude",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Fortitude."},
                    {ModLanguage.Chinese, "坚忍。"}
                }
            ),
            new LocalizationSentence(
                id: "mod_re_enchantment_Healing_Received",
                sentence: new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Healing Efficiency."},
                    {ModLanguage.Chinese, "治疗效果。"}
                }
            )
        );
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