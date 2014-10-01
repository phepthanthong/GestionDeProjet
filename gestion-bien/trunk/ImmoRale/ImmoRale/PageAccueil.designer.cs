namespace Maquette.cs
{
    partial class PageAccueil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butEntrer = new System.Windows.Forms.Button();
            this.butAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue au";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(91, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Système de gestion des biens";
            // 
            // butEntrer
            // 
            this.butEntrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butEntrer.Location = new System.Drawing.Point(131, 218);
            this.butEntrer.Name = "butEntrer";
            this.butEntrer.Size = new System.Drawing.Size(80, 45);
            this.butEntrer.TabIndex = 1;
            this.butEntrer.Text = "Entrer";
            this.butEntrer.UseVisualStyleBackColor = true;
            this.butEntrer.Click += new System.EventHandler(this.butEntrer_Click);
            // 
            // butAnnuler
            // 
            this.butAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butAnnuler.Location = new System.Drawing.Point(384, 218);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(80, 45);
            this.butAnnuler.TabIndex = 1;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            this.butAnnuler.Click += new System.EventHandler(this.butAnnuler_Click);
            // 
            // PageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 371);
            this.Controls.Add(this.butAnnuler);
            this.Controls.Add(this.butEntrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agence Immo Rale - Gestion des biens ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butEntrer;
        private System.Windows.Forms.Button butAnnuler;

    }
}

