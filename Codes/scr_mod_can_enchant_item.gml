function scr_mod_can_enchant_item()
{
    var _discount = argument[0]
    if (_discount)
    {
        if (scr_dialogue_complete("mod_re_runaway_enchanter_secret_agreement") && scr_npc_check_gold(200))
            return true
        else
            return false
    }
    else
    {
        if (scr_dialogue_uncomplete("mod_re_runaway_enchanter_secret_agreement") && scr_npc_check_gold(400))
            return true
        else
            return false
    }
}