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
    public partial class Variables : Functions
    {
        public Variables()
        {
            InitializeComponent();
        }

        public int MouseX()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_MX)), 0));
        }

        public int MouseY()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_MY)), 0));
        }

        public int MouseZ()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_MZ)), 0));
        }

        public string CharID()
        {
            return AlignDWORD(new IntPtr(ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_ID))))).Substring(0, 4).ToUpper();
        }

        public int CharHP()
        {
            return ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_HP)));
        }

        public int CharMaxHP()
        {
            return ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_MAXHP)));
        }

        public int CharMP()
        {
            return ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_MP)));
        }

        public int CharMaxMP()
        {
            return ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_MAXMP)));
        }

        public long CharExp()
        {
            return long.Parse(ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_EXP))).ToString());
        }

        public long CharMaxExp()
        {
            return long.Parse(ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_MAXEXP))).ToString());
        }

        public int CharLvl()
        {
            return ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_LVL)));
        }

        public int CharMoney()
        {
            return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_CHR))) + 0x9D0)));
        }

        public int CharZone()
        {
            return ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_ZONE)));
        }

        public int CharDC()
        {
            int dc = ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_PKT))) + 0x4004C)));
            if (DEBUG_MODE)
                if (dc == 0)
                    log(">>> DISCONECTED!!!.");
            if (dc == 0)
            {
                FuncPtr = IntPtr.Zero;
                BytesAddr = IntPtr.Zero;
            }
            return dc;
        }

        public int CharX()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_X)), 0));
        }

        public int CharY()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_Y)), 0));
        }

        public int CharZ()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_Z)), 0));
        }

        public string CharName()
        {
            byte[] pBytes = new byte[25];
            string Name = Convert.ToString(ASCIIEncoding.ASCII.GetString(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_NAME)))), pBytes, 25L)));
            for (int i = 0; i < Name.Length; i++)
                if ((int)Name[i] == 0)
                    return Name.Substring(0, i);
            return "";
        }

        public string CharServer(int j)
        {
                byte[] pBytes = new byte[25];
                string Name = Convert.ToString(ASCIIEncoding.ASCII.GetString(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_PKT))) + 0x74 + j)))), pBytes, 25L)));
                for (int i = 0; i < Name.Length; i++)
                    if ((int)Name[i] == 0)
                        return Name.Substring(0, i);
            return "";
        }

        public int FindClass()
        {
            return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_CHR))) + OFF_CLASS)));
        }

        public string CharJob()
        {
            switch (FindClass())
            {
                case 102: return "Rogue";
                case 107: return "Rogue";
                case 108: return "Rogue";
                case 202: return "Rogue";
                case 207: return "Rogue";
                case 208: return "Rogue";
                case 104: return "Priest";
                case 111: return "Priest";
                case 112: return "Priest";
                case 204: return "Priest";
                case 211: return "Priest";
                case 212: return "Priest";
                case 101: return "Warrior";
                case 105: return "Warrior";
                case 106: return "Warrior";
                case 201: return "Warrior";
                case 205: return "Warrior";
                case 206: return "Warrior";
                case 103: return "Mage";
                case 109: return "Mage";
                case 110: return "Mage";
                case 203: return "Mage";
                case 209: return "Mage";
                case 210: return "Mage";
                default: return "Undefined";
            }
        }

        public string EnemyID()
        {
            return AlignDWORD(new IntPtr(ToInt32(ReadMemory(new IntPtr(AddressPointer + OFF_MOB))))).Substring(0, 4).ToUpper();
        }

        public int EnemyHP()
        {
            return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x1BC))) + 0xD8))) + 0x100)));
        }

        public int EnemyX()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x3DC))) + 0x58)), 0));
        }

        public int EnemyY()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x3DC))) + 0x60)), 0));
        }

        public int EnemyZ()
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x3DC))) + 0x5C)), 0));
        }

        public int EnemyDistance()
        {
            return Convert.ToInt32(Math.Round(Math.Pow((((EnemyX() - BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_X)), 0)) * (EnemyX() - BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_X)), 0))) + ((EnemyY() - BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_Y)), 0)) * (EnemyY() - BitConverter.ToSingle(ReadMemory(new IntPtr(AddressPointer + OFF_Y)), 0)))), 0.5) / 4));
        }

        public string EnemyName()
        {
            byte[] pBytes = new byte[25];
            string Name = Convert.ToString(ASCIIEncoding.ASCII.GetString(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x1BC))) + 0xE8))) + 0xE8)))), pBytes, 25L)));
            for (int i = 0; i < Name.Length; i++)
                if ((int)Name[i] == 0)
                    return Name.Substring(0, i);
            return "";
        }

        public int PartyBase(int Member)
        {
            int pBase = ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(OFF_PARTY))) + OFF_PARTY_OFFSET))) + OFF_PARTY_VALUE)));
            switch (Member)
            {
                case 1: return ToInt32(ReadMemory(new IntPtr(pBase + 0x0)));
                case 2: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0)));
                case 3: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0)));
                case 4: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 5: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 6: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 7: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 8: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                default: return 0;
            }
        }

        public string PartyID(int Member)
        {
            return AlignDWORD(new IntPtr(ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + OFF_PARTY_ID))))).Substring(0, 4).ToUpper();
        }

        public int PartyHP(int Member)
        {
            return ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + OFF_PARTY_HP)));
        }

        public int PartyMaxHP(int Member)
        {
            return ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + OFF_PARTY_MAXHP)));
        }

        public int PartyLevel(int Member)
        {
            return ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + OFF_PARTY_LEVEL)));
        }

        public int PartyClass(int Member)
        {
            return ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + OFF_PARTY_CLASS)));
        }

        public string PartyName(int Member)
        {
            byte[] pBytes = new byte[25];
            string Name = Convert.ToString(ASCIIEncoding.ASCII.GetString(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + OFF_PARTY_NAME))) + 0x0), pBytes, 25L)));
            for (int i = 0; i < Name.Length; i++)
                if ((int)Name[i] == 0)
                    return Name.Substring(0, i);
            return "";
        }

        public int PartyMembers()
        {
            return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + OFF_PARTY_OFFSET))) + OFF_PARTY_NUMBER)));
        }

        public int PartyPosition(string Nick)
        {
            for (int i = 1; i <= PartyMembers(); i++)
                if (PartyName(i).ToUpper().Equals(Nick.ToUpper()))
                    return i;
            return -1;
        }

        public int RightDurabilty()
        {
            return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x2D8))) + 260)));
        }

        public int LeftDurabilty()
        {
            return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x2D8))) + 256)));
        }

        public string PlayerBase(string Player)
        {
            int tmpBase, IDArray, offset, Mob;
            int BaseAddr = 0;
            Mob = FormatDec(Player, 4);
            if (Mob > 9999) offset = 44; else offset = 60;
            tmpBase = ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(FLDB))) + offset))) + 0x4)));
            while (tmpBase != 0)
            {
                IDArray = ToInt32(ReadMemory(new IntPtr(tmpBase + 0xC)));
                if (IDArray >= Mob)
                {
                    if (IDArray == Mob)
                        BaseAddr = ToInt32(ReadMemory(new IntPtr(tmpBase + 0x10)));
                    tmpBase = ToInt32(ReadMemory(new IntPtr(tmpBase + 0x0)));
                }
                else
                    tmpBase = ToInt32(ReadMemory(new IntPtr(tmpBase + 0x8)));
            }
            return Convert.ToString(BaseAddr, 16).ToUpper();
        }

        public int PartyX(int Member)
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(Convert.ToInt32(PlayerBase(PartyID(Member)), 16) + OFF_X)), 0));
        }

        public int PartyY(int Member)
        {
            return Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(Convert.ToInt32(PlayerBase(PartyID(Member)), 16) + OFF_Y)), 0));
        }

        public bool PartyInRange(int Member)
        {
            if (PartyName(Member).Equals(CharName()))
                return true;
            if (PartyX(Member) != 0 && PartyY(Member) != 0)
                return true;
            return false;
        }

        public int Distance(int x1, int y1, int x2, int y2)
        {
            return Convert.ToInt32(Math.Round(Math.Pow((((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2))), 0.5) / 4));
            // { [(x1 - x2)^2 + (y1 - y2)^2] ^ 1/2 } /4
        }
    }
}