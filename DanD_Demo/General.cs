using DanD_Demo.Models;
using Spectre.Console;
using static System.Console;

namespace DanD_Demo
{
    internal static class General
    {
        // *****************************************
        public static bool Battle(Player you, Player them)
        {
            int yourAS = 0;
            int theirAS = 0;
            bool first = true;

            do
            {
                ForegroundColor = ConsoleColor.Red;
                BackgroundColor = ConsoleColor.White;

                yourAS = you.GetAttackStrenght();
                theirAS = them.GetAttackStrenght();

                if (first)
                {
                    if (GL.spectre == true)
                    {
                        AnsiConsole.Write(new Markup($"{you.Name} ", GL.player1));
                        AnsiConsole.Write(new Markup($"engage the ", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{them.Name}.\n", GL.redOnBlack));
                    }
                    else
                    {
                        WriteLine($"{you.Name} engage the {them.Name}.");
                    }
                    first = false;
                }
                else
                {
                    if (GL.spectre == true)
                    {
                        AnsiConsole.Write(new Markup($"{you.Name} ", GL.player1));
                        AnsiConsole.Write(new Markup($"attack again.\n", GL.greenOnBlack));
                    }
                    else
                    {
                        WriteLine($"{you.Name} attack again.");
                    }
                }

                if (yourAS == theirAS)
                {
                    if (GL.spectre == true)
                    {
                        AnsiConsole.Write(new Markup($"You have both missed each other, Fight on!\n", GL.greenOnBlack));
                    }
                    else
                    {
                        WriteLine("You have both missed each other, Fight on!");
                    }
                }
                else if (yourAS > theirAS)
                {
                    if (GL.spectre == true)
                    {
                        AnsiConsole.Write(new Markup($"{you.Name} ", GL.player1));
                        AnsiConsole.Write(new Markup($"wound the ", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{them.Name}!\n", GL.redOnBlack));

                        AnsiConsole.Write(new Markup($"{you.Name} ", GL.player1));
                        AnsiConsole.Write(new Markup($"- Stamina:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{you.Stamina}", GL.yellowOnBlack));
                        AnsiConsole.Write(new Markup($", Attack Strength:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{yourAS}\n", GL.yellowOnBlack));

                        AnsiConsole.Write(new Markup($"{them.Name} ", GL.redOnBlack));
                        AnsiConsole.Write(new Markup($"- Stamina:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{them.Stamina}", GL.yellowOnBlack));
                        AnsiConsole.Write(new Markup($", Attack Strength:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{theirAS}\n", GL.yellowOnBlack));
                    }
                    else
                    {
                        WriteLine($"{you.Name} wound the {them.Name}!");
                        WriteLine($"{you.Name} - Stamina:{you.Stamina}, Attack Strength:{yourAS}");
                        WriteLine($"{them.Name} - Stamina:{them.Stamina}, Attack Strength:{theirAS}");
                    }
                    them.Stamina = them.Stamina - 2;

                    if (you.HaveSpell(eSpells.Luck) && them.Stamina > 0) // you can try luck.
                    {
                        string ans = InputYesNo("Do you want to use a luck Spell");
                        if (ans == "Y")
                        {
                            you.UseSpell(eSpells.Luck);
                            if (you.AmILucky())
                            {
                                them.Stamina = them.Stamina - 2;
                            }
                            else
                            {
                                them.Stamina++;
                            }
                        }
                    }
                }
                else
                {
                    if (GL.spectre == true)
                    {
                        AnsiConsole.Write(new Markup($"{them.Name} ", GL.redOnBlack));
                        AnsiConsole.Write(new Markup($"wounds ", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{you.Name}!\n", GL.player1));

                        AnsiConsole.Write(new Markup($"{you.Name} ", GL.player1));
                        AnsiConsole.Write(new Markup($"- Stamina:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{you.Stamina}", GL.yellowOnBlack));
                        AnsiConsole.Write(new Markup($", Attack Strength:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{yourAS}\n", GL.yellowOnBlack));

                        AnsiConsole.Write(new Markup($"{them.Name} ", GL.redOnBlack));
                        AnsiConsole.Write(new Markup($"- Stamina:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{them.Stamina}", GL.yellowOnBlack));
                        AnsiConsole.Write(new Markup($", Attack Strength:", GL.greenOnBlack));
                        AnsiConsole.Write(new Markup($"{theirAS}\n", GL.yellowOnBlack));
                    }
                    else
                    {
                        WriteLine($"{them.Name} wound {you.Name}!");
                        WriteLine($"{you.Name} - Stamina:{you.Stamina}, Attack Strength:{yourAS}");
                        WriteLine($"{them.Name} - Stamina:{them.Stamina}, Attack Strength:{theirAS}");
                    }
                    you.Stamina = you.Stamina - 2;

                    if (you.HaveSpell(eSpells.Luck) && them.Stamina > 0) // you can try luck
                    {
                        string ans = InputYesNo("\nDo you want to use a luck Spell");
                        if (ans == "Y")
                        {
                            you.UseSpell(eSpells.Luck);
                            if (you.AmILucky())
                            {
                                you.Stamina++;
                            }
                            else
                            {
                                them.Stamina--;
                            }
                        }
                    }
                }
            } while (you.Stamina > 0 && them.Stamina > 0);

            BackgroundColor = ConsoleColor.Black;

            if (you.Stamina > 0)
            {
                // You lose
                if (GL.spectre == true)
                {
                    AnsiConsole.Write(new Markup($"{you.Name} ", GL.player1));
                    AnsiConsole.Write(new Markup($"has won the battle!\n", GL.greenOnBlack));
                }
                else
                {
                    WriteLine($"{you.Name} has won the battle!");
                    General.TimeDelay(7);
                }

                return true;
            }
            else
            {
                // You Win
                if (GL.spectre == true)
                {
                    AnsiConsole.Write(new Markup($"{you.Name} ", GL.player1));
                    AnsiConsole.Write(new Markup($"lost the battle!\n", GL.greenOnBlack));
                }
                else
                {
                    WriteLine($"{you.Name} lost the battle!");
                    General.TimeDelay(7);
                }

                return false;
            }
        }

        // *****************************************
        public static int CheckBagOfTricks(Player player, int nextRoom, eSpells spell, int currentRoom)
        {
            int output = currentRoom;

            if (player.HaveSpell(spell))
            {
                player.UseSpell(spell);
                output = nextRoom;
            }
            else
            {
                if (GL.spectre == true)
                {
                    AnsiConsole.Write(new Markup($"You do not have the spell to cast!\n", GL.greenOnBlack));
                }
                else
                {
                    WriteLine("You do not have the spell to cast!");
                }

                General.Pause();
            }

            return output;
        }

        // *****************************************
        public static void DisplayLine(int size, string text)
        {
            string textToPrint = "";
            string remaining = "";

            if (text.Length < size)
            {
                if (GL.spectre == true)
                {
                    AnsiConsole.Write(new Markup($"{text}\n", GL.aquaOnBlack));
                }
                else
                {
                    WriteLine(text);
                }
            }
            else
            {
                do
                {
                    if (text.Length > size)
                    {
                        // ***************************************
                        textToPrint = "";
                        remaining = "";

                        string[] words = text.Split(" ");
                        int ptr = 0;

                        do
                        {
                            textToPrint = textToPrint + words[ptr] + " ";
                            ptr++;
                        } while ((textToPrint.Length + words[ptr].Length) < size);

                        for (int i = ptr; i < words.Count(); i++)
                        {
                            remaining = remaining + words[i] + " ";
                        }
                        // ***************************************
                    }
                    else
                    {
                        textToPrint = text;
                        remaining = "";
                    }

                    if (GL.spectre == true)
                    {
                        AnsiConsole.Write(new Markup($"{textToPrint}\n", GL.aquaOnBlack));
                    }
                    else
                    {
                        WriteLine(textToPrint);
                    }

                    text = remaining;
                } while (remaining != "");
            }
        }

        // *****************************************
        public static void DisplayLine2(int size, string text)
        {
            string textToPrint = "";
            string remaining = "";

            if (text.Length < size)
            {
                if (GL.spectre == true)
                {
                    AnsiConsole.Write(new Markup($"{text}", GL.aquaOnBlack));
                }
                else
                {
                    Write(text);
                }
            }
            else
            {
                do
                {
                    if (text.Length > size)
                    {
                        // ***************************************
                        textToPrint = "";
                        remaining = "";

                        string[] words = text.Split(" ");
                        int ptr = 0;

                        do
                        {
                            textToPrint = textToPrint + words[ptr] + " ";
                            ptr++;
                        } while ((textToPrint.Length + words[ptr].Length) < size);

                        for (int i = ptr; i < words.Count(); i++)
                        {
                            remaining = remaining + words[i] + " ";
                        }
                        // ***************************************
                    }
                    else
                    {
                        textToPrint = text;
                        remaining = "";
                    }

                    if (GL.spectre == true)
                    {
                        AnsiConsole.Write(new Markup($"{textToPrint}", GL.aquaOnBlack));
                    }
                    else
                    {
                        Write(textToPrint);
                    }

                    text = remaining;
                } while (remaining != "");
            }
        }

        // *****************************************
        public static int DisplayRoom(int room, Player player)
        {
            int output = 0;

            if (GL.spectre == true)
            {
                output = DisplayRoomSpectre(room, player);
            }
            else
            {
                output = DisplayRoomCon(room, player);
            }

            return output;
        }

        // *****************************************

        public static int DisplayRoomCon(int room, Player player)
        {
            List<Citadel> currentRoom = new List<Citadel>();

            currentRoom = SQLiteDataAccess.LoadCell(room);

            string ans = "";

            ForegroundColor = ConsoleColor.Magenta;
            Clear();

            Heading($"Location: {room}");
            DisplayLine(120, $"\n{currentRoom[0].Description}\n");

            string respones = "QS";

            if (player.HaveSpell(eSpells.Luck))
            {
                respones += "L";
            }

            int output = 0;

            if (currentRoom[0].Option1 != 0)
            {
                DisplayLine(120, $"1) {currentRoom[0].Option1Text}");
                respones += "1";
            }

            if (currentRoom[0].Option2 != 0)
            {
                DisplayLine(120, $"2) {currentRoom[0].Option2Text}");
                respones += "2";
            }

            if (currentRoom[0].Option3 != 0)
            {
                DisplayLine(120, $"3) {currentRoom[0].Option3Text}");
                respones += "3";
            }

            if (currentRoom[0].Option4 != 0)
            {
                DisplayLine(120, $"4) {currentRoom[0].Option4Text}");
                respones += "4";
            }

            BlankLine();

            ans = General.InputString("Choose", respones);

            switch (ans)
            {
                case "Q": // Quit Game
                    output = 999;
                    break;

                case "S": // Player Status

                    player.Status();
                    General.Pause();
                    output = room;
                    break;

                case "L": // Luck Spell
                    player.UseSpell(eSpells.Luck);
                    General.Pause();
                    output = room;
                    break;

                case "1":
                    output = currentRoom[0].Option1;
                    break;

                case "2":
                    output = currentRoom[0].Option2;
                    break;

                case "3":
                    output = currentRoom[0].Option3;
                    break;

                case "4":
                    output = currentRoom[0].Option4;
                    break;
            }

            General.SaveRoom(output);

            return output;
        }

        // *****************************************
        public static int DisplayRoomSpectre(int room, Player player)
        {
            List<Citadel> currentRoom = new List<Citadel>();

            currentRoom = SQLiteDataAccess.LoadCell(room);

            Clear();

            Heading($"Location: {room}");
            DisplayLine(120, $"\n{currentRoom[0].Description}\n");

            // Setup response list

            List<string> respones = new List<string>();

            int output = 0;

            if (currentRoom[0].Option1 != 0)
            {
                respones.Add(currentRoom[0].Option1Text);
            }

            if (currentRoom[0].Option2 != 0)
            {
                respones.Add(currentRoom[0].Option2Text);
            }

            if (currentRoom[0].Option3 != 0)
            {
                respones.Add(currentRoom[0].Option3Text);
            }

            if (currentRoom[0].Option4 != 0)
            {
                respones.Add(currentRoom[0].Option4Text);
            }

            if (player.HaveSpell(eSpells.Luck))
            {
                respones.Add("[yellow]Luck Spell[/]");
            }

            respones.Add("[yellow]Status[/]");
            respones.Add("[Red]Quit[/]");

            BlankLine();

            string ans = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Select an Option?")
                .AddChoices(respones)
            );

            // Had to change the Switch to an If..Else If block as case statement had a problem

            if (ans == "[Red]Quit[/]") // Quit Game
            {
                output = 999;
            }
            else if (ans == "[yellow]Status[/]") // Player Status
            {
                player.Status();
                General.Pause();
                output = room;
            }
            else if (ans == "[yellow]Luck Spell[/]") // Luck Spell
            {
                player.UseSpell(eSpells.Luck);
                General.Pause();
                output = room;
            }
            else if (ans == currentRoom[0].Option1Text)
            {
                output = currentRoom[0].Option1;
            }
            else if (ans == currentRoom[0].Option2Text)
            {
                output = currentRoom[0].Option2;
            }
            else if (ans == currentRoom[0].Option3Text)
            {
                output = currentRoom[0].Option3;
            }
            else if (ans == currentRoom[0].Option4Text)
            {
                output = currentRoom[0].Option4;
            }

            General.SaveRoom(output);

            return output;
        }

        // *****************************************
        public static void DisplayRoom2(int room)
        {
            List<Citadel> currentRoom = new List<Citadel>();

            currentRoom = SQLiteDataAccess.LoadCell(room);

            ForegroundColor = ConsoleColor.Magenta;
            Clear();

            Heading($"Location: {room}");
            DisplayLine(120, $"\n{currentRoom[0].Description}\n");

            BlankLine();
        }

        // *****************************************
        public static void BlankLine()
        {
            if (GL.spectre == true)
            {
                AnsiConsole.MarkupLine("");
            }
            else
            {
                WriteLine();
            }
        }

        // *****************************************
        public static void EndCredits()
        {
            if (GL.spectre == true)
            {
                AnsiConsole.Write(new Markup($"{DrawLine('*', 120)}\n", GL.whiteOnBlack));
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine(DrawLine('*', 120));
            }
        }

        // *****************************************
        public static void StartCredits()
        {
            if (GL.spectre == true)
            {
                AnsiConsole.Write(new Markup($"{DrawLine('*', 120)}\n", GL.whiteOnBlack));
                AnsiConsole.Write(new Markup($"{"The Citadel of Chaos was written by Steve Jackson (c) 1983".CenterText(120)}\n", GL.aquaOnBlack));
                AnsiConsole.Write(new Markup($"{"Coded by Kelvin Clements".CenterText(120)}\n", GL.aquaOnBlack));
                AnsiConsole.Write(new Markup($"\n{"This is NOT a full work application/game, only a programming exercise.".CenterText(120)}\n", GL.danger));
                AnsiConsole.Write(new Markup($"{DrawLine('*', 120)}\n", GL.whiteOnBlack));
            }
            else
            {
                WriteLine(DrawLine('*', 120));
                WriteLine("The Citadel of Chaos was written by Steve Jackson (c) 1983");
                WriteLine("Coded by Kelvin Clements");
                WriteLine("\nThis is NOT a full work application/game, only a programming exercise.");
                WriteLine(DrawLine('*', 120));
            }
        }

        // *****************************************
        public static void FlushConsole()
        {
            // Flush the input stream
            while (KeyAvailable) ReadKey(false);
        }

        // *****************************************
        public static void Heading(string str = "")
        {
            Clear();

            if (GL.spectre == true)
            {
                BlankLine();
                AnsiConsole.Write(new Markup($"{DrawLine('*', 120)}\n", GL.greenOnBlack));
                AnsiConsole.Write(new Markup($"*{DrawLine(' ', 118)}*\n", GL.greenOnBlack));

                AnsiConsole.Write(new Markup($"*", GL.greenOnBlack));
                AnsiConsole.Write(new Markup($"{"The Citadel of Chaos".CenterText(118)}", GL.aquaOnBlack));
                AnsiConsole.Write(new Markup($"*\n", GL.greenOnBlack));

                AnsiConsole.Write(new Markup($"*", GL.greenOnBlack));
                AnsiConsole.Write(new Markup($"{str.CenterText(118)}", GL.aquaOnBlack));
                AnsiConsole.Write(new Markup($"*\n", GL.greenOnBlack));

                AnsiConsole.Write(new Markup($"*{DrawLine(' ', 118)}*\n", GL.greenOnBlack));
                AnsiConsole.Write(new Markup($"{DrawLine('*', 120)}\n", GL.greenOnBlack));
                BlankLine();
            }
            else
            {
                BlankLine();
                WriteLine(DrawLine('*', 120));

                Write("*");
                WriteLine(DrawLine(' ', 118));
                WriteLine("*");

                Write($"*{"The Citadel of Chaos".CenterText(118)}*");

                Write($"*{str.CenterText(118)}*");

                Write("*");
                WriteLine(DrawLine(' ', 118));
                WriteLine("*");

                WriteLine(DrawLine('*', 120));
                BlankLine();
            }
        }

        // *****************************************
        public static int InputInt(string questionText, int Lower, int Higher)
        {
            ConsoleColor currentColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Blue;
            BackgroundColor = ConsoleColor.Black;
            DisplayLine2(120, questionText);

            bool valid = false;
            int nbrAns = 0;

            do
            {
                ForegroundColor = ConsoleColor.White;

                FlushConsole();

                string key = ReadLine();

                if (key != "")
                {
                    nbrAns = int.Parse(key);

                    valid = nbrAns.Between(Lower, Higher);
                }
                else
                {
                    valid = false;
                    ForegroundColor = ConsoleColor.Red;
                    DisplayLine(120, "Invalid input!");

                    ForegroundColor = ConsoleColor.Blue;
                    DisplayLine2(120, questionText);
                }
            } while (!valid);

            ForegroundColor = currentColor;
            return nbrAns;
        }

        // *****************************************
        public static string InputYesNo(string questionText)
        {
            string output;

            if (GL.spectre)
            {
                output = AnsiConsole.Prompt<string>(
                    new TextPrompt<string>($"{questionText}?")
                    .AddChoice("Yes")
                    .AddChoice("No")
                    .DefaultValue("Yes")
                    );

                if (output == "Yes") output = "Y";
                if (output == "No") output = "Nn";
            }
            else
            {
                output = InputString(questionText, "YN");
            }

            return output;
        }

        // *****************************************
        public static string InputString(string questionText, string responses)
        {
            ConsoleColor currentColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Blue;
            BackgroundColor = ConsoleColor.Black;

            bool valid = false;
            int loc = 888;

            if (responses != "*")
            {
                DisplayLine2(120, $"{questionText} ({responses})? ");

                do
                {
                    ForegroundColor = ConsoleColor.White;

                    FlushConsole();
                    string key = "";

                    do
                    {
                        key = ReadLine().ToUpper();
                    } while (key == "");

                    if (HasOneOf(key, responses))
                    {
                        loc = responses.IndexOf(key);
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        ForegroundColor = ConsoleColor.Red;
                        DisplayLine(120, "Invalid input!");

                        ForegroundColor = ConsoleColor.Blue;
                        DisplayLine2(120, $"{questionText} ({responses})? ");
                    }
                } while (!valid);

                ForegroundColor = currentColor;
                return responses.Substring(loc, 1);
            }
            else
            {
                DisplayLine2(120, $"{questionText}? ");

                ForegroundColor = ConsoleColor.White;

                FlushConsole();
                string key = "";

                do
                {
                    key = ReadLine();
                } while (key.Length < 1);

                ForegroundColor = currentColor;
                return key;
            }
        }

        // *****************************************
        public static int LoadRoom(bool newgame)
        {
            int output = 0;

            if (!newgame)
            {
                var Game = new IniFile("Citadel.ini");

                if (Game.KeyExists("Room", "Location"))
                {
                    output = int.Parse(Game.Read("Room", "Location"));
                }
            }

            return output;
        }

        // *****************************************
        public static string MakeString(char c, int width)
        {
            string line = "";

            for (int i = 0; i < width; i++)
            {
                line += c;
            }

            return line;
        }

        // *****************************************
        public static void Pause(string text = "\nPress any key ...")
        {
            ForegroundColor = ConsoleColor.White;

            FlushConsole();

            DisplayLine(120, $"\n{text}");

            Read();
        }

        // *****************************************
        public static void PickUpItems(List<eEquip> items, int NbrToSelect, Player player)
        {
            ForegroundColor = ConsoleColor.Green;
            Clear();
            int nbrAns = 0;

            do
            {
                for (int i = 0; i < items.Count; i++)
                {
                    DisplayLine(120, $"{i + 1}) {items[i]}");
                }

                BlankLine();
                nbrAns = InputInt("Which item would you like to take with you ? ", 0, items.Count) - 1;

                if (nbrAns <= NbrToSelect)
                {
                    switch (items[nbrAns])
                    {
                        case eEquip.Gold:
                            int gold = InputInt("How much Gold is there? ", 0, 15);
                            player.AdjustGold(gold);
                            break;

                        case eEquip.DarkOninment:
                            player.AddEquipment(items[nbrAns]);
                            player.AddEquipment(items[nbrAns]);
                            break;

                        default:
                            player.AddEquipment(items[nbrAns]);
                            break;
                    }

                    items.RemoveAt(nbrAns);
                    NbrToSelect--;
                }
            } while (NbrToSelect != 0);
        }

        // *****************************************
        public static int RollDice(int numberOfDice, int sides, int offset = 0)
        {
            int output = 0;

            var rand = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < numberOfDice; i++)
            {
                output += rand.Next(sides);
            }

            return output + offset;
        }

        // *****************************************
        public static void SaveRoom(int loc)
        {
            if (loc != 999)
            {
                var Game = new IniFile("Citadel.ini");

                Game.Write("Room", loc.ToString(), "Location");

                GL.room = loc;
            }
        }

        // *****************************************
        public static void SelectSpellsSpectre(Player player, int count)
        {
            List<string> spells = new List<string>()
            {
                "Creature Copy",
                "ESP",
                "Fire",
                "FoolsGold",
                "Illusion",
                "Levitation",
                "Luck",
                "Shielding",
                "Skill",
                "Stamina",
                "Strength",
                "Weakness",
            };

            do
            {
                Clear();
                player.ListSpells();

                string spell = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title($"\nChoose a spell, you can select {count}")
                    .AddChoices(spells)
                    );

                int spellId = spells.IndexOf(spell);

                switch (spellId)
                {
                    case 0:
                        player.AddSpell(eSpells.CreatureCopy);
                        count--;
                        break;

                    case 1:
                        player.AddSpell(eSpells.ESP);
                        count--;
                        break;

                    case 2:
                        player.AddSpell(eSpells.Fire);
                        count--;
                        break;

                    case 3:
                        player.AddSpell(eSpells.FoolsGold);
                        count--;
                        break;

                    case 4:
                        player.AddSpell(eSpells.Illusion);
                        count--;
                        break;

                    case 5:
                        player.AddSpell(eSpells.Levitation);
                        count--;
                        break;

                    case 6:
                        player.AddSpell(eSpells.Luck);
                        count--;
                        break;

                    case 7:
                        player.AddSpell(eSpells.Shielding);
                        count--;
                        break;

                    case 8:
                        player.AddSpell(eSpells.Skill);
                        count--;
                        break;

                    case 9:
                        player.AddSpell(eSpells.Stamina);
                        count--;
                        break;

                    case 10:
                        player.AddSpell(eSpells.Strength);
                        count--;
                        break;

                    case 11:
                        player.AddSpell(eSpells.Weakness);
                        count--;
                        break;
                }
            } while (count > 0);
        }

        // *****************************************
        public static void SelectSpells(Player player, int count)
        {
            ForegroundColor = ConsoleColor.Green;

            do
            {
                Clear();
                player.ListSpells();

                DisplayLine(120, $"\nChoose a spell, you can select {count}");

                DisplayLine(120, "1) CreatureCopy");
                DisplayLine(120, "2) ESP");
                DisplayLine(120, "3) Fire");
                DisplayLine(120, "4) FoolsGold");
                DisplayLine(120, "5) Illusion");
                DisplayLine(120, "6) Levitation");
                DisplayLine(120, "7) Luck");
                DisplayLine(120, "8) Shielding");
                DisplayLine(120, "9) Skill");
                DisplayLine(120, "0) Stamina");
                DisplayLine(120, "A) Strength");
                DisplayLine(120, "B) Weakness");

                string ans = InputString("\nChoose", "1234567890AB");

                switch (ans)
                {
                    case "1":
                        player.AddSpell(eSpells.CreatureCopy);
                        count--;
                        break;

                    case "2":
                        player.AddSpell(eSpells.ESP);
                        count--;
                        break;

                    case "3":
                        player.AddSpell(eSpells.Fire);
                        count--;
                        break;

                    case "4":
                        player.AddSpell(eSpells.FoolsGold);
                        count--;
                        break;

                    case "5":
                        player.AddSpell(eSpells.Illusion);
                        count--;
                        break;

                    case "6":
                        player.AddSpell(eSpells.Levitation);
                        count--;
                        break;

                    case "7":
                        player.AddSpell(eSpells.Luck);
                        count--;
                        break;

                    case "8":
                        player.AddSpell(eSpells.Shielding);
                        count--;
                        break;

                    case "9":
                        player.AddSpell(eSpells.Skill);
                        count--;
                        break;

                    case "0":
                        player.AddSpell(eSpells.Stamina);
                        count--;
                        break;

                    case "A":
                        player.AddSpell(eSpells.Strength);
                        count--;
                        break;

                    case "B":
                        player.AddSpell(eSpells.Weakness);
                        count--;
                        break;
                }
            } while (count > 0);
        }

        // *****************************************
        public static int TestYourLuck(int room, Player player)
        {
            List<Citadel> currentRoom = new List<Citadel>();

            currentRoom = SQLiteDataAccess.LoadCell(room);
            int output = room;

            ForegroundColor = ConsoleColor.Magenta;
            Clear();
            Heading($"Room {room}");

            //DisplayLine(120, $"\n{currentRoom[0].Description}\n");

            if (player.AmILucky())
            {
                DisplayLine(120, $"\n{currentRoom[0].Option1Text}\n");
                output = currentRoom[0].Option1;
            }
            else
            {
                DisplayLine(120, $"\n{currentRoom[0].Option2Text}\n");
                output = currentRoom[0].Option2;
            }

            BlankLine();

            General.Pause();

            return output;
        }

        // *****************************************
        public static int YouDied(string how)
        {
            if (GL.spectre == true)
            {
                AnsiConsole.Write(new Markup($"\n\nI'm sorry you have died. ", GL.greenOnBlack));
                AnsiConsole.Write(new Markup($"{how}.\n", GL.redOnwhite));
            }
            else
            {
                WriteLine($"\n\nI'm sorry you have died. {how}.");
            }

            return 999;
        }

        // *****************************************
        public static bool TossACoin()
        {
            var coin = new Random(Guid.NewGuid().GetHashCode());
            var toss = coin.Next(2);

            if (toss == 1)   // Heads
            {
                if (GL.spectre == true)
                {
                    AnsiConsole.Write(new Markup($"Head you win!", GL.greenOnBlack));
                }
                else
                {
                    WriteLine("Head you win!");
                }

                Pause();
                return true;
            }
            else             // Tails
            {
                if (GL.spectre == true)
                {
                    AnsiConsole.Write(new Markup($"Tails you loss!", GL.greenOnBlack));
                }
                else
                {
                    WriteLine("Tails you loss.");
                }

                Pause();
                return false;
            }
        }

        // *****************************************

        public static void TimeDelay(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        // *****************************************
        // **            P R I V A T E            **
        // *****************************************

        // *****************************************
        private static string DrawLine(char c, int width)
        {
            return MakeString(c, width);
        }

        // *****************************************
        private static bool HasOneOf(string text, string oneOf)
        {
            bool valid = false;

            for (int i = 0; i < oneOf.Length; i++)
            {
                if (text.Contains(oneOf[i]))
                {
                    valid = true;
                    break;
                }
            }

            return valid;
        }
    }
}