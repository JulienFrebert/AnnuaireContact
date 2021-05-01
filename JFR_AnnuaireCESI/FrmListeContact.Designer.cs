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
            this.LblNom = new System.Windows.Forms.Label();
            this.DTPDateEntree = new System.Windows.Forms.DateTimePicker();
            this.LblDateA = new System.Windows.Forms.Label();
            this.LblEntrepriseA = new System.Windows.Forms.Label();
            this.LblServiceA = new System.Windows.Forms.Label();
            this.LblTelA = new System.Windows.Forms.Label();
            this.LblNomA = new System.Windows.Forms.Label();
            this.LblRechercheNom = new System.Windows.Forms.Label();
            this.TbxRechercheNom = new System.Windows.Forms.TextBox();
            this.BtnRechercheNom = new System.Windows.Forms.Button();
            this.BtnReafficher = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Btn_Generer = new System.Windows.Forms.Button();
            this.LblRechercheEntreprise = new System.Windows.Forms.Label();
            this.TbxRechercheEntreprise = new System.Windows.Forms.TextBox();
            this.BtnRechercheEntreprise = new System.Windows.Forms.Button();
            this.LblPrenomA = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.GbxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeContact)).BeginInit();
            this.GbxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxListe
            // 
            this.GbxListe.Controls.Add(this.DtgListeContact);
            this.GbxListe.Location = new System.Drawing.Point(23, 96);
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
            this.GbxDetail.Controls.Add(this.LblPrenom);
            this.GbxDetail.Controls.Add(this.LblPrenomA);
            this.GbxDetail.Controls.Add(this.LblEntreprise);
            this.GbxDetail.Controls.Add(this.LblService);
            this.GbxDetail.Controls.Add(this.LblTelephone);
            this.GbxDetail.Controls.Add(this.LblNom);
            this.GbxDetail.Controls.Add(this.DTPDateEntree);
            this.GbxDetail.Controls.Add(this.LblDateA);
            this.GbxDetail.Controls.Add(this.LblEntrepriseA);
            this.GbxDetail.Controls.Add(this.LblServiceA);
            this.GbxDetail.Controls.Add(this.LblTelA);
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
            // LblNomA
            // 
            this.LblNomA.AutoSize = true;
            this.LblNomA.Location = new System.Drawing.Point(24, 49);
            this.LblNomA.Name = "LblNomA";
            this.LblNomA.Size = new System.Drawing.Size(45, 17);
            this.LblNomA.TabIndex = 0;
            this.LblNomA.Text = "Nom :";
            // 
            // LblRechercheNom
            // 
            this.LblRechercheNom.AutoSize = true;
            this.LblRechercheNom.Location = new System.Drawing.Point(12, 17);
            this.LblRechercheNom.Name = "LblRechercheNom";
            this.LblRechercheNom.Size = new System.Drawing.Size(143, 17);
            this.LblRechercheNom.TabIndex = 2;
            this.LblRechercheNom.Text = "Recherche par Nom :";
            // 
            // TbxRechercheNom
            // 
            this.TbxRechercheNom.Location = new System.Drawing.Point(161, 14);
            this.TbxRechercheNom.Name = "TbxRechercheNom";
            this.TbxRechercheNom.Size = new System.Drawing.Size(275, 22);
            this.TbxRechercheNom.TabIndex = 3;
            // 
            // BtnRechercheNom
            // 
            this.BtnRechercheNom.Location = new System.Drawing.Point(442, 10);
            this.BtnRechercheNom.Name = "BtnRechercheNom";
            this.BtnRechercheNom.Size = new System.Drawing.Size(97, 30);
            this.BtnRechercheNom.TabIndex = 4;
            this.BtnRechercheNom.Text = "Recherche";
            this.BtnRechercheNom.UseVisualStyleBackColor = true;
            this.BtnRechercheNom.Click += new System.EventHandler(this.BtnRecherche_Click);
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
            this.Btn_Quitter.Location = new System.Drawing.Point(23, 736);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(154, 41);
            this.Btn_Quitter.TabIndex = 6;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Btn_Generer
            // 
            this.Btn_Generer.Location = new System.Drawing.Point(197, 736);
            this.Btn_Generer.Name = "Btn_Generer";
            this.Btn_Generer.Size = new System.Drawing.Size(154, 41);
            this.Btn_Generer.TabIndex = 7;
            this.Btn_Generer.Text = "Génération";
            this.Btn_Generer.UseVisualStyleBackColor = true;
            this.Btn_Generer.Click += new System.EventHandler(this.Btn_Generer_Click);
            // 
            // LblRechercheEntreprise
            // 
            this.LblRechercheEntreprise.AutoSize = true;
            this.LblRechercheEntreprise.Location = new System.Drawing.Point(12, 59);
            this.LblRechercheEntreprise.Name = "LblRechercheEntreprise";
            this.LblRechercheEntreprise.Size = new System.Drawing.Size(179, 17);
            this.LblRechercheEntreprise.TabIndex = 8;
            this.LblRechercheEntreprise.Text = "Recherche par Entreprise :";
            // 
            // TbxRechercheEntreprise
            // 
            this.TbxRechercheEntreprise.Location = new System.Drawing.Point(197, 59);
            this.TbxRechercheEntreprise.Name = "TbxRechercheEntreprise";
            this.TbxRechercheEntreprise.Size = new System.Drawing.Size(275, 22);
            this.TbxRechercheEntreprise.TabIndex = 9;
            // 
            // BtnRechercheEntreprise
            // 
            this.BtnRechercheEntreprise.Location = new System.Drawing.Point(478, 55);
            this.BtnRechercheEntreprise.Name = "BtnRechercheEntreprise";
            this.BtnRechercheEntreprise.Size = new System.Drawing.Size(97, 30);
            this.BtnRechercheEntreprise.TabIndex = 10;
            this.BtnRechercheEntreprise.Text = "Recherche";
            this.BtnRechercheEntreprise.UseVisualStyleBackColor = true;
            this.BtnRechercheEntreprise.Click += new System.EventHandler(this.BtnRechercheEntreprise_Click);
            // 
            // LblPrenomA
            // 
            this.LblPrenomA.AutoSize = true;
            this.LblPrenomA.Location = new System.Drawing.Point(27, 92);
            this.LblPrenomA.Name = "LblPrenomA";
            this.LblPrenomA.Size = new System.Drawing.Size(65, 17);
            this.LblPrenomA.TabIndex = 12;
            this.LblPrenomA.Text = "Prénom :";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(110, 92);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(0, 17);
            this.LblPrenom.TabIndex = 13;
            // 
            // FrmListeContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 821);
            this.Controls.Add(this.BtnRechercheEntreprise);
            this.Controls.Add(this.TbxRechercheEntreprise);
            this.Controls.Add(this.LblRechercheEntreprise);
            this.Controls.Add(this.Btn_Generer);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.BtnReafficher);
            this.Controls.Add(this.BtnRechercheNom);
            this.Controls.Add(this.TbxRechercheNom);
            this.Controls.Add(this.LblRechercheNom);
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
        private System.Windows.Forms.Label LblRechercheNom;
        private System.Windows.Forms.TextBox TbxRechercheNom;
        private System.Windows.Forms.Button BtnRechercheNom;
        private System.Windows.Forms.Button BtnReafficher;
        private System.Windows.Forms.DateTimePicker DTPDateEntree;
        private System.Windows.Forms.Label LblDateA;
        private System.Windows.Forms.Label LblEntrepriseA;
        private System.Windows.Forms.Label LblServiceA;
        private System.Windows.Forms.Label LblTelA;
        private System.Windows.Forms.Label LblNomA;
        private System.Windows.Forms.Label LblEntreprise;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.Button Btn_Generer;
        private System.Windows.Forms.Label LblRechercheEntreprise;
        private System.Windows.Forms.TextBox TbxRechercheEntreprise;
        private System.Windows.Forms.Button BtnRechercheEntreprise;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblPrenomA;
    }
}

