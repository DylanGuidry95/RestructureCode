using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProfileApplication;
using RestructureCode;

namespace RPG_Characters
{
    public partial class Create : Form
    {
        Form1 parent = new Form1();

        List<int> StatRolls;

        SaveLoad<Character> _SaveLoad = new SaveLoad<Character>();

        public Create(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void StatsRoll_Click(object sender, EventArgs e)
        {
            StatRolls = new List<int>();
            DiceRoll.Text = "";
            for(int i = 0; i < 6; i++)
            {
                int t = PublicFunctions.DiceRoll(20);
                if(t == 1)
                {
                    t = PublicFunctions.DiceRoll(20);
                }
                DiceRoll.Text += t.ToString() + "\n";
                StatRolls.Add(t);
            }
            AddStats();
        }

        private void AddStats()
        {
            foreach(int i in StatRolls)
            {
                StrStat.Items.Add(i);
                ConStat.Items.Add(i);
                DexStat.Items.Add(i);
                IntStat.Items.Add(i);
                WisStat.Items.Add(i);
                ChaStat.Items.Add(i);
            }
        }

        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            //Character c = new Character(FirstName.Text + "_" + LastName.Text, IntStat.SelectedIndex.ToString(), StrStat.SelectedIndex.ToString(),
                //DexStat.SelectedIndex.ToString(), ConStat.SelectedIndex.ToString(), ChaStat.SelectedIndex.ToString());
        }
    }
}
