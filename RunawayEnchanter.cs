// Copyright (C) 2024 Altair Wei
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib.Models;

namespace RunawayEnchanter;
public class RunawayEnchanter : Mod
{
    public override string Author => "Altair";
    public override string Name => "Runaway Enchanter";
    public override string Description => "An Enchanter who escaped from the Order's Prison and now lives in seclusion at the Rotten Willow Inn. He can enchant your equipment with specified attributes.";
    public override string Version => "1.0.0";
    public override string TargetVersion => "0.8.2.10";

    public override void PatchMod()
    {
        // Create a new NPC

        UndertaleSprite s_npc_runaway_enchanter = Msl.GetSprite("s_npc_runaway_enchanter");
        s_npc_runaway_enchanter.CollisionMasks.RemoveAt(0);
        s_npc_runaway_enchanter.IsSpecialType = true;
        s_npc_runaway_enchanter.SVersion = 3;
        s_npc_runaway_enchanter.Width = 44;
        s_npc_runaway_enchanter.Height = 49;
        s_npc_runaway_enchanter.MarginLeft = 12;
        s_npc_runaway_enchanter.MarginRight = 31;
        s_npc_runaway_enchanter.MarginBottom = 39;
        s_npc_runaway_enchanter.MarginTop = 7;
        s_npc_runaway_enchanter.OriginX = 21;
        s_npc_runaway_enchanter.OriginY = 35;
        s_npc_runaway_enchanter.GMS2PlaybackSpeed = 1;
        s_npc_runaway_enchanter.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerGameFrame;

        UndertaleSprite s_npc_runaway_enchanter_sitting_idle = Msl.GetSprite("s_npc_runaway_enchanter_sitting_idle");
        s_npc_runaway_enchanter_sitting_idle.CollisionMasks.RemoveAt(0);
        s_npc_runaway_enchanter_sitting_idle.IsSpecialType = true;
        s_npc_runaway_enchanter_sitting_idle.SVersion = 3;
        s_npc_runaway_enchanter_sitting_idle.Width = 21;
        s_npc_runaway_enchanter_sitting_idle.Height = 33;
        s_npc_runaway_enchanter_sitting_idle.MarginLeft = 0;
        s_npc_runaway_enchanter_sitting_idle.MarginRight = 20;
        s_npc_runaway_enchanter_sitting_idle.MarginBottom = 32;
        s_npc_runaway_enchanter_sitting_idle.MarginTop = 0;
        s_npc_runaway_enchanter_sitting_idle.OriginX = 5;
        s_npc_runaway_enchanter_sitting_idle.OriginY = 38;
        s_npc_runaway_enchanter_sitting_idle.GMS2PlaybackSpeed = 0.3F;
        s_npc_runaway_enchanter_sitting_idle.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerGameFrame;

        UndertaleGameObject o_npc_runaway_enchanter = Msl.AddObject(
            name: "o_npc_runaway_enchanter",
            spriteName: "s_npc_runaway_enchanter",
            parentName: "o_village_standing",
            isVisible: true,
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        o_npc_runaway_enchanter.ApplyEvent(ModFiles,
            new MslEvent("npc_runaway_enchanter_create_0.gml", EventType.Create, 0),
            new MslEvent("npc_runaway_enchanter_precreate_0.gml", EventType.PreCreate, 0),
            new MslEvent("npc_runaway_enchanter_other_23.gml", EventType.Other, 23),
            new MslEvent("npc_runaway_enchanter_other_25.gml", EventType.Other, 25)
        );

        // Add the NPC to the room

        UndertaleRoom room = Msl.GetRoom("r_tavernWillow1floor");
        UndertaleRoom.Layer LayerTarget = Msl.GetLayer(room, UndertaleRoom.LayerType.Instances, "Targets");
        UndertaleRoom.Layer LayerNPC = Msl.GetLayer(room, UndertaleRoom.LayerType.Instances, "NPC");

        UndertaleRoom.GameObject o_NPC_target_runaway_enchanter = room.AddGameObject(
            LayerTarget,
            "o_NPC_target",
            Msl.AddCode(ModFiles.GetCode("taverninside_100_create.gml"), "gml_RoomCC_r_tavernWillow1floor_100_Create"),
            x: 598, y: 442
        );

        uint tagertID = o_NPC_target_runaway_enchanter.InstanceID;
        string codeRunawayEnchanter = string.Format(@ModFiles.GetCode("taverninside_101_create.gml"), tagertID);

        room.AddGameObject(
            LayerNPC, 
            "o_npc_runaway_enchanter", 
            Msl.AddCode(codeRunawayEnchanter, "gml_RoomCC_r_tavernWillow1floor_101_Create"),
            x: 610, y: 455
        );

        // Add a beer cup

        UndertaleRoom.Layer LayerForegroundInstances = Msl.GetLayer(room, UndertaleRoom.LayerType.Instances, "ForegroundInstances");
        UndertaleRoom.GameObject o_loot_marker = room.AddGameObject(
            LayerForegroundInstances,
            "o_loot_marker",
            Msl.AddCode("chance = 100\nloot = choose(o_loot_mug)\nhasOwner = false", "gml_RoomCC_r_tavernWillow1floor_102_Create"),
            x: 608, y: 426
        );
        o_loot_marker.ImageSpeed = 1;

        // Add enchant skill
        UndertaleGameObject o_skill_enchant_specify = Msl.AddObject(
            name: "o_skill_enchant_specify",
            spriteName: "sprite1",
            parentName: "o_weapon_skills",
            isVisible: true,
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        // Add functions

        Msl.AddFunction(ModFiles.GetCode("scr_mod_enchant_specify.gml"), "scr_mod_enchant_specify");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_enchant_generation.gml"), "scr_mod_enchant_generation");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_can_enchant_item.gml"), "scr_mod_can_enchant_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_prison_note_opened.gml"), "scr_mod_prison_note_opened");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_elm_do_extra_enchantment.gml"), "scr_mod_elm_do_extra_enchantment");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_can_extra_enchant_item.gml"), "scr_mod_can_extra_enchant_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_elm_miniquest.gml"), "scr_mod_elm_miniquest");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_re_gwynnel_elixir_effect.gml"), "scr_mod_re_gwynnel_elixir_effect");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_elm_take_artifact.gml"), "scr_mod_elm_take_artifact");

        o_skill_enchant_specify.ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_skill_enchant_specify_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_enchant_specify_Other_11.gml", EventType.Other, 11),
            new MslEvent("gml_Object_o_skill_enchant_specify_Other_20.gml", EventType.Other, 20)
        );

        // About the story of Elm

        Msl.LoadGML("gml_Object_o_inv_prison_note_Create_0")
            .MatchAll()
            .InsertBelow("script_after_close = gml_Script_scr_mod_prison_note_opened")
            .Peek()
            .Save();

        // Init the mini quest of backpack making (only works in a new game save)
        Msl.LoadGML("gml_GlobalScript_scr_init_quests")
            .MatchFrom("        scr_brynn_guild_init()")
            .InsertAbove(@"        scr_quest_init(""mod_re_cure_elm"", """", [""mod_re_find_artifacts"", 1, ""mod_re_find_artifacts_desc"", []])")
            .Save();

        Msl.AddMenu(
            "Runaway Enchanter",
            new UIComponent(
                name: "Press F1 to fix Elm's quest", associatedGlobal: "add_runaway_enchanter_miniquest",
                UIComponentType.CheckBox, 0)
        );

        Msl.LoadGML("gml_Object_o_player_KeyPress_112") // F1
            .MatchAll()
            .InsertBelow(@"
if (global.add_runaway_enchanter_miniquest)
{
    scr_quest_init(""mod_re_cure_elm"", """", [""mod_re_find_artifacts"", 1, ""mod_re_find_artifacts_desc"", []])
    audio_play_sound(snd_quest_update, 3, 0)
}")
            .Save();

        // Add localization text

        Localization.PatchNames();
        Localization.PatchDialogs();
        Localization.PatchQeusts();
    }
}
