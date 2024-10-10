if (interact_id == noone)
    interact_id = instance_position(global.guiMouseX, global.guiMouseY, o_inv_slot)
var _success = false
with (interact_id)
{
    if (image_alpha == 1)
    {
        scr_mod_enchant_generation(other.enchant_key)
        if inmouse
        {
            scr_guiInteractiveEventPerform(id, 1)
            scr_guiInteractiveEventPerform(id, 0)
        }
        _success = true
    }
}
if _success
{
    with (parent)
    {
        //scr_actionsLog("useItem", [scr_id_get_name(o_player), log_text, ds_map_find_value(data, "Name")])
        sh_diss = 200
        event_user(15)
    }
    audio_play_sound(snd_gui_identification, 4, 0)
    event_user(0)
}
interact_id = noone
