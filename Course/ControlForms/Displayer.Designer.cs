namespace Course
{
    partial class Displayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Displayer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HelpFac = new System.Windows.Forms.Label();
            this.FindAllCases = new System.Windows.Forms.Button();
            this.DisplayAll = new System.Windows.Forms.Button();
            this.HelpDa = new System.Windows.Forms.Label();
            this.FindById = new System.Windows.Forms.Button();
            this.HelpFbi = new System.Windows.Forms.Label();
            this.EditSelected = new System.Windows.Forms.Button();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.IdCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // HelpFac
            // 
            this.HelpFac.AutoSize = true;
            this.HelpFac.Location = new System.Drawing.Point(12, 251);
            this.HelpFac.Name = "HelpFac";
            this.HelpFac.Size = new System.Drawing.Size(0, 13);
            this.HelpFac.TabIndex = 1;
            // 
            // FindAllCases
            // 
            this.FindAllCases.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindAllCases.Location = new System.Drawing.Point(12, 168);
            this.FindAllCases.Name = "FindAllCases";
            this.FindAllCases.Size = new System.Drawing.Size(150, 50);
            this.FindAllCases.TabIndex = 4;
            this.FindAllCases.Text = "Find all cases";
            this.FindAllCases.UseVisualStyleBackColor = true;
            this.FindAllCases.Click += new System.EventHandler(this.button1_Click);
            this.FindAllCases.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.FindAllCases.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // DisplayAll
            // 
            this.DisplayAll.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayAll.Location = new System.Drawing.Point(505, 168);
            this.DisplayAll.Name = "DisplayAll";
            this.DisplayAll.Size = new System.Drawing.Size(150, 50);
            this.DisplayAll.TabIndex = 5;
            this.DisplayAll.Text = "Display all ";
            this.DisplayAll.UseVisualStyleBackColor = true;
            this.DisplayAll.Click += new System.EventHandler(this.button2_Click);
            this.DisplayAll.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.DisplayAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // HelpDa
            // 
            this.HelpDa.AutoSize = true;
            this.HelpDa.Location = new System.Drawing.Point(498, 251);
            this.HelpDa.Name = "HelpDa";
            this.HelpDa.Size = new System.Drawing.Size(0, 13);
            this.HelpDa.TabIndex = 6;
            // 
            // FindById
            // 
            this.FindById.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindById.Location = new System.Drawing.Point(268, 168);
            this.FindById.Name = "FindById";
            this.FindById.Size = new System.Drawing.Size(150, 50);
            this.FindById.TabIndex = 8;
            this.FindById.Text = "FInd by id";
            this.FindById.UseVisualStyleBackColor = true;
            this.FindById.Click += new System.EventHandler(this.button4_Click);
            this.FindById.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.FindById.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // HelpFbi
            // 
            this.HelpFbi.AutoSize = true;
            this.HelpFbi.Location = new System.Drawing.Point(265, 251);
            this.HelpFbi.Name = "HelpFbi";
            this.HelpFbi.Size = new System.Drawing.Size(0, 13);
            this.HelpFbi.TabIndex = 9;
            // 
            // EditSelected
            // 
            this.EditSelected.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditSelected.Location = new System.Drawing.Point(104, 278);
            this.EditSelected.Name = "EditSelected";
            this.EditSelected.Size = new System.Drawing.Size(150, 50);
            this.EditSelected.TabIndex = 11;
            this.EditSelected.Text = "Edit selected";
            this.EditSelected.UseVisualStyleBackColor = true;
            this.EditSelected.Click += new System.EventHandler(this.button3_Click);
            this.EditSelected.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.EditSelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSelected.Location = new System.Drawing.Point(389, 278);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(150, 50);
            this.DeleteSelected.TabIndex = 12;
            this.DeleteSelected.Text = "Delete selected";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.button5_Click);
            this.DeleteSelected.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.DeleteSelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(15, 372);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 50);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button6_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(192, 372);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(110, 50);
            this.Edit.TabIndex = 14;
            this.Edit.Text = "Edit ";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.button7_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(375, 372);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 50);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button8_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(541, 372);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(110, 50);
            this.Close.TabIndex = 16;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button9_Click);
            // 
            // IdCB
            // 
            this.IdCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdCB.FormattingEnabled = true;
            this.IdCB.Location = new System.Drawing.Point(268, 227);
            this.IdCB.Name = "IdCB";
            this.IdCB.Size = new System.Drawing.Size(150, 21);
            this.IdCB.TabIndex = 64;
            // 
            // Displayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 439);
            this.Controls.Add(this.IdCB);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.EditSelected);
            this.Controls.Add(this.HelpFbi);
            this.Controls.Add(this.FindById);
            this.Controls.Add(this.HelpDa);
            this.Controls.Add(this.DisplayAll);
            this.Controls.Add(this.FindAllCases);
            this.Controls.Add(this.HelpFac);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Displayer";
            this.Text = "Displayer";
            this.Activated += new System.EventHandler(this.Displayer_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HelpFac;
        private System.Windows.Forms.Button FindAllCases;
        private System.Windows.Forms.Button DisplayAll;
        private System.Windows.Forms.Label HelpDa;
        private System.Windows.Forms.Button FindById;
        private System.Windows.Forms.Label HelpFbi;
        private System.Windows.Forms.Button EditSelected;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Close;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox IdCB;
    }
}