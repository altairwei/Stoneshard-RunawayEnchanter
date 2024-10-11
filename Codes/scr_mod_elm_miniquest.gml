function scr_mod_elm_miniquest()
{
    if argument_count > 0
    {
        switch (argument[0])
        {
            case "inquiry":
                // Should start mini quest dialog?
                if !scr_dialogue_complete("mod_re_intro_miniquest")
                    return true;
                else
                    return false;
            case "ready":
                // Should check artifacts or elixir?
                if scr_quest_get_started("mod_re_cure_elm") && !scr_quest_get_complete("mod_re_cure_elm")
                    return true;
                else
                    return false;
            case "complete":
                scr_quest_set_progress("mod_re_cure_elm", "mod_re_find_artifacts", 1)
                scr_quest_set_complete("mod_re_cure_elm")
                break;
            default:
                return false;
        }
    }
    else
    {
        // Start mini quest.
        scr_quest_start("mod_re_cure_elm")
        scr_quest_set_progress("mod_re_cure_elm", "mod_re_find_artifacts", 0)
        scr_dialogue_complete("mod_re_intro_miniquest", true)
        scr_close_dialog()
    }
}