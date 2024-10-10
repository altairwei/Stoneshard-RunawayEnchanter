function scr_mod_enchant_specify()
{
    scr_close_dialog()

    with (owner)
    {
        with (instance_create_depth(x, y, 0, o_skill_enchant_specify))
        {
            parent = other.id
            do_extra_enchantment = other.do_extra_enchantment
            target_metatype = argument0
            enchant_key = argument1
            event_user(10)
        }
    }
}