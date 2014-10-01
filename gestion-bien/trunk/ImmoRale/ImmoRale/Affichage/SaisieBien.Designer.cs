namespace ImmoRale.Affichage
{
    partial class SaisieBien
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
            this.butAjoutFiche = new System.Windows.Forms.Button();
            this.butEnregistrer = new System.Windows.Forms.Button();
            this.dateVenteReelle = new System.Windows.Forms.DateTimePicker();
            this.dateMiseEnVente = new System.Windows.Forms.DateTimePicker();
            this.txtMailPro = new System.Windows.Forms.TextBox();
            this.txtTelMobilePro = new System.Windows.Forms.TextBox();
            this.txtTelFixePro = new System.Windows.Forms.TextBox();
            this.txtCommentaires = new System.Windows.Forms.TextBox();
            this.txtAcheteur = new System.Windows.Forms.TextBox();
            this.txtPrixVenteReel = new System.Windows.Forms.TextBox();
            this.txtPrixSouhaite = new System.Windows.Forms.TextBox();
            this.txtSurPar = new System.Windows.Forms.TextBox();
            this.txtAdrPro = new System.Windows.Forms.TextBox();
            this.txtSurHabi = new System.Windows.Forms.TextBox();
            this.txtAdrBien = new System.Windows.Forms.TextBox();
            this.txtNomPro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenomPro = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.numNbrChambres = new System.Windows.Forms.NumericUpDown();
            this.numNbrToilettes = new System.Windows.Forms.NumericUpDown();
            this.comboStatut = new System.Windows.Forms.ComboBox();
            this.butNouveau = new System.Windows.Forms.Button();
            this.comboVille = new System.Windows.Forms.ComboBox();
            this.butAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNbrChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbrToilettes)).BeginInit();
            this.SuspendLayout();
            // 
            // butAjoutFiche
            // 
            this.butAjoutFiche.Location = new System.Drawing.Point(639, 406);
            this.butAjoutFiche.Name = "butAjoutFiche";
            this.butAjoutFiche.Size = new System.Drawing.Size(75, 23);
            this.butAjoutFiche.TabIndex = 61;
            this.butAjoutFiche.Text = "Ajout Fiche";
            this.butAjoutFiche.UseVisualStyleBackColor = true;
            this.butAjoutFiche.Click += new System.EventHandler(this.butAjoutFiche_Click);
            // 
            // butEnregistrer
            // 
            this.butEnregistrer.Location = new System.Drawing.Point(441, 406);
            this.butEnregistrer.Name = "butEnregistrer";
            this.butEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.butEnregistrer.TabIndex = 59;
            this.butEnregistrer.Text = "Enregistrer";
            this.butEnregistrer.UseVisualStyleBackColor = true;
            this.butEnregistrer.Click += new System.EventHandler(this.butEnregistrer_Click);
            // 
            // dateVenteReelle
            // 
            this.dateVenteReelle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVenteReelle.Location = new System.Drawing.Point(881, 113);
            this.dateVenteReelle.Name = "dateVenteReelle";
            this.dateVenteReelle.Size = new System.Drawing.Size(200, 20);
            this.dateVenteReelle.TabIndex = 54;
            // 
            // dateMiseEnVente
            // 
            this.dateMiseEnVente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMiseEnVente.Location = new System.Drawing.Point(881, 80);
            this.dateMiseEnVente.Name = "dateMiseEnVente";
            this.dateMiseEnVente.Size = new System.Drawing.Size(200, 20);
            this.dateMiseEnVente.TabIndex = 53;
            // 
            // txtMailPro
            // 
            this.txtMailPro.Location = new System.Drawing.Point(178, 246);
            this.txtMailPro.Name = "txtMailPro";
            this.txtMailPro.Size = new System.Drawing.Size(153, 20);
            this.txtMailPro.TabIndex = 46;
            // 
            // txtTelMobilePro
            // 
            this.txtTelMobilePro.Location = new System.Drawing.Point(178, 210);
            this.txtTelMobilePro.Name = "txtTelMobilePro";
            this.txtTelMobilePro.Size = new System.Drawing.Size(153, 20);
            this.txtTelMobilePro.TabIndex = 42;
            this.txtTelMobilePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelFixePro_KeyPress);
            // 
            // txtTelFixePro
            // 
            this.txtTelFixePro.Location = new System.Drawing.Point(178, 177);
            this.txtTelFixePro.Name = "txtTelFixePro";
            this.txtTelFixePro.Size = new System.Drawing.Size(153, 20);
            this.txtTelFixePro.TabIndex = 43;
            this.txtTelFixePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelFixePro_KeyPress);
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(764, 240);
            this.txtCommentaires.Multiline = true;
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.Size = new System.Drawing.Size(316, 80);
            this.txtCommentaires.TabIndex = 44;
            // 
            // txtAcheteur
            // 
            this.txtAcheteur.Location = new System.Drawing.Point(481, 317);
            this.txtAcheteur.Name = "txtAcheteur";
            this.txtAcheteur.Size = new System.Drawing.Size(248, 20);
            this.txtAcheteur.TabIndex = 45;
            // 
            // txtPrixVenteReel
            // 
            this.txtPrixVenteReel.Location = new System.Drawing.Point(881, 177);
            this.txtPrixVenteReel.Name = "txtPrixVenteReel";
            this.txtPrixVenteReel.Size = new System.Drawing.Size(200, 20);
            this.txtPrixVenteReel.TabIndex = 52;
            this.txtPrixVenteReel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelFixePro_KeyPress);
            // 
            // txtPrixSouhaite
            // 
            this.txtPrixSouhaite.Location = new System.Drawing.Point(881, 143);
            this.txtPrixSouhaite.Name = "txtPrixSouhaite";
            this.txtPrixSouhaite.Size = new System.Drawing.Size(200, 20);
            this.txtPrixSouhaite.TabIndex = 47;
            this.txtPrixSouhaite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelFixePro_KeyPress);
            // 
            // txtSurPar
            // 
            this.txtSurPar.Location = new System.Drawing.Point(481, 210);
            this.txtSurPar.Name = "txtSurPar";
            this.txtSurPar.Size = new System.Drawing.Size(246, 20);
            this.txtSurPar.TabIndex = 49;
            this.txtSurPar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelFixePro_KeyPress);
            // 
            // txtAdrPro
            // 
            this.txtAdrPro.Location = new System.Drawing.Point(178, 146);
            this.txtAdrPro.Name = "txtAdrPro";
            this.txtAdrPro.Size = new System.Drawing.Size(153, 20);
            this.txtAdrPro.TabIndex = 50;
            // 
            // txtSurHabi
            // 
            this.txtSurHabi.Location = new System.Drawing.Point(481, 177);
            this.txtSurHabi.Name = "txtSurHabi";
            this.txtSurHabi.Size = new System.Drawing.Size(246, 20);
            this.txtSurHabi.TabIndex = 51;
            this.txtSurHabi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelFixePro_KeyPress);
            // 
            // txtAdrBien
            // 
            this.txtAdrBien.Location = new System.Drawing.Point(481, 80);
            this.txtAdrBien.Name = "txtAdrBien";
            this.txtAdrBien.Size = new System.Drawing.Size(246, 20);
            this.txtAdrBien.TabIndex = 39;
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(178, 80);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(153, 20);
            this.txtNomPro.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(356, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Adresse";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(761, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Prix de vente réel";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Téléphone portable";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(73, 249);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Email";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(73, 249);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(356, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Nombre de chambres";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(356, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Surface habitable";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(761, 213);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(158, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Information(s) complémentaire(s)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(356, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Acheteur";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(761, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Date de vente réelle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(761, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Date de mise en vente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Statut";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Ville";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Surface de la parcelle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Type d\'habitation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Prix de vente souhaité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Téléphone fixe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(722, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Bien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(156, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Propriétaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(464, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fiche de description du bien";
            // 
            // txtPrenomPro
            // 
            this.txtPrenomPro.Location = new System.Drawing.Point(178, 113);
            this.txtPrenomPro.Name = "txtPrenomPro";
            this.txtPrenomPro.Size = new System.Drawing.Size(153, 20);
            this.txtPrenomPro.TabIndex = 38;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(73, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 63;
            this.label24.Text = "Nom ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(356, 282);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "Nombre de toilettes";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(481, 144);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(167, 21);
            this.comboType.TabIndex = 64;
            // 
            // numNbrChambres
            // 
            this.numNbrChambres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNbrChambres.Location = new System.Drawing.Point(482, 247);
            this.numNbrChambres.Name = "numNbrChambres";
            this.numNbrChambres.Size = new System.Drawing.Size(166, 20);
            this.numNbrChambres.TabIndex = 66;
            // 
            // numNbrToilettes
            // 
            this.numNbrToilettes.Location = new System.Drawing.Point(481, 280);
            this.numNbrToilettes.Name = "numNbrToilettes";
            this.numNbrToilettes.Size = new System.Drawing.Size(166, 20);
            this.numNbrToilettes.TabIndex = 66;
            // 
            // comboStatut
            // 
            this.comboStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatut.FormattingEnabled = true;
            this.comboStatut.Location = new System.Drawing.Point(482, 347);
            this.comboStatut.Name = "comboStatut";
            this.comboStatut.Size = new System.Drawing.Size(167, 21);
            this.comboStatut.TabIndex = 64;
            // 
            // butNouveau
            // 
            this.butNouveau.Location = new System.Drawing.Point(256, 406);
            this.butNouveau.Name = "butNouveau";
            this.butNouveau.Size = new System.Drawing.Size(75, 23);
            this.butNouveau.TabIndex = 67;
            this.butNouveau.Text = "Nouveau";
            this.butNouveau.UseVisualStyleBackColor = true;
            this.butNouveau.Click += new System.EventHandler(this.butNouveau_Click);
            // 
            // comboVille
            // 
            this.comboVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVille.FormattingEnabled = true;
            this.comboVille.Location = new System.Drawing.Point(480, 113);
            this.comboVille.Name = "comboVille";
            this.comboVille.Size = new System.Drawing.Size(167, 21);
            this.comboVille.TabIndex = 64;
            // 
            // butAnnuler
            // 
            this.butAnnuler.Location = new System.Drawing.Point(844, 406);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(75, 23);
            this.butAnnuler.TabIndex = 68;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            this.butAnnuler.Click += new System.EventHandler(this.butAnnuler_Click);
            // 
            // SaisieBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.butAnnuler);
            this.Controls.Add(this.butNouveau);
            this.Controls.Add(this.numNbrToilettes);
            this.Controls.Add(this.numNbrChambres);
            this.Controls.Add(this.comboVille);
            this.Controls.Add(this.comboStatut);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.butAjoutFiche);
            this.Controls.Add(this.butEnregistrer);
            this.Controls.Add(this.dateVenteReelle);
            this.Controls.Add(this.dateMiseEnVente);
            this.Controls.Add(this.txtMailPro);
            this.Controls.Add(this.txtTelMobilePro);
            this.Controls.Add(this.txtTelFixePro);
            this.Controls.Add(this.txtCommentaires);
            this.Controls.Add(this.txtAcheteur);
            this.Controls.Add(this.txtPrixVenteReel);
            this.Controls.Add(this.txtPrixSouhaite);
            this.Controls.Add(this.txtSurPar);
            this.Controls.Add(this.txtAdrPro);
            this.Controls.Add(this.txtSurHabi);
            this.Controls.Add(this.txtAdrBien);
            this.Controls.Add(this.txtPrenomPro);
            this.Controls.Add(this.txtNomPro);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaisieBien";
            this.Size = new System.Drawing.Size(1162, 463);
            ((System.ComponentModel.ISupportInitialize)(this.numNbrChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbrToilettes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAjoutFiche;
        private System.Windows.Forms.Button butEnregistrer;
        private System.Windows.Forms.DateTimePicker dateVenteReelle;
        private System.Windows.Forms.DateTimePicker dateMiseEnVente;
        private System.Windows.Forms.TextBox txtMailPro;
        private System.Windows.Forms.TextBox txtTelMobilePro;
        private System.Windows.Forms.TextBox txtTelFixePro;
        private System.Windows.Forms.TextBox txtCommentaires;
        private System.Windows.Forms.TextBox txtAcheteur;
        private System.Windows.Forms.TextBox txtPrixVenteReel;
        private System.Windows.Forms.TextBox txtPrixSouhaite;
        private System.Windows.Forms.TextBox txtSurPar;
        private System.Windows.Forms.TextBox txtAdrPro;
        private System.Windows.Forms.TextBox txtSurHabi;
        private System.Windows.Forms.TextBox txtAdrBien;
        private System.Windows.Forms.TextBox txtNomPro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenomPro;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.NumericUpDown numNbrChambres;
        private System.Windows.Forms.NumericUpDown numNbrToilettes;
        private System.Windows.Forms.ComboBox comboStatut;
        private System.Windows.Forms.Button butNouveau;
        private System.Windows.Forms.ComboBox comboVille;
        private System.Windows.Forms.Button butAnnuler;
    }
}
