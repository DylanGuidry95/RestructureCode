using System;
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
    public partial class Class_Race_Creation : Form
    {
        SaveLoad<JobsAndRaces> _SaveLoad = new SaveLoad<JobsAndRaces>();

        public Class_Race_Creation()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            if (CreateClass.Checked == true)
            {
                JobsAndRaces newClass = new JobsAndRaces(Name.Text, (int)intMod.Value, (int)strMod.Value, (int)dexMod.Value,
                    (int)conMod.Value, (int)wisMod.Value, (int)chaMod.Value);
                string file = @"Classes\" + newClass.Name;
                _SaveLoad.Serialize(file, newClass);
            }
            if (CreateRace.Checked == true)
            {
                JobsAndRaces newClass = new JobsAndRaces(Name.Text, (int)intMod.Value, (int)strMod.Value, (int)dexMod.Value,
                    (int)conMod.Value, (int)wisMod.Value, (int)chaMod.Value);
                string file = @"Races\" + newClass.Name;
                _SaveLoad.Serialize(file, newClass);
            }

        }
    }
}
