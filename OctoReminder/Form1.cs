using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OctoReminder
{
    public partial class Form1 : Form
    {
        private const int gelbSeconds = 1200;
        private const int rotSeconds = 1800;

        private Stopwatch watch;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            watch = new Stopwatch();
            Reset();
        }

        private void Reset()
        {
            timer1.Enabled = true;
            this.BackColor = Color.Green;
            watch.Restart();
        }

        void timer1_Tick(object sender, EventArgs e)
        {            
            this.label1.Text = watch.Elapsed.ToString(@"hh\:mm\:ss");
            if (watch.Elapsed.TotalSeconds >= gelbSeconds)
                this.BackColor = Color.Yellow;
            if (watch.Elapsed.TotalSeconds >= rotSeconds)
                this.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMMIT!");
            Reset();            
        }
    }
}
