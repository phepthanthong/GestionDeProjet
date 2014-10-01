namespace ImmoRale.Affichage
{
    partial class AffichageBien
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.butChercher = new System.Windows.Forms.Button();
            this.comboCriteres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(174, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(985, 420);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // butChercher
            // 
            this.butChercher.Location = new System.Drawing.Point(50, 208);
            this.butChercher.Name = "butChercher";
            this.butChercher.Size = new System.Drawing.Size(75, 23);
            this.butChercher.TabIndex = 1;
            this.butChercher.Text = "Chercher";
            this.butChercher.UseVisualStyleBackColor = true;
            this.butChercher.Click += new System.EventHandler(this.butChercher_Click);
            // 
            // comboCriteres
            // 
            this.comboCriteres.FormattingEnabled = true;
            this.comboCriteres.Location = new System.Drawing.Point(25, 131);
            this.comboCriteres.Name = "comboCriteres";
            this.comboCriteres.Size = new System.Drawing.Size(121, 21);
            this.comboCriteres.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Critères";
            // 
            // AffichageBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCriteres);
            this.Controls.Add(this.butChercher);
            this.Controls.Add(this.dataGridView2);
            this.Name = "AffichageBien";
            this.Size = new System.Drawing.Size(1162, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button butChercher;
        private System.Windows.Forms.ComboBox comboCriteres;
        private System.Windows.Forms.Label label1;
    }
}
