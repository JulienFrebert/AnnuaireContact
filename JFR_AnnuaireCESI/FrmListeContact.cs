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
using System.Net;
using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace JFR_AnnuaireCESI
{
    public partial class FrmListeContact : Form
    {

        #region Objet global 

        ManagerPersonn ObjBdd = new ManagerPersonn();

        string API_RAMDOM_USER = "https://randomuser.me/api/";

        HttpClient client = new HttpClient();


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

        #region Affichage et boutons

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

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Generer_Click(object sender, EventArgs e)
        {
            #region Récupération des valeurs

            var JSON = "";
                JSON =  getRamdomUser().GetAwaiter().GetResult();
           var data = JObject.Parse(JSON).SelectToken("results").ToObject<List<Personne>>().First();

            #endregion

            #region Instanciation de personne

            Personne.Name name = new Personne.Name(data.name.title.ToString(),data.name.first.ToString(),data.name.last.ToString()); // Instanciation de nom
            Personne.Registered dateentreprise = new Personne.Registered(data.registered.date); // Instanciation de la date d'entré dans l'entreprise
            Personne.ID entreprise = new Personne.ID(data.id.nom); // Instanciation du nom de l'entreprise 
            Personne personne = new Personne(name, dateentreprise, entreprise,data.phone); // Instanciation de la personne

            #endregion

            #region Attributions des valeurs

            LblNom.Text = (personne.name.title + " " + personne.name.last);
            LblPrenom.Text = name.first;
            LblEntreprise.Text = personne.id.nom;
            LblTelephone.Text = personne.phone;
            DTPDateEntree.Text = personne.registered.date.ToString();

            #endregion
        }

        #endregion

        #region DTGListeContact

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

        #endregion

        #region Appel API RandomUser

        async Task<string> getRamdomUser()
        {
            client.BaseAddress = new Uri(API_RAMDOM_USER);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var data = string.Empty;

            var reponse = await client.GetAsync(API_RAMDOM_USER).ConfigureAwait(false);

            if (reponse.IsSuccessStatusCode)
            {
                data = await reponse.Content.ReadAsStringAsync();
            }
            return data;
        }

        #endregion


    }
}
