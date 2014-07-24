using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ZeusAFK_koxp.NET
{
    public partial class frm_AddSkill : Form
    {
        public string[,] SkillList;
        public ArrayList SelectedSkills = new ArrayList();

        public frm_AddSkill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedSkills.Add(listBox1.SelectedItem);
        }

        private void frm_AddSkill_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SkillList.GetLength(0); i++)
                listBox1.Items.Add(SkillList[i, 0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
