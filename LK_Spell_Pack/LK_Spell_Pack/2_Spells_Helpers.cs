// ============================================================================
// NEW CAST HELPERS  ->  paste INSIDE the Spells class in Scripts/Spells.cs,
// next to CastTeleport / CastAoe / CastBuff (OUTSIDE the Load() method).
// ----------------------------------------------------------------------------
// NOTE: TELEPORT is intentionally NOT modified. vans163's original CastTeleport
//       already lands you on the clicked tile only when it's walkable, so it
//       stops at walls / lava / rivers / map edges yet still jumps OVER a wall
//       onto open space behind it. That is the correct behavior.
// ============================================================================

// Grabs the single ground item on the clicked tile, within level-based range.
// Reaches THROUGH barriers (range check only). Reuses the normal pickup path.
public static void CastPickup(Player.LeafSpell spell, Player.Player caster, int x, int y)
{
    var maxdist = (spell.Level / 2) * 2;   // same distance model as Teleport
    if (maxdist > 12) maxdist = 12;

    if (Point2D.Distance(caster.Position.X, caster.Position.Y, x, y) > maxdist)
        return;   // clicked item is out of range

    var obj = caster.Position.CurMap.Items.Skip(0)
        .Where(o => o.Value.Position.X == x && o.Value.Position.Y == y)
        .FirstOrDefault();

    if (obj.Value != null && caster.OnPickUp(obj.Value))
    {
        if (!obj.Value.Static)
            caster.Position.CurMap.Exit(obj.Value);   // remove from ground + notify
        if (obj.Value is Object.Item)
            (obj.Value as Object.Item).DroppedTime = null;
    }
}
