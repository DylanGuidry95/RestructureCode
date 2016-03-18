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

        Character CreatedCharacter;

        List<ComboBox> StatValues = new List<ComboBox>();

        public Create(Form1 p)
        {
            parent = p;
            InitializeComponent();
            //CharCreate.Visible = false;
            SaveInfo.Visible = false;
            foreach (JobsAndRaces jc in parent.Races)
                RaceSelection.Items.Add(jc.Name);
            foreach (JobsAndRaces jc in parent.Classes)
                ClassSelection.Items.Add(jc.Name);
            StatValues.Add(StrStat);
            StatValues.Add(ConStat);
            StatValues.Add(DexStat);
            StatValues.Add(IntStat);
            StatValues.Add(WisStat);
            StatValues.Add(ChaStat);
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
            parent.GetSavedItems();
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            _SaveLoad.Serialize("/Characters/" + CreatedCharacter.Name, CreatedCharacter);
            parent.Characters.Add(CreatedCharacter);
            parent.AddItems("Characters", CreatedCharacter.Name);
        }

        private void CharCreate_Click(object sender, EventArgs e)
        {
            CreatedCharacter = new Character(FirstName.Text + "_" + LastName.Text, (int)IntStat.SelectedItem, (int)StrStat.SelectedItem,
                    (int)DexStat.SelectedItem, (int)ConStat.SelectedItem, (int)WisStat.SelectedItem, (int)ChaStat.SelectedItem, parent.Races[RaceSelection.SelectedIndex],
                    parent.Classes[ClassSelection.SelectedIndex]);
            PreviewPane.Text = "Name: " + CreatedCharacter.Name + "\n" +
                "Class: " + CreatedCharacter.CharClass.Name + "\n" +
                "Race: " + CreatedCharacter.CharRace.Name + "\n" +
                "Health" + CreatedCharacter.MaxHealth + "\n" +
                "\n" +
                "Int: " + CreatedCharacter.Intelligence + "\n" +
                "Str: " + CreatedCharacter.Strength + "\n" +
                "Dex: " + CreatedCharacter.Dexterity + "\n" +
                "Con: " + CreatedCharacter.Constitution + "\n" +
                "Wis: " + CreatedCharacter.Wisdom + "\n" +
                "Cha: " + CreatedCharacter.Charisma;
            SaveInfo.Visible = true;
        }

        private void Save_return_Click(object sender, EventArgs e)
        {
            _SaveLoad.Serialize("/Characters/" + CreatedCharacter.Name, CreatedCharacter);
            parent.Characters.Add(CreatedCharacter);
            parent.AddItems("Characters", CreatedCharacter.Name);
            this.Close();
        }
    }
}
