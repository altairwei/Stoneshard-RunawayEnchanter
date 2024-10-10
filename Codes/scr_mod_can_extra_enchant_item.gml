function scr_mod_can_extra_enchant_item()
{
    if (scr_npc_check_gold(700) && scr_instance_exists_item(o_inv_ruby))
        return true
    else
        return false
}