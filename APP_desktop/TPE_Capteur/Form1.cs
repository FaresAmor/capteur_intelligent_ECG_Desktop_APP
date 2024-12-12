using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPE_Capteur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h =Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Base.Controls.Clear();
            capteur capteur_1 = new capteur() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            capteur_1.FormBorderStyle = FormBorderStyle.None;
            this.Base.Controls.Add(capteur_1);
            capteur_1.Show();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Réajuste les contrôles si nécessaire
            foreach (Control control in this.Base.Controls)
            {
                control.Size = new Size(this.Base.Width, this.Base.Height);
            }
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            this.Base.Controls.Clear();
            intro intro_1 = new intro() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            intro_1.FormBorderStyle = FormBorderStyle.None;
            this.Base.Controls.Add(intro_1);
            intro_1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Base.Controls.Clear();
            mesure mesure_1 = new mesure() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mesure_1.FormBorderStyle = FormBorderStyle.None;
            this.Base.Controls.Add(mesure_1);
            mesure_1.Show();
        }

        private void Comprendre_Click(object sender, EventArgs e)
        {
            this.Base.Controls.Clear();
            comprendre comprendre_1 = new comprendre() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            comprendre_1.FormBorderStyle = FormBorderStyle.None;
            this.Base.Controls.Add(comprendre_1);
            comprendre_1.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Base.Controls.Clear();
            Connexion Connexion_1 = new Connexion() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Connexion_1.FormBorderStyle = FormBorderStyle.None;
            this.Base.Controls.Add(Connexion_1);
            Connexion_1.Show();

        }

        private void Emplacement_Click(object sender, EventArgs e)
        {
            this.Base.Controls.Clear();
            Emplacement Emplacement_1 = new Emplacement() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Emplacement_1.FormBorderStyle = FormBorderStyle.None;
            this.Base.Controls.Add(Emplacement_1);
            Emplacement_1.Show();

        }

        private void nous_Click(object sender, EventArgs e)
        {
            this.Base.Controls.Clear();
            nous nous_1 = new nous() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            nous_1.FormBorderStyle = FormBorderStyle.None;
            this.Base.Controls.Add(nous_1);
            nous_1.Show();

        }
    }
}
