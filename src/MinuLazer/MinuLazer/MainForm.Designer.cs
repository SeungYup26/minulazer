
namespace MinuLazer
{
    partial class MainForm
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
            this.ipBox = new System.Windows.Forms.TextBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.threadBox = new System.Windows.Forms.TextBox();
            this.packetBox = new System.Windows.Forms.TextBox();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.githubPage = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.threadLogBox = new System.Windows.Forms.TextBox();
            this.stateLogBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ipBox.Location = new System.Drawing.Point(16, 20);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(502, 20);
            this.ipBox.TabIndex = 0;
            this.ipBox.Text = "000.000.000.000";
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.Color.White;
            this.attackButton.FlatAppearance.BorderSize = 0;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackButton.ForeColor = System.Drawing.Color.Black;
            this.attackButton.Location = new System.Drawing.Point(16, 62);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(292, 30);
            this.attackButton.TabIndex = 5;
            this.attackButton.Text = "shoot";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // portBox
            // 
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.portBox.Location = new System.Drawing.Point(539, 20);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(71, 20);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "80";
            // 
            // threadBox
            // 
            this.threadBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threadBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.threadBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.threadBox.Location = new System.Drawing.Point(16, 20);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(77, 20);
            this.threadBox.TabIndex = 1;
            this.threadBox.Text = "5";
            // 
            // packetBox
            // 
            this.packetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.packetBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.packetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.packetBox.Location = new System.Drawing.Point(114, 20);
            this.packetBox.Multiline = true;
            this.packetBox.Name = "packetBox";
            this.packetBox.Size = new System.Drawing.Size(496, 20);
            this.packetBox.TabIndex = 3;
            this.packetBox.Text = "packet";
            // 
            // methodBox
            // 
            this.methodBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.methodBox.Location = new System.Drawing.Point(16, 27);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(594, 21);
            this.methodBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ipBox);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.threadBox);
            this.groupBox2.Controls.Add(this.packetBox);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(7, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread Packet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopButton);
            this.groupBox3.Controls.Add(this.methodBox);
            this.groupBox3.Controls.Add(this.attackButton);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(7, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 112);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Method Attack";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.White;
            this.stopButton.Enabled = false;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.Location = new System.Drawing.Point(318, 62);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(292, 30);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // githubPage
            // 
            this.githubPage.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.githubPage.AutoSize = true;
            this.githubPage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.githubPage.Location = new System.Drawing.Point(217, 244);
            this.githubPage.Name = "githubPage";
            this.githubPage.Size = new System.Drawing.Size(207, 13);
            this.githubPage.TabIndex = 9;
            this.githubPage.TabStop = true;
            this.githubPage.Text = "https://github.com/seungyup26/minulazer";
            this.githubPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.githubPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubPage_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.threadLogBox);
            this.groupBox4.Controls.Add(this.stateLogBox);
            this.groupBox4.Controls.Add(this.logBox);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 233);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log";
            // 
            // threadLogBox
            // 
            this.threadLogBox.Location = new System.Drawing.Point(16, 196);
            this.threadLogBox.Name = "threadLogBox";
            this.threadLogBox.ReadOnly = true;
            this.threadLogBox.Size = new System.Drawing.Size(594, 20);
            this.threadLogBox.TabIndex = 2;
            this.threadLogBox.Text = "Thread: 0";
            // 
            // stateLogBox
            // 
            this.stateLogBox.Location = new System.Drawing.Point(16, 170);
            this.stateLogBox.Name = "stateLogBox";
            this.stateLogBox.ReadOnly = true;
            this.stateLogBox.Size = new System.Drawing.Size(594, 20);
            this.stateLogBox.TabIndex = 1;
            this.stateLogBox.Text = "Ready";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(16, 19);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(594, 145);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "[*] Program Start";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 290);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.githubPage);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lazer";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(217, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/seungyup26/minulazer";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 312);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(652, 5);
            this.panel10.TabIndex = 17;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(629, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(17, 17);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Black;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(610, 6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(17, 17);
            this.minimizeButton.TabIndex = 18;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Minu Lazer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(652, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minu Lazer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox threadBox;
        private System.Windows.Forms.TextBox packetBox;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel githubPage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox stateLogBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox threadLogBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label4;
    }
}

