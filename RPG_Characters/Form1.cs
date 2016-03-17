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
using System.Collections;

namespace RPG_Characters
{    
    public partial class Form1 : Form
    {
        public ArrayList Characters = new ArrayList();
        public ArrayList Races = new ArrayList();
        public ArrayList Classes = new ArrayList();

        ArrayList Strings = new ArrayList();

        SaveLoad<ArrayList> _SaveLoad = new SaveLoad<ArrayList>();
        SaveLoad<Character> _CharLoadSave = new SaveLoad<Character>();
        SaveLoad<JobsAndRaces> _JobRaceSaveLoad = new SaveLoad<JobsAndRaces>();

        public Form1()
        {
            InitializeComponent();
        }

        bool DirtyHome = false;

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            DisplayElements(DirtyHome);
        }

        public void DisplayElements(bool display)
        {
            Items.Visible = display;
            Preview.Visible = display;
            DirtyHome = !DirtyHome;
        }

        private void newToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Text)
            {
                case "Character":
                    Create charForm = new Create(this);
                    charForm.MdiParent = this;
                    charForm.Show();
                    break;
                case "Weapon":
                    break;
                case "Armor":
                    break;
                case "Class/Race":
                    Class_Race_Creation classForm = new Class_Race_Creation();
                    classForm.MdiParent = this;
                    classForm.Show();
                    break;
            }
        }

        private void GetItems()
        {
            Strings.Add(_SaveLoad.FileNames("Characters"));
            Strings.Add(_SaveLoad.FileNames("Races"));
            Strings.Add(_SaveLoad.FileNames("Classes"));

            foreach (string s in Strings)
            {
                if (s.Contains("Characters"))
                {
                    Characters.Add(_CharLoadSave.Deserialize("Characters" + s));
                }

                if (s.Contains("Races"))
                {
                    Races.Add(_JobRaceSaveLoad.Deserialize("Races" + s));
                }
                if (s.Contains("Classes"))
                {
                    Classes.Add(_JobRaceSaveLoad.Deserialize("Classes" + s));
                }
            }

            AddItems();
        }

        private void AddItems()
        {
            foreach (Character c in Characters)
            {
                Creations.Nodes["Character"].Nodes.Add(c.Name);
            }
            foreach (JobsAndRaces jc in Races)
            {
                Creations.Nodes["Races"].Nodes.Add(jc.Name);
            }
            foreach (JobsAndRaces jc in Classes)
            {
                Creations.Nodes["Classes"].Nodes.Add(jc.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetItems();
        }
    }
}
