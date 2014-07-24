using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeusAFK_koxp.NET
{
    public partial class Addresses : Converter
    {
        public Addresses()
        {
            InitializeComponent();
        }

        //Pointers
        public int PTR_CHR = 0xC3E030;
        public int PTR_DLG = 0xC3E37C;
        public int PTR_PKT = 0xC3E348;
        public int SND_FNC = 0x476762; // Auto Update Algorith implemented.
        public int SEND_PTR = 0xC33728;

        public int FNCZ = 0x835270;
        public int FLDB = 0xC3E02C;

        //Offsets
        public int OFF_ID = 0x5C4;
        public int OFF_HP = 0x5F4;
        public int OFF_MAXHP = 0x5F0;
        public int OFF_MP = 0x9C8;
        public int OFF_MAXMP = 0x9C4;
        public int OFF_WH = 0x5F8;
        public int OFF_CLASS = 0x5E8;
        public int OFF_MOB = 0x590;
        public int OFF_EXP = 0x9E0;
        public int OFF_MAXEXP = 0x9D8;
        public int OFF_LVL = 0x5EC;
        public int OFF_ZONE = 0xA64;
        public int OFF_X = 0xC4;
        public int OFF_Y = 0xCC;
        public int OFF_Z = 0xC8;
        public int OFF_NAME = 0x5CC;
        public int OFF_MX = 0xD84;
        public int OFF_MY = 0xD8C;
        public int OFF_MZ = 0xD88;
        public int OFF_MOVTYPE = 0xD78;
        public int OFF_GO_X = 0xD84;
        public int OFF_GO_Y = 0xD8C;
        public int OFF_MVCHRTYP = 0x3A4;
        public int OFF_PARTY = 0xC3E368;
        public int OFF_PARTY_VALUE = 0x370;
        public int OFF_PARTY_OFFSET = 0x1CC;
        public int OFF_PARTY_HP = 0x14;
        public int OFF_PARTY_MAXHP = 0x18;
        public int OFF_PARTY_LEVEL = 0xC;
        public int OFF_PARTY_CLASS = 0x10;
        public int OFF_PARTY_NAME = 0x30;
        public int OFF_PARTY_NUMBER = 0x364;
        public int OFF_PARTY_ID = 0x8;
    }
}
