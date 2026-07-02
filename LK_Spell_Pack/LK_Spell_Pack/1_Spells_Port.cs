// ============================================================================
// THE LAST KINGDOM - PORTED SPELLS (53 missing spells)
// Generated for LKEmuV2 Scripts/Spells.cs  -> paste inside Spells.Load()
// Stats: official manual + Actoz wiki. Class: spellbook/wiki-verified.
// NOTE: icons + animations are provisional (client data obfuscated).
//       "// TODO" marks estimated mana or effects needing engine work.
// ============================================================================

            #region PORTED - Common
            SpellList.Add("STARTING POINT", new Spell("STARTING POINT", 0, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Starting Point is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("ICE BAG", new Spell("ICE BAG", 3, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Ice Bag is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("COME BACK", new Spell("COME BACK", 4, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Come Back is not yet implemented."); })  // TODO: needs game system
            });

            SpellList.Add("TRACE", new Spell("TRACE", 5, E_MagicType.Target2, new SpellSequence
                 (0, 0, 0, 0, 255, 0, 0))
            {
                ManaCost = 30,  // TODO mana estimated (no source)
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { p.WriteWarn("Trace is not yet implemented."); })  // TODO: needs game system
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
            SpellList.Add("TORNADO", new Buff("TORNADO", 34, E_MagicType.Casted, new SpellSequence
                 (57, 0, 0, 0, 0, 3, 0))
            {
                FManaCost = 0.48f, FManaCostPl = 0.03f,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastBuff(s, p); })  // TODO: TORNADO is a control/utility effect - confirm behavior
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
                 (0, 81, 0, 0, 0, 8, 0))
            {
                Dam = 76, DamPl = 9,
                FManaCost = 0.42f, FManaCostPl = 0.02f,
                Range = 7,
                ClassReq = (int)E_Class.Wizard,
                Cast = new Action<Player.LeafSpell, Player.Player, Mobile, Point2D>(
                    (Player.LeafSpell s, Player.Player p, Mobile tar, Point2D tarloc) =>
                    { CastAoe(s, p); })
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
