using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZeusAFK_koxp.NET
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        public Byte[] ToByteArray(String pStr)
        {
            Byte[] pByte = new Byte[pStr.Length / 2];
            Int32 i, j;
            j = -1;
            Int32 pStrLength = pStr.Length;
            try
            {
                for (i = 0; i < pStrLength; i += 2)
                {
                    j++;
                    pByte[j] = Convert.ToByte(Convert.ToInt32("0x" + pStr.Substring(i, 2), 16));
                }
            }
            catch { }
            return pByte;
        }

        public string ToHex(string pStr)
        {
            string hex = "";
            foreach (char c in pStr)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex.ToUpper();
        }

        public String AlignDWORD(IntPtr word)
        {
            long ADDWORD;
            String ADpStr, ADpStr2, ADresultStr;

            ADDWORD = (long)Convert.ToInt32(word.ToString());
            ADpStr = Convert.ToString(ADDWORD, 16);
            ADpStr2 = "";

            Int32 ADpStrLength = ADpStr.Length;

            int i = 0;
            for (i = 0; i < 8 - ADpStrLength; i++)
            {
                ADpStr2 = ADpStr2.Insert(i, "0");
            }

            int j = 0;
            int t = i;
            for (i = t; i < 8; i++)
            {
                ADpStr2 = ADpStr2.Insert(i, ADpStr[j].ToString());
                j++;
            }

            ADresultStr = "";

            ADresultStr = ADresultStr.Insert(0, ADpStr2[6].ToString());
            ADresultStr = ADresultStr.Insert(1, ADpStr2[7].ToString());
            ADresultStr = ADresultStr.Insert(2, ADpStr2[4].ToString());
            ADresultStr = ADresultStr.Insert(3, ADpStr2[5].ToString());
            ADresultStr = ADresultStr.Insert(4, ADpStr2[2].ToString());
            ADresultStr = ADresultStr.Insert(5, ADpStr2[3].ToString());
            ADresultStr = ADresultStr.Insert(6, ADpStr2[0].ToString());
            ADresultStr = ADresultStr.Insert(7, ADpStr2[1].ToString());

            return ADresultStr.ToUpper();
        }

        public Int32 ToInt32(byte[] pBytes)
        {
            return BitConverter.ToInt32(pBytes, 0);
        }

        public int FormatDec(string strHex, int inLength)
        {
            string NewDec; string byte1; string byte2; string byte3; string byte4;
            int ZeroSpaces = inLength - strHex.Length;
            //NewDec = ZeroSpaces.ToString() + strHex;
            NewDec = strHex;

            try { byte1 = NewDec.Substring(0, 2); }
            catch { byte1 = ""; }
            try { byte2 = NewDec.Substring(2, 2); }
            catch { byte2 = ""; }
            try { byte3 = NewDec.Substring(4, 2); }
            catch { byte3 = ""; }
            try { byte4 = NewDec.Substring(NewDec.Length - 2, 2); }
            catch { byte4 = ""; }

            switch (NewDec.Length)
            {
                case 2: NewDec = Convert.ToInt32("0x" + byte1, 16).ToString(); break;
                case 4: NewDec = Convert.ToInt32("0x" + byte4 + byte1, 16).ToString(); break;
                case 6: NewDec = Convert.ToInt32("0x" + byte4 + byte2 + byte1, 16).ToString(); break;
                case 8: NewDec = Convert.ToInt32("0x" + byte4 + byte3 + byte2 + byte1, 16).ToString(); break;
                default: return 0;
            }
            return int.Parse(NewDec);
        }
        public string FormatHex(string strHex, int inLength)
        {
            string NewHex; string byte1; string byte2; string byte3; string byte4;
            int ZeroSpaces = inLength - strHex.Length;
            //NewDec = ZeroSpaces.ToString() + strHex;
            NewHex = strHex;

            try { byte1 = NewHex.Substring(0, 2); }
            catch { byte1 = ""; }
            try { byte2 = NewHex.Substring(2, 2); }
            catch { byte2 = ""; }
            try { byte3 = NewHex.Substring(4, 2); }
            catch { byte3 = ""; }
            try { byte4 = NewHex.Substring(NewHex.Length - 2, 2); }
            catch { byte4 = ""; }

            switch (NewHex.Length)
            {
                case 2: NewHex = byte1; break;
                case 4: NewHex = byte4 + byte1; break;
                case 6: NewHex = byte4 + byte2 + byte1; break;
                case 8: NewHex = byte4 + byte3 + byte2 + byte1; break;
                default: return "";
            }
            return NewHex;
        }
    }
}
