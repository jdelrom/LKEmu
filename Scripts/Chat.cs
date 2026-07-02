using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelotV2.Scripts
{
    public static class Chat
    {
        public static void Load()
        {
            World.World._ProcCommand = ProcessCommand;
        }

        public static void ProcessCommand(Player.Player playr, string command, string[] suffix)
        {
            //Suffixed commands
            //if (suffix.Length == 0)
            //    return;
            switch (command)
            {
                
                case "@autohit":
                    playr.State.autohit = !playr.State.autohit;
                    break;
                case "@rank":
                    playr.WriteRank();
                    break;
                case "@go":
                    if (suffix.Length == 0)
                        return;
                    var lowermap = suffix[0].ToLower();
                    MapContainer point;
                    if (GoMaps.TryGetValue(lowermap, out point))
                    {
                        var tarmap = World.World.GetMap(point.MapName);
                        if (tarmap != null)
                            World.World.ChangeMap(playr, tarmap, point.point.X, point.point.Y);
                    }
                    break;
                case "@tele":
                    if (playr.Name != "PATHFINDER" && playr.Name.ToLower() != "sir")
                        return;
                    int tx = 1, ty = 1;
                    if (suffix.Length > 1)
                        int.TryParse(suffix[1], out tx);
                    if (suffix.Length > 2)
                        int.TryParse(suffix[2], out ty);
                    var lowermap1 = suffix[0];
                    var map = World.World.GetMap(lowermap1);
                    if (map != null)
                        World.World.ChangeMap(playr, map, tx, ty);
                    break;
                case "@learn":
                    if (playr.Name != "PATHFINDER" && playr.Name.ToLower() != "sir")
                        return;
                    if (suffix.Length == 0)
                        return;
                    // rejoin the spell name (spell names have spaces, e.g. "DRAGON OF FIRE")
                    var spellName = string.Join(" ", suffix).ToUpper().Trim();
                    Object.Spell learnSp;
                    if (!Spells.SpellList.TryGetValue(spellName, out learnSp))
                    {
                        playr.WriteWarn("No spell named '" + spellName + "'.");
                        return;
                    }
                    // if already known, bump its level; else grant fresh at level 1 (bypasses reqs)
                    var existing = playr.Spells.HasSpell(learnSp);
                    if (existing.Value != null)
                    {
                        if (existing.Value.Level < learnSp.MaxLevel)
                            existing.Value.Level++;
                        playr.gameLink.Send(new Network.GameOutMessage.CreateSlotMagic(existing.Value, existing.Key).Compile());
                    }
                    else
                    {
                        var fs = playr.Spells.FreeSlot;
                        if (!fs.Key)
                        {
                            playr.WriteWarn("No free spell slots.");
                            return;
                        }
                        var leaf = new Player.LeafSpell() { Level = 1, SubLevel = 0, Name = learnSp.Name, Spell = learnSp };
                        playr.Spells.LearnedSpells[fs.Value] = leaf;
                        playr.gameLink.Send(new Network.GameOutMessage.CreateSlotMagic(leaf, fs.Value).Compile());
                    }
                    playr.WriteWarn("Learned " + spellName + ".");
                    break;
 
                case "@level":
                    if (playr.Name != "PATHFINDER" && playr.Name.ToLower() != "sir")
                        return;
                    if (suffix.Length == 0)
                        return;
                    int newlvl;
                    if (int.TryParse(suffix[0], out newlvl))
                    {
                        playr.State.Level = newlvl;
                        playr.gameLink.Send(new Network.GameOutMessage.SetLevelGold(playr).Compile());
                        playr.WriteWarn("Level set to " + newlvl + ".");
                    }
                    break;    
                case "@deposit":
                case "@deposited":
                    if (playr.Position.CurMap.Name != "Loen")
                        return;

                    int amt = bankAmt(suffix);
                    if (amt > 0)
                        if (playr.State.Gold >= amt)
                        {
                            playr.State.Gold -= amt;
                            playr.Bank.Gold += amt;
                        }
                    break;
                case "@withdrawal":
                case "@withdraw":
                case "@withdrawn":
                    if (playr.Position.CurMap.Name != "Loen")
                        return;

                    int amt1 = bankAmt(suffix);
                    if (amt1 > 0)
                        if (playr.Bank.Gold >= amt1)
                        {
                            playr.State.Gold += amt1;
                            playr.Bank.Gold -= amt1;
                        }
                    break;
               /* case "@reset":
                    playr.State.Stats.Str = 0;
                    playr.State.Stats.Dex = 0;
                    playr.State.Stats.Men = 0;
                    playr.State.Stats.Vit = 0;
                    playr.State.Stats.Extra = 0;
                    playr.State.Level = 1;
                    playr.State.XP = 0;
                    playr.State.Gold = 0;
                    playr.Bank.Gold = 0;

                    playr.gameLink.Send(new Network.GameOutMessage.UpdateCharStats(playr).Compile());
                    break;*/
                case "@remitee":
                    if (playr.Position.CurMap.Name != "Loen")
                        return;

                    if (suffix.Length >= 2)
                    {
                        int amt2 = bankAmt(suffix, 1);
                        var tar = World.World.GetPlayer(suffix[0].ToLower());
                        if (tar != null)
                        {
                            if (amt2 > 0)
                                if (playr.Bank.Gold >= amt2)
                                {
                                    playr.Bank.Gold -= amt2;
                                    playr.WriteWarn(string.Format("You have sent {0:N0} gold to {1}.", amt2, tar.Name));
                                    tar.Bank.Gold += amt2;
                                    tar.WriteWarn(string.Format("You have recieved {0:N0} gold from {1}.", amt2, playr.Name));
                                }
                                else
                                {
                                    playr.WriteWarn(string.Format("You dont have enough money in your bank.", amt2, tar.Name));
                                }
                        }
                    }
                    break;
                case "@bankaccount":
                case "@balance":
                    if (playr.Position.CurMap.Name != "Loen")
                        return;

                    playr.WriteMessage("Your balance is " + playr.Bank.Gold.ToString("N0"));
                    break;
            }
        }

        static int bankAmt(string[] suffixes, int index = 0)
        {
            if (suffixes.Length >= 1)
            {
                int amt = 0;
                if (int.TryParse(suffixes[index], out amt))
                {
                    return amt;
                }
            }
            return 0;
        }

        static Dictionary<string, MapContainer> GoMaps = new Dictionary<string, MapContainer>()
        {
            {"rest", new MapContainer("Rest", new Point2D(18,18))},
            {"death", new MapContainer("Rest", new Point2D(15,15))},
            {"village", new MapContainer("St. Andover", new Point2D(50,50))},
            {"aron", new MapContainer("St. Andover", new Point2D(98,60))},
            {"loen", new MapContainer("Loen", new Point2D(8,12))},
            {"arnold", new MapContainer("Arnold", new Point2D(8,12))},
            {"employee", new MapContainer("St. Andover", new Point2D(128,94))},
            {"alias", new MapContainer("St. Andover", new Point2D(90,176))},
            {"miner", new MapContainer("Miner0", new Point2D(15,38))},

            {"weakly", new MapContainer("St. Andover", new Point2D(67,125))},
            {"skel", new MapContainer("St. Andover", new Point2D(139,137))},
            {"biggun", new MapContainer("St. Andover", new Point2D(167,119))},
            {"miro", new MapContainer("St. Andover", new Point2D(135,58))},
            {"level", new MapContainer("St. Andover", new Point2D(99,130))},
            {"item", new MapContainer("St. Andover", new Point2D(70,68))},

            {"venture", new MapContainer("Venture4", new Point2D(31,17))},
            {"golem", new MapContainer("Golem", new Point2D(15,0))},
            {"treasureland", new MapContainer("TreasureLand", new Point2D(25,25))},
            {"vv", new MapContainer("VV1", new Point2D(25,54))},
            {"cave", new MapContainer("Cave", new Point2D(25,54))},
        };
    }

    class MapContainer
    {
        public Point2D point;
        public string MapName;

        public MapContainer()
        {
        }

        public MapContainer(string MapName, Point2D point)
        {
            this.point = point;
            this.MapName = MapName;
        }
    }
}
