namespace ImmoRale
{
    partial class GestionBien
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
            this.tabControlBiens = new System.Windows.Forms.TabControl();
            this.tabPage1Biens = new System.Windows.Forms.TabPage();
            this.tabPage2Biens = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butCommercial = new System.Windows.Forms.Button();
            this.butBiens = new System.Windows.Forms.Button();
            this.butAcheteur = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlAcheteurs = new System.Windows.Forms.TabControl();
            this.tabPageInformationsAcheteurs = new System.Windows.Forms.TabPage();
            this.tabPageListeAcheteurs = new System.Windows.Forms.TabPage();
            this.tabControlCommerciaux = new System.Windows.Forms.TabControl();
            this.tabPageInformationsCom = new System.Windows.Forms.TabPage();
            this.tabPageListeCom = new System.Windows.Forms.TabPage();
            this.tabControlBiens.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlAcheteurs.SuspendLayout();
            this.tabControlCommerciaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBiens
            // 
            this.tabControlBiens.Controls.Add(this.tabPage1Biens);
            this.tabControlBiens.Controls.Add(this.tabPage2Biens);
            this.tabControlBiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlBiens.Location = new System.Drawing.Point(0, 0);
            this.tabControlBiens.Name = "tabControlBiens";
            this.tabControlBiens.SelectedIndex = 0;
            this.tabControlBiens.Size = new System.Drawing.Size(1184, 478);
            this.tabControlBiens.TabIndex = 0;
            this.tabControlBiens.SelectedIndexChanged += new System.EventHandler(this.tabControlBiens_SelectedIndexChanged);
            // 
            // tabPage1Biens
            // 
            this.tabPage1Biens.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Biens.Name = "tabPage1Biens";
            this.tabPage1Biens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Biens.Size = new System.Drawing.Size(1176, 452);
            this.tabPage1Biens.TabIndex = 0;
            this.tabPage1Biens.Text = "Saisie";
            this.tabPage1Biens.UseVisualStyleBackColor = true;
            // 
            // tabPage2Biens
            // 
            this.tabPage2Biens.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Biens.Name = "tabPage2Biens";
            this.tabPage2Biens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Biens.Size = new System.Drawing.Size(1176, 452);
            this.tabPage2Biens.TabIndex = 1;
            this.tabPage2Biens.Text = "Liste";
            this.tabPage2Biens.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.butCommercial);
            this.flowLayoutPanel1.Controls.Add(this.butBiens);
            this.flowLayoutPanel1.Controls.Add(this.butAcheteur);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Castellar", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 77);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // butCommercial
            // 
            this.butCommercial.AutoSize = true;
            this.butCommercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butCommercial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCommercial.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCommercial.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butCommercial.Location = new System.Drawing.Point(3, 3);
            this.butCommercial.Name = "butCommercial";
            this.butCommercial.Size = new System.Drawing.Size(431, 66);
            this.butCommercial.TabIndex = 0;
            this.butCommercial.Text = "Commerciaux";
            this.butCommercial.UseVisualStyleBackColor = false;
            this.butCommercial.Click += new System.EventHandler(this.butCommercial_Click);
            // 
            // butBiens
            // 
            this.butBiens.AutoSize = true;
            this.butBiens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butBiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBiens.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBiens.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butBiens.Location = new System.Drawing.Point(440, 3);
            this.butBiens.Name = "butBiens";
            this.butBiens.Size = new System.Drawing.Size(342, 66);
            this.butBiens.TabIndex = 0;
            this.butBiens.Text = "Biens";
            this.butBiens.UseVisualStyleBackColor = false;
            this.butBiens.Click += new System.EventHandler(this.butBiens_Click);
            // 
            // butAcheteur
            // 
            this.butAcheteur.AutoSize = true;
            this.butAcheteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butAcheteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAcheteur.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAcheteur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butAcheteur.Location = new System.Drawing.Point(788, 3);
            this.butAcheteur.Name = "butAcheteur";
            this.butAcheteur.Size = new System.Drawing.Size(391, 66);
            this.butAcheteur.TabIndex = 0;
            this.butAcheteur.Text = "Acheteurs";
            this.butAcheteur.UseVisualStyleBackColor = false;
            this.butAcheteur.Click += new System.EventHandler(this.butAcheteur_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlBiens);
            this.splitContainer1.Panel2.Controls.Add(this.tabControlAcheteurs);
            this.splitContainer1.Panel2.Controls.Add(this.tabControlCommerciaux);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 561);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControlAcheteurs
            // 
            this.tabControlAcheteurs.Controls.Add(this.tabPageInformationsAcheteurs);
            this.tabControlAcheteurs.Controls.Add(this.tabPageListeAcheteurs);
            this.tabControlAcheteurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAcheteurs.Location = new System.Drawing.Point(0, 0);
            this.tabControlAcheteurs.Name = "tabControlAcheteurs";
            this.tabControlAcheteurs.SelectedIndex = 0;
            this.tabControlAcheteurs.Size = new System.Drawing.Size(1184, 478);
            this.tabControlAcheteurs.TabIndex = 0;
            this.tabControlAcheteurs.SelectedIndexChanged += new System.EventHandler(this.tabControlAcheteurs_SelectedIndexChanged);
            // 
            // tabPageInformationsAcheteurs
            // 
            this.tabPageInformationsAcheteurs.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformationsAcheteurs.Name = "tabPageInformationsAcheteurs";
            this.tabPageInformationsAcheteurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformationsAcheteurs.Size = new System.Drawing.Size(1176, 452);
            this.tabPageInformationsAcheteurs.TabIndex = 0;
            this.tabPageInformationsAcheteurs.Text = "Informations";
            this.tabPageInformationsAcheteurs.UseVisualStyleBackColor = true;
            // 
            // tabPageListeAcheteurs
            // 
            this.tabPageListeAcheteurs.Location = new System.Drawing.Point(4, 22);
            this.tabPageListeAcheteurs.Name = "tabPageListeAcheteurs";
            this.tabPageListeAcheteurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListeAcheteurs.Size = new System.Drawing.Size(1176, 452);
            this.tabPageListeAcheteurs.TabIndex = 1;
            this.tabPageListeAcheteurs.Text = "Liste";
            this.tabPageListeAcheteurs.UseVisualStyleBackColor = true;
            // 
            // tabControlCommerciaux
            // 
            this.tabControlCommerciaux.Controls.Add(this.tabPageInformationsCom);
            this.tabControlCommerciaux.Controls.Add(this.tabPageListeCom);
            this.tabControlCommerciaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCommerciaux.Location = new System.Drawing.Point(0, 0);
            this.tabControlCommerciaux.Name = "tabControlCommerciaux";
            this.tabControlCommerciaux.SelectedIndex = 0;
            this.tabControlCommerciaux.Size = new System.Drawing.Size(1184, 478);
            this.tabControlCommerciaux.TabIndex = 1;
            this.tabControlCommerciaux.SelectedIndexChanged += new System.EventHandler(this.tabControlCommerciaux_SelectedIndexChanged);
            // 
            // tabPageInformationsCom
            // 
            this.tabPageInformationsCom.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformationsCom.Name = "tabPageInformationsCom";
            this.tabPageInformationsCom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformationsCom.Size = new System.Drawing.Size(1176, 452);
            this.tabPageInformationsCom.TabIndex = 0;
            this.tabPageInformationsCom.Text = "Informations";
            this.tabPageInformationsCom.UseVisualStyleBackColor = true;
            // 
            // tabPageListeCom
            // 
            this.tabPageListeCom.Location = new System.Drawing.Point(4, 22);
            this.tabPageListeCom.Name = "tabPageListeCom";
            this.tabPageListeCom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListeCom.Size = new System.Drawing.Size(1176, 452);
            this.tabPageListeCom.TabIndex = 1;
            this.tabPageListeCom.Text = "Liste";
            this.tabPageListeCom.UseVisualStyleBackColor = true;
            // 
            // GestionBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GestionBien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agence Immo Rale - Gestion des biens";
            this.tabControlBiens.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlAcheteurs.ResumeLayout(false);
            this.tabControlCommerciaux.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBiens;
        private System.Windows.Forms.TabPage tabPage1Biens;
        private System.Windows.Forms.TabPage tabPage2Biens;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butCommercial;
        private System.Windows.Forms.Button butBiens;
        private System.Windows.Forms.Button butAcheteur;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlAcheteurs;
        private System.Windows.Forms.TabPage tabPageInformationsAcheteurs;
        private System.Windows.Forms.TabPage tabPageListeAcheteurs;
        private System.Windows.Forms.TabControl tabControlCommerciaux;
        private System.Windows.Forms.TabPage tabPageInformationsCom;
        private System.Windows.Forms.TabPage tabPageListeCom;            
    }
}

