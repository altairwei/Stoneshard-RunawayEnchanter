function scr_mod_can_enchant_item()
{
    if (scr_npc_check_gold(400) && scr_instance_exists_item(o_inv_scroll_enchant))
        return true;
    else
        return false;
}