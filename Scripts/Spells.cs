using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LKCamelotV2.Object;
using LKCamelotV2.Player;

namespace LKCamelotV2.Scripts
{
    public static class Spells
    {
        public static Dictionary<string, Spell> SpellList = new Dictionary<string, Spell>();
        public static void Load()
        {
            SpellList.Add("FLAME ROUND", new Spell("FLAME ROUND", 18, E_MagicType.Casted, new SpellSequence
                 (40, 25, 15, 0, 1, 6, 0))
                 {
                     Dam = 64,
                     DamPl = 6,
                     ManaCost = 54,
                     Range = 7,
                     Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                         (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) => { CastAoe(s, p); })
                 });
            SpellList.Add("THUNDER CROSS", new Spell("THUNDER CROSS", 24, E_MagicType.Casted, new SpellSequence
                 (46, 32, 0, 0, 1, 5, 0))
            {
                Dam = 132,
                DamPl = 8,
                ManaCost = 105,
                Range = 7,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) => { CastAoe(s, p); })
            });
            SpellList.Add("ELECTRONIC BALL", new Spell("ELECTRONIC BALL", 58, E_MagicType.Target2, new SpellSequence
                 (45, 32, 0, 0, 0, 9, 0))
            {
                Dam = 30,
                DamPl = 5,
                ManaCost = 25,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar);
                    })
            });
            SpellList.Add("FIRE BALL", new Spell("FIRE BALL", 12, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 40,
                DamPl = 6,
                ManaCost = 32,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar);
                    })
            });
            SpellList.Add("ZIG ZAG", new Spell("ZIG ZAG", 21, E_MagicType.Target2, new SpellSequence
                 (0, 32, 0, 0, 0, 7, 0))
            {
                Dam = 18,
                DamPl = 4,
                ManaCost = 16,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar);
                    })
            });
            SpellList.Add("MOON LIGHT", new Spell("MOON LIGHT", 37, E_MagicType.Target2, new SpellSequence
                 (0, 81, 0, 0, 0, 8, 0))
            {
                Dam = 42,
                DamPl = 6,
                ManaCost = 28,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar, race: E_Race.Undead | E_Race.Animal);
                    })
            });
            SpellList.Add("SHOOTING STAR", new Spell("SHOOTING STAR", 37, E_MagicType.Target2, new SpellSequence
                 (0, 81, 0, 0, 0, 8, 0))
            {
                Dam = 88,
                DamPl = 8,
                ManaCost = 32,
                ClassReq = (int)E_Class.Knight | (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar, race: E_Race.Undead | E_Race.Animal);
                    })
            });
            SpellList.Add("MORNING STAR", new Spell("MORNING STAR", 37, E_MagicType.Target2, new SpellSequence
                 (0, 0, 73, 0, 3, 30, 0))
            {
                Dam = 88,
                DamPl = 8,
                ManaCost = 44,
                ClassReq = (int)E_Class.Swordsman | (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                        {
                            p.Position.CurMap.Events.OnMagcEffect(tar, s.Spell.SpellSeq.OnImpactSprite);
                            CastSingleTarget(s, p, tar, race: E_Race.Undead | E_Race.Animal);
                        }
                    })
            });
            SpellList.Add("SORCERER HUNTER", new Spell("SORCERER HUNTER", 37, E_MagicType.Target2, new SpellSequence
                 (0, 0, 73, 0, 3, 30, 0))
            {
                Dam = 152,
                DamPl = 10,
                ManaCost = 125,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                        {
                            p.Position.CurMap.Events.OnMagcEffect(tar, s.Spell.SpellSeq.OnImpactSprite);
                            CastSingleTarget(s, p, tar, race: E_Race.Magical | E_Race.Demon);
                        }
                    })
            });
            SpellList.Add("FLAME WAVE", new Spell("FLAME WAVE", 16, E_MagicType.Target2, new SpellSequence
                 (0, 52, 0, 3, 0, 8, 0))
            {
                Dam = 52,
                DamPl = 6,
                ManaCost = 38,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar);
                    })
            });
            SpellList.Add("LIGHTNING", new Spell("LIGHTNING", 22, E_MagicType.Target2, new SpellSequence
                 (0, 30, 0, 0, 0, 12, 4))
            {
                Dam = 60,
                DamPl = 6,
                ManaCost = 40,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar);
                    })
            });
            SpellList.Add("THUNDER BOLT", new Spell("THUNDER BOLT", 58, E_MagicType.Target2, new SpellSequence
                 (0, 79, 30, 0, 0, 9, 0))
            {
                Dam = 112,
                DamPl = 6,
                ManaCost = 60,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar, E_Race.Undead | E_Race.Animal | E_Race.Demon);
                    })
            });
            SpellList.Add("HONEST BOLT", new Spell("HONEST BOLT", 36, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 556,
                DamPl = 11,
                FManaCost = 0.64f,
                FManaCostPl = 0.04f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar, E_Race.Undead | E_Race.Animal | E_Race.Demon);
                    })
            });
            SpellList.Add("GHOST HUNTER", new Spell("GHOST HUNTER", 36, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 146,
                DamPl = 10,
                ManaCost = 79,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar, E_Race.Magical | E_Race.Demon);
                    })
            });
            SpellList.Add("FIRE SHOT", new Spell("FIRE SHOT", 13, E_MagicType.Target2, new SpellSequence
                 (41, 26, 20, 0, 0, 9, 0))
            {
                Dam = 352,
                DamPl = 8,
                ManaCost = 180,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar);
                    })
            });
            SpellList.Add("SIDEWINDER", new Spell("SIDEWINDER", 41, E_MagicType.Target2, new SpellSequence
                 (8, 37, 0, 0, 0, 9, 0))
            {
                Dam = 290,
                DamPl = 10,
                FManaCost = 0.72f,
                FManaCostPl = 0.04f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                            CastSingleTarget(s, p, tar);
                    })
            });

            SpellList.Add("TELEPORT", new Spell("TELEPORT", 53, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 0xFF, 0, 0))
            {
                ManaCost = 125,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastTeleport(s, p, tarloc.X, tarloc.Y);
                    })
            });
            SpellList.Add("VIEW", new Spell("VIEW", 9, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 0xFF, 0, 0))
            {
                ManaCost = 5,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastView(s, p, tar);
                    })
            });
            SpellList.Add("TRANSPARENCY", new Spell("TRANSPARENCY", 10, E_MagicType.Casted, new SpellSequence
                 (0, 0, 0, 0, 0xFF, 0, 0))
            {
                FManaCost = 0.55f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastTransparency(s, p);
                    })
            });

            SpellList.Add("MAGIC SHIELD", new Buff("MAGIC SHIELD", 27, E_MagicType.Casted, new SpellSequence
                 (5, 0, 0, 0, 0, 3, 0))
            {
                ManaCost = 76,
                AC = 4,
                ACpl = 4,
                BuffEffect = Object.BuffEffect.ManaAsHp,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });
            SpellList.Add("TEAGUE SHIELD", new Buff("TEAGUE SHIELD", 28, E_MagicType.Casted, new SpellSequence
                 (6, 0, 0, 0, 0, 3, 0))
            {
                ManaCost = 66,
                Dam = 30,
                DamPl = 5,
                AC = 4,
                ACpl = 4,
                BuffEffect = Object.BuffEffect.ManaAsHp,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });
            SpellList.Add("FIRE PROTECTOR", new Buff("FIRE PROTECTOR", 19, E_MagicType.Casted, new SpellSequence
                 (70, 0, 0, 0, 0, 3, 0))
            {
                FManaCost = 0.50f,
                FManaCostPl = 0.02f,
                Dam = 60,
                DamPl = 6,
                FAC = 0.25f,
                FACpl = 0.01f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });
            SpellList.Add("GUARDIAN SWORD", new Buff("GUARDIAN SWORD", 31, E_MagicType.Casted, new SpellSequence
                 (3, 0, 0, 0, 0, 3, 0))
            {
                FManaCost = 0.25f,
                FAC = 0.20f,
                FACpl = 0.01f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });
            SpellList.Add("ELECTRONIC TUBE", new Buff("ELECTRONIC TUBE", 26, E_MagicType.Casted, new SpellSequence
                 (12, 0, 0, 0, 0, 3, 0))
            {
                FManaCost = 0.70f,
                FManaCostPl = 0.04f,
                Dam = 147,
                DamPl = 10,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });
            SpellList.Add("MAGIC ARMOR", new Buff("MAGIC ARMOR", 35, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                FManaCost = 0.20f,
                FAC = 0.16f,
                FACpl = 0.01f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });
            SpellList.Add("MENTAL SWORD", new Buff("MENTAL SWORD", 50, E_MagicType.Casted, new SpellSequence
                 (63, 0, 0, 0, 0, 0, 0))
            {
                FManaCost = 0.33f,
                FDam = 0.7f,
                FDampl = 0.1f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });
            SpellList.Add("RAINBOW ARMOR", new Buff("RAINBOW ARMOR", 30, E_MagicType.Casted, new SpellSequence
                 (73, 0, 0, 0, 0, 1, 0))
            {
                FManaCost = 0.53f,
                FManaCostPl = 0.03f,
                FAC = 0.35f,
                FACpl = 0.01f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastBuff(s, p);
                    })
            });

            SpellList.Add("HEAL", new Buff("HEAL", 1, E_MagicType.Casted, new SpellSequence
                 (1, 0, 0, 0, 3, 3, 0))
            {
                ManaCost = 36,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastHeal(s, p);
                    })
            });
            SpellList.Add("PLUS HEAL", new Buff("PLUS HEAL", 2, E_MagicType.Target2, new SpellSequence
                 (0, 1, 0, 0, 0, 6, 3))
            {
                ManaCost = 118,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        CastHeal(s, tar as Living);
                    })
            });

            #region WIZARD
            SpellList.Add("DEADLY BOOM", new Spell("DEADLY BOOM", 69, E_MagicType.Target2, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 541,
                DamPl = 14,
                FManaCost = 0.70f,
                FManaCostPl = 0.05f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    {
                        if (tar != null)
                        {
                            p.Position.CurMap.Events.OnMagcEffect(tar, s.Spell.SpellSeq.OnImpactSprite);
                            CastSingleTarget(s, p, tar);
                        }
                    })
            });
            #endregion


            // ===== ADDED: 53 ported spells =====

            #region PORTED - Common
            SpellList.Add("STARTING POINT", new Spell("STARTING POINT", 0, E_MagicType.Casted, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 20,   // TODO confirm mana
                MaxLevel = 1,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastStartingPoint(s, p); })
            });

            SpellList.Add("ICE BAG", new Spell("ICE BAG", 3, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Ice Bag is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("COME BACK", new Spell("COME BACK", 4, E_MagicType.Casted, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 25,   // TODO confirm mana
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastComeBack(s, p); })
            });

            SpellList.Add("TRACE", new Spell("TRACE", 5, E_MagicType.Casted, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 28,   // TODO confirm mana
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastTrace(s, p); })
            });

            SpellList.Add("OBLIVION", new Spell("OBLIVION", 6, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Oblivion is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("PICK UP", new Spell("PICK UP", 7, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 30,   // TODO confirm mana (no source value)
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastPickup(s, p, tarloc.X, tarloc.Y); })
            });

            SpellList.Add("FIRE WALL", new Spell("FIRE WALL", 8, E_MagicType.Casted, new SpellSequence
                 (40, 25, 15, 0, 1, 6, 0))
            {
                Dam = 130, DamPl = 8,
                ManaCost = 96,
                Range = 7,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe(s, p); })
            });

            SpellList.Add("LIGHTNING WALL", new Spell("LIGHTNING WALL", 15, E_MagicType.Casted, new SpellSequence
                 (46, 32, 0, 0, 1, 5, 0))
            {
                Dam = 152, DamPl = 8,
                ManaCost = 102,
                Range = 7,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe(s, p); })
            });

            SpellList.Add("THUNDER STROKE", new Spell("THUNDER STROKE", 17, E_MagicType.Target2, new SpellSequence
                 (0, 30, 0, 0, 0, 12, 4))
            {
                Dam = 206, DamPl = 8,
                ManaCost = 150,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            #endregion

            #region PORTED - Swordsman
            SpellList.Add("DEMON DEATH", new Buff("DEMON DEATH", 20, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Swordsman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastBuff(s, p); })  // TODO: DEMON DEATH is a control/utility effect - confirm behavior
            });

            SpellList.Add("TRIPLE", new Buff("TRIPLE", 23, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Swordsman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastBuff(s, p); })  // TODO: TRIPLE is a control/utility effect - confirm behavior
            });

            SpellList.Add("EXECUTION", new Spell("EXECUTION", 25, E_MagicType.Target2, new SpellSequence
                 (0, 0, 73, 0, 3, 30, 0))
            {
                Dam = 390, DamPl = 12,
                FManaCost = 0.67f, FManaCostPl = 0.05f,
                ClassReq = (int)E_Class.Swordsman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("FLYING SWORD", new Spell("FLYING SWORD", 33, E_MagicType.Target2, new SpellSequence
                 (0, 0, 73, 0, 3, 30, 0))
            {
                Dam = 606, DamPl = 12,
                FManaCost = 0.80f, FManaCostPl = 0.06f,
                ClassReq = (int)E_Class.Swordsman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            #endregion

            #region PORTED - Knight
            SpellList.Add("TWISTER", new Buff("TWISTER", 38, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Knight,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastBuff(s, p); })  // TODO: TWISTER is a control/utility effect - confirm behavior
            });

            SpellList.Add("FLAME STRIKE", new Spell("FLAME STRIKE", 14, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 3000, DamPl = 300,
                FManaCost = 0.85f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Knight,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            #endregion

            #region PORTED - Shaman
            SpellList.Add("STONE CURSE", new Spell("STONE CURSE", 45, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 0, DamPl = 0,
                FManaCost = 0.65f, FManaCostPl = 0.05f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })  // TODO: apply StoneCurse
            });

            SpellList.Add("SMOG SCREEN", new Spell("SMOG SCREEN", 40, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 8, DamPl = 2,
                FManaCost = 0.58f, FManaCostPl = 0.03f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })  // TODO: apply Debuff
            });

            SpellList.Add("NOSEBLEED", new Spell("NOSEBLEED", 42, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 20, DamPl = 2,
                FManaCost = 0.48f, FManaCostPl = 0.03f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })  // TODO: apply Debuff
            });

            SpellList.Add("RADIATION", new Spell("RADIATION", 43, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 20, DamPl = 2,
                FManaCost = 0.75f, FManaCostPl = 0.00f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })  // TODO: apply Debuff
            });

            SpellList.Add("WAKONDA", new Spell("WAKONDA", 44, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 20, DamPl = 2,
                ManaCost = 40,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("DEADLY MESSENGER", new Spell("DEADLY MESSENGER", 51, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                FManaCost = 0.66f, FManaCostPl = 0.04f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Deadly Messenger is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("DRAGON BREATH", new Spell("DRAGON BREATH", 63, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 456, DamPl = 10,
                FManaCost = 0.54f, FManaCostPl = 0.04f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("REVELATION", new Spell("REVELATION", 48, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 495, DamPl = 14,
                FManaCost = 0.80f, FManaCostPl = 0.06f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("BLACK HAND", new Spell("BLACK HAND", 66, E_MagicType.Target2, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 500, DamPl = 0,
                FManaCost = 0.60f, FManaCostPl = 0.03f,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("ASSASSIN", new Spell("ASSASSIN", 47, E_MagicType.Target2, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 536, DamPl = 14,
                FManaCost = 0.78f, FManaCostPl = 0.06f,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("SOUL SPRITE", new Spell("SOUL SPRITE", 11, E_MagicType.Target2, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 555, DamPl = 20,
                ManaCost = 132,
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("ASSASSIN SPECIAL", new Spell("ASSASSIN SPECIAL", 47, E_MagicType.Target2, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 1000, DamPl = 30,
                FManaCost = 0.75f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("MAGMA HAND", new Spell("MAGMA HAND", 49, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 1500, DamPl = 30,
                FManaCost = 0.85f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("WINDY SPIRIT", new Spell("WINDY SPIRIT", 52, E_MagicType.Target2, new SpellSequence
                 (0, 81, 0, 0, 0, 8, 0))
            {
                Dam = 3000, DamPl = 300,
                FManaCost = 0.85f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            #endregion

            #region PORTED - Wizard
            SpellList.Add("TORNADO", new Spell("TORNADO", 34, E_MagicType.Casted, new SpellSequence
                 (0, 81, 0, 0, 1, 8, 0))
            {
                Dam = 500, DamPl = 14,
                FManaCost = 0.48f, FManaCostPl = 0.03f,   // TODO tune mana (Shaman AoE)
                Range = 2,                                 // 3x3 box
                ClassReq = (int)E_Class.Shaman,
                AffinityRace = E_Race.Undead,              // +10% vs Undead
                AffinityBonus = 0.10f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe3x3(s, p, tarloc.X, tarloc.Y); })
            });

            SpellList.Add("CHAOS", new Buff("CHAOS", 55, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                FManaCost = 0.50f, FManaCostPl = 0.03f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastBuff(s, p); })  // TODO: CHAOS is a control/utility effect - confirm behavior
            });

            SpellList.Add("FREEZING", new Buff("FREEZING", 29, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                FManaCost = 0.60f, FManaCostPl = 0.04f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastBuff(s, p); })  // TODO: FREEZING is a control/utility effect - confirm behavior
            });

            SpellList.Add("MEDUSA", new Spell("MEDUSA", 46, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 0, DamPl = 0,
                FManaCost = 0.76f, FManaCostPl = 0.04f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })  // TODO: apply StoneCurse
            });

            SpellList.Add("RECALL", new Spell("RECALL", 54, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                FManaCost = 0.65f, FManaCostPl = 0.03f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Recall is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("BUTTERFLY", new Spell("BUTTERFLY", 56, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 20, DamPl = 2,
                ManaCost = 40,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("FIREFLY", new Spell("FIREFLY", 57, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 20, DamPl = 2,
                ManaCost = 40,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("SILVER SCREEN", new Spell("SILVER SCREEN", 59, E_MagicType.Target2, new SpellSequence
                 (0, 38, 80, 0, 0, 9, 0))
            {
                Dam = 20, DamPl = 2,
                ManaCost = 40,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("SHOCK", new Spell("SHOCK", 60, E_MagicType.Target2, new SpellSequence
                 (0, 30, 0, 0, 0, 12, 4))
            {
                Dam = 30, DamPl = 5,
                ManaCost = 66,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("HAIL STORM", new Spell("HAIL STORM", 29, E_MagicType.Casted, new SpellSequence
                 (0, 81, 0, 0, 1, 8, 0))
            {
                Dam = 290, DamPl = 10,                     // anchored to Thunder Storm
                FManaCost = 0.42f, FManaCostPl = 0.02f,
                Range = 2,                                 // 3x3 box
                ClassReq = (int)E_Class.Wizard,
                AffinityRace = E_Race.Human,               // +10% vs Human
                AffinityBonus = 0.10f,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe3x3(s, p, tarloc.X, tarloc.Y); })
            });

            SpellList.Add("FIRE SCREW", new Spell("FIRE SCREW", 61, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 270, DamPl = 8,
                FManaCost = 0.42f, FManaCostPl = 0.03f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("THUNDER STORM", new Spell("THUNDER STORM", 65, E_MagicType.Casted, new SpellSequence
                 (46, 32, 0, 0, 1, 5, 0))
            {
                Dam = 290, DamPl = 10,
                FManaCost = 0.67f, FManaCostPl = 0.05f,
                Range = 7,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe(s, p); })
            });

            SpellList.Add("WILD MONK", new Spell("WILD MONK", 45, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                FManaCost = 0.70f, FManaCostPl = 0.04f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Wild Monk is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("FIRE HAWK", new Spell("FIRE HAWK", 67, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 456, DamPl = 14,
                FManaCost = 0.77f, FManaCostPl = 0.06f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("DRAGON OF FIRE", new Spell("DRAGON OF FIRE", 63, E_MagicType.Target2, new SpellSequence
                 (40, 23, 0, 0, 0, 9, 0))
            {
                Dam = 575, DamPl = 12,
                FManaCost = 0.78f, FManaCostPl = 0.06f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("EVIL MIND", new Spell("EVIL MIND", 62, E_MagicType.Target2, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 666, DamPl = 20,
                ManaCost = 312,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            SpellList.Add("BIG BANG", new Spell("BIG BANG", 64, E_MagicType.Casted, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 882, DamPl = 14,
                FManaCost = 0.75f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                Range = 7,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe(s, p); })
            });

            SpellList.Add("ULTRA BIG BANG", new Spell("ULTRA BIG BANG", 64, E_MagicType.Casted, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 902, DamPl = 20,
                FManaCost = 0.75f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                Range = 7,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe(s, p); })
            });

            SpellList.Add("GRAND BIG BANG", new Spell("GRAND BIG BANG", 64, E_MagicType.Casted, new SpellSequence
                 (0, 0, 63, 0, 3, 30, 0))
            {
                Dam = 1300, DamPl = 30,
                FManaCost = 0.85f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                Range = 7,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe(s, p); })
            });

            SpellList.Add("CURVE SHOCK", new Spell("CURVE SHOCK", 32, E_MagicType.Target2, new SpellSequence
                 (0, 30, 0, 0, 0, 12, 4))
            {
                Dam = 3000, DamPl = 300,
                FManaCost = 0.85f, FManaCostPl = 0.05f,  // TODO mana estimated (no source)
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            #endregion

            #region PORTED - Knight/Wizard
            SpellList.Add("TWIN COBRA", new Spell("TWIN COBRA", 39, E_MagicType.Target2, new SpellSequence
                 (0, 0, 73, 0, 3, 30, 0))
            {
                Dam = 182, DamPl = 8,
                FManaCost = 0.55f, FManaCostPl = 0.03f,
                ClassReq = (int)E_Class.Knight | (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { if (tar != null) CastSingleTarget(s, p, tar); })
            });

            #endregion

            #region PORTED - Shaman/Wizard
            SpellList.Add("ICE WALL", new Buff("ICE WALL", 68, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                ManaCost = 120,
                ClassReq = (int)E_Class.Wizard | (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastBuff(s, p); })  // TODO: ICE WALL is a control/utility effect - confirm behavior
            });

            SpellList.Add("SHARP EYE", new Spell("SHARP EYE", 70, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                FManaCost = 0.45f, FManaCostPl = 0.00f,
                ClassReq = (int)E_Class.Wizard | (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Sharp Eye is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("ELIMINATION", new Spell("ELIMINATION", 71, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 324,
                ClassReq = (int)E_Class.Wizard | (int)E_Class.Shaman,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Elimination is not yet implemented."); })  // TODO: needs game system
            });

            #endregion

        }

        // === ADDED: Pick Up spell cast (remote item grab, reaches through walls) ===
        public static void CastPickup(Player.LeafSpell spell, Player.Player caster, int x, int y)
        {
            var maxdist = (spell.Level / 2) * 2;
            if (maxdist > 12) maxdist = 12;

            if (Point2D.Distance(caster.Position.X, caster.Position.Y, x, y) > maxdist)
                return;

            var obj = caster.Position.CurMap.Items.Skip(0)
                .Where(o => o.Value.Position.X == x && o.Value.Position.Y == y)
                .FirstOrDefault();

            if (obj.Value != null && caster.OnPickUp(obj.Value))
            {
                if (!obj.Value.Static)
                    caster.Position.CurMap.Exit(obj.Value);
                if (obj.Value is Object.Item)
                    (obj.Value as Object.Item).DroppedTime = null;
            }
        }


        public static void CastSingleTarget(Player.LeafSpell spell, Player.Player caster, Object.Mobile target, E_Race race = 0)
        {
            if (!(target is Object.Living))
                return;

            if (race != 0)
            {
                if (((target as Object.Living).Race & race) == 0)
                    return;
            }
            (target as Object.Living).TakeDamage(caster, spell);
        }

        public static void CastSingleTarget(Player.LeafSpell spell, Player.Player caster, int x, int y)
        {
            var Targets = caster.Position.CurMap.TargetsInAoE(new Point2D(caster.Position.X, caster.Position.Y),
                spell.Spell.Range, caster.State.PKMode);
            foreach (var tar in Targets)
            {
                tar.TakeDamage(caster, spell);
            }
        }

        public static void CastTeleport(Player.LeafSpell spell, Player.Player caster, int x, int y)
        {
            var tpdist = (spell.Level / 2) * 2;
            // if (tpdist <= 3) tpdist = 4;
            if (tpdist > 12) tpdist = 12;

            if (Point2D.Distance(caster.Position.X, caster.Position.Y, x, y) > tpdist)
                return;

            var tile = caster.Position.CurMap.GetTile(x, y);
            if (tile == null || tile.WalkFlags == 0)
                return;

            caster.Position.X = x;
            caster.Position.Y = y;

            caster.Position.CurMap.Events.OnTele(caster);
        }

        public static void CastView(Player.LeafSpell spell, Player.Player caster, Object.Mobile target)
        {
            if (target == null)
                return;

            if (target is Craft)
            {
                var cstd = target as Craft;
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("The contents: ", cstd.Name));
                foreach (var ob in cstd.Contents)
                    sb.Append(string.Format("{0} ", ob.Value.Name));
                caster.WriteWarn(sb.ToString());
            }
        }

        public static void CastTransparency(Player.LeafSpell spell, Player.Player caster)
        {
            int amt = 1;
            if (spell.Level >= 12)
                amt = 100;
            caster.Transparency = amt;
        }

        public static void CastBuff(Player.LeafSpell spell, Player.Player caster)
        {
            caster.SetBuff(spell);
            caster.UpdateStats();
            caster.Position.CurMap.Events.OnChgObjSprit(caster);
        }

        public static void CastHeal(Player.LeafSpell spell, Player.Player caster)
        {
            double amt = 0.6f + (spell.Level * 0.02);
            caster.HPCur += (int)(caster.HP * amt);
        }

        public static void CastHeal(Player.LeafSpell spell, Object.Living target)
        {
            double amt = 0.6f + (spell.Level * 0.02);
            target.HPCur += (int)(target.HP * amt);
        }

        public static void CastAoe(Player.LeafSpell spell, Player.Player caster)
        {
            var Targets = caster.Position.CurMap.TargetsInAoE(new Point2D(caster.Position.X, caster.Position.Y),
                spell.Spell.Range, caster.State.PKMode);
            foreach (var tar in Targets)
            {
                tar.TakeDamage(caster, spell);
            }
        }

        // ==================== ADDED: utility + AoE spell helpers ====================

        static HashSet<string> NoRecallMaps = new HashSet<string>()
        {
            "VV1", "VV2", "Cave", "Golem", "ItemGolem1", "TreasureLand", "Venture4",
            "050", "060", "070", "080"
            // add battleground / arena maps here once they exist
        };

        static Dictionary<string, Point2D> MapEntrances = new Dictionary<string, Point2D>()
        {
            { "010", new Point2D(73, 8) },   // from elevel
            { "020", new Point2D(7, 8) },   // from elevel
            { "030", new Point2D(14, 12) },   // from elevel
            { "040", new Point2D(16, 18) },   // from elevel
            { "050", new Point2D(87, 46) },   // from elevel
            { "060", new Point2D(105, 78) },   // from elevel
            { "061", new Point2D(12, 12) },   // from L060
            { "070", new Point2D(12, 10) },   // from elevel
            { "080", new Point2D(17, 9) },   // from elevel
            { "Arnold", new Point2D(5, 17) },   // from village1
            { "Biggun1", new Point2D(98, 78) },   // from village1
            { "ELevel", new Point2D(11, 44) },   // from L010
            { "ItemButcher1", new Point2D(20, 23) },   // from Itemvillage
            { "ItemDummy1", new Point2D(18, 19) },   // from Itemvillage
            { "ItemGolem1", new Point2D(18, 19) },   // from Itemvillage
            { "ItemHardboil1", new Point2D(18, 19) },   // from Itemvillage
            { "ItemMummy1", new Point2D(18, 19) },   // from Itemvillage
            { "ItemPigmy1", new Point2D(16, 30) },   // from Itemvillage
            { "ItemSkel1", new Point2D(21, 29) },   // from Itemvillage
            { "ItemStone1", new Point2D(16, 14) },   // from Itemvillage
            { "ItemVillage", new Point2D(93, 110) },   // from village1
            { "ItemWarDummy1", new Point2D(18, 19) },   // from Itemvillage
            { "ItemZomby1", new Point2D(13, 39) },   // from Itemvillage
            { "Loen", new Point2D(6, 14) },   // from village1
            { "Miro1", new Point2D(1, 1) },   // from village1
            { "Skel1", new Point2D(50, 13) },   // from village1
            { "Skel2", new Point2D(12, 14) },   // from Skel1
            { "Skel3", new Point2D(34, 14) },   // from Skel2
            { "Skel4", new Point2D(33, 24) },   // from Skel3
            { "Skel5", new Point2D(14, 21) },   // from Skel4
            { "St. Andover", new Point2D(50, 50) },   // from Rest
            { "VV1", new Point2D(96, 132) },   // from VV2
            { "VV2", new Point2D(46, 55) },   // from VV1
            { "Weakly1", new Point2D(11, 19) },   // from village1
            { "Weakly2", new Point2D(51, 14) },   // from weakly1
            { "Weakly3", new Point2D(53, 15) },   // from weakly2
        };

        // 3x3 AoE (9 tiles) centered on the clicked location. Euclidean distance < 2
        // selects exactly the 3x3 tile block. Race affinity is applied inside TakeDamage.
        public static void CastAoe3x3(Player.LeafSpell spell, Player.Player caster, int cx, int cy)
        {
            var targets = caster.Position.CurMap.TargetsInAoE(new Point2D(cx, cy), 2, caster.State.PKMode);
            foreach (var tar in targets)
                tar.TakeDamage(caster, spell);
        }

        // TRACE: save the caster's current map + position (persists across logout).
        public static void CastTrace(Player.LeafSpell spell, Player.Player caster)
        {
            caster.TraceMap = caster.Position.CurMap.Name;
            caster.TraceX = caster.Position.X;
            caster.TraceY = caster.Position.Y;
            caster.WriteWarn("Return point saved.");
        }

        // COME BACK: return to the saved Trace point. Blocked in endgame / battleground maps.
        public static void CastComeBack(Player.LeafSpell spell, Player.Player caster)
        {
            if (NoRecallMaps.Contains(caster.Position.CurMap.Name))
            {
                caster.WriteWarn("You cannot use Come Back here.");
                return;
            }
            if (string.IsNullOrEmpty(caster.TraceMap))
            {
                caster.WriteWarn("No return point set. Cast Trace first.");
                return;
            }
            var map = World.World.GetMap(caster.TraceMap);
            if (map == null)
                return;
            World.World.ChangeMap(caster, map, caster.TraceX, caster.TraceY);
        }

        // STARTING POINT: return to the entrance of the current hunting ground.
        public static void CastStartingPoint(Player.LeafSpell spell, Player.Player caster)
        {
            Point2D ent;
            if (!MapEntrances.TryGetValue(caster.Position.CurMap.Name, out ent))
            {
                caster.WriteWarn("There is no entrance point here.");
                return;
            }
            World.World.ChangeMap(caster, caster.Position.CurMap, ent.X, ent.Y);
        }

    }
}
