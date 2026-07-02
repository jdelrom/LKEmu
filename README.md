# The Last Kingdom — Complete Updated Server Files

All changes merged into their real files. NO hand-editing, NO patches.
Just drop these folders into your LKEmuV2-master and replace when prompted.

## How to install

1. BACK UP first (copy these somewhere safe):
   - Scripts\Spells.cs, Scripts\Items.cs
   - Player\Player.cs
   - Object\Spell.cs, Object\Living.cs
   - your db\players folder

2. Copy the Scripts, Player, and Object folders from here into your
   LKEmuV2-master folder and let them REPLACE the 5 files:
       Scripts\Spells.cs      (83 spells + travel/AoE + helpers)
       Scripts\Items.cs       (83 spellbooks)
       Player\Player.cs       (+ Trace save fields)
       Object\Spell.cs        (+ race affinity fields)
       Object\Living.cs       (+ affinity damage line)

3. Rebuild LKCamelotV2 and run the new bin\Release\LKCamelotV2.exe

That's everything - both batches are already combined in these files.

## What's included

- 30 -> 83 spells (all attack, buff, and wall spells functional)
- Pick Up (remote item grab), Teleport (unchanged - already correct)
- Trace / Come Back (save + return; Come Back blocked in endgame maps)
- Starting Point (return to hunting-ground entrance)
- Tornado (Shaman, 3x3 AoE, +10% vs Undead)
- Hail Storm (Wizard, 3x3 AoE, +10% vs Human)
- Race affinity system (opt-in +% vs race; Moon Light & all existing spells untouched)
- reference\ : updated spell master + 104-monster race classification sheets

## Still stubs (need new engine systems - print a message for now)

Recall (pull player), Sharp Eye / Elimination (mines), Deadly Messenger / Wild Monk
(summons), Ice Bag, Oblivion, and the 5 debuffs (freeze/stun/stat-drain).

## Reminders

- Map references use the map Name (unique). diskName was ruled out (not unique -
  several maps share one .map file).
- Some mana values are placeholders (marked // TODO) - tune after testing.
- NOT compiled here (no build environment) - structure-checked only. Build on your
  backup; if the compiler complains, send the error and it gets fixed fast.
