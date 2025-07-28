using Spectre.Console;
using static System.Console;

namespace DanD_Demo
{
    public class Player
    {
        private int AttackStrenght;
        private List<eEquip> Equipment = new();
        private int InitialLuck;
        private int InitialMagic;
        private int InitialSkill;
        private int InitialStamina;
        private List<eSpells> MagicSpells = new();

        // ***** C O N S T R U C T's
        public Player()
        {
        }

        // *****
        public Player(string name, int iSkill, int iStamina, int iLuck, int iMagic, int skill, int stamina, int luck, int magic, int gold)
        {
            Name = name;

            InitialSkill = iSkill;
            Skill = skill;

            InitialStamina = iStamina;
            Stamina = stamina;

            InitialLuck = iLuck;
            Luck = luck;

            InitialMagic = iMagic;
            Magic = magic;

            Gold = gold;
        }

        // *****
        public Player(string name, int skill, int stamina)
        {
            Name = name;

            InitialSkill = Skill;
            Skill = skill;

            InitialStamina = Stamina;
            Stamina = stamina;
        }

        public string Name { get; set; }
        public int Stamina { get; set; }
        private int Gold { get; set; }
        private int Luck { get; set; }
        private int Magic { get; set; }
        private int Skill { get; set; }

        // *****
        public void AddEquipment(eEquip item, bool say = true)
        {
            switch (item)
            {
                case eEquip.Sword:
                    Equipment.Add(eEquip.Sword);
                    break;

                case eEquip.LeatherArmour:
                    Equipment.Add(eEquip.LeatherArmour);
                    break;

                case eEquip.Lantern:
                    Equipment.Add(eEquip.Lantern);
                    break;

                case eEquip.Backpack:
                    Equipment.Add(eEquip.Backpack);
                    break;

                case eEquip.Berries:
                    Equipment.Add(eEquip.Berries);
                    break;

                case eEquip.Dagger:
                    Equipment.Add(eEquip.Berries);
                    break;

                case eEquip.CopperKey:
                    Equipment.Add(eEquip.CopperKey);
                    break;

                case eEquip.DarkOninment:
                    Equipment.Add(eEquip.DarkOninment);
                    break;
            }

            if (say)
            {
                General.DisplayLine(120, $"You put the {item} in your pack.");
            }
        }

        // *****
        public void AddSpell(eSpells spell, bool say = true)
        {
            if (Magic < InitialMagic)
            {
                Magic++;

                switch (spell)
                {
                    case eSpells.CreatureCopy:
                        MagicSpells.Add(eSpells.CreatureCopy);
                        break;

                    case eSpells.ESP:
                        MagicSpells.Add(eSpells.ESP);
                        break;

                    case eSpells.Fire:
                        MagicSpells.Add(eSpells.Fire);
                        break;

                    case eSpells.FoolsGold:
                        MagicSpells.Add(eSpells.FoolsGold);
                        break;

                    case eSpells.Illusion:
                        MagicSpells.Add(eSpells.Illusion);
                        break;

                    case eSpells.Levitation:
                        MagicSpells.Add(eSpells.Levitation);
                        break;

                    case eSpells.Luck:
                        MagicSpells.Add(eSpells.Luck);
                        break;

                    case eSpells.Shielding:
                        MagicSpells.Add(eSpells.Shielding);
                        break;

                    case eSpells.Skill:
                        MagicSpells.Add(eSpells.Skill);
                        break;

                    case eSpells.Stamina:
                        MagicSpells.Add(eSpells.Stamina);
                        break;

                    case eSpells.Strength:
                        MagicSpells.Add(eSpells.Strength);
                        break;

                    case eSpells.Weakness:
                        MagicSpells.Add(eSpells.Weakness);
                        break;
                }

                if (say)
                {
                    General.DisplayLine(120, $"You read and memorise the {spell} spell.");

                    General.TimeDelay(1);
                }
            }
        }

        // *****
        public void SetAttackStrenght(int amount)
        {
            AttackStrenght = amount;
        }

        // *****
        public void AdjustGold(int amount)
        {
            if ((Gold + amount) > 0)
            {
                General.DisplayLine(120, $"Your gold has changed from {Gold} to {Gold + amount}");
                Gold += amount;
            }

            if (Gold <= 0)
            {
                Gold = 0;
                General.DisplayLine(120, "You have no more Gold!!");
            }

            General.Pause();
        }

        // *****
        public void AdjuctLuck(int amount)
        {
            if ((Luck + amount) > 0)
            {
                General.DisplayLine(120, $"Your luck has changed from {Luck} to {Luck + amount}");
                Luck += amount;
                General.Pause();
            }

            if (Luck <= 0)
            {
                Luck = 0;
                General.DisplayLine(120, "Your Luck is at zero!!");
                General.Pause();
            }
        }

        // *****
        public int AdjustStamina(int amount, int CurrentRoom)
        {
            if ((Stamina + amount) > 0)
            {
                General.DisplayLine(120, $"Your stamina has changed from {Stamina} to {Stamina + amount}");
                Stamina += amount;
            }

            if (Stamina <= 0)
            {
                CurrentRoom = General.YouDied("You have no more Stamina.");
            }

            General.Pause();

            return CurrentRoom;
        }

        // *****
        public bool Alive()
        {
            if (Stamina > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // *****
        public bool AmILucky()
        {
            int test = General.RollDice(2, 6, 0);

            if (test <= Luck)   // Lucky
            {
                General.DisplayLine(120, "You have been Lucky.");
                return true;
            }
            else                // Un-Lucky
            {
                General.DisplayLine(120, "You have been Unlucky.");
                return false;
            }

            Luck--;

            if (Luck > 0)
            {
                Luck = 0;
            }
        }

        // *****
        public void ChooseSpell()
        {
            General.DisplayLine(120, "What spell do you what to use?");

            string responses = "";

            for (int i = 0; i < MagicSpells.Count; i++)
            {
                General.DisplayLine(120, $"{i}) {MagicSpells[i]}");
                responses += i.ToString();
            }

            int ans = int.Parse(General.InputString("Choose", responses));

            UseSpell(MagicSpells[ans]);
        }

        // *****
        public int GetAttackStrenght()
        {
            AttackStrenght = General.RollDice(2, 6, 0) + Skill;

            return AttackStrenght;
        }

        // *****
        public int GetInitialMagic()
        {
            return InitialMagic;
        }

        // *****
        public bool HaveSpell(eSpells spell)
        {
            bool output = false;

            if (Magic > 0)
            {
                switch (spell)
                {
                    case eSpells.CreatureCopy:
                        if (MagicSpells.Contains(eSpells.CreatureCopy))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.ESP:
                        if (MagicSpells.Contains(eSpells.ESP))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Fire:
                        if (MagicSpells.Contains(eSpells.Fire))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.FoolsGold:
                        if (MagicSpells.Contains(eSpells.FoolsGold))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Illusion:
                        if (MagicSpells.Contains(eSpells.Illusion))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Levitation:
                        if (MagicSpells.Contains(eSpells.Levitation))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Luck:
                        if (MagicSpells.Contains(eSpells.Luck))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Shielding:
                        if (MagicSpells.Contains(eSpells.Shielding))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Skill:
                        if (MagicSpells.Contains(eSpells.Skill))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Stamina:
                        if (MagicSpells.Contains(eSpells.Stamina))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Strength:
                        if (MagicSpells.Contains(eSpells.Strength))
                        {
                            output = true;
                        }
                        break;

                    case eSpells.Weakness:
                        if (MagicSpells.Contains(eSpells.Weakness))
                        {
                            output = true;
                        }
                        break;
                }
            }

            return output;
        }

        // *****
        public void ListSpells()
        {
            string output = $"\nSpells ({MagicSpells.Count}) :";
            string output2 = "";

            foreach (var s in MagicSpells)
            {
                output2 += ($"{s}, ");
            }

            if (output2.Length > 2)
            {
                output2 = output2.Substring(0, (output2.Length - 2));
            }

            if (GL.spectre)
            {
                AnsiConsole.Write(new Markup($"{output}", GL.cyanOnBlack));
                AnsiConsole.Write(new Markup($"{output2}\n", GL.yellowOnBlack));
            }
            else
            {
                General.DisplayLine(120, $"{output} {output2}");
            }
        }

        // *****
        public void Load()
        {
            var Game = new IniFile("Citadel.ini");
            string id = "Player";

            if (Game.KeyExists("InitialLuck", id))
            {
                InitialLuck = int.Parse(Game.Read("InitialLuck", id));
                InitialMagic = int.Parse(Game.Read("InitialMagic", id));
                InitialStamina = int.Parse(Game.Read("InitialStamina", id));
                InitialSkill = int.Parse(Game.Read("InitialSkill", id));

                Luck = int.Parse(Game.Read("Luck", id));
                int mCount = int.Parse(Game.Read("Magic", id));
                Stamina = int.Parse(Game.Read("Stamina", id));
                Skill = int.Parse(Game.Read("Skill", id));

                Name = Game.Read("Name", id);
                Gold = int.Parse(Game.Read("Gold", id));
                int Equipment = int.Parse(Game.Read("Equipment", id));

                id = "Spells";
                Magic = 0;

                for (int i = 1; i < mCount; i++)
                {
                    string name = "Spell" + i.ToString();
                    int s = int.Parse(Game.Read(name, id));
                    AddSpell((eSpells)s, false);
                }

                id = "Equipment";

                for (int i = 1; i < (Equipment + 1); i++)
                {
                    string name = "Equipment" + i.ToString();
                    int e = int.Parse(Game.Read(name, id));
                    AddEquipment((eEquip)e, false);
                }
            }
        }

        // *****
        public void New()
        {
            InitialSkill = General.RollDice(1, 6, 6);
            Skill = InitialSkill;
            InitialStamina = General.RollDice(2, 6, 12);
            Stamina = InitialStamina;
            InitialLuck = General.RollDice(1, 6, 6);
            Luck = InitialLuck;
            InitialMagic = General.RollDice(2, 6, 6);
            Magic = 0;

            AddEquipment(eEquip.Sword, false);
            AddEquipment(eEquip.LeatherArmour, false);
            AddEquipment(eEquip.Lantern, false);
            AddEquipment(eEquip.Backpack, false);

            Gold = 0;
        }

        // *****
        public void Save()
        {
            var Game = new IniFile("Citadel.ini");
            string id = "Player";

            Game.Write("InitialLuck", InitialLuck.ToString(), id);
            Game.Write("InitialMagic", InitialMagic.ToString(), id);
            Game.Write("InitialStamina", InitialStamina.ToString(), id);
            Game.Write("InitialSkill", InitialSkill.ToString(), id);

            Game.Write("Luck", Luck.ToString(), id);
            Game.Write("Magic", Magic.ToString(), id);
            Game.Write("Stamina", Stamina.ToString(), id);
            Game.Write("Skill", Skill.ToString(), id);

            Game.Write("Name", Name, id);
            Game.Write("Gold", Gold.ToString(), id);
            Game.Write("Equipment", Equipment.Count.ToString(), id);

            id = "Spells";
            int sCount = 0;
            foreach (var s in MagicSpells)
            {
                sCount++;

                string name = "Spell" + sCount.ToString();
                int sNbr = (int)s;

                Game.Write(name, sNbr.ToString(), id);
            }

            id = "Equipment";
            sCount = 0;
            foreach (var e in Equipment)
            {
                sCount++;

                string name = "Equipment" + sCount.ToString();
                int eNbr = (int)e;
                Game.Write(name, eNbr.ToString(), id);
            }
        }

        // *****
        public void Status()
        {
            if (GL.spectre)
            {
                AnsiConsole.Write(new Markup("\n--- Player Status ---\n", GL.cyanOnBlack));

                AnsiConsole.Write(new Markup($"Luck:", GL.cyanOnBlack));
                AnsiConsole.Write(new Markup($"{InitialLuck}\\{Luck}", GL.yellowOnBlack));
                AnsiConsole.Write(new Markup($" | Stamina:", GL.cyanOnBlack));
                AnsiConsole.Write(new Markup($"{InitialStamina}\\{Stamina}", GL.yellowOnBlack));
                AnsiConsole.Write(new Markup($" | Skill:", GL.cyanOnBlack));
                AnsiConsole.Write(new Markup($"{InitialSkill}\\{Skill}", GL.yellowOnBlack));
                AnsiConsole.Write(new Markup($" | Magic:", GL.cyanOnBlack));
                AnsiConsole.Write(new Markup($"{InitialMagic}\\{Magic}", GL.yellowOnBlack));
                AnsiConsole.Write(new Markup($" | Gold - ", GL.cyanOnBlack));
                AnsiConsole.Write(new Markup($"{Gold}\n", GL.yellowOnBlack));
            }
            else
            {
                ForegroundColor = ConsoleColor.Cyan;
                General.DisplayLine(120, "\n--- Player Status ---");
                General.DisplayLine(120, $"Luck:{InitialLuck}\\{Luck} | Stamina:{InitialStamina}\\{Stamina} | Skill:{InitialSkill}\\{Skill} | Magic:{InitialMagic}\\{Magic} | Gold - {Gold}");
            }

            ListEquipment();

            ListSpells();
        }

        // *****
        public void UseEquipment(eEquip item)
        {
            switch (item)
            {
                case eEquip.Sword:
                    Equipment.Remove(eEquip.Sword);
                    break;

                case eEquip.LeatherArmour:
                    Equipment.Remove(eEquip.LeatherArmour);
                    break;

                case eEquip.Lantern:
                    Equipment.Remove(eEquip.Lantern);
                    break;

                case eEquip.Berries:
                    Equipment.Remove(eEquip.Berries);
                    break;

                case eEquip.Backpack:
                    Equipment.Remove(eEquip.Backpack);
                    break;

                case eEquip.Dagger:
                    Equipment.Remove(eEquip.Berries);
                    break;

                case eEquip.CopperKey:
                    Equipment.Remove(eEquip.CopperKey);
                    break;

                case eEquip.DarkOninment:
                    Equipment.Remove(eEquip.DarkOninment);
                    break;
            }
        }

        // *****
        public void UseSpell(eSpells spell)
        {
            if (Magic > 0)
            {
                Magic--;

                switch (spell)
                {
                    case eSpells.CreatureCopy:
                        MagicSpells.Remove(eSpells.CreatureCopy);
                        break;

                    case eSpells.ESP:
                        MagicSpells.Remove(eSpells.ESP);
                        break;

                    case eSpells.Fire:
                        MagicSpells.Remove(eSpells.Fire);
                        break;

                    case eSpells.FoolsGold:
                        MagicSpells.Remove(eSpells.FoolsGold);
                        break;

                    case eSpells.Illusion:
                        MagicSpells.Remove(eSpells.Illusion);
                        break;

                    case eSpells.Levitation:
                        MagicSpells.Remove(eSpells.Levitation);
                        break;

                    case eSpells.Luck:
                        {
                            MagicSpells.Remove(eSpells.Luck);
                            int temp = InitialLuck / 2;
                            int b4Luck = Luck;
                            if (temp + Luck < InitialLuck)
                            {
                                Luck += temp;
                            }
                            else
                            {
                                Luck = InitialLuck;
                            }
                            General.DisplayLine(120, $"Your luck has increased from {b4Luck} to {Luck}.");
                            General.Pause();
                        }

                        break;

                    case eSpells.Shielding:
                        MagicSpells.Remove(eSpells.Shielding);
                        break;

                    case eSpells.Skill:
                        {
                            MagicSpells.Remove(eSpells.Skill);
                            int temp = InitialSkill / 2;
                            int b4Skill = Skill;
                            if (temp + Skill < InitialSkill)
                            {
                                Skill += temp;
                            }
                            else
                            {
                                Skill = InitialSkill;
                            }
                            General.DisplayLine(120, $"Your skill has increased from {b4Skill} to {Skill}.");
                            General.Pause();
                        }
                        break;

                    case eSpells.Stamina:
                        {
                            MagicSpells.Remove(eSpells.Stamina);
                            int temp = InitialStamina / 2;
                            int b4Stamina = Stamina;
                            if (temp + Stamina < InitialStamina)
                            {
                                Stamina += temp;
                            }
                            else
                            {
                                Stamina = InitialStamina;
                            }
                            General.DisplayLine(120, $"Your Stamina has increased from {b4Stamina} to {Stamina}.");
                            General.Pause();
                        }
                        break;

                    case eSpells.Strength:
                        MagicSpells.Remove(eSpells.Strength);
                        break;

                    case eSpells.Weakness:
                        MagicSpells.Remove(eSpells.Weakness);
                        break;
                }

                General.DisplayLine(120, $"You cast the {spell} Spell...");
                General.TimeDelay(5);
            }
        }

        // *********************************************************
        private void ListEquipment()
        {
            string output = $"\nEquipment ({Equipment.Count}) :";
            string output2 = "";

            foreach (var i in Equipment)
            {
                output2 += $"{i}, ";
            }

            if (output2.Length > 2)
            {
                output2 = output2.Substring(0, (output2.Length - 2));
            }

            if (GL.spectre)
            {
                AnsiConsole.Write(new Markup($"{output}", GL.cyanOnBlack));
                AnsiConsole.Write(new Markup($"{output2}\n", GL.yellowOnBlack));
            }
            else
            {
                General.DisplayLine(120, $"\nEquipment ({output}): {output2}");
            }
        }

        // *****
    }
}