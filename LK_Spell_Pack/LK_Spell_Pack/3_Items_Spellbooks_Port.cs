// ============================================================================
// SPELLBOOKS for the 53 ported spells -> paste into Scripts/Items.cs GetItem switch
// Requirements from Actoz wiki (Mentality/Skill/Level). BuyPrice estimated by tier.
// ============================================================================

                #region BOOKS - Common
                case "BOOK OF STARTING POINT":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 20, LevelReq = 15, BuyPrice = 5000 };
                case "BOOK OF ICE BAG":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 27, MenReqPl = 7, BuyPrice = 5000 };
                case "BOOK OF COME BACK":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 25, MenReqPl = 6, BuyPrice = 5000 };
                case "BOOK OF TRACE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 28, MenReqPl = 6, BuyPrice = 5000 };
                case "BOOK OF OBLIVION":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 34, MenReqPl = 8, BuyPrice = 5000 };
                case "BOOK OF PICK UP":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 130, MenReqPl = 32, BuyPrice = 5000 };
                case "BOOK OF FIRE WALL":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 50, MenReqPl = 12, BuyPrice = 10000 };
                case "BOOK OF LIGHTNING WALL":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 56, MenReqPl = 14, BuyPrice = 10000 };
                case "BOOK OF THUNDER STROKE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")]) { MenReq = 72, MenReqPl = 18, BuyPrice = 10000 };
                #endregion

                #region BOOKS - Swordsman
                case "BOOK OF DEMON DEATH":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Swordsman) { DexReq = 99, DexReqPl = 6, LevelReq = 50, BuyPrice = 5000 };
                case "BOOK OF TRIPLE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Swordsman) { LevelReq = 90, BuyPrice = 5000 };
                case "BOOK OF EXECUTION":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Swordsman) { DexReq = 260, DexReqPl = 6, BuyPrice = 30000 };
                case "BOOK OF FLYING SWORD":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Swordsman) { MenReq = 130, MenReqPl = 5, DexReq = 360, DexReqPl = 5, LevelReq = 80, BuyPrice = 50000 };
                #endregion

                #region BOOKS - Knight
                case "BOOK OF TWISTER":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Knight) { LevelReq = 90, BuyPrice = 5000 };
                case "BOOK OF FLAME STRIKE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Knight) { LevelReq = 135, BuyPrice = 80000 };
                #endregion

                #region BOOKS - Shaman
                case "BOOK OF STONE CURSE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { MenReq = 186, MenReqPl = 25, BuyPrice = 5000 };
                case "BOOK OF SMOG SCREEN":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { BuyPrice = 3000 };
                case "BOOK OF NOSEBLEED":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { LevelReq = 20, BuyPrice = 3000 };
                case "BOOK OF RADIATION":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { LevelReq = 20, BuyPrice = 3000 };
                case "BOOK OF WAKONDA":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { LevelReq = 20, BuyPrice = 3000 };
                case "BOOK OF DEADLY MESSENGER":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { MenReq = 336, MenReqPl = 9, BuyPrice = 30000 };
                case "BOOK OF DRAGON BREATH":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { BuyPrice = 30000 };
                case "BOOK OF REVELATION":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { MenReq = 430, MenReqPl = 10, BuyPrice = 30000 };
                case "BOOK OF BLACK HAND":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { LevelReq = 90, BuyPrice = 30000 };
                case "BOOK OF ASSASSIN":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { MenReq = 435, MenReqPl = 10, DexReq = 234, DexReqPl = 7, BuyPrice = 30000 };
                case "BOOK OF SOUL SPRITE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { BuyPrice = 30000 };
                case "BOOK OF ASSASSIN SPECIAL":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { MenReq = 1200, MenReqPl = 30, DexReq = 1000, DexReqPl = 20, LevelReq = 111, BuyPrice = 50000 };
                case "BOOK OF MAGMA HAND":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { MenReq = 900, MenReqPl = 20, DexReq = 500, DexReqPl = 15, LevelReq = 101, BuyPrice = 80000 };
                case "BOOK OF WINDY SPIRIT":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Shaman) { MenReq = 1200, MenReqPl = 30, DexReq = 1000, DexReqPl = 20, LevelReq = 135, BuyPrice = 80000 };
                #endregion

                #region BOOKS - Wizard
                case "BOOK OF TORNADO":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 390, MenReqPl = 10, BuyPrice = 5000 };
                case "BOOK OF CHAOS":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 408, MenReqPl = 8, DexReq = 112, DexReqPl = 2, BuyPrice = 5000 };
                case "BOOK OF FREEZING":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 275, MenReqPl = 32, BuyPrice = 5000 };
                case "BOOK OF MEDUSA":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { BuyPrice = 5000 };
                case "BOOK OF RECALL":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 475, MenReqPl = 25, BuyPrice = 5000 };
                case "BOOK OF BUTTERFLY":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { LevelReq = 20, BuyPrice = 3000 };
                case "BOOK OF FIREFLY":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { LevelReq = 20, BuyPrice = 3000 };
                case "BOOK OF SILVER SCREEN":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { LevelReq = 20, BuyPrice = 3000 };
                case "BOOK OF SHOCK":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 127, MenReqPl = 13, BuyPrice = 3000 };
                case "BOOK OF HAIL STORM":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 417, MenReqPl = 11, BuyPrice = 3000 };
                case "BOOK OF FIRE SCREW":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { BuyPrice = 10000 };
                case "BOOK OF THUNDER STORM":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 485, MenReqPl = 11, BuyPrice = 10000 };
                case "BOOK OF WILD MONK":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 518, MenReqPl = 12, BuyPrice = 30000 };
                case "BOOK OF FIRE HAWK":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { LevelReq = 50, BuyPrice = 30000 };
                case "BOOK OF DRAGON OF FIRE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 686, MenReqPl = 12, BuyPrice = 30000 };
                case "BOOK OF EVIL MIND":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { BuyPrice = 50000 };
                case "BOOK OF BIG BANG":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 690, MenReqPl = 10, BuyPrice = 50000 };
                case "BOOK OF ULTRA BIG BANG":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 720, MenReqPl = 15, DexReq = 205, DexReqPl = 7, BuyPrice = 50000 };
                case "BOOK OF GRAND BIG BANG":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 1100, MenReqPl = 20, DexReq = 1100, DexReqPl = 30, LevelReq = 111, BuyPrice = 80000 };
                case "BOOK OF CURVE SHOCK":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard) { MenReq = 1100, MenReqPl = 20, DexReq = 1100, DexReqPl = 30, LevelReq = 135, BuyPrice = 80000 };
                #endregion

                #region BOOKS - Knight/Wizard
                case "BOOK OF TWIN COBRA":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Knight | (int)E_Class.Wizard) { MenReq = 60, MenReqPl = 18, BuyPrice = 10000 };
                #endregion

                #region BOOKS - Shaman/Wizard
                case "BOOK OF ICE WALL":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard | (int)E_Class.Shaman) { BuyPrice = 5000 };
                case "BOOK OF SHARP EYE":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard | (int)E_Class.Shaman) { MenReq = 220, MenReqPl = 50, BuyPrice = 5000 };
                case "BOOK OF ELIMINATION":
                    return new Spellbook(name, Spells.SpellList[name.Replace("BOOK OF ", "")], (int)E_Class.Wizard | (int)E_Class.Shaman) { BuyPrice = 5000 };
                #endregion
