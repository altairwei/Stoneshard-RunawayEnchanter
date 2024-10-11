function scr_mod_can_extra_enchant_item()
{
    if !scr_npc_check_gold(700)
        return false

    with (owner)
    {
        var _timestamp = scr_npc_get_global_info("gwynnel_elixir_effect_timestamp")
        var _daysPassed = scr_timeGetPassed(_timestamp, "days")
    }

    if scr_quest_get_complete("mod_re_cure_elm")
        return true
    else if (_timestamp != 0 && _daysPassed < 7)
        return true
    else
        return false
}