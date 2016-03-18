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
        public List<Character> Characters = new List<Character>();
        public List<JobsAndRaces> Races = new List<JobsAndRaces>();
        public List<JobsAndRaces> Classes = new List<JobsAndRaces>();

        List<string> FilePaths = new List<string>();

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
                    Class_Race_Creation classForm = new Class_Race_Creation(this);
                    classForm.MdiParent = this;
                    classForm.Show();
                    break;
            }
        }

        public void GetSavedItems()
        {
            FilePaths = _SaveLoad.FileNames();
            Characters = new List<Character>();
            Classes = new List<JobsAndRaces>();
            Races = new List<JobsAndRaces>();

            foreach (string s in FilePaths)
            {
                if (s.Contains("Characters"))
                {
                    Characters.Add(_CharLoadSave.Deserialize(s));
                }

                if (s.Contains("Races"))
                {
                    Races.Add(_JobRaceSaveLoad.Deserialize(s));
                }
                if (s.Contains("Classes"))
                {
                    Classes.Add(_JobRaceSaveLoad.Deserialize(s));                  
                }
            }   
        }

        public void AddItems(string type, string name)
        {
            Creations.Nodes[type].Nodes.Add(name);     
        }

        void GenCreations()
        {
            foreach (Character c in Characters)
            {
                Creations.Nodes["Characters"].Nodes.Add(c.Name);
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
            GetSavedItems();
            GenCreations();
        }

        private void Creations_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach(Character c in Characters)
            {
                if(c.Name == e.Node.Text)
                {
                    CharPreview.Text = "";
                    CharPreview.Text += "Name: " + c.Name + "\n" + 
                        "Class: " + c.CharClass.Name + "\n" +
                        "Race: " + c.CharRace.Name;
                }
            }

            foreach (JobsAndRaces c in Classes)
            {
                if (c.Name == e.Node.Text)
                {
                    CharPreview.Text = "";
                    CharPreview.Text += "Name: " + c.Name + "\n" +
                        "Int Modifier: " + c.Intelligence + "\n" + 
                        "Str Modifier: " + c.Strength + "\n" +
                        "Dex Modifier: " + c.Dexterity + "\n" +
                        "Wis Modifier: " + c.Wisdom + "\n" +
                        "Cha Modifier: " + c.Charisma + "\n" +
                        "Con Modifier: " + c.Constitution;
                }
            }

            foreach (JobsAndRaces c in Races)
            {
                if (c.Name == e.Node.Text)
                {
                    CharPreview.Text = "";
                    CharPreview.Text += "Name: " + c.Name + "\n" +
                        "Int Modifier: " + c.Intelligence + "\n" +
                        "Str Modifier: " + c.Strength + "\n" +
                        "Dex Modifier: " + c.Dexterity + "\n" +
                        "Wis Modifier: " + c.Wisdom + "\n" +
                        "Cha Modifier: " + c.Charisma + "\n" +
                        "Con Modifier: " + c.Constitution;
                }
            }
        }
    }
}
