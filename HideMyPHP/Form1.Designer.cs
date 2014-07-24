namespace HideMyPHP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVarName = new System.Windows.Forms.TextBox();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.btnRemoveVar = new System.Windows.Forms.Button();
            this.txtRemoveFunc = new System.Windows.Forms.Button();
            this.txtAddFunc = new System.Windows.Forms.Button();
            this.txtFuncName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstPHPVars = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstFiles = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.lstFunctions = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSelectAllFunc = new System.Windows.Forms.Button();
            this.btnSelectAllVars = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.BackColor = System.Drawing.Color.White;
            this.txtDirectory.Location = new System.Drawing.Point(6, 22);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(700, 20);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(712, 20);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(87, 23);
            this.btnSelectDirectory.TabIndex = 1;
            this.btnSelectDirectory.Text = "Browse";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Skip PHP Variables";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skip Functions";
            // 
            // txtVarName
            // 
            this.txtVarName.BackColor = System.Drawing.Color.White;
            this.txtVarName.Location = new System.Drawing.Point(13, 259);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.Size = new System.Drawing.Size(147, 20);
            this.txtVarName.TabIndex = 19;
            // 
            // btnAddVar
            // 
            this.btnAddVar.Location = new System.Drawing.Point(14, 285);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(67, 23);
            this.btnAddVar.TabIndex = 20;
            this.btnAddVar.Text = "Add";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // btnRemoveVar
            // 
            this.btnRemoveVar.Location = new System.Drawing.Point(93, 284);
            this.btnRemoveVar.Name = "btnRemoveVar";
            this.btnRemoveVar.Size = new System.Drawing.Size(67, 23);
            this.btnRemoveVar.TabIndex = 21;
            this.btnRemoveVar.Text = "Remove";
            this.btnRemoveVar.UseVisualStyleBackColor = true;
            this.btnRemoveVar.Click += new System.EventHandler(this.btnRemoveVar_Click);
            // 
            // txtRemoveFunc
            // 
            this.txtRemoveFunc.Location = new System.Drawing.Point(255, 284);
            this.txtRemoveFunc.Name = "txtRemoveFunc";
            this.txtRemoveFunc.Size = new System.Drawing.Size(67, 23);
            this.txtRemoveFunc.TabIndex = 24;
            this.txtRemoveFunc.Text = "Remove";
            this.txtRemoveFunc.UseVisualStyleBackColor = true;
            this.txtRemoveFunc.Click += new System.EventHandler(this.txtRemoveFunc_Click);
            // 
            // txtAddFunc
            // 
            this.txtAddFunc.Location = new System.Drawing.Point(176, 285);
            this.txtAddFunc.Name = "txtAddFunc";
            this.txtAddFunc.Size = new System.Drawing.Size(67, 23);
            this.txtAddFunc.TabIndex = 23;
            this.txtAddFunc.Text = "Add";
            this.txtAddFunc.UseVisualStyleBackColor = true;
            this.txtAddFunc.Click += new System.EventHandler(this.txtAddFunc_Click);
            // 
            // txtFuncName
            // 
            this.txtFuncName.BackColor = System.Drawing.Color.White;
            this.txtFuncName.Location = new System.Drawing.Point(175, 259);
            this.txtFuncName.Name = "txtFuncName";
            this.txtFuncName.Size = new System.Drawing.Size(147, 20);
            this.txtFuncName.TabIndex = 22;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(645, 308);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 23);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start project obfuscation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstPHPVars
            // 
            this.lstPHPVars.FormattingEnabled = true;
            this.lstPHPVars.Items.AddRange(new object[] {
            "$this",
            "$GLOBALS",
            "$_SERVER",
            "$_GET",
            "$_POST",
            "$_FILES",
            "$_REQUEST",
            "$_SESSION",
            "$_ENV",
            "$_COOKIE",
            "$php_errormsg",
            "$HTTP_RAW_POST_DATA",
            "$http_response_header",
            "$argc",
            "$argv",
            "$num_rows"});
            this.lstPHPVars.Location = new System.Drawing.Point(14, 54);
            this.lstPHPVars.Name = "lstPHPVars";
            this.lstPHPVars.Size = new System.Drawing.Size(146, 199);
            this.lstPHPVars.TabIndex = 29;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBarMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 30;
            // 
            // lblStatusBarMessage
            // 
            this.lblStatusBarMessage.Name = "lblStatusBarMessage";
            this.lblStatusBarMessage.Size = new System.Drawing.Size(312, 17);
            this.lblStatusBarMessage.Text = "Please select the directory containing the php source files.";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(6, 103);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(793, 199);
            this.lstFiles.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Target Directory";
            // 
            // txtOutDirectory
            // 
            this.txtOutDirectory.BackColor = System.Drawing.Color.White;
            this.txtOutDirectory.Location = new System.Drawing.Point(6, 66);
            this.txtOutDirectory.Name = "txtOutDirectory";
            this.txtOutDirectory.ReadOnly = true;
            this.txtOutDirectory.Size = new System.Drawing.Size(700, 20);
            this.txtOutDirectory.TabIndex = 32;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(6, 308);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(116, 23);
            this.btnSelectAll.TabIndex = 35;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(128, 308);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(116, 23);
            this.btnUnselectAll.TabIndex = 36;
            this.btnUnselectAll.Text = "Unselect All";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // lstFunctions
            // 
            this.lstFunctions.FormattingEnabled = true;
            this.lstFunctions.Location = new System.Drawing.Point(175, 54);
            this.lstFunctions.Name = "lstFunctions";
            this.lstFunctions.Size = new System.Drawing.Size(147, 199);
            this.lstFunctions.TabIndex = 37;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 369);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lstFiles);
            this.tabPage1.Controls.Add(this.txtDirectory);
            this.tabPage1.Controls.Add(this.btnUnselectAll);
            this.tabPage1.Controls.Add(this.btnSelectDirectory);
            this.tabPage1.Controls.Add(this.btnSelectAll);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.txtOutDirectory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnSelectAllFunc);
            this.tabPage2.Controls.Add(this.btnSelectAllVars);
            this.tabPage2.Controls.Add(this.lstFunctions);
            this.tabPage2.Controls.Add(this.txtVarName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnAddVar);
            this.tabPage2.Controls.Add(this.lstPHPVars);
            this.tabPage2.Controls.Add(this.btnRemoveVar);
            this.tabPage2.Controls.Add(this.txtRemoveFunc);
            this.tabPage2.Controls.Add(this.txtFuncName);
            this.tabPage2.Controls.Add(this.txtAddFunc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // btnSelectAllFunc
            // 
            this.btnSelectAllFunc.Location = new System.Drawing.Point(175, 314);
            this.btnSelectAllFunc.Name = "btnSelectAllFunc";
            this.btnSelectAllFunc.Size = new System.Drawing.Size(146, 23);
            this.btnSelectAllFunc.TabIndex = 39;
            this.btnSelectAllFunc.Text = "Select All";
            this.btnSelectAllFunc.UseVisualStyleBackColor = true;
            this.btnSelectAllFunc.Click += new System.EventHandler(this.btnSelectAllFunc_Click);
            // 
            // btnSelectAllVars
            // 
            this.btnSelectAllVars.Location = new System.Drawing.Point(14, 314);
            this.btnSelectAllVars.Name = "btnSelectAllVars";
            this.btnSelectAllVars.Size = new System.Drawing.Size(146, 23);
            this.btnSelectAllVars.TabIndex = 38;
            this.btnSelectAllVars.Text = "Select All";
            this.btnSelectAllVars.UseVisualStyleBackColor = true;
            this.btnSelectAllVars.Click += new System.EventHandler(this.btnSelectAllVars_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.linkLabel2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(814, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(23, 306);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 16);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://apathae.com/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Icon design by apathae";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(23, 225);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(235, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.zeusafk.net/?page=projects";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HideMyPHP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(446, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 108);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Version: 1.2 beta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Developed by ZeusAFK Technologies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "HideMyPHP - PHP Project Obfuscator";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstLog);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(814, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(3, 3);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(808, 342);
            this.lstLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 397);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HideMyPHP - PHP Project Obfuscator by ZeusAFK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVarName;
        private System.Windows.Forms.Button btnAddVar;
        private System.Windows.Forms.Button btnRemoveVar;
        private System.Windows.Forms.Button txtRemoveFunc;
        private System.Windows.Forms.Button txtAddFunc;
        private System.Windows.Forms.TextBox txtFuncName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckedListBox lstPHPVars;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckedListBox lstFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutDirectory;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBarMessage;
        private System.Windows.Forms.CheckedListBox lstFunctions;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectAllFunc;
        private System.Windows.Forms.Button btnSelectAllVars;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstLog;
    }
}

