namespace TPE_Capteur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nous = new System.Windows.Forms.Button();
            this.Emplacement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Comprendre = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.capteur = new System.Windows.Forms.Button();
            this.Accueil = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 1080);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 319);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nous);
            this.panel1.Controls.Add(this.Emplacement);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Comprendre);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.capteur);
            this.panel1.Controls.Add(this.Accueil);
            this.panel1.Location = new System.Drawing.Point(3, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 752);
            this.panel1.TabIndex = 0;
            // 
            // nous
            // 
            this.nous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nous.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nous.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nous.Location = new System.Drawing.Point(3, 623);
            this.nous.Name = "nous";
            this.nous.Size = new System.Drawing.Size(347, 60);
            this.nous.TabIndex = 7;
            this.nous.Text = "à propos de nous";
            this.nous.UseVisualStyleBackColor = true;
            this.nous.Click += new System.EventHandler(this.nous_Click);
            // 
            // Emplacement
            // 
            this.Emplacement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Emplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Emplacement.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emplacement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Emplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Emplacement.Location = new System.Drawing.Point(3, 264);
            this.Emplacement.Name = "Emplacement";
            this.Emplacement.Size = new System.Drawing.Size(347, 60);
            this.Emplacement.TabIndex = 6;
            this.Emplacement.Text = "Emplacement du capteur";
            this.Emplacement.UseVisualStyleBackColor = true;
            this.Emplacement.Click += new System.EventHandler(this.Emplacement_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Connexion du matériel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Comprendre
            // 
            this.Comprendre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comprendre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comprendre.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comprendre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Comprendre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Comprendre.Location = new System.Drawing.Point(0, 132);
            this.Comprendre.Name = "Comprendre";
            this.Comprendre.Size = new System.Drawing.Size(347, 60);
            this.Comprendre.TabIndex = 3;
            this.Comprendre.Text = "Comprendre l\'ECG";
            this.Comprendre.UseVisualStyleBackColor = true;
            this.Comprendre.Click += new System.EventHandler(this.Comprendre_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 689);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(347, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "fermer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mesure";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // capteur
            // 
            this.capteur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capteur.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capteur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.capteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.capteur.Location = new System.Drawing.Point(0, 66);
            this.capteur.Name = "capteur";
            this.capteur.Size = new System.Drawing.Size(347, 60);
            this.capteur.TabIndex = 2;
            this.capteur.Text = "Capteur ECG";
            this.capteur.UseVisualStyleBackColor = true;
            this.capteur.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accueil
            // 
            this.Accueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accueil.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accueil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Accueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accueil.Location = new System.Drawing.Point(0, 0);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(347, 60);
            this.Accueil.TabIndex = 1;
            this.Accueil.Text = "Accueil";
            this.Accueil.UseVisualStyleBackColor = true;
            this.Accueil.Click += new System.EventHandler(this.Accueil_Click);
            // 
            // Base
            // 
            this.Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base.Location = new System.Drawing.Point(350, 0);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(1570, 1080);
            this.Base.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Accueil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button capteur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Base;
        private System.Windows.Forms.Button Comprendre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Emplacement;
        private System.Windows.Forms.Button nous;
    }
}

