event_inherited()
with (o_inv_slot)
{
    var _allowed_target = ds_map_find_value(data, "Metatype") == other.target_metatype
    if (owner.object_index != o_trade_inventory && is_weapon && _allowed_target && scr_dsMapFindValue(data, "identified", false) && (!(scr_dsMapFindValue(data, "is_cursed", true))) && scr_dsMapFindValue(data, "quality", -4) != (6 << 0))
        image_alpha = 1
    else
        image_alpha = 0.25
    can_pick = false
}
