namespace Course
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.judgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewJudgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findJudgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editJudgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayJudgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJudgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaintiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPlaintiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPlaintiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlaintiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPlaintiffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlaintiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defendantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDefendantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDefendantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDefendantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDefendantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDefendantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.judgeToolStripMenuItem,
            this.plaintiffToolStripMenuItem,
            this.defendantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // judgeToolStripMenuItem
            // 
            this.judgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewJudgeToolStripMenuItem,
            this.findJudgeToolStripMenuItem,
            this.editJudgeToolStripMenuItem,
            this.displayJudgesToolStripMenuItem,
            this.deleteJudgeToolStripMenuItem});
            this.judgeToolStripMenuItem.Name = "judgeToolStripMenuItem";
            this.judgeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.judgeToolStripMenuItem.Text = "Judge";
            // 
            // addNewJudgeToolStripMenuItem
            // 
            this.addNewJudgeToolStripMenuItem.Name = "addNewJudgeToolStripMenuItem";
            this.addNewJudgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewJudgeToolStripMenuItem.Text = "Add new judge";
            this.addNewJudgeToolStripMenuItem.Click += new System.EventHandler(this.addNewJudgeToolStripMenuItem_Click);
            // 
            // findJudgeToolStripMenuItem
            // 
            this.findJudgeToolStripMenuItem.Name = "findJudgeToolStripMenuItem";
            this.findJudgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findJudgeToolStripMenuItem.Text = "Find judge";
            this.findJudgeToolStripMenuItem.Click += new System.EventHandler(this.findJudgeToolStripMenuItem_Click);
            // 
            // editJudgeToolStripMenuItem
            // 
            this.editJudgeToolStripMenuItem.Name = "editJudgeToolStripMenuItem";
            this.editJudgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editJudgeToolStripMenuItem.Text = "Edit judge";
            this.editJudgeToolStripMenuItem.Click += new System.EventHandler(this.editJudgeToolStripMenuItem_Click);
            // 
            // displayJudgesToolStripMenuItem
            // 
            this.displayJudgesToolStripMenuItem.Name = "displayJudgesToolStripMenuItem";
            this.displayJudgesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayJudgesToolStripMenuItem.Text = "Display judges";
            this.displayJudgesToolStripMenuItem.Click += new System.EventHandler(this.displayJudgesToolStripMenuItem_Click);
            // 
            // deleteJudgeToolStripMenuItem
            // 
            this.deleteJudgeToolStripMenuItem.Name = "deleteJudgeToolStripMenuItem";
            this.deleteJudgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteJudgeToolStripMenuItem.Text = "Delete judge";
            this.deleteJudgeToolStripMenuItem.Click += new System.EventHandler(this.deleteJudgeToolStripMenuItem_Click);
            // 
            // plaintiffToolStripMenuItem
            // 
            this.plaintiffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPlaintiffToolStripMenuItem,
            this.findPlaintiffToolStripMenuItem,
            this.editPlaintiffToolStripMenuItem,
            this.displayPlaintiffsToolStripMenuItem,
            this.deletePlaintiffToolStripMenuItem});
            this.plaintiffToolStripMenuItem.Name = "plaintiffToolStripMenuItem";
            this.plaintiffToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.plaintiffToolStripMenuItem.Text = "Plaintiff";
            // 
            // addNewPlaintiffToolStripMenuItem
            // 
            this.addNewPlaintiffToolStripMenuItem.Name = "addNewPlaintiffToolStripMenuItem";
            this.addNewPlaintiffToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addNewPlaintiffToolStripMenuItem.Text = "Add new plaintiff";
            this.addNewPlaintiffToolStripMenuItem.Click += new System.EventHandler(this.addNewPlaintiffToolStripMenuItem_Click);
            // 
            // findPlaintiffToolStripMenuItem
            // 
            this.findPlaintiffToolStripMenuItem.Name = "findPlaintiffToolStripMenuItem";
            this.findPlaintiffToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.findPlaintiffToolStripMenuItem.Text = "Find plaintiff";
            this.findPlaintiffToolStripMenuItem.Click += new System.EventHandler(this.findPlaintiffToolStripMenuItem_Click);
            // 
            // editPlaintiffToolStripMenuItem
            // 
            this.editPlaintiffToolStripMenuItem.Name = "editPlaintiffToolStripMenuItem";
            this.editPlaintiffToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editPlaintiffToolStripMenuItem.Text = "Edit plaintiff";
            this.editPlaintiffToolStripMenuItem.Click += new System.EventHandler(this.editPlaintiffToolStripMenuItem_Click);
            // 
            // displayPlaintiffsToolStripMenuItem
            // 
            this.displayPlaintiffsToolStripMenuItem.Name = "displayPlaintiffsToolStripMenuItem";
            this.displayPlaintiffsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.displayPlaintiffsToolStripMenuItem.Text = "Display plaintiffs";
            this.displayPlaintiffsToolStripMenuItem.Click += new System.EventHandler(this.displayPlaintiffsToolStripMenuItem_Click);
            // 
            // deletePlaintiffToolStripMenuItem
            // 
            this.deletePlaintiffToolStripMenuItem.Name = "deletePlaintiffToolStripMenuItem";
            this.deletePlaintiffToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deletePlaintiffToolStripMenuItem.Text = "Delete plaintiff";
            this.deletePlaintiffToolStripMenuItem.Click += new System.EventHandler(this.deletePlaintiffToolStripMenuItem_Click);
            // 
            // defendantToolStripMenuItem
            // 
            this.defendantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDefendantToolStripMenuItem,
            this.findDefendantToolStripMenuItem,
            this.editDefendantToolStripMenuItem,
            this.displayDefendantToolStripMenuItem,
            this.deleteDefendantToolStripMenuItem});
            this.defendantToolStripMenuItem.Name = "defendantToolStripMenuItem";
            this.defendantToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.defendantToolStripMenuItem.Text = "Defendant";
            // 
            // addNewDefendantToolStripMenuItem
            // 
            this.addNewDefendantToolStripMenuItem.Name = "addNewDefendantToolStripMenuItem";
            this.addNewDefendantToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewDefendantToolStripMenuItem.Text = "Add new defendant";
            this.addNewDefendantToolStripMenuItem.Click += new System.EventHandler(this.addNewDefendantToolStripMenuItem_Click);
            // 
            // findDefendantToolStripMenuItem
            // 
            this.findDefendantToolStripMenuItem.Name = "findDefendantToolStripMenuItem";
            this.findDefendantToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.findDefendantToolStripMenuItem.Text = "Find defendant";
            this.findDefendantToolStripMenuItem.Click += new System.EventHandler(this.findDefendantToolStripMenuItem_Click);
            // 
            // editDefendantToolStripMenuItem
            // 
            this.editDefendantToolStripMenuItem.Name = "editDefendantToolStripMenuItem";
            this.editDefendantToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editDefendantToolStripMenuItem.Text = "Edit defendant";
            this.editDefendantToolStripMenuItem.Click += new System.EventHandler(this.editDefendantToolStripMenuItem_Click);
            // 
            // displayDefendantToolStripMenuItem
            // 
            this.displayDefendantToolStripMenuItem.Name = "displayDefendantToolStripMenuItem";
            this.displayDefendantToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.displayDefendantToolStripMenuItem.Text = "Display defendant";
            this.displayDefendantToolStripMenuItem.Click += new System.EventHandler(this.displayDefendantToolStripMenuItem_Click);
            // 
            // deleteDefendantToolStripMenuItem
            // 
            this.deleteDefendantToolStripMenuItem.Name = "deleteDefendantToolStripMenuItem";
            this.deleteDefendantToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deleteDefendantToolStripMenuItem.Text = "Delete defendant";
            this.deleteDefendantToolStripMenuItem.Click += new System.EventHandler(this.deleteDefendantToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Case display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 217);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem judgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewJudgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findJudgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteJudgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plaintiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defendantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editJudgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPlaintiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPlaintiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlaintiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlaintiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDefendantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDefendantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDefendantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDefendantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayJudgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPlaintiffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDefendantToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}