event_inherited()
with (o_inv_slot)
{
    var _curse_enchant = scr_dialogue_complete("mod_re_enchant_cursed_item_intro")
    var _allowed_target = ds_map_find_value(data, "Metatype") == other.target_metatype
    var _is_your_item = owner.object_index != o_trade_inventory && is_weapon && _allowed_target && ds_map_find_value_ext(data, "identified", false)
    if (!other.do_extra_enchantment && _is_your_item && (!(ds_map_find_value_ext(data, "is_cursed", true))) && ds_map_find_value_ext(data, "quality", -4) != (6 << 0))
        image_alpha = 1
    else if (other.do_extra_enchantment && _is_your_item && (!(ds_map_find_value_ext(data, "is_cursed", true))) && ds_map_find_value_ext(data, "quality", -4) == (2 << 0))
    {
        // Do not allow same enchantments
        var _key = ds_map_find_value(data, "key")
        if (!__is_undefined(_key) && _key != other.enchant_key)
            image_alpha = 1
        else
            image_alpha = 0.25
    }
    else if (_curse_enchant && ds_map_find_value_ext(data, "is_cursed", false) && _is_your_item)
    {
        var _quality = ds_map_find_value(data, "cursedQuality")
        if (!other.do_extra_enchantment)
            image_alpha = 1
        else if (other.do_extra_enchantment && _quality == (2 << 0))
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
    }
    else
        image_alpha = 0.25
    can_pick = false
}
