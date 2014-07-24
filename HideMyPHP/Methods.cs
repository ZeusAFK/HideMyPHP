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
    public partial class Methods : Skills
    {
        public Methods()
        {
            InitializeComponent();
        }

        public void EjecutarComandos(string comandos)
        {
            string[] splitComandos = comandos.Split('|');
            for (int i = 0; i < splitComandos.Length; i++)
            {
                string comando = splitComandos[i];

                if (comando.ToUpper().IndexOf("INVITE(") != -1)
                {
                    int indexInicio = comando.IndexOf('(');
                    int indexFin = comando.LastIndexOf(')');

                    string nick = comando.Substring(indexInicio + 1, (indexFin - indexInicio - 1));

                    InviteParty(nick);
                }
                else if (comando.ToUpper().IndexOf("CHAT(") != -1)
                {
                    int indexInicio = comando.IndexOf('(');
                    int indexFin = comando.LastIndexOf(')');
                    string parametros = comandos.Substring(indexInicio + 1, (indexFin - indexInicio - 1));

                    string[] arrayParametros = parametros.Split(',');

                    string texto = arrayParametros[0];
                    string tipo = arrayParametros[1].ToUpper();

                    Chat(texto, tipo);
                }
                else if (comando.ToUpper().IndexOf("TP(") != -1)
                {
                    int indexInicio = comando.IndexOf('(');
                    int indexFin = comando.LastIndexOf(')');
                    string parametro = comandos.Substring(indexInicio + 1, (indexFin - indexInicio - 1));
                    TP(parametro);
                }
                else
                {
                    Console.Write("Comando no reconocido " + comando + "\n");
                }
            }
        }

        public void TP(string Data)
        {
            int Index = -1;
            try { Index = int.Parse(Data); }
            catch { Index = PartyPosition(Data); }
            if (Index != -1 && Index >=1 && Index <=8)
                TPskill(PartyID(Index));
        }

        public void NotifyMoney(string mail)
        {

            int newNoah = CharMoney();
            if (noah != newNoah)
            {
                //Cambio Noah
                noah = newNoah;
                System.Net.HttpWebRequest myRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("http://ferchonet.net63.net/mail.php?c=" + mail + "&a=Dinero&m=Tiene " + noah + " Dinero");
                myRequest.Method = "GET";
                System.Net.WebResponse myResponse = myRequest.GetResponse();
            }
        }

        public string HealChooser(string heal, int Member)
        {
            if (heal.Equals("Auto"))
            {
                int needed = PartyMaxHP(Member) - PartyHP(Member);
                if (needed < 45)
                    return "60";
                else if (needed < 200)
                    return "240";
                else if (needed < 320)
                    return "360";
                else if (needed < 680)
                    return "720";
                else if (needed < 890)
                    return "960";
                else
                    return "1920";
            }
            else
                return heal;
        }

        public string HealChooser(string heal)
        {
            if (heal.Equals("Auto"))
            {
                int needed = CharMaxHP() - CharHP();
                if (needed < 45)
                    return "60";
                else if (needed < 200)
                    return "240";
                else if (needed < 320)
                    return "360";
                else if (needed < 680)
                    return "720";
                else if (needed < 890)
                    return "960";
                else
                    return "1920";
            }
            else
                return heal;
        }
    }
}
