:[100]
pushglb.v global.add_runaway_enchanter_miniquest
conv.v.b
bf [end]

:[101]
push.s "mod_re_cure_elm"
conv.s.v
push.i gml_Script_QuestDefinition
conv.i.v
call.i @@NewGMLObject@@(argc=2)
push.s "mod_re_find_artifacts"
conv.s.v
dup.v 1 8
dup.v 0
push.v stacktop.Task
callv.v 1
push.s "mod_re_find_artifacts_desc"
conv.s.v
dup.v 1 8
dup.v 0
push.v stacktop.SetDescription
callv.v 1
dup.v 0 8
dup.v 0
push.v stacktop.Register
callv.v 0
popz.v
pushi.e 0
conv.i.v
pushi.e 3
conv.i.v
pushi.e 1013
conv.i.v
call.i audio_play_sound(argc=3)
popz.v
