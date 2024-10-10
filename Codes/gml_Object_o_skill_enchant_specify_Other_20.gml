event_inherited()
with (o_inv_slot)
{
    var _allowed_target = ds_map_find_value(data, "Metatype") == other.target_metatype
    if (!other.do_extra_enchantment && owner.object_index != o_trade_inventory && is_weapon && _allowed_target && scr_dsMapFindValue(data, "identified", false) && (!(scr_dsMapFindValue(data, "is_cursed", true))) && scr_dsMapFindValue(data, "quality", -4) != (6 << 0))
        image_alpha = 1
    else if (other.do_extra_enchantment && owner.object_index != o_trade_inventory && is_weapon && _allowed_target && scr_dsMapFindValue(data, "identified", false) && (!(scr_dsMapFindValue(data, "is_cursed", true))) && scr_dsMapFindValue(data, "quality", -4) == (2 << 0))
    {
        // Do not allow same enchantments
        var _key = ds_map_find_value(data, "key")
        if (!__is_undefined(_key) && _key != other.enchant_key)
            image_alpha = 1
        else
            image_alpha = 0.25
    }
    else
        image_alpha = 0.25
    can_pick = false
}
