namespace ImmoRale.Affichage
{
    partial class AffichageCommercial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCom = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAgenceAffiCom = new System.Windows.Forms.ComboBox();
            this.cbStaAffiCom = new System.Windows.Forms.ComboBox();
            this.butChercherAche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCom
            // 
            this.dataGridViewCom.AllowUserToAddRows = false;
            this.dataGridViewCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCom.Location = new System.Drawing.Point(194, 24);
            this.dataGridViewCom.Name = "dataGridViewCom";
            this.dataGridViewCom.ReadOnly = true;
            this.dataGridViewCom.Size = new System.Drawing.Size(968, 424);
            this.dataGridViewCom.TabIndex = 0;
            this.dataGridViewCom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCom_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agence Locale";
            // 
            // cbAgenceAffiCom
            // 
            this.cbAgenceAffiCom.FormattingEnabled = true;
            this.cbAgenceAffiCom.Location = new System.Drawing.Point(39, 205);
            this.cbAgenceAffiCom.Name = "cbAgenceAffiCom";
            this.cbAgenceAffiCom.Size = new System.Drawing.Size(121, 21);
            this.cbAgenceAffiCom.TabIndex = 6;
            // 
            // cbStaAffiCom
            // 
            this.cbStaAffiCom.FormattingEnabled = true;
            this.cbStaAffiCom.Location = new System.Drawing.Point(39, 154);
            this.cbStaAffiCom.Name = "cbStaAffiCom";
            this.cbStaAffiCom.Size = new System.Drawing.Size(121, 21);
            this.cbStaAffiCom.TabIndex = 7;
            // 
            // butChercherAche
            // 
            this.butChercherAche.Location = new System.Drawing.Point(63, 301);
            this.butChercherAche.Name = "butChercherAche";
            this.butChercherAche.Size = new System.Drawing.Size(75, 23);
            this.butChercherAche.TabIndex = 5;
            this.butChercherAche.Text = "Chercher";
            this.butChercherAche.UseVisualStyleBackColor = true;
            this.butChercherAche.Click += new System.EventHandler(this.butChercherAche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Statut";
            // 
            // AffichageCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAgenceAffiCom);
            this.Controls.Add(this.cbStaAffiCom);
            this.Controls.Add(this.butChercherAche);
            this.Controls.Add(this.dataGridViewCom);
            this.Name = "AffichageCommercial";
            this.Size = new System.Drawing.Size(1162, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAgenceAffiCom;
        private System.Windows.Forms.ComboBox cbStaAffiCom;
        private System.Windows.Forms.Button butChercherAche;
        private System.Windows.Forms.Label label1;
    }
}
