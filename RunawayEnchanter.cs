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
            new MslEvent("npc_runaway_enchanter_precreate_0.gml", EventType.PreCreate, 0)
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

        // Add localization text

        Localization.PatchNames();
    }
}
