namespace JFR_AnnuaireCESI
{
    partial class FrmListeContact
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
            this.GbxListe = new System.Windows.Forms.GroupBox();
            this.DtgListeContact = new System.Windows.Forms.DataGridView();
            this.GbxDetail = new System.Windows.Forms.GroupBox();
            this.LblEntreprise = new System.Windows.Forms.Label();
            this.LblService = new System.Windows.Forms.Label();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.DTPDateEntree = new System.Windows.Forms.DateTimePicker();
            this.LblDateA = new System.Windows.Forms.Label();
            this.LblEntrepriseA = new System.Windows.Forms.Label();
            this.LblServiceA = new System.Windows.Forms.Label();
            this.LblTelA = new System.Windows.Forms.Label();
            this.LblPrenomA = new System.Windows.Forms.Label();
            this.LblNomA = new System.Windows.Forms.Label();
            this.LblRecherche = new System.Windows.Forms.Label();
            this.TbxRecherche = new System.Windows.Forms.TextBox();
            this.BtnRecherche = new System.Windows.Forms.Button();
            this.BtnReafficher = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.GbxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeContact)).BeginInit();
            this.GbxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxListe
            // 
            this.GbxListe.Controls.Add(this.DtgListeContact);
            this.GbxListe.Location = new System.Drawing.Point(23, 78);
            this.GbxListe.Name = "GbxListe";
            this.GbxListe.Size = new System.Drawing.Size(1100, 615);
            this.GbxListe.TabIndex = 0;
            this.GbxListe.TabStop = false;
            this.GbxListe.Text = "Liste des contacts";
            // 
            // DtgListeContact
            // 
            this.DtgListeContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeContact.Location = new System.Drawing.Point(17, 33);
            this.DtgListeContact.Name = "DtgListeContact";
            this.DtgListeContact.RowTemplate.Height = 24;
            this.DtgListeContact.Size = new System.Drawing.Size(1071, 562);
            this.DtgListeContact.TabIndex = 0;
            this.DtgListeContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListeContact_CellClick);
            // 
            // GbxDetail
            // 
            this.GbxDetail.Controls.Add(this.LblEntreprise);
            this.GbxDetail.Controls.Add(this.LblService);
            this.GbxDetail.Controls.Add(this.LblTelephone);
            this.GbxDetail.Controls.Add(this.LblPrenom);
            this.GbxDetail.Controls.Add(this.LblNom);
            this.GbxDetail.Controls.Add(this.DTPDateEntree);
            this.GbxDetail.Controls.Add(this.LblDateA);
            this.GbxDetail.Controls.Add(this.LblEntrepriseA);
            this.GbxDetail.Controls.Add(this.LblServiceA);
            this.GbxDetail.Controls.Add(this.LblTelA);
            this.GbxDetail.Controls.Add(this.LblPrenomA);
            this.GbxDetail.Controls.Add(this.LblNomA);
            this.GbxDetail.Location = new System.Drawing.Point(1129, 17);
            this.GbxDetail.Name = "GbxDetail";
            this.GbxDetail.Size = new System.Drawing.Size(579, 435);
            this.GbxDetail.TabIndex = 1;
            this.GbxDetail.TabStop = false;
            this.GbxDetail.Text = "Detail";
            // 
            // LblEntreprise
            // 
            this.LblEntreprise.AutoSize = true;
            this.LblEntreprise.Location = new System.Drawing.Point(114, 233);
            this.LblEntreprise.Name = "LblEntreprise";
            this.LblEntreprise.Size = new System.Drawing.Size(0, 17);
            this.LblEntreprise.TabIndex = 11;
            // 
            // LblService
            // 
            this.LblService.AutoSize = true;
            this.LblService.Location = new System.Drawing.Point(110, 194);
            this.LblService.Name = "LblService";
            this.LblService.Size = new System.Drawing.Size(0, 17);
            this.LblService.TabIndex = 10;
            // 
            // LblTelephone
            // 
            this.LblTelephone.AutoSize = true;
            this.LblTelephone.Location = new System.Drawing.Point(114, 148);
            this.LblTelephone.Name = "LblTelephone";
            this.LblTelephone.Size = new System.Drawing.Size(0, 17);
            this.LblTelephone.TabIndex = 9;
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(110, 94);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(0, 17);
            this.LblPrenom.TabIndex = 8;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(110, 49);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(0, 17);
            this.LblNom.TabIndex = 7;
            // 
            // DTPDateEntree
            // 
            this.DTPDateEntree.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDateEntree.Location = new System.Drawing.Point(244, 282);
            this.DTPDateEntree.Name = "DTPDateEntree";
            this.DTPDateEntree.Size = new System.Drawing.Size(271, 22);
            this.DTPDateEntree.TabIndex = 6;
            // 
            // LblDateA
            // 
            this.LblDateA.AutoSize = true;
            this.LblDateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateA.Location = new System.Drawing.Point(27, 282);
            this.LblDateA.Name = "LblDateA";
            this.LblDateA.Size = new System.Drawing.Size(211, 17);
            this.LblDateA.TabIndex = 5;
            this.LblDateA.Text = "Date d\'entrée dans l\'entreprise :";
            // 
            // LblEntrepriseA
            // 
            this.LblEntrepriseA.AutoSize = true;
            this.LblEntrepriseA.Location = new System.Drawing.Point(26, 233);
            this.LblEntrepriseA.Name = "LblEntrepriseA";
            this.LblEntrepriseA.Size = new System.Drawing.Size(81, 17);
            this.LblEntrepriseA.TabIndex = 4;
            this.LblEntrepriseA.Text = "Entreprise :";
            // 
            // LblServiceA
            // 
            this.LblServiceA.AutoSize = true;
            this.LblServiceA.Location = new System.Drawing.Point(24, 194);
            this.LblServiceA.Name = "LblServiceA";
            this.LblServiceA.Size = new System.Drawing.Size(63, 17);
            this.LblServiceA.TabIndex = 3;
            this.LblServiceA.Text = "Service :";
            // 
            // LblTelA
            // 
            this.LblTelA.AutoSize = true;
            this.LblTelA.Location = new System.Drawing.Point(24, 148);
            this.LblTelA.Name = "LblTelA";
            this.LblTelA.Size = new System.Drawing.Size(84, 17);
            this.LblTelA.TabIndex = 2;
            this.LblTelA.Text = "Téléphone :";
            // 
            // LblPrenomA
            // 
            this.LblPrenomA.AutoSize = true;
            this.LblPrenomA.Location = new System.Drawing.Point(24, 94);
            this.LblPrenomA.Name = "LblPrenomA";
            this.LblPrenomA.Size = new System.Drawing.Size(65, 17);
            this.LblPrenomA.TabIndex = 1;
            this.LblPrenomA.Text = "Prenom :";
            // 
            // LblNomA
            // 
            this.LblNomA.AutoSize = true;
            this.LblNomA.Location = new System.Drawing.Point(24, 49);
            this.LblNomA.Name = "LblNomA";
            this.LblNomA.Size = new System.Drawing.Size(45, 17);
            this.LblNomA.TabIndex = 0;
            this.LblNomA.Text = "Nom :";
            // 
            // LblRecherche
            // 
            this.LblRecherche.AutoSize = true;
            this.LblRecherche.Location = new System.Drawing.Point(12, 17);
            this.LblRecherche.Name = "LblRecherche";
            this.LblRecherche.Size = new System.Drawing.Size(143, 17);
            this.LblRecherche.TabIndex = 2;
            this.LblRecherche.Text = "Recherche par Nom :";
            // 
            // TbxRecherche
            // 
            this.TbxRecherche.Location = new System.Drawing.Point(161, 14);
            this.TbxRecherche.Name = "TbxRecherche";
            this.TbxRecherche.Size = new System.Drawing.Size(275, 22);
            this.TbxRecherche.TabIndex = 3;
            // 
            // BtnRecherche
            // 
            this.BtnRecherche.Location = new System.Drawing.Point(442, 10);
            this.BtnRecherche.Name = "BtnRecherche";
            this.BtnRecherche.Size = new System.Drawing.Size(97, 30);
            this.BtnRecherche.TabIndex = 4;
            this.BtnRecherche.Text = "Recherche";
            this.BtnRecherche.UseVisualStyleBackColor = true;
            this.BtnRecherche.Click += new System.EventHandler(this.BtnRecherche_Click);
            // 
            // BtnReafficher
            // 
            this.BtnReafficher.Location = new System.Drawing.Point(985, 42);
            this.BtnReafficher.Name = "BtnReafficher";
            this.BtnReafficher.Size = new System.Drawing.Size(126, 30);
            this.BtnReafficher.TabIndex = 5;
            this.BtnReafficher.Text = "Réaffichage";
            this.BtnReafficher.UseVisualStyleBackColor = true;
            this.BtnReafficher.Click += new System.EventHandler(this.BtnReafficher_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Location = new System.Drawing.Point(23, 713);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(154, 41);
            this.Btn_Quitter.TabIndex = 6;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // FrmListeContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 754);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.BtnReafficher);
            this.Controls.Add(this.BtnRecherche);
            this.Controls.Add(this.TbxRecherche);
            this.Controls.Add(this.LblRecherche);
            this.Controls.Add(this.GbxDetail);
            this.Controls.Add(this.GbxListe);
            this.Name = "FrmListeContact";
            this.Text = "Liste des Contacts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListeContact_Load);
            this.GbxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeContact)).EndInit();
            this.GbxDetail.ResumeLayout(false);
            this.GbxDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxListe;
        private System.Windows.Forms.DataGridView DtgListeContact;
        private System.Windows.Forms.GroupBox GbxDetail;
        private System.Windows.Forms.Label LblRecherche;
        private System.Windows.Forms.TextBox TbxRecherche;
        private System.Windows.Forms.Button BtnRecherche;
        private System.Windows.Forms.Button BtnReafficher;
        private System.Windows.Forms.DateTimePicker DTPDateEntree;
        private System.Windows.Forms.Label LblDateA;
        private System.Windows.Forms.Label LblEntrepriseA;
        private System.Windows.Forms.Label LblServiceA;
        private System.Windows.Forms.Label LblTelA;
        private System.Windows.Forms.Label LblPrenomA;
        private System.Windows.Forms.Label LblNomA;
        private System.Windows.Forms.Label LblEntreprise;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Button Btn_Quitter;
    }
}

