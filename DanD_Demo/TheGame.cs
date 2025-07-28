namespace DanD_Demo
{
    internal static class TheGame
    {
        public static int PlayGame(int room, Player player)
        {
            bool dontQuit = true;
            bool win = false;
            int oldRoom = room;

            // Creatures
            Player ApeDog = new Player("ApeDog", 7, 4);
            Player DogApe = new Player("DogApe", 6, 6);
            Player TallMan = new Player("Tall Man", 8, 8);
            Player ShortMan = new Player("Short Man", 7, 6);
            Player Dwarf = new Player("Dwarf", 5, 6);
            Player Goblin = new Player("Goblin", 6, 4);
            Player Orc = new Player("Orc", 5, 7);
            Player Tentacle = new Player("Tentacle", 0, 2);
            Tentacle.SetAttackStrenght(15);
            Player RhinoMan = new Player("Rhino-Man", 8, 9);

            do
            {
                switch (room)
                {
                    case 0:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 1:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 2:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 3:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;

                        break;

                    case 4:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 5:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 6:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 7:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 8:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 9:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 10:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 11:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 12:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 13:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 14:
                        General.DisplayRoom2(room);
                        room = General.TestYourLuck(room, player);
                        break;

                    case 15:
                        room = General.DisplayRoom(room, player);
                        player.AddEquipment(eEquip.Dagger);
                        break;

                    case 16:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 17:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 18:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 19:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 20:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 21:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 22:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 23:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 24:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 25:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 26:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 27:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 28:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 29:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 30:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 31:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 32:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 33:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 34:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 35:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 36:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 37:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 38:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 39:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 40:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 41:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 42:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 43:
                        room = General.DisplayRoom(room, player);
                        room = player.AdjustStamina(-1, room);
                        break;

                    case 44:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 45:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 46:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 47:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 48:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 49:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 50:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 51:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 52:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 53:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 54:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 55:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 56:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 57:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 58:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 59:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 60:
                        room = General.DisplayRoom(room, player);

                        if (room == 33)
                        {
                            room = General.CheckBagOfTricks(player, 33, eSpells.Levitation, 60);
                        }

                        if (room == 295)
                        {
                            room = General.CheckBagOfTricks(player, 295, eSpells.Illusion, 60);
                        }

                        break;

                    case 61:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 62:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 63:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 64:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 65:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 66:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 67:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 68:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 69:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 70:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 71:
                        room = General.DisplayRoom(room, player);

                        // PROBLEM - This may not fully work as the book uses a different fight method.

                        win = General.Battle(player, Tentacle);

                        if (!win)
                        {
                            room = General.YouDied("It succeeds in dragging you into its lair and your adventure is over.");
                            break;
                        }
                        else
                        {
                            General.DisplayLine(120, "You defeated the creature, you peel the Tentacle off your leg and proceed to the main entrance.");
                        }

                        General.Pause();

                        break;

                    case 72:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 73:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 74:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 75:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 76:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 77:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 78:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 79:
                        room = General.DisplayRoom(room, player);
                        player.AddEquipment(eEquip.Berries);
                        break;

                    case 80:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 81:
                        room = General.DisplayRoom(room, player);
                        room = oldRoom;
                        break;

                    case 82:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 83:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 84:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 85:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 86:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 87:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 88:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 89:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 90:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 91:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 92:
                        room = General.DisplayRoom(room, player);
                        room = player.AdjustStamina(2, room);
                        break;

                    case 93:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 94:
                        room = General.DisplayRoom(room, player);
                        room = player.AdjustStamina(-1, room);
                        break;

                    case 95:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 96:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 97:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 98:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 99:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 100:
                        room = General.DisplayRoom(room, player);

                        if (room == 79)
                        {
                            room = General.CheckBagOfTricks(player, 79, eSpells.Levitation, 100);
                        }
                        break;

                    case 101:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 102:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 103:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 104:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 105:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 106:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 107:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 108:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 109:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 110:
                        room = General.TestYourLuck(room, player);
                        break;

                    case 111:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 112:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 113:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 114:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 115:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 116:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 117:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 118:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 119:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 120:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 121:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 122:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 123:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 124:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 125:
                        General.DisplayRoom2(room);

                        room = 209;

                        if (player.AmILucky())
                        {
                            General.DisplayLine(120, "All the arrows missed you! and you reach the monument , ducking behind the stone.");
                        }
                        else
                        {
                            General.DisplayLine(120, "One of the arrows hit you in the shoulder before you can reach the monument.");
                            room = player.AdjustStamina(-5, room);
                        }
                        break;

                    case 126:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 127:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 128:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 129:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 130:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 131:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 132:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 133:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 134:
                        room = General.DisplayRoom(room, player);
                        room = oldRoom;
                        break;

                    case 135:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 136:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 137:
                        room = General.DisplayRoom(room, player);

                        if (room == 383)
                        {
                            room = General.CheckBagOfTricks(player, 383, eSpells.Stamina, 137);
                        }
                        break;

                    case 138:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 139:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 140:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 141:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 142:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 143:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 144:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 145:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 146:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 147:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 148:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 149:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 150:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 151:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 152:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 153:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 154:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 155:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 156:
                        room = General.DisplayRoom(room, player);

                        if (room == 284)
                        {
                            room = General.CheckBagOfTricks(player, 284, eSpells.Levitation, 156);
                        }

                        if (room == 114)
                        {
                            room = General.CheckBagOfTricks(player, 114, eSpells.Fire, 156);
                        }

                        break;

                    case 157:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 158:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 159:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 160:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 161:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 162:
                        room = General.DisplayRoom(room, player);

                        player.UseEquipment(eEquip.Sword);

                        if (room == 32)
                        {
                            List<Player> opponents = new() { ApeDog, DogApe };

                            foreach (var o in opponents)
                            {
                                win = General.Battle(player, o);

                                if (!win)
                                {
                                    room = General.YouDied("In battle.");
                                    break;
                                }
                            }
                        }
                        break;

                    case 163:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 164:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 165:
                        room = General.DisplayRoom(room, player);

                        if (room == 398)
                        {
                            room = General.CheckBagOfTricks(player, 398, eSpells.Strength, 165);
                        }
                        break;

                    case 166:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 167:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 168:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 169:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 170:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 171:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 172:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 173:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 174:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 175:
                        room = General.DisplayRoom(room, player); break;

                    case 176:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 177:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 178:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 179:
                        room = General.DisplayRoom(room, player);

                        if (room == 341)
                        {
                            room = General.CheckBagOfTricks(player, 341, eSpells.Shielding, 179);
                        }

                        break;

                    case 180:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 181:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 182:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 183:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 184:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 185:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 186:
                        room = General.DisplayRoom(room, player);

                        if (room == 15)
                        {
                            room = General.CheckBagOfTricks(player, 15, eSpells.FoolsGold, 186);
                        }
                        break;

                    case 187:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 188:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 189:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 190:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 191:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 192:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 193:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 194:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 195:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 196:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 197:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 198:
                        General.DisplayRoom2(room);

                        if (player.AmILucky())
                        {
                            room = 177;
                            General.DisplayLine(120, "He believes you! and lets you in . . .");
                        }
                        else
                        {
                            room = 290;
                            General.DisplayLine(120, "He doesn't care who you are, you may not enter without the password, and he advances towards you with his pike.");
                        }
                        break;

                    case 199:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 200:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 201:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 202:
                        General.DisplayRoom2(room);
                        room = General.YouDied("Burned alive in a pit.");
                        break;

                    case 203:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 204:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 205:
                        General.DisplayRoom2(room);

                        int dice = General.RollDice(1, 6);
                        win = false;

                        if (!dice.IsEven())
                        {
                            win = General.Battle(ShortMan, TallMan);

                            if (!win)
                            {
                                win = General.Battle(player, TallMan);

                                if (!win)
                                {
                                    room = General.YouDied("Fighting in battle.");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            win = General.Battle(player, TallMan);
                        }

                        if (ShortMan.Alive())
                        {
                            room = 309;
                        }
                        else
                        {
                            room = 368;
                        }

                        break;

                    case 206:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 207:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 208:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 209:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 210:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 211:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 212:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 213:
                        room = General.DisplayRoom(room, player);

                        if (room == 235)
                        {
                            List<Player> opponents = new() { Dwarf, Goblin, Orc };

                            foreach (var o in opponents)
                            {
                                win = General.Battle(player, o);

                                if (!win)
                                {
                                    room = General.YouDied("In battle.");
                                    break;
                                }
                            }
                        }
                        break;

                    case 214:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 215:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 216:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 217:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 218:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 219:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 220:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 221:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 222:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 223:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 224:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 225:
                        room = General.DisplayRoom(room, player);

                        if (room == 15)
                        {
                            room = General.CheckBagOfTricks(player, 15, eSpells.FoolsGold, 225);
                        }
                        break;

                    case 226:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 227:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 228:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 229:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 230:
                        room = General.DisplayRoom(room, player);

                        if (room == 96)
                        {
                            room = General.CheckBagOfTricks(player, 96, eSpells.FoolsGold, 230);
                        }
                        break;

                    case 231:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 232:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 233:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 234:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 235:
                        room = General.DisplayRoom(room, player);

                        List<eEquip> items = new() { eEquip.Gold, eEquip.CopperKey, eEquip.DarkOninment };
                        General.PickUpItems(items, 2, player);
                        break;

                    case 236:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 237:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 238:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 239:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 240:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 241:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 242:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 243:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 244:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 245:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 246:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 247:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 248:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 249:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 250:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 251:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 252:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 253:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 254:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 255:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 256:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 257:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 258:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 259:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 260:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 261:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 262:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 263:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 264:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 265:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 266:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 267:
                        room = General.DisplayRoom(room, player);
                        player.AdjuctLuck(-1);
                        break;

                    case 268:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 269:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 270:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 271:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 272:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 273:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 274:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 275:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 276:
                        room = General.DisplayRoom(room, player);

                        if (room == 165)
                        {
                            room = General.CheckBagOfTricks(player, 165, eSpells.Strength, 276);
                        }

                        break;

                    case 277:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 278:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 279:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 280:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 281:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 282:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 283:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 284:
                        room = General.DisplayRoom(room, player);

                        if (room == 114)
                        {
                            room = General.CheckBagOfTricks(player, 114, eSpells.Fire, 284);
                        }

                        break;

                    case 285:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 286:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 287:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 288:
                        room = General.DisplayRoom(room, player);

                        if (room == 162)
                        {
                            room = General.CheckBagOfTricks(player, 162, eSpells.Strength, 288);
                        }

                        if (room == 56)
                        {
                            room = General.CheckBagOfTricks(player, 56, eSpells.Levitation, 288);
                        }

                        if (room == 32)
                        {
                            List<Player> opponents = new() { ApeDog, DogApe };

                            foreach (var o in opponents)
                            {
                                win = General.Battle(player, o);

                                if (!win)
                                {
                                    room = General.YouDied("In battle.");
                                    break;
                                }
                            }
                        }
                        break;

                    case 289:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 290:
                        room = General.DisplayRoom(room, player);

                        if (room == 307)
                        {
                            room = General.CheckBagOfTricks(player, 307, eSpells.Weakness, 290);
                        }

                        if (room == 70)
                        {
                            room = General.CheckBagOfTricks(player, 70, eSpells.Levitation, 290);
                        }

                        if (room == 264)
                        {
                            room = General.CheckBagOfTricks(player, 264, eSpells.Strength, 290);
                        }

                        break;

                    case 291:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 292:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 293:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 294:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 295:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 296:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 297:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 298:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 299:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 300:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 301:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 302:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 303:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 304:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 305:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 306:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 307:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 308:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 309:
                        General.DisplayRoom2(room);
                        player.AdjustGold(10);

                        if (General.TossACoin())
                        {
                            player.AddEquipment(eEquip.Dagger);
                            room = 15;
                        }
                        else
                        {
                            room = 245;
                        }
                        break;

                    case 310:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 311:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 312:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 313:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 314:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 315:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 316:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 317:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 318:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 319:
                        room = General.DisplayRoom(room, player);
                        room = player.AdjustStamina(-2, room);
                        break;

                    case 320:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 321:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 322:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 323:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 324:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 325:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 326:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 327:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 328:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 329:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 330:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 331:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 332:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 333:
                        room = General.DisplayRoom(room, player);
                        room = player.AdjustStamina(-2, room);
                        break;

                    case 334:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 335:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 336:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 337:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 338:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 339:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 340:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 341:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 342:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 343:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 344:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 345:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 346:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 347:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 348:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 349:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 350:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 351:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 352:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 353:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 354:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 355:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 356:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 357:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 358:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 359:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 360:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 361:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 362:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 363:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 364:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 365:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 366:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 367:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 368:
                        room = General.DisplayRoom(room, player);
                        player.AdjustGold(28);
                        player.AddEquipment(eEquip.Dagger);
                        break;

                    case 369:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 370:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 371:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 372:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 373:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 374:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 375:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 376:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 377:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 378:
                        room = General.DisplayRoom(room, player);
                        room = player.AdjustStamina(-4, room);
                        break;

                    case 379:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 380:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 381:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 382:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 383:
                        room = General.DisplayRoom(room, player);

                        if (room == 189)
                        {
                            player.ChooseSpell();
                        }
                        break;

                    case 384:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 385:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 386:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 387:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 388:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 389:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 390:
                        General.DisplayRoom2(room);

                        if (player.AmILucky())
                        {
                            room = 350;
                        }
                        else
                        {
                            room = 122;
                        }

                        General.Pause();

                        break;

                    case 391:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 392:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 393:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 394:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 395:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 396:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 397:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 398:
                        room = General.DisplayRoom(room, player);
                        break;

                    case 399:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 400:
                        General.Pause($"Room {room} has not yet been implemented.");
                        room = oldRoom;
                        break;

                    case 999:
                        General.DisplayLine(120, "Goodbye for now, see you soon.");
                        player.Status();
                        General.DisplayLine(120, $"Your last room was {room}");
                        General.Pause();
                        dontQuit = false;
                        break;

                    default:
                        General.Pause($"Room {room} not recognised.");
                        room = oldRoom;
                        break;
                }
            } while (dontQuit);

            return room;
        }
    }
}