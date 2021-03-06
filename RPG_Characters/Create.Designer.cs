﻿namespace RPG_Characters
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RaceSelection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassSelection = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CharCreate = new System.Windows.Forms.Button();
            this.Stats = new System.Windows.Forms.GroupBox();
            this.ChaStat = new System.Windows.Forms.ComboBox();
            this.WisStat = new System.Windows.Forms.ComboBox();
            this.IntStat = new System.Windows.Forms.ComboBox();
            this.DexStat = new System.Windows.Forms.ComboBox();
            this.ConStat = new System.Windows.Forms.ComboBox();
            this.StrStat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatsRoll = new System.Windows.Forms.Button();
            this.DiceRoll = new System.Windows.Forms.RichTextBox();
            this.PreviewPane = new System.Windows.Forms.RichTextBox();
            this.SaveInfo = new System.Windows.Forms.Button();
            this.Save_return = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(67, 16);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(113, 20);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(187, 15);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(113, 20);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Race:";
            // 
            // RaceSelection
            // 
            this.RaceSelection.FormattingEnabled = true;
            this.RaceSelection.Location = new System.Drawing.Point(65, 49);
            this.RaceSelection.Name = "RaceSelection";
            this.RaceSelection.Size = new System.Drawing.Size(115, 21);
            this.RaceSelection.TabIndex = 5;
            this.RaceSelection.Text = "Select Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class:";
            // 
            // ClassSelection
            // 
            this.ClassSelection.FormattingEnabled = true;
            this.ClassSelection.Location = new System.Drawing.Point(65, 82);
            this.ClassSelection.Name = "ClassSelection";
            this.ClassSelection.Size = new System.Drawing.Size(115, 21);
            this.ClassSelection.TabIndex = 7;
            this.ClassSelection.Text = "Select Class";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CharCreate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClassSelection);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.RaceSelection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Info";
            // 
            // CharCreate
            // 
            this.CharCreate.Location = new System.Drawing.Point(208, 47);
            this.CharCreate.Name = "CharCreate";
            this.CharCreate.Size = new System.Drawing.Size(75, 23);
            this.CharCreate.TabIndex = 8;
            this.CharCreate.Text = "Create";
            this.CharCreate.UseVisualStyleBackColor = true;
            this.CharCreate.Click += new System.EventHandler(this.CharCreate_Click);
            // 
            // Stats
            // 
            this.Stats.Controls.Add(this.ChaStat);
            this.Stats.Controls.Add(this.WisStat);
            this.Stats.Controls.Add(this.IntStat);
            this.Stats.Controls.Add(this.DexStat);
            this.Stats.Controls.Add(this.ConStat);
            this.Stats.Controls.Add(this.StrStat);
            this.Stats.Controls.Add(this.label9);
            this.Stats.Controls.Add(this.label8);
            this.Stats.Controls.Add(this.label7);
            this.Stats.Controls.Add(this.label6);
            this.Stats.Controls.Add(this.label5);
            this.Stats.Controls.Add(this.label4);
            this.Stats.Location = new System.Drawing.Point(14, 144);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(119, 189);
            this.Stats.TabIndex = 9;
            this.Stats.TabStop = false;
            this.Stats.Text = "Character Stats";
            // 
            // ChaStat
            // 
            this.ChaStat.FormattingEnabled = true;
            this.ChaStat.Location = new System.Drawing.Point(58, 161);
            this.ChaStat.Name = "ChaStat";
            this.ChaStat.Size = new System.Drawing.Size(42, 21);
            this.ChaStat.TabIndex = 11;
            this.ChaStat.Text = "0";
            // 
            // WisStat
            // 
            this.WisStat.FormattingEnabled = true;
            this.WisStat.Location = new System.Drawing.Point(58, 133);
            this.WisStat.Name = "WisStat";
            this.WisStat.Size = new System.Drawing.Size(42, 21);
            this.WisStat.TabIndex = 10;
            this.WisStat.Text = "0";
            // 
            // IntStat
            // 
            this.IntStat.FormattingEnabled = true;
            this.IntStat.Location = new System.Drawing.Point(58, 108);
            this.IntStat.Name = "IntStat";
            this.IntStat.Size = new System.Drawing.Size(42, 21);
            this.IntStat.TabIndex = 9;
            this.IntStat.Text = "0";
            // 
            // DexStat
            // 
            this.DexStat.FormattingEnabled = true;
            this.DexStat.Location = new System.Drawing.Point(58, 81);
            this.DexStat.Name = "DexStat";
            this.DexStat.Size = new System.Drawing.Size(42, 21);
            this.DexStat.TabIndex = 8;
            this.DexStat.Text = "0";
            // 
            // ConStat
            // 
            this.ConStat.FormattingEnabled = true;
            this.ConStat.Location = new System.Drawing.Point(58, 52);
            this.ConStat.Name = "ConStat";
            this.ConStat.Size = new System.Drawing.Size(42, 21);
            this.ConStat.TabIndex = 7;
            this.ConStat.Text = "0";
            // 
            // StrStat
            // 
            this.StrStat.FormattingEnabled = true;
            this.StrStat.Location = new System.Drawing.Point(58, 25);
            this.StrStat.Name = "StrStat";
            this.StrStat.Size = new System.Drawing.Size(42, 21);
            this.StrStat.TabIndex = 6;
            this.StrStat.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 157);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(56, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cha: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(49, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Wis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 103);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(41, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "Int:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 76);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(55, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dex: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 49);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Con:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(44, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Str:";
            // 
            // StatsRoll
            // 
            this.StatsRoll.Location = new System.Drawing.Point(337, 37);
            this.StatsRoll.Name = "StatsRoll";
            this.StatsRoll.Size = new System.Drawing.Size(93, 23);
            this.StatsRoll.TabIndex = 10;
            this.StatsRoll.Text = "Roll Stats";
            this.StatsRoll.UseVisualStyleBackColor = true;
            this.StatsRoll.Click += new System.EventHandler(this.StatsRoll_Click);
            // 
            // DiceRoll
            // 
            this.DiceRoll.Location = new System.Drawing.Point(337, 67);
            this.DiceRoll.Name = "DiceRoll";
            this.DiceRoll.ReadOnly = true;
            this.DiceRoll.Size = new System.Drawing.Size(93, 69);
            this.DiceRoll.TabIndex = 11;
            this.DiceRoll.Text = "";
            // 
            // PreviewPane
            // 
            this.PreviewPane.Location = new System.Drawing.Point(145, 153);
            this.PreviewPane.Name = "PreviewPane";
            this.PreviewPane.ReadOnly = true;
            this.PreviewPane.Size = new System.Drawing.Size(284, 180);
            this.PreviewPane.TabIndex = 12;
            this.PreviewPane.Text = "";
            // 
            // SaveInfo
            // 
            this.SaveInfo.Location = new System.Drawing.Point(272, 346);
            this.SaveInfo.Name = "SaveInfo";
            this.SaveInfo.Size = new System.Drawing.Size(59, 23);
            this.SaveInfo.TabIndex = 13;
            this.SaveInfo.Text = "Save";
            this.SaveInfo.UseVisualStyleBackColor = true;
            this.SaveInfo.Click += new System.EventHandler(this.SaveInfo_Click);
            // 
            // Save_return
            // 
            this.Save_return.Location = new System.Drawing.Point(337, 346);
            this.Save_return.Name = "Save_return";
            this.Save_return.Size = new System.Drawing.Size(92, 23);
            this.Save_return.TabIndex = 14;
            this.Save_return.Text = "Save and Close ";
            this.Save_return.UseVisualStyleBackColor = true;
            this.Save_return.Click += new System.EventHandler(this.Save_return_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 381);
            this.Controls.Add(this.Save_return);
            this.Controls.Add(this.SaveInfo);
            this.Controls.Add(this.PreviewPane);
            this.Controls.Add(this.DiceRoll);
            this.Controls.Add(this.StatsRoll);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Create";
            this.Text = "Character Creation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Create_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Stats.ResumeLayout(false);
            this.Stats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RaceSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClassSelection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Stats;
        private System.Windows.Forms.ComboBox ChaStat;
        private System.Windows.Forms.ComboBox WisStat;
        private System.Windows.Forms.ComboBox IntStat;
        private System.Windows.Forms.ComboBox DexStat;
        private System.Windows.Forms.ComboBox ConStat;
        private System.Windows.Forms.ComboBox StrStat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StatsRoll;
        private System.Windows.Forms.RichTextBox DiceRoll;
        private System.Windows.Forms.RichTextBox PreviewPane;
        private System.Windows.Forms.Button SaveInfo;
        private System.Windows.Forms.Button CharCreate;
        private System.Windows.Forms.Button Save_return;
    }
}