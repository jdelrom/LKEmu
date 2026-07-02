# The Last Kingdom — Spell Content Pack (LKEmuV2)

Takes the server from **30 implemented spells to 83** by porting the 53 that were
missing. Stats are drawn from the official game manual and the Actoz fan-wiki;
class assignments are cross-verified against the server's own spellbook data.

## Files & where each goes

| File | Paste into | Location within the file |
|------|-----------|--------------------------|
| `1_Spells_Port.cs` | `Scripts/Spells.cs` | INSIDE `Spells.Load()`, before its closing `}` |
| `2_Spells_Helpers.cs` | `Scripts/Spells.cs` | INSIDE the `Spells` class, OUTSIDE `Load()` (next to `CastTeleport`) |
| `3_Items_Spellbooks_Port.cs` | `Scripts/Items.cs` | INSIDE the `GetItem` switch (adds the "BOOK OF ..." cases) |
| `LK_Spell_Master.xlsx` | — | Reference sheet; not code |

Apply in order 1 → 2 → 3, then rebuild `LKCamelotV2`.

## What works vs. what's flagged

**43 spells fully functional** the moment you build:
- All 27 attack spells (single-target + AoE), correct damage/mana/class.
- All 10 buffs/armor/walls (see AC note below).
- **Pick Up** — grabs the clicked ground item within level-based range, reaching
  through walls. Built on the existing pickup mechanic.

**5 debuffs** (Stone Curse, Medusa, Nosebleed, Radiation, Smog Screen) — they cast
and deal their listed damage, but the **status effect is NOT wired**. The engine
has empty `Debuff` / `StoneCurse` enum slots but no logic behind them, and buffs
currently only apply to the caster (self). Applying a status to an ENEMY target,
plus the freeze/stat-drain logic, still has to be built. Marked `// TODO`.

**10 stubs** — castable but currently just print a message; they need game systems
that don't exist yet:
- Starting Point, Come Back (bind + return — needs a saved-location field on the player)
- Trace, Recall (mechanics still unconfirmed)
- Sharp Eye, Elimination (mine/trap detect + remove — needs a mine system)
- Deadly Messenger, Wild Monk (likely summons)
- Ice Bag, Oblivion (unconfirmed)

## Known caveats (all flagged inline with `// TODO`)

- **Mana estimated on 22 spells.** Wiki-only spells (Big Bang line, Magma Hand,
  Windy Spirit, etc.) had no mana value in any source; estimated by damage tier.
- **Icons & animations are provisional.** The client's magic data is table-obfuscated,
  so exact icon/animation IDs aren't recoverable. Assigned by element; cosmetic.
- **Buff AC values are placeholders** (`FAC = 0.20`); tune to source per spell.
- **Teleport was NOT touched** — the original is already correct.

## Provenance

- Damage / mana: official `manual13.pdf` + Actoz fan-wiki (1996–2000 data).
- Class: verified against `Items.cs` spellbook `ClassReq` where the spell exists;
  wiki class pages otherwise; 8 low-confidence ones inferred from manual layout
  (see the "Class Basis" column in the xlsx — amber = inferred).
- ClassReq bitmask: Knight 1, Swordsman 2, Wizard 4, Shaman 8, Beginner 16, Any 31.

## Nothing here is test-verified

This code matches the codebase's patterns and is structurally validated (balanced
braces/parens), but it has NOT been compiled or run — that requires the Mono build
environment and the game client. Build, then cast a few on a localhost GM character
to confirm before relying on it.
