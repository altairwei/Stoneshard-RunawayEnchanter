if scr_dialogue_complete("mod_re_runaway_enchanter_intro")
    topic = "topicS" + string(irandom_range(1, 3))

var _reputation = scr_globaltile_get("reputation", village_xy[0], village_xy[1])
if (_reputation >= 3000 && scr_quest_get_complete("mod_re_cure_elm") && scr_dialogue_complete("cursescroll_ready_to_sell") && scr_dialogue_uncomplete("enchant_cursed_item_ready"))
{
    topic = "topicCurse"
}

event_inherited()