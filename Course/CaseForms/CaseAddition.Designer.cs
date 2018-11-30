namespace Course
{
    partial class CaseAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseAddition));
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.VerdictTB = new System.Windows.Forms.TextBox();
            this.ArticleTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Close = new System.Windows.Forms.Button();
            this.JudgeCB = new System.Windows.Forms.ComboBox();
            this.PlaintiffCB = new System.Windows.Forms.ComboBox();
            this.DefendantCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Verdict";
            this.label7.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(85, 279);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 52;
            this.checkBox2.Text = "Is it legal?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "Is it end?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Enter article";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Enter description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Select judge id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Select plaintiff id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Select defendant id";
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Yu Gothic UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done.Location = new System.Drawing.Point(7, 341);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(115, 59);
            this.Done.TabIndex = 44;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerdictTB
            // 
            this.VerdictTB.Location = new System.Drawing.Point(109, 315);
            this.VerdictTB.Name = "VerdictTB";
            this.VerdictTB.Size = new System.Drawing.Size(152, 20);
            this.VerdictTB.TabIndex = 43;
            this.VerdictTB.Visible = false;
            // 
            // ArticleTB
            // 
            this.ArticleTB.Location = new System.Drawing.Point(109, 154);
            this.ArticleTB.Name = "ArticleTB";
            this.ArticleTB.Size = new System.Drawing.Size(152, 20);
            this.ArticleTB.TabIndex = 42;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(109, 119);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(152, 20);
            this.DescriptionTB.TabIndex = 41;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(118, 194);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(143, 20);
            this.StartDate.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Enter case start date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Enter case end date";
            this.label9.Visible = false;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(118, 240);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(143, 20);
            this.EndDate.TabIndex = 56;
            this.EndDate.Visible = false;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Yu Gothic UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(146, 341);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(115, 59);
            this.Close.TabIndex = 58;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // JudgeCB
            // 
            this.JudgeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JudgeCB.FormattingEnabled = true;
            this.JudgeCB.Location = new System.Drawing.Point(109, 88);
            this.JudgeCB.Name = "JudgeCB";
            this.JudgeCB.Size = new System.Drawing.Size(152, 21);
            this.JudgeCB.TabIndex = 59;
            // 
            // PlaintiffCB
            // 
            this.PlaintiffCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaintiffCB.FormattingEnabled = true;
            this.PlaintiffCB.Location = new System.Drawing.Point(109, 49);
            this.PlaintiffCB.Name = "PlaintiffCB";
            this.PlaintiffCB.Size = new System.Drawing.Size(152, 21);
            this.PlaintiffCB.TabIndex = 60;
            // 
            // DefendantCB
            // 
            this.DefendantCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefendantCB.FormattingEnabled = true;
            this.DefendantCB.Location = new System.Drawing.Point(109, 10);
            this.DefendantCB.Name = "DefendantCB";
            this.DefendantCB.Size = new System.Drawing.Size(152, 21);
            this.DefendantCB.TabIndex = 61;
            // 
            // CaseAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 408);
            this.Controls.Add(this.DefendantCB);
            this.Controls.Add(this.PlaintiffCB);
            this.Controls.Add(this.JudgeCB);
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
            this.Controls.Add(this.Done);
            this.Controls.Add(this.VerdictTB);
            this.Controls.Add(this.ArticleTB);
            this.Controls.Add(this.DescriptionTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaseAddition";
            this.Text = "Addition";
            this.Activated += new System.EventHandler(this.CaseAddition_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaseAddition_FormClosing);
            this.Load += new System.EventHandler(this.CaseAddition_Load);
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
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.TextBox VerdictTB;
        private System.Windows.Forms.TextBox ArticleTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox JudgeCB;
        private System.Windows.Forms.ComboBox PlaintiffCB;
        private System.Windows.Forms.ComboBox DefendantCB;
    }
}