if (time_period == 2 || time_period == 3)
    topic = "topicLeave"
else
{
    if scr_dialogue_complete("mod_re_runaway_enchanter_intro")
        topic = "topicS" + string(irandom_range(1, 3))
    else
        topic = "topicIntro"
}

var _reputation = scr_globaltile_get("reputation", village_xy[0], village_xy[1])
if (_reputation >= 3000 && scr_quest_get_complete("mod_re_cure_elm") && scr_dialogue_complete("cursescroll_ready_to_sell") && scr_dialogue_uncomplete("mod_re_enchant_cursed_item_intro"))
{
    topic = "topicCurse"
}

event_inherited()