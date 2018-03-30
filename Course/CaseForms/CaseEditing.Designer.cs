namespace Course
{
    partial class CaseEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseEditing));
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.VerdictTB = new System.Windows.Forms.TextBox();
            this.ArticleTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.JudgeIdTB = new System.Windows.Forms.TextBox();
            this.PlaintiffIdTB = new System.Windows.Forms.TextBox();
            this.DefendantIdTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Verdict";
            this.label7.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 349);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "Is it legal?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Is it end?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Enter article";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Enter description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Enter judge id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Enter plaintiff id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Enter defendant id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter id";
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(12, 413);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(174, 56);
            this.Done.TabIndex = 27;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerdictTB
            // 
            this.VerdictTB.Location = new System.Drawing.Point(12, 387);
            this.VerdictTB.Name = "VerdictTB";
            this.VerdictTB.Size = new System.Drawing.Size(174, 20);
            this.VerdictTB.TabIndex = 26;
            this.VerdictTB.Visible = false;
            // 
            // ArticleTB
            // 
            this.ArticleTB.Location = new System.Drawing.Point(12, 222);
            this.ArticleTB.Name = "ArticleTB";
            this.ArticleTB.Size = new System.Drawing.Size(174, 20);
            this.ArticleTB.TabIndex = 25;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(12, 183);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(174, 20);
            this.DescriptionTB.TabIndex = 24;
            // 
            // JudgeIdTB
            // 
            this.JudgeIdTB.Location = new System.Drawing.Point(12, 144);
            this.JudgeIdTB.Name = "JudgeIdTB";
            this.JudgeIdTB.Size = new System.Drawing.Size(174, 20);
            this.JudgeIdTB.TabIndex = 23;
            // 
            // PlaintiffIdTB
            // 
            this.PlaintiffIdTB.Location = new System.Drawing.Point(12, 105);
            this.PlaintiffIdTB.Name = "PlaintiffIdTB";
            this.PlaintiffIdTB.Size = new System.Drawing.Size(174, 20);
            this.PlaintiffIdTB.TabIndex = 22;
            // 
            // DefendantIdTB
            // 
            this.DefendantIdTB.Location = new System.Drawing.Point(12, 66);
            this.DefendantIdTB.Name = "DefendantIdTB";
            this.DefendantIdTB.Size = new System.Drawing.Size(174, 20);
            this.DefendantIdTB.TabIndex = 21;
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(12, 23);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(174, 20);
            this.IdTB.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Enter case start date";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(12, 261);
            this.StartDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.StartDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(174, 20);
            this.StartDate.TabIndex = 56;
            this.StartDate.Value = new System.DateTime(2018, 3, 22, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Enter case end date";
            this.label9.Visible = false;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(12, 300);
            this.EndDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.EndDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(174, 20);
            this.EndDate.TabIndex = 58;
            this.EndDate.Value = new System.DateTime(2018, 3, 22, 0, 0, 0, 0);
            this.EndDate.Visible = false;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(12, 475);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(174, 56);
            this.Close.TabIndex = 60;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // CaseEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 540);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.VerdictTB);
            this.Controls.Add(this.ArticleTB);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.JudgeIdTB);
            this.Controls.Add(this.PlaintiffIdTB);
            this.Controls.Add(this.DefendantIdTB);
            this.Controls.Add(this.IdTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaseEditing";
            this.Text = "Editing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaseEditing_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.TextBox VerdictTB;
        private System.Windows.Forms.TextBox ArticleTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.TextBox JudgeIdTB;
        private System.Windows.Forms.TextBox PlaintiffIdTB;
        private System.Windows.Forms.TextBox DefendantIdTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Button Close;
    }
}