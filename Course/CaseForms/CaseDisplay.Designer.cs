namespace Course
{
    partial class CaseDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseDisplay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HelpFl = new System.Windows.Forms.Label();
            this.FindLegal = new System.Windows.Forms.Button();
            this.HelpFbk = new System.Windows.Forms.Label();
            this.FindByKeywordTB = new System.Windows.Forms.TextBox();
            this.FindByKeyword = new System.Windows.Forms.Button();
            this.HelpFba = new System.Windows.Forms.Label();
            this.FindByArticle = new System.Windows.Forms.Button();
            this.HelpFa = new System.Windows.Forms.Label();
            this.FindActive = new System.Windows.Forms.Button();
            this.HelpJcl = new System.Windows.Forms.Label();
            this.JudgeCaseList = new System.Windows.Forms.Button();
            this.HelpPcl = new System.Windows.Forms.Label();
            this.PlaintiffCaseList = new System.Windows.Forms.Button();
            this.HelpDcl = new System.Windows.Forms.Label();
            this.DefendantCaseList = new System.Windows.Forms.Button();
            this.EditSelected = new System.Windows.Forms.Button();
            this.DeleteSelectedCase = new System.Windows.Forms.Button();
            this.DisplayAll = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Close = new System.Windows.Forms.Button();
            this.AddCase = new System.Windows.Forms.Button();
            this.EditCase = new System.Windows.Forms.Button();
            this.DeleteCase = new System.Windows.Forms.Button();
            this.DefendantByFullname = new System.Windows.Forms.Button();
            this.DbfTB = new System.Windows.Forms.TextBox();
            this.HelpDbf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // HelpFl
            // 
            this.HelpFl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpFl.AutoSize = true;
            this.HelpFl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpFl.Location = new System.Drawing.Point(9, 307);
            this.HelpFl.Name = "HelpFl";
            this.HelpFl.Size = new System.Drawing.Size(0, 13);
            this.HelpFl.TabIndex = 1;
            // 
            // FindLegal
            // 
            this.FindLegal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindLegal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindLegal.Location = new System.Drawing.Point(12, 216);
            this.FindLegal.Name = "FindLegal";
            this.FindLegal.Size = new System.Drawing.Size(150, 50);
            this.FindLegal.TabIndex = 3;
            this.FindLegal.Text = "Find legal";
            this.FindLegal.UseVisualStyleBackColor = true;
            this.FindLegal.Click += new System.EventHandler(this.button1_Click);
            this.FindLegal.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.FindLegal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // HelpFbk
            // 
            this.HelpFbk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpFbk.AutoSize = true;
            this.HelpFbk.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpFbk.Location = new System.Drawing.Point(172, 303);
            this.HelpFbk.Name = "HelpFbk";
            this.HelpFbk.Size = new System.Drawing.Size(0, 13);
            this.HelpFbk.TabIndex = 4;
            // 
            // FindByKeywordTB
            // 
            this.FindByKeywordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindByKeywordTB.Location = new System.Drawing.Point(175, 273);
            this.FindByKeywordTB.Name = "FindByKeywordTB";
            this.FindByKeywordTB.Size = new System.Drawing.Size(124, 20);
            this.FindByKeywordTB.TabIndex = 5;
            // 
            // FindByKeyword
            // 
            this.FindByKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindByKeyword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByKeyword.Location = new System.Drawing.Point(175, 217);
            this.FindByKeyword.Name = "FindByKeyword";
            this.FindByKeyword.Size = new System.Drawing.Size(150, 50);
            this.FindByKeyword.TabIndex = 6;
            this.FindByKeyword.Text = "Find by keyword";
            this.FindByKeyword.UseVisualStyleBackColor = true;
            this.FindByKeyword.Click += new System.EventHandler(this.button2_Click);
            this.FindByKeyword.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.FindByKeyword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // HelpFba
            // 
            this.HelpFba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpFba.AutoSize = true;
            this.HelpFba.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpFba.Location = new System.Drawing.Point(342, 303);
            this.HelpFba.Name = "HelpFba";
            this.HelpFba.Size = new System.Drawing.Size(0, 13);
            this.HelpFba.TabIndex = 7;
            // 
            // FindByArticle
            // 
            this.FindByArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindByArticle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindByArticle.Location = new System.Drawing.Point(345, 217);
            this.FindByArticle.Name = "FindByArticle";
            this.FindByArticle.Size = new System.Drawing.Size(150, 50);
            this.FindByArticle.TabIndex = 8;
            this.FindByArticle.Text = "Find by article";
            this.FindByArticle.UseVisualStyleBackColor = true;
            this.FindByArticle.Click += new System.EventHandler(this.button3_Click);
            this.FindByArticle.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.FindByArticle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // HelpFa
            // 
            this.HelpFa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpFa.AutoSize = true;
            this.HelpFa.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpFa.Location = new System.Drawing.Point(512, 303);
            this.HelpFa.Name = "HelpFa";
            this.HelpFa.Size = new System.Drawing.Size(0, 13);
            this.HelpFa.TabIndex = 9;
            // 
            // FindActive
            // 
            this.FindActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindActive.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindActive.Location = new System.Drawing.Point(515, 217);
            this.FindActive.Name = "FindActive";
            this.FindActive.Size = new System.Drawing.Size(150, 50);
            this.FindActive.TabIndex = 10;
            this.FindActive.Text = "Find active";
            this.FindActive.UseVisualStyleBackColor = true;
            this.FindActive.Click += new System.EventHandler(this.button4_Click);
            this.FindActive.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.FindActive.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // HelpJcl
            // 
            this.HelpJcl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpJcl.AutoSize = true;
            this.HelpJcl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpJcl.Location = new System.Drawing.Point(682, 307);
            this.HelpJcl.Name = "HelpJcl";
            this.HelpJcl.Size = new System.Drawing.Size(0, 13);
            this.HelpJcl.TabIndex = 11;
            // 
            // JudgeCaseList
            // 
            this.JudgeCaseList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JudgeCaseList.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JudgeCaseList.Location = new System.Drawing.Point(685, 216);
            this.JudgeCaseList.Name = "JudgeCaseList";
            this.JudgeCaseList.Size = new System.Drawing.Size(150, 50);
            this.JudgeCaseList.TabIndex = 12;
            this.JudgeCaseList.Text = "Judge case list";
            this.JudgeCaseList.UseVisualStyleBackColor = true;
            this.JudgeCaseList.Click += new System.EventHandler(this.button5_Click);
            this.JudgeCaseList.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.JudgeCaseList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // HelpPcl
            // 
            this.HelpPcl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpPcl.AutoSize = true;
            this.HelpPcl.Location = new System.Drawing.Point(852, 307);
            this.HelpPcl.Name = "HelpPcl";
            this.HelpPcl.Size = new System.Drawing.Size(0, 13);
            this.HelpPcl.TabIndex = 13;
            // 
            // PlaintiffCaseList
            // 
            this.PlaintiffCaseList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaintiffCaseList.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaintiffCaseList.Location = new System.Drawing.Point(855, 216);
            this.PlaintiffCaseList.Name = "PlaintiffCaseList";
            this.PlaintiffCaseList.Size = new System.Drawing.Size(150, 50);
            this.PlaintiffCaseList.TabIndex = 14;
            this.PlaintiffCaseList.Text = "Plaintiff case list";
            this.PlaintiffCaseList.UseVisualStyleBackColor = true;
            this.PlaintiffCaseList.Click += new System.EventHandler(this.button6_Click);
            this.PlaintiffCaseList.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            this.PlaintiffCaseList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button6_MouseMove);
            // 
            // HelpDcl
            // 
            this.HelpDcl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpDcl.AutoSize = true;
            this.HelpDcl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpDcl.Location = new System.Drawing.Point(1022, 307);
            this.HelpDcl.Name = "HelpDcl";
            this.HelpDcl.Size = new System.Drawing.Size(0, 13);
            this.HelpDcl.TabIndex = 15;
            // 
            // DefendantCaseList
            // 
            this.DefendantCaseList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefendantCaseList.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefendantCaseList.Location = new System.Drawing.Point(1025, 216);
            this.DefendantCaseList.Name = "DefendantCaseList";
            this.DefendantCaseList.Size = new System.Drawing.Size(150, 50);
            this.DefendantCaseList.TabIndex = 16;
            this.DefendantCaseList.Text = "Defendant case list";
            this.DefendantCaseList.UseVisualStyleBackColor = true;
            this.DefendantCaseList.Click += new System.EventHandler(this.button7_Click);
            this.DefendantCaseList.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            this.DefendantCaseList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button7_MouseMove);
            // 
            // EditSelected
            // 
            this.EditSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditSelected.Font = new System.Drawing.Font("Yu Gothic UI Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditSelected.Location = new System.Drawing.Point(12, 335);
            this.EditSelected.Name = "EditSelected";
            this.EditSelected.Size = new System.Drawing.Size(400, 100);
            this.EditSelected.TabIndex = 17;
            this.EditSelected.Text = "Edit selected case";
            this.EditSelected.UseVisualStyleBackColor = true;
            this.EditSelected.Click += new System.EventHandler(this.button8_Click);
            this.EditSelected.MouseLeave += new System.EventHandler(this.button8_MouseLeave);
            this.EditSelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button8_MouseMove);
            // 
            // DeleteSelectedCase
            // 
            this.DeleteSelectedCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSelectedCase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteSelectedCase.Font = new System.Drawing.Font("Yu Gothic UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSelectedCase.Location = new System.Drawing.Point(484, 335);
            this.DeleteSelectedCase.Name = "DeleteSelectedCase";
            this.DeleteSelectedCase.Size = new System.Drawing.Size(400, 100);
            this.DeleteSelectedCase.TabIndex = 18;
            this.DeleteSelectedCase.Text = "Delete selected case";
            this.DeleteSelectedCase.UseVisualStyleBackColor = true;
            this.DeleteSelectedCase.Click += new System.EventHandler(this.button9_Click);
            this.DeleteSelectedCase.MouseLeave += new System.EventHandler(this.button9_MouseLeave);
            this.DeleteSelectedCase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button9_MouseMove);
            // 
            // DisplayAll
            // 
            this.DisplayAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayAll.Font = new System.Drawing.Font("Yu Gothic UI Light", 40F);
            this.DisplayAll.Location = new System.Drawing.Point(958, 335);
            this.DisplayAll.Name = "DisplayAll";
            this.DisplayAll.Size = new System.Drawing.Size(400, 100);
            this.DisplayAll.TabIndex = 20;
            this.DisplayAll.Text = "Display all";
            this.DisplayAll.UseVisualStyleBackColor = true;
            this.DisplayAll.Click += new System.EventHandler(this.button11_Click);
            this.DisplayAll.MouseLeave += new System.EventHandler(this.button11_MouseLeave);
            this.DisplayAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button11_MouseMove);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(1161, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(197, 191);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Font = new System.Drawing.Font("Yu Gothic UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(1058, 482);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(300, 110);
            this.Close.TabIndex = 19;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button10_Click);
            this.Close.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            this.Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button10_MouseMove);
            // 
            // AddCase
            // 
            this.AddCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCase.Font = new System.Drawing.Font("Yu Gothic UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCase.Location = new System.Drawing.Point(12, 482);
            this.AddCase.Name = "AddCase";
            this.AddCase.Size = new System.Drawing.Size(300, 110);
            this.AddCase.TabIndex = 22;
            this.AddCase.Text = "Add case";
            this.AddCase.UseVisualStyleBackColor = true;
            this.AddCase.Click += new System.EventHandler(this.button12_Click);
            this.AddCase.MouseLeave += new System.EventHandler(this.button12_MouseLeave);
            this.AddCase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button12_MouseMove);
            // 
            // EditCase
            // 
            this.EditCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCase.Font = new System.Drawing.Font("Yu Gothic UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCase.Location = new System.Drawing.Point(361, 482);
            this.EditCase.Name = "EditCase";
            this.EditCase.Size = new System.Drawing.Size(300, 110);
            this.EditCase.TabIndex = 23;
            this.EditCase.Text = "Edit case";
            this.EditCase.UseVisualStyleBackColor = true;
            this.EditCase.Click += new System.EventHandler(this.button13_Click);
            this.EditCase.MouseLeave += new System.EventHandler(this.button13_MouseLeave);
            this.EditCase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button13_MouseMove);
            // 
            // DeleteCase
            // 
            this.DeleteCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCase.Font = new System.Drawing.Font("Yu Gothic UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCase.Location = new System.Drawing.Point(718, 482);
            this.DeleteCase.Name = "DeleteCase";
            this.DeleteCase.Size = new System.Drawing.Size(300, 110);
            this.DeleteCase.TabIndex = 24;
            this.DeleteCase.Text = "Delete case";
            this.DeleteCase.UseVisualStyleBackColor = true;
            this.DeleteCase.Click += new System.EventHandler(this.button14_Click);
            this.DeleteCase.MouseLeave += new System.EventHandler(this.button14_MouseLeave);
            this.DeleteCase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button14_MouseMove);
            // 
            // DefendantByFullname
            // 
            this.DefendantByFullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefendantByFullname.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefendantByFullname.Location = new System.Drawing.Point(1195, 216);
            this.DefendantByFullname.Name = "DefendantByFullname";
            this.DefendantByFullname.Size = new System.Drawing.Size(150, 50);
            this.DefendantByFullname.TabIndex = 25;
            this.DefendantByFullname.Text = "Defendant by fullname";
            this.DefendantByFullname.UseVisualStyleBackColor = true;
            this.DefendantByFullname.Click += new System.EventHandler(this.button15_Click);
            this.DefendantByFullname.MouseLeave += new System.EventHandler(this.button15_MouseLeave);
            this.DefendantByFullname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button15_MouseMove);
            // 
            // DbfTB
            // 
            this.DbfTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbfTB.Location = new System.Drawing.Point(1195, 273);
            this.DbfTB.Name = "DbfTB";
            this.DbfTB.Size = new System.Drawing.Size(124, 20);
            this.DbfTB.TabIndex = 26;
            // 
            // HelpDbf
            // 
            this.HelpDbf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpDbf.AutoSize = true;
            this.HelpDbf.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpDbf.Location = new System.Drawing.Point(1192, 307);
            this.HelpDbf.Name = "HelpDbf";
            this.HelpDbf.Size = new System.Drawing.Size(0, 13);
            this.HelpDbf.TabIndex = 27;
            // 
            // CaseDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 606);
            this.Controls.Add(this.HelpDbf);
            this.Controls.Add(this.DbfTB);
            this.Controls.Add(this.DefendantByFullname);
            this.Controls.Add(this.DeleteCase);
            this.Controls.Add(this.EditCase);
            this.Controls.Add(this.AddCase);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DisplayAll);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DeleteSelectedCase);
            this.Controls.Add(this.EditSelected);
            this.Controls.Add(this.DefendantCaseList);
            this.Controls.Add(this.HelpDcl);
            this.Controls.Add(this.PlaintiffCaseList);
            this.Controls.Add(this.HelpPcl);
            this.Controls.Add(this.JudgeCaseList);
            this.Controls.Add(this.HelpJcl);
            this.Controls.Add(this.FindActive);
            this.Controls.Add(this.HelpFa);
            this.Controls.Add(this.FindByArticle);
            this.Controls.Add(this.HelpFba);
            this.Controls.Add(this.FindByKeyword);
            this.Controls.Add(this.FindByKeywordTB);
            this.Controls.Add(this.HelpFbk);
            this.Controls.Add(this.FindLegal);
            this.Controls.Add(this.HelpFl);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaseDisplay";
            this.Text = "Case";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaseDisplay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HelpFl;
        private System.Windows.Forms.Button FindLegal;
        private System.Windows.Forms.Label HelpFbk;
        private System.Windows.Forms.TextBox FindByKeywordTB;
        private System.Windows.Forms.Button FindByKeyword;
        private System.Windows.Forms.Label HelpFba;
        private System.Windows.Forms.Button FindByArticle;
        private System.Windows.Forms.Label HelpFa;
        private System.Windows.Forms.Button FindActive;
        private System.Windows.Forms.Label HelpJcl;
        private System.Windows.Forms.Button JudgeCaseList;
        private System.Windows.Forms.Label HelpPcl;
        private System.Windows.Forms.Button PlaintiffCaseList;
        private System.Windows.Forms.Label HelpDcl;
        private System.Windows.Forms.Button DefendantCaseList;
        private System.Windows.Forms.Button EditSelected;
        private System.Windows.Forms.Button DeleteSelectedCase;
        private System.Windows.Forms.Button DisplayAll;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button AddCase;
        private System.Windows.Forms.Button EditCase;
        private System.Windows.Forms.Button DeleteCase;
        private System.Windows.Forms.Button DefendantByFullname;
        private System.Windows.Forms.TextBox DbfTB;
        private System.Windows.Forms.Label HelpDbf;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}