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
        //Lists for each type of object that can be created
        //These objects are set to public so they can be accessed by out child 
        //forms and add there information to the list
        public List<Character> Characters = new List<Character>();
        public List<JobsAndRaces> Races = new List<JobsAndRaces>();
        public List<JobsAndRaces> Classes = new List<JobsAndRaces>();

        //All the file paths to each of the saved items
        List<string> FilePaths = new List<string>();

        //Multiple instances of the SaveLoad class so that we can Serialize and Deseralize 
        //each of the data type we need to save
        SaveLoad<ArrayList> _SaveLoad = new SaveLoad<ArrayList>();
        SaveLoad<Character> _CharLoadSave = new SaveLoad<Character>();
        SaveLoad<JobsAndRaces> _JobRaceSaveLoad = new SaveLoad<JobsAndRaces>();

        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Used to turn the information on this form on and off
        bool DirtyHome = false;

        /// <summary>
        /// Checks to see when a MdiChild of this form has been enabled or if it has been closed
        /// This will call the function we use to turn elements of this form on an off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            DisplayElements(DirtyHome);
        }

        /// <summary>
        /// Turns elemesnt on and off
        /// Called in:
        ///     Form1_MdiChildActivate
        /// </summary>
        /// <param name="display"> value we set the visible property of elements we are turning off</param>
        public void DisplayElements(bool display)
        {
            Items.Visible = display;
            Preview.Visible = display;
            DirtyHome = !DirtyHome;
        }

        /// <summary>
        /// Creates a new window corresponding with the tab clicked
        /// Each tab has its own window assigned to it and each window
        /// has unique attributes to it that allow the user to create objects
        /// of that type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Locates all the file paths of saved items and deserialized the 
        /// information in the files and assigns then to the appropiate list
        /// of DataTypes depending on the location they where saved to
        /// </summary>
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

        /// <summary>
        /// Called by the children of this form to add
        /// the new content being created to the lists of 
        /// objects and adding the new item to the TreeView 
        /// under its respectable node
        /// </summary>
        /// <param name="type"> Type of object </param>
        /// <param name="name"> Name of the object </param>
        public void AddItems(string type, string name)
        {
            Creations.Nodes[type].Nodes.Add(name);     
        }

        /// <summary>
        /// Generates our TreeView when this form is created
        /// </summary>
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

        /// <summary>
        /// Sets the text in the preview pane to the information associated with
        /// the element clicked on in the TreeView that holds the names of all the 
        /// items the user has saved to his or her machine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
