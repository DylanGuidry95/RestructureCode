﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestructureCode;
using UserProfileApplication;
using System.Windows.Forms;

namespace RPG_Characters
{
    /// <summary>
    /// Used to create new races and classes
    /// </summary>
    public partial class Class_Race_Creation : Form
    {
        //SaveLoad object to of type JobsAndRaces
        SaveLoad<JobsAndRaces> _SaveLoad = new SaveLoad<JobsAndRaces>();
        //Parent of this form
        Form1 parent = new Form1();
        //Class or race we are trying to create
        JobsAndRaces newClass;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p">Parent form</param>
        public Class_Race_Creation(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Saves our newly created Class or Race
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveInfo_Click(object sender, EventArgs e)
        {
            if (CreateClass.Checked == true)
            {
                 newClass = new JobsAndRaces(Name.Text, (int)intMod.Value, (int)strMod.Value, (int)dexMod.Value,
                    (int)conMod.Value, (int)wisMod.Value, (int)chaMod.Value);
                string file = "/Classes/" + newClass.Name;
                _SaveLoad.Serialize(file, newClass);
                if(!Exists())
                {
                    parent.Classes.Add(newClass);
                    parent.AddItems("Classes", newClass.Name);
                }
            }
            if (CreateRace.Checked == true)
            {
                 newClass = new JobsAndRaces(Name.Text, (int)intMod.Value, (int)strMod.Value, (int)dexMod.Value,
                    (int)conMod.Value, (int)wisMod.Value, (int)chaMod.Value);
                string file = "/Races/" + newClass.Name;
                _SaveLoad.Serialize(file, newClass);
                if (!Exists())
                {
                    parent.Races.Add(newClass);
                    parent.AddItems("Races", newClass.Name);
                }
            }

        }

        private void Class_Race_Creation_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// Saves out newly created race or class and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Return_Click(object sender, EventArgs e)
        {
            newClass = new JobsAndRaces(Name.Text, (int)intMod.Value, (int)strMod.Value, (int)dexMod.Value,
                (int)conMod.Value, (int)wisMod.Value, (int)chaMod.Value);
            if (CreateClass.Checked)
            {
                _SaveLoad.Serialize("/Classes/" + newClass.Name, newClass);
                if (!Exists())
                {
                    parent.Classes.Add(newClass);
                    parent.AddItems("Classes", newClass.Name);
                }
                this.Close();
            }
            if(CreateRace.Checked)
            {
                _SaveLoad.Serialize("/Races/" + newClass.Name, newClass);
                if (!Exists())
                {
                    parent.Races.Add(newClass);
                    parent.AddItems("Races", newClass.Name);
                }
                this.Close();
            }
        }

        /// <summary>
        /// Checks to see if an items of the same name as the one being created exists
        /// </summary>
        /// <returns></returns>
        private bool Exists()
        {
            foreach(JobsAndRaces c in parent.Classes)
            {
                if(c.Name == newClass.Name)
                {
                    return true;
                }
            }
            foreach(JobsAndRaces r in parent.Races)
            {
                if (r.Name == newClass.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
