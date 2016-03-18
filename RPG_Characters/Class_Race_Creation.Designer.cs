namespace RPG_Characters
{
    partial class Class_Race_Creation
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateRace = new System.Windows.Forms.RadioButton();
            this.CreateClass = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chaMod = new System.Windows.Forms.NumericUpDown();
            this.wisMod = new System.Windows.Forms.NumericUpDown();
            this.intMod = new System.Windows.Forms.NumericUpDown();
            this.dexMod = new System.Windows.Forms.NumericUpDown();
            this.conMod = new System.Windows.Forms.NumericUpDown();
            this.strMod = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveInfo = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Save_Return = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strMod)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.newToolStripMenuItem.Text = "Clear";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreateRace);
            this.groupBox1.Controls.Add(this.CreateClass);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(71, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(113, 20);
            this.Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name: ";
            // 
            // CreateRace
            // 
            this.CreateRace.AutoSize = true;
            this.CreateRace.Location = new System.Drawing.Point(9, 44);
            this.CreateRace.Name = "CreateRace";
            this.CreateRace.Size = new System.Drawing.Size(51, 17);
            this.CreateRace.TabIndex = 1;
            this.CreateRace.TabStop = true;
            this.CreateRace.Text = "Race";
            this.CreateRace.UseVisualStyleBackColor = true;
            // 
            // CreateClass
            // 
            this.CreateClass.AutoSize = true;
            this.CreateClass.Location = new System.Drawing.Point(71, 44);
            this.CreateClass.Name = "CreateClass";
            this.CreateClass.Size = new System.Drawing.Size(50, 17);
            this.CreateClass.TabIndex = 0;
            this.CreateClass.TabStop = true;
            this.CreateClass.Text = "Class";
            this.CreateClass.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.chaMod);
            this.groupBox3.Controls.Add(this.wisMod);
            this.groupBox3.Controls.Add(this.intMod);
            this.groupBox3.Controls.Add(this.dexMod);
            this.groupBox3.Controls.Add(this.conMod);
            this.groupBox3.Controls.Add(this.strMod);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 195);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stat Modifiers";
            // 
            // chaMod
            // 
            this.chaMod.Location = new System.Drawing.Point(57, 161);
            this.chaMod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.chaMod.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.chaMod.Name = "chaMod";
            this.chaMod.Size = new System.Drawing.Size(43, 20);
            this.chaMod.TabIndex = 11;
            // 
            // wisMod
            // 
            this.wisMod.Location = new System.Drawing.Point(57, 134);
            this.wisMod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.wisMod.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.wisMod.Name = "wisMod";
            this.wisMod.Size = new System.Drawing.Size(43, 20);
            this.wisMod.TabIndex = 10;
            // 
            // intMod
            // 
            this.intMod.Location = new System.Drawing.Point(58, 109);
            this.intMod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.intMod.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.intMod.Name = "intMod";
            this.intMod.Size = new System.Drawing.Size(42, 20);
            this.intMod.TabIndex = 9;
            // 
            // dexMod
            // 
            this.dexMod.Location = new System.Drawing.Point(58, 82);
            this.dexMod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dexMod.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.dexMod.Name = "dexMod";
            this.dexMod.Size = new System.Drawing.Size(42, 20);
            this.dexMod.TabIndex = 8;
            // 
            // conMod
            // 
            this.conMod.Location = new System.Drawing.Point(58, 56);
            this.conMod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.conMod.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.conMod.Name = "conMod";
            this.conMod.Size = new System.Drawing.Size(42, 20);
            this.conMod.TabIndex = 7;
            // 
            // strMod
            // 
            this.strMod.Location = new System.Drawing.Point(57, 29);
            this.strMod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.strMod.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.strMod.Name = "strMod";
            this.strMod.Size = new System.Drawing.Size(42, 20);
            this.strMod.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 157);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(53, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Chr: ";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(147, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 195);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abilities";
            // 
            // SaveInfo
            // 
            this.SaveInfo.Location = new System.Drawing.Point(217, 29);
            this.SaveInfo.Name = "SaveInfo";
            this.SaveInfo.Size = new System.Drawing.Size(91, 23);
            this.SaveInfo.TabIndex = 12;
            this.SaveInfo.Text = "Save";
            this.SaveInfo.UseVisualStyleBackColor = true;
            this.SaveInfo.Click += new System.EventHandler(this.SaveInfo_Click);
            // 
            // Save_Return
            // 
            this.Save_Return.Location = new System.Drawing.Point(217, 58);
            this.Save_Return.Name = "Save_Return";
            this.Save_Return.Size = new System.Drawing.Size(91, 23);
            this.Save_Return.TabIndex = 13;
            this.Save_Return.Text = "Save and Close";
            this.Save_Return.UseVisualStyleBackColor = true;
            this.Save_Return.Click += new System.EventHandler(this.Save_Return_Click);
            // 
            // Class_Race_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 312);
            this.Controls.Add(this.Save_Return);
            this.Controls.Add(this.SaveInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Class_Race_Creation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Class_Race_Creation_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CreateRace;
        private System.Windows.Forms.RadioButton CreateClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown chaMod;
        private System.Windows.Forms.NumericUpDown wisMod;
        private System.Windows.Forms.NumericUpDown intMod;
        private System.Windows.Forms.NumericUpDown dexMod;
        private System.Windows.Forms.NumericUpDown conMod;
        private System.Windows.Forms.NumericUpDown strMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Save_Return;
    }
}