function scr_mod_secret_agreement()
{
    scr_dialogue_complete("mod_re_runaway_enchanter_secret_agreement", true)
    scr_close_dialog()

    with (scr_guiCreateContainer(global.guiBaseContainerVisible, o_reward_container))
    {
        with (scr_inventory_add_item(o_inv_gold))
            stack = 1000
    }
}