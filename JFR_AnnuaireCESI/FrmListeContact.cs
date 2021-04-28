using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace JFR_AnnuaireCESI
{
    public partial class FrmListeContact : Form
    {

        #region Objet global 

        ManagerPersonn ObjBdd = new ManagerPersonn();

        #endregion

        #region Procédures

        private void affichageContact()
        {
            ObjBdd.OpenConnexion();
            MySqlDataReader sdrListe = ObjBdd.Select("PERSONNE");
            DataTable Dt1 = new DataTable();
            Dt1.Load(sdrListe);
            DtgListeContact.DataSource = Dt1;
            DtgListeContact.ReadOnly = true;
            DtgListeContact.Refresh();
            DtgListeContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgListeContact.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            ObjBdd.CloseConnexion();
        }

        private void affichageRecherche()
        {
            if (TbxRecherche.Text != "")
            {
                ObjBdd.OpenConnexion();
                MySqlDataReader sdrListe = ObjBdd.SelectRecherche("PERSONNE", TbxRecherche.Text);
                DataTable Dt1 = new DataTable();
                Dt1.Load(sdrListe);
                DtgListeContact.DataSource = Dt1;
                DtgListeContact.ReadOnly = true;
                DtgListeContact.Refresh();
                DtgListeContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DtgListeContact.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                ObjBdd.CloseConnexion();
            }

        }

        #endregion

        public FrmListeContact()
        {
            InitializeComponent();
        }

        private void FrmListeContact_Load(object sender, EventArgs e)
        {
            affichageContact();
        }

        private void BtnRecherche_Click(object sender, EventArgs e)
        {
            affichageRecherche();
        }

        private void BtnReafficher_Click(object sender, EventArgs e)
        {
            affichageContact();
        }

        private void DtgListeContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region Récupération des valeurs 
            string Nom = DtgListeContact.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Prenom = DtgListeContact.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Telephone = DtgListeContact.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Service = DtgListeContact.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Date = DtgListeContact.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Entreprise = DtgListeContact.Rows[e.RowIndex].Cells[5].Value.ToString();
            #endregion

            #region Attributions des valeurs 
            LblNom.Text = Nom;
            LblPrenom.Text = Prenom;
            LblTelephone.Text = Telephone;
            LblService.Text = Service;
            DTPDateEntree.Text = Date;
            LblEntreprise.Text = Entreprise;
            #endregion
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Generer_Click(object sender, EventArgs e)
        {

        }
    }
}
