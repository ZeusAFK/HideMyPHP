using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZeusAFK_koxp.NET
{
    public partial class Skills : Variables
    {
        public Skills()
        {
            InitializeComponent();
        }

        public void MageAttack(string Skill, bool extra)
        {
            if (extra)
                AttackR();
            string SkillSelected = "";
            int type = -1;
            switch (Skill)
            {
                case "Burn": SkillSelected = "503"; type = 1; break;
                case "Ignition": SkillSelected = "518"; type = 1; break;
                case "Specter Of Fire": SkillSelected = "543"; type = 1; break;
                case "Manes Of Fire": SkillSelected = "556"; type = 1; break;

                case "Fire Blast": SkillSelected = "535"; type = 2; break;
                case "Blaze": SkillSelected = "509"; type = 2; break;
                case "Fire Spear": SkillSelected = "527"; type = 2; break;
                case "Hell Fire": SkillSelected = "539"; type = 2; break;
                case "Pillar Of Fire": SkillSelected = "551"; type = 2; break;
                case "Fire Thorn": SkillSelected = "554"; type = 2; break;
                case "Fire Impact": SkillSelected = "557"; type = 2; break;

                case "Fire Ball": SkillSelected = "509"; type = 3; break;

                case "Flame Staff": SkillSelected = "542"; type = 4; break;
                case "Glacier Staff": SkillSelected = "642"; type = 4; break;
                case "Lightining Staff": SkillSelected = "742"; type = 4; break;

                case "Freeze": SkillSelected = "603"; type = 5; break;
                case "Chill": SkillSelected = "609"; type = 5; break;
                case "Solid": SkillSelected = "618"; type = 5; break;
                case "Frostbite": SkillSelected = "639"; type = 5; break;
                case "Frozen Blade": SkillSelected = "642"; type = 5; break;
                case "Specter Of Ice": SkillSelected = "643"; type = 5; break;
                case "Ice Comet": SkillSelected = "651"; type = 5; break;

                case "Ice Orb": SkillSelected = "627"; type = 6; break;
                case "Manes Of Ice": SkillSelected = "656"; type = 7; break;
                case "Ice Impact": SkillSelected = "657"; type = 7; break;
                case "Ice Staff": SkillSelected = "672"; type = 7; break;

                case "Charge": SkillSelected = "703"; type = 8; break;
                case "Counter Spell": SkillSelected = "709"; type = 8; break;
                case "Lightining": SkillSelected = "715"; type = 8; break;
                case "Static Hemispher": SkillSelected = "718"; type = 8; break;
                case "Thunder": SkillSelected = "727"; type = 8; break;
                case "Thunder Blast": SkillSelected = "735"; type = 8; break;
                case "Charged Blade": SkillSelected = "742"; type = 8; break;
                case "Specter Of Thund": SkillSelected = "743"; type = 8; break;
                case "Static Orb": SkillSelected = "751"; type = 8; break;
                case "Static Thorn": SkillSelected = "754"; type = 8; break;
                case "Manes Of Thunder": SkillSelected = "756"; type = 8; break;
                case "Thunder Impact": SkillSelected = "757"; type = 8; break;

                case "Inferno": SkillSelected = "545"; type = 9; break;
                case "Blizzard": SkillSelected = "645"; type = 9; break;
                case "Thundercloud": SkillSelected = "745"; type = 9; break;
                case "Super Nova": SkillSelected = "560"; type = 9; break;
                case "Frost Nova": SkillSelected = "660"; type = 9; break;
                case "Static Nova": SkillSelected = "760"; type = 9; break;
                case "Meteor Fall": SkillSelected = "571"; type = 9; break;
                case "Ice Storm": SkillSelected = "671"; type = 9; break;
                case "Chain Lightning": SkillSelected = "771"; type = 9; break;
                case "Incineration": SkillSelected = "570"; type = 1; break;
                default: return;
            }
            string SkillID = AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6);
            switch (type)
            {
                case 1:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000A00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "FA020400AA01000000000000");
                    break;
                case 2:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "FA020400AA01000000000000");
                    break;
                case 3:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "09030400A101000000000000");
                    break;
                case 4:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000D00");
                    Packet("3102" + SkillID + "00" + "FFFF" + CharID() + "0D020600B7019BFF0000F0000F00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "0D020600B7019BFF0000F0000F00");
                    break;
                case 5:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "FD020400A101000000000000");
                    break;
                case 6:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
                    Packet("3102" + SkillID + "00" + CharID() + EnemyID() + "000000000000000000000000");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000000");
                    Packet("3104" + SkillID + "00" + CharID() + EnemyID() + "5C020600B7019BFF000000000000");
                    break;
                case 7:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000A00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "000000000000000000000000");
                    break;
                case 8:
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "0D020600B7019BFF0000F0000F00");
                    break;
                case 9:
                    Packet("3101" + SkillID + "00" + CharID() + "FFFF" + (AlignDWORD(new IntPtr(EnemyX()))).Substring(0, 4) + "0400" + (AlignDWORD(new IntPtr(EnemyY()))).Substring(0, 4) + "0000000000000F00");
                    Packet("3103" + SkillID + "00" + CharID() + "FFFF" + (AlignDWORD(new IntPtr(EnemyX()))).Substring(0, 4) + "0400" + (AlignDWORD(new IntPtr(EnemyY()))).Substring(0, 4) + "000000000000");
                    break;
                case 10:
                    //Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
                    Packet("3101" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000A00");
                    //Packet("3102" + SkillID + "00" + CharID() + EnemyID() + "000000000000000000000000");
                    //Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "0000000000000000000000000000");
                    Packet("3102" + SkillID + "00" + CharID() + EnemyID() + "0D020600B7019BFF0000F0000F00");
                    Packet("3103" + SkillID + "00" + CharID() + EnemyID() + "0D020600B7019BFF0000F0000F00");
                    //Packet("3101" + SkillID + "00" + CharID() + "FFFF" + (AlignDWORD(new IntPtr(EnemyX()))).Substring(0, 4) + "0400" + (AlignDWORD(new IntPtr(EnemyY()))).Substring(0, 4) + "0000000000000D00");
                    //Packet("3103" + SkillID + "00" + CharID() + "FFFF" + (AlignDWORD(new IntPtr(EnemyX()))).Substring(0, 4) + "0400" + (AlignDWORD(new IntPtr(EnemyY()))).Substring(0, 4) + "000000000000");
                    break;
                default: return;
            }
        }

        public void RogueAttack(string skill, bool extra)
        {
            string SkillSelected = "";
            switch (skill)
            {
                case "Archery": SkillSelected = "003"; break;
                case "Through Shot": SkillSelected = "500"; break;
                case "Fire Arrow": SkillSelected = "505"; break;
                case "Poison Arrow": SkillSelected = "510"; break;
                case "Multiple Shot": MultipleShot(); return;
                case "Guided Arrow": SkillSelected = "520"; break;
                case "Perfect Shot": SkillSelected = "525"; break;
                case "Fire Shot": SkillSelected = "530"; break;
                case "Poison Shot": SkillSelected = "535"; break;
                case "Arc Shot": SkillSelected = "540"; break;
                case "Explosive Shot": SkillSelected = "545"; break;
                case "Viper": SkillSelected = "550"; break;
                case "Counter Strike": CounterStrike(); return;
                case "Arrow Shower": ArrowShower(); return;
                case "Shadow Shot": SkillSelected = "557"; break;
                case "Shadow Hunter": SkillSelected = "560"; break;
                case "Ice Shot": SkillSelected = "562"; break;
                case "Lightning Shot": SkillSelected = "566"; break;
                case "Dark Pursuer": SkillSelected = "570"; break;
                case "Blow Arrow": SkillSelected = "572"; break;
                case "Blinding Strafe": SkillSelected = "580"; break;
                case "Super Archer": SuperArcher(); return;

            }
            if (!SkillSelected.Equals(""))
            {
                Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "FB020000B1010000000000000D00");
                Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "FB020000B101000000000000");
                Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "FB020000B1010000000000000000");

                //Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000000000000000D00");
                //Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "000000000000010000000000");
                //Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000100000000000000");
            }
            else
            {
                if (extra)
                    AttackR();
                switch (skill)
                {
                    case "Stab": SkillSelected = "005"; break;
                    case "Stab2": SkillSelected = "006"; break;
                    case "Jab": SkillSelected = "600"; break;
                    case "Pierce": SkillSelected = "615"; break;
                    case "Shock": SkillSelected = "620"; break;
                    case "Thrust": SkillSelected = "635"; break;
                    case "Cut": SkillSelected = "640"; break;
                    case "Spike": SkillSelected = "655"; break;
                    case "Blody Beast": SkillSelected = "670"; break;
                    case "Blinding": SkillSelected = "675"; break;
                    default: return;
                }
                Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0100010000000000000000000000");
            }
        }

        public void AssasinAttack(string Skill, bool extra)
        {
            if (extra)
                AttackR();
            string SkillSelected = "";
            switch (Skill)
            {
                case "Stab": SkillSelected = "005"; break;
                case "Stab2": SkillSelected = "006"; break;
                case "Jab": SkillSelected = "600"; break;
                case "Pierce": SkillSelected = "615"; break;
                case "Shock": SkillSelected = "620"; break;
                case "Thrust": SkillSelected = "635"; break;
                case "Cut": SkillSelected = "640"; break;
                case "Spike": SkillSelected = "655"; break;
                case "Blody Beast": SkillSelected = "670"; break;
                case "Blinding": SkillSelected = "675"; break;
                default: return;
            }
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0100010000000000000000000000");
        }

        public void WarriorAttack(string skill, bool extra)
        {
            if (extra)
                AttackR();
            string SkillSelected = "";
            switch (skill)
            {
                case "Slash": SkillSelected = "003"; break;
                case "Crash": SkillSelected = "005"; break;
                case "Piercing": SkillSelected = "009"; break;
                case "Whipping": SkillSelected = "010"; break;
                case "Hash": SkillSelected = "500"; break;
                case "Hoodwink": SkillSelected = "505"; break;
                case "Shear": SkillSelected = "510"; break;
                case "Pierce": SkillSelected = "515"; break;
                case "Carwing": SkillSelected = "525"; break;
                case "Sever": SkillSelected = "530"; break;
                case "Prick": SkillSelected = "535"; break;
                case "Multiple Shock": SkillSelected = "540"; break;
                case "Cleave": SkillSelected = "545"; break;
                case "Mangling": SkillSelected = "550"; break;
                case "Thrust": SkillSelected = "555"; break;
                case "Sword Aura": SkillSelected = "557"; break;
                case "Sword Dancing": SkillSelected = "560"; break;
                case "Howling Sword": SkillSelected = "570"; break;
                case "Blooding": SkillSelected = "575"; break;
                case "Hell Blade": SkillSelected = "580"; break;
                default: return;
            }
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "5D020600B6019BFF0000F0000A00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "5D020600B6019BFF0000F0000A00");
        }

        public void PriestAttack(string skill, bool extra)
        {
            if (extra)
                AttackR();
            string SkillSelected = "";
            switch (skill)
            {
                case "Stroke": SkillSelected = "001"; break;
                case "Holy Attack": SkillSelected = "006"; break;
                case "Wrath": SkillSelected = "611"; break;
                case "Wield": SkillSelected = "620"; break;
                case "Harsh": SkillSelected = "641"; break;
                case "Collision": SkillSelected = "511"; break;
                case "Shuddering": SkillSelected = "520"; break;
                case "Ruin": SkillSelected = "542"; break;
                case "Helish": SkillSelected = "551"; break;
                case "Tilt": SkillSelected = "712"; break;
                case "Bloody": SkillSelected = "721"; break;
                case "Raving Edge": SkillSelected = "739"; break;
                case "Hades": SkillSelected = "750"; break;
                case "Judgement": SkillSelected = "802"; break;
                default: return;
            }
            //Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000000000000000D00");
            //Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + "FFFF" + EnemyID() + "0D020600B7019BFF0000F0000F00");
            //Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0D020600B7019BFF0000F0000F00");

            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + SkillSelected))).Substring(0, 6) + "00" + CharID() + EnemyID() + "5D020600B6019BFF0000F0000A00");
        }

        public void AttackR()
        {
            Packet("080101" + EnemyID() + "FF00000000");
            //WriteMemory(new IntPtr(AddressPointer + 0xD29), 1);
        }

        public void MultipleShot()
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000000000000000D00");
            Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0D020600B7019BFF0000F0000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000400000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000400000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000500000000000000");
        }

        public void CounterStrike()
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "552"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "FB020000B1010000000000000A00");
            Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "552"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "FB020000B101000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "552"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "FB020000B1010000000000000000");
        }

        public void ArrowShower()
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
            Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0D020600B7019BFF0000F0000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000001500000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000001500000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000001600000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000001700000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000001800000000000000");
        }

        public void SuperArcher()
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000000000000000D00");
            Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "000000000000040000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000400000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF040000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000400000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF040000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000500000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "515"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF050000000000");

            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000000000000000000F00");
            Packet("3102" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "000000000000290000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000002900000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF290000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000002900000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF290000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000002A00000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF2A0000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000002B00000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF2B0000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + "0000000000002C00000000000000");
            Packet("3104" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "555"))).Substring(0, 6) + "00" + CharID() + EnemyID() + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "9BFF2C0000000000");
        }

        public void PotionHP(string potion)
        {
            string PotionID = "";
            switch (potion)
            {
                case "720": PotionID = "014"; break;
                case "360": PotionID = "013"; break;
                case "180": PotionID = "012"; break;
                case "90": PotionID = "011"; break;
                case "45": PotionID = "010"; break;
                case "Ibexs": PotionID = "071"; break;
                default: return;
            }
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse("490" + PotionID))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000000");
        }

        public void PotionMP(string potion)
        {
            string PotionID = "";
            switch (potion)
            {
                case "1920": PotionID = "020"; break;
                case "960": PotionID = "019"; break;
                case "480": PotionID = "018"; break;
                case "180": PotionID = "017"; break;
                case "90": PotionID = "016"; break;
                case "Crisis": PotionID = "072"; break;
                default: return;
            }
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse("490" + PotionID))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000000");
        }

        public void Wolf()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "030"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "030"))).Substring(0, 6) + "00" + CharID() + "FFFF" + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "0000000000001100");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "030"))).Substring(0, 6) + "00" + CharID() + "FFFF" + AlignDWORD(new IntPtr(CharX())).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ())).Substring(0, 4) + AlignDWORD(new IntPtr(CharY())).Substring(0, 4) + "000000000000");
        }

        public void MinorHealing()
        {
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "705"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000000");
        }

        public void Swift()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "010"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "010"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "010"))).Substring(0, 6) + "00" + CharID() + CharID() + "F7020400AE01000000000000");
        }

        public void LightFeet()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "725"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "725"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000000");
        }

        public void RogueHide()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "700"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "700"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "700"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void LupinEyes()
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "735"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000001400");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "735"))).Substring(0, 6) + "00" + CharID() + CharID() + "F7020400AE01000000000000");
        }

        public void Evade()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "710"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "710"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "710"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void Safely()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "730"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "730"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "730"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void SkaledSkin()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "760"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "760"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "760"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void PowerShootEffect()
        {
            //Packet("3104" + AlignDWORD(new IntPtr(210503)).Substring(0, 6) + "00" + CharID() + EnemyID() + "F7020500A0019BFF040000000000");
            Packet("3104" + AlignDWORD(new IntPtr(210545)).Substring(0, 6) + "00" + CharID() + "FFFF" + AlignDWORD(new IntPtr(EnemyX())).Substring(0, 4) + "0400" + AlignDWORD(new IntPtr(EnemyY())).Substring(0, 4) + "9BFF000000000000");
        }

        public void Gain()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "705"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "705"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000001400");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "705"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void Sprint()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "002"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "002"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000000");
        }

        public void Defense()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "007"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "007"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000000");
        }

        public void Strenght(string ID)
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "004"))).Substring(0, 6) + "00" + CharID() + ID + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "004"))).Substring(0, 6) + "00" + CharID() + ID + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "004"))).Substring(0, 6) + "00" + CharID() + ID + "000000000000000000000000");
        }

        public void Blasting()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "529"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "529"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "529"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void Wildness()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "629"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "629"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "629"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void PlayerOfCronos()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "013"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "013"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "013"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void PlayerOfGodPower()
        {
            Packet("3106" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "020"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "020"))).Substring(0, 6) + "00" + CharID() + CharID() + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "020"))).Substring(0, 6) + "00" + CharID() + CharID() + "000000000000000000000000");
        }

        public void Malice(string ID)
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "703"))).Substring(0, 6) + "00" + CharID() + ID + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "703"))).Substring(0, 6) + "00" + CharID() + ID + "000000000000000000000000");
        }

        public void SpeedHack()
        {
            if (GetAsyncKeyState(32) != 0)
            {
                if (CharX() > MouseX())
                {
                    if (CharX() - MouseX() > 5)
                    {
                        //Packet("06" + AlignDWORD(new IntPtr((CharX() - 5) * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharY() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ() * 10)).Substring(0, 4) + "2D0001");
                        WriteMemory(new IntPtr(AddressPointer + OFF_X), Convert.ToSingle(CharX() - 5));
                    }
                }
                else if (CharX() < MouseX())
                {
                    if (MouseX() - CharX() > 5)
                    {
                        //Packet("06" + AlignDWORD(new IntPtr((CharX() + 5) * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharY() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ() * 10)).Substring(0, 4) + "2D0001");
                        WriteMemory(new IntPtr(AddressPointer + OFF_X), Convert.ToSingle(CharX() + 5));
                    }
                }
                if (CharY() > MouseY())
                {
                    if (CharY() - MouseY() > 5)
                    {
                        //Packet("06" + AlignDWORD(new IntPtr(CharX() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr((CharY() - 5) * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ() * 10)).Substring(0, 4) + "2D0001");
                        WriteMemory(new IntPtr(AddressPointer + OFF_Y), Convert.ToSingle(CharY() - 5));
                    }
                }
                else if (CharY() < MouseY())
                {
                    if (MouseY() - CharY() > 5)
                    {
                        //Packet("06" + AlignDWORD(new IntPtr(CharX() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr((CharY() + 5) * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ() * 10)).Substring(0, 4) + "2D0001");
                        WriteMemory(new IntPtr(AddressPointer + OFF_Y), Convert.ToSingle(CharY() + 5));
                    }
                }
                Packet("06" + AlignDWORD(new IntPtr(CharX() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharY() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ() * 10)).Substring(0, 4) + "2D0001");
            }
        }

        public void Transform(string Transformation)
        {
            string ID = "";
            switch (Transformation)
            {
                case "Willd Bulcan": ID = "FA2B07"; break;
                case "Kecon": ID = "042C07"; break;
                case "Bulture": ID = "182C07"; break;
                case "Zombie": ID = "222C07"; break;
                case "Lycan": ID = "362C07"; break;
                case "Stripter Scorpion": ID = "402C07"; break;
                case "Kobolt": ID = "4A2C07"; break;
                case "Death Knight": ID = "862C07"; break;
                case "Mastadon": ID = "722C07"; break;
                case "Black Window": ID = "742C07"; break;
                case "Sheriff": ID = "9A2C07"; break;
                case "Harunga": ID = "B82C07"; break;
                case "Burning Skeloton": ID = "BA2C07"; break;
                case "Raven Harpy": ID = "EA2C07"; break;
                case "Uruk Tron": ID = "F42C07"; break;
                case "Troll Warior": ID = "FE2C07"; break;
                case "Centaur": ID = "042D07"; break;
                case "Stone Golem": ID = "082D07"; break;
                case "Orc Bowman": ID = "262D07"; break;
                default: return;
            }
            Packet("3101" + ID + "00" + CharID() + CharID() + "0000000000000000000000");
            Packet("3102" + ID + "00" + CharID() + CharID() + "0000000000000000000000");
            Packet("3103" + ID + "00" + CharID() + CharID() + "0000000000000000000000");
            Packet("3104" + ID + "00" + CharID() + CharID() + "0000000000000000000000");
            TransformStatus = 5400;
        }

        public void TPskill(string ID)
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "004"))).Substring(0, 6) + "00" + CharID() + ID + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + "004"))).Substring(0, 6) + "00" + CharID() + ID + "BA0190005F06000000000000");
        }

        public void Heal(string Skill, string ID)
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + HealSkillID(Skill)))).Substring(0, 6) + "00" + CharID() + ID + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + HealSkillID(Skill)))).Substring(0, 6) + "00" + CharID() + ID + "000000000000000000000000");
        }

        public void Buff(string Skill, string ID)
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + BuffSkillID(Skill)))).Substring(0, 6) + "00" + CharID() + ID + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + BuffSkillID(Skill)))).Substring(0, 6) + "00" + CharID() + ID + "000000000000000000000000");
        }

        public void AC(string Skill, string ID)
        {
            Packet("3101" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + ACSkillID(Skill)))).Substring(0, 6) + "00" + CharID() + ID + "0000000000000000000000000F00");
            Packet("3103" + AlignDWORD(new IntPtr(int.Parse(FindClass().ToString() + ACSkillID(Skill)))).Substring(0, 6) + "00" + CharID() + ID + "000000000000000000000000");
        }

        public string HealSkillID(string Skill)
        {
            switch (Skill)
            {
                case "60": return "500";
                case "240": return "509";
                case "360": return "518";
                case "720": return "527";
                case "960": return "536";
                case "1920": return "545";
                default: return null;
            }
        }

        public string BuffSkillID(string Skill)
        {
            switch (Skill)
            {
                case "60": return "606";
                case "240": return "615";
                case "360": return "624";
                case "720": return "633";
                case "960": return "642";
                case "1200": return "655";
                case "Undy": return "654";
                case "1500": return "657";
                case "2000": return "670";
                case "2500": return "678";
                default: return null;
            }
        }

        public string ACSkillID(string Skill)
        {
            switch (Skill)
            {
                case "20": return "603";
                case "40": return "612";
                case "80": return "621";
                case "120": return "630";
                case "160": return "639";
                case "200": return "651";
                case "300": return "660";
                case "350": return "676";
                default: return null;
            }
        }
        //int DistanceX = (Math.Abs(X - CharX()) * 65) / 100;
        //int DistanceY = (Math.Abs(Y - CharY()) * 65) / 100;
        public void SpeedHackTo(int X, int Y)
        {
            if (Distance(CharX(), CharY(), EnemyX(), EnemyY()) < 15)
            {
                int DistanceX = Math.Abs(X - CharX());
                int DistanceY = Math.Abs(Y - CharY());
                int DirectionX = 0;
                int DirectionY = 0;
                double x = 0;
                double y = 0;
                float GoX = 0;
                float GoY = 0;
                if (CharX() > X) DirectionX = -1; else DirectionX = 1;
                if (CharY() > Y) DirectionY = -1; else DirectionY = 1;

                int Offset = 5;

                int Movement = Convert.ToInt32(Math.Floor(Math.Sqrt(Math.Pow(DistanceX, 2) + Math.Pow(DistanceY, 2))));

                for (int i = Offset; i <= Movement; i += Offset)
                {
                    x = Math.Pow(5, 2) * Math.Pow(DistanceX, 2);
                    y = Math.Pow(DistanceX, 2) + Math.Pow(DistanceY, 2);
                    GoX = Convert.ToSingle(Math.Sqrt(x / y));
                    GoY = Convert.ToSingle(Math.Sqrt(Math.Pow(5, 2) - Math.Pow(GoX, 2)));
                    GoX = Convert.ToSingle(Math.Round(CharX() + DirectionX * GoX));
                    GoY = Convert.ToSingle(Math.Round(CharY() + DirectionY * GoY));
                    //a = Math.Pow(5, 2) * Math.Pow(DistanceX, 2);
                    //b = Math.Pow(DistanceX, 2) + Math.Pow(DistanceY, 2);
                    //d = Math.Sqrt(a / b);
                    //e = Math.Sqrt(Math.Pow(5, 2) - Math.Pow(d, 2));
                    //GoX = Convert.ToSingle(Math.Round(CharX() + DirectionX * d));
                    //GoY = Convert.ToSingle(Math.Round(CharY() + DirectionY * e));

                    WriteMemory(new IntPtr(AddressPointer + OFF_X), GoX);
                    WriteMemory(new IntPtr(AddressPointer + OFF_Y), GoY);
                    WriteMemory(new IntPtr(AddressPointer + OFF_Z), Convert.ToSingle(CharZ()));
                    //Packet("06" + FormatHex(AlignDWORD(new IntPtr(Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_X)), 0)) * 10)).Substring(0, 4), 4) + FormatHex(AlignDWORD(new IntPtr(Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_Y)), 0)) * 10)).Substring(0, 4), 4) + FormatHex(AlignDWORD(new IntPtr(Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_Z)), 0)) * 10)).Substring(0, 4), 4) + "2D0003");
                    Packet("06" + AlignDWORD(new IntPtr(CharX() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharY() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ() * 10)).Substring(0, 4) + "2D0001");
                    Application.DoEvents();
                }
                Packet("06" + AlignDWORD(new IntPtr(CharX() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharY() * 10)).Substring(0, 4) + AlignDWORD(new IntPtr(CharZ() * 10)).Substring(0, 4) + "2D0001");
            }
        }

    }
}