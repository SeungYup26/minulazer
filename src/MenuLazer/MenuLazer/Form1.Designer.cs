
namespace MinuLazer
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
            this.ipBox = new System.Windows.Forms.TextBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.threadBox = new System.Windows.Forms.TextBox();
            this.packetBox = new System.Windows.Forms.TextBox();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.githubPage = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ipBox.Location = new System.Drawing.Point(16, 19);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(277, 20);
            this.ipBox.TabIndex = 0;
            this.ipBox.Text = "000.000.000.000";
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.Color.White;
            this.attackButton.FlatAppearance.BorderSize = 0;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackButton.ForeColor = System.Drawing.Color.Black;
            this.attackButton.Location = new System.Drawing.Point(16, 46);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(346, 30);
            this.attackButton.TabIndex = 5;
            this.attackButton.Text = "shoot";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minu Lazer";
            // 
            // portBox
            // 
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.portBox.Location = new System.Drawing.Point(313, 19);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(49, 20);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "80";
            // 
            // threadBox
            // 
            this.threadBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threadBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.threadBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.threadBox.Location = new System.Drawing.Point(16, 19);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(53, 20);
            this.threadBox.TabIndex = 2;
            this.threadBox.Text = "99";
            // 
            // packetBox
            // 
            this.packetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.packetBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.packetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.packetBox.Location = new System.Drawing.Point(89, 19);
            this.packetBox.Name = "packetBox";
            this.packetBox.Size = new System.Drawing.Size(273, 20);
            this.packetBox.TabIndex = 3;
            this.packetBox.Text = "packet";
            // 
            // methodBox
            // 
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.methodBox.Location = new System.Drawing.Point(16, 19);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(346, 21);
            this.methodBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ipBox);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread Packet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.methodBox);
            this.groupBox3.Controls.Add(this.attackButton);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(15, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 89);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Method Attack";
            // 
            // githubPage
            // 
            this.githubPage.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.githubPage.AutoSize = true;
            this.githubPage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.githubPage.Location = new System.Drawing.Point(97, 259);
            this.githubPage.Name = "githubPage";
            this.githubPage.Size = new System.Drawing.Size(207, 13);
            this.githubPage.TabIndex = 9;
            this.githubPage.TabStop = true;
            this.githubPage.Text = "https://github.com/seungyup26/minulazer";
            this.githubPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.githubPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubPage_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(406, 280);
            this.Controls.Add(this.githubPage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label label1;
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
    }
}

