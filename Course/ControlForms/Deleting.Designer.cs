namespace Course
{
    partial class Deleting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deleting));
            this.Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.IdCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done.Location = new System.Drawing.Point(15, 51);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(159, 42);
            this.Done.TabIndex = 1;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter id";
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(15, 99);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(159, 42);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdCB
            // 
            this.IdCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdCB.FormattingEnabled = true;
            this.IdCB.Location = new System.Drawing.Point(15, 24);
            this.IdCB.Name = "IdCB";
            this.IdCB.Size = new System.Drawing.Size(158, 21);
            this.IdCB.TabIndex = 64;
            // 
            // Deleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 151);
            this.Controls.Add(this.IdCB);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Deleting";
            this.Text = "Deleting";
            this.Activated += new System.EventHandler(this.Deleting_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deleting_FormClosing);
            this.Load += new System.EventHandler(this.Deleting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox IdCB;
    }
}