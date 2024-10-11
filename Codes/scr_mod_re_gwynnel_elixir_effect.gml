function scr_mod_re_gwynnel_elixir_effect()
{
    with (owner)
    {
        var _timestamp = scr_timeGetTimestamp()
        scr_npc_set_global_info("gwynnel_elixir_effect_timestamp", _timestamp)
    }
}