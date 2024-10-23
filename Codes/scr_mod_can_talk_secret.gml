function scr_mod_can_talk_secret()
{
    return scr_dialogue_complete("mod_re_runaway_enchanter_secret")
                && scr_dialogue_uncomplete("mod_re_runaway_enchanter_secret_agreement")
}