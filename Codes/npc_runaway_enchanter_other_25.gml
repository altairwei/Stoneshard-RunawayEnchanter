if (!do_extra_enchantment)
{
    if scr_dialogue_complete("mod_re_runaway_enchanter_secret_agreement")
        scr_gold_write_off(200)
    else
        scr_gold_write_off(400)
}
else if (do_extra_enchantment)
{
    scr_gold_write_off(700)
    scr_delete_item(o_inv_ruby)
}

