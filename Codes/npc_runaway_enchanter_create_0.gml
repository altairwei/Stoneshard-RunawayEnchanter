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
ds_list_add(myfloor_list, "H1", "H1", "H2", "H2")
scr_create_skill_map("Discharge")
scr_create_skill_map("Impulse")
scr_create_skill_map("Short_Circuit")
scr_create_skill_map("Chain_Lightning")
scr_create_skill_map("Tempest")
scr_create_skill_map("Curse")
scr_create_skill_map("Life_Leech")
scr_create_skill_map("Seal_of_Shackles")
scr_create_skill_map("Seal_of_Power")
scr_create_skill_passive(o_pass_skill_dispersion)
scr_create_skill_passive(o_pass_skill_residual_charge)
scr_create_skill_passive(o_pass_skill_unlimited_power)
scr_create_skill_passive(o_pass_skill_inner_reserves)
myfloor = "H1"
myfloor_counter = "H1"
scr_set_hl()
time_period_night = do_animation
ai_script = gml_Script_scr_enemy_choose_state
idle_state = false
gold_k = irandom_range(100, 300)
chat = false
rumors = false
dialog_id = de2_dialog_open("runaway_enchanter.de2")
topic = "topicIntro"
event_user_number = 11
place = "tavern"
