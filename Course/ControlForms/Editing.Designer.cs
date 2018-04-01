namespace Course
{
    partial class Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editing));
            this.IdTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CaseNumberTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatronymicTB = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(12, 25);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(160, 20);
            this.IdTB.TabIndex = 0;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 101);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(160, 20);
            this.NameTB.TabIndex = 1;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(12, 140);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(160, 20);
            this.SurnameTB.TabIndex = 2;
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done.Location = new System.Drawing.Point(11, 205);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(161, 25);
            this.Done.TabIndex = 3;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Case number";
            // 
            // CaseNumberTB
            // 
            this.CaseNumberTB.Location = new System.Drawing.Point(12, 64);
            this.CaseNumberTB.Name = "CaseNumberTB";
            this.CaseNumberTB.Size = new System.Drawing.Size(160, 20);
            this.CaseNumberTB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Patronymic";
            // 
            // PatronymicTB
            // 
            this.PatronymicTB.Location = new System.Drawing.Point(12, 179);
            this.PatronymicTB.Name = "PatronymicTB";
            this.PatronymicTB.Size = new System.Drawing.Size(160, 20);
            this.PatronymicTB.TabIndex = 15;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(11, 239);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(161, 25);
            this.Close.TabIndex = 16;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 276);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PatronymicTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CaseNumberTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IdTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editing";
            this.Text = "Editing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editing_FormClosing);
            this.Load += new System.EventHandler(this.Editing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CaseNumberTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatronymicTB;
        private System.Windows.Forms.Button Close;
    }
}