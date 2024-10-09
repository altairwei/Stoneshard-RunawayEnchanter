event_inherited()
on_tavern = true
town = "RottenWillow"
town_faction = "RottenWillow"
id_name = "npc_runaway_enchanter"
occupation = "occultist"
subtype = "townee"
name = ds_map_find_value(global.npc_info, id_name)
avatar = s_npc_SpecialDrunkard01d_P
ds_list_clear(myfloor_list)
ds_list_add(myfloor_list, "H1", "H1", "H1", "H1")
scr_create_skill_map("Fire_Barrage")
scr_create_skill_map("Flame_Wave")
scr_create_skill_map("Incineration")
scr_create_skill_map("Curse")
scr_create_skill_map("Life_Leech")
scr_create_skill_map("Seal_of_Shackles")
myfloor = "H1"
myfloor_counter = "H1"
scr_set_hl()
time_period_night = do_animation
ai_script = gml_Script_scr_enemy_choose_state
idle_state = false
gold_k = irandom_range(100, 300)
chat = false
rumors = false
