using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace JFR_AnnuaireCESI
{
    class ManagerPersonn
    {
        #region Attributs
        private MySqlConnection connexion; //Objet permettant la connexion
        private static string connectionString = "SERVER=127.0.0.1; DATABASE=annuaire ; UID=root; PASSWORD="; //Identifiants de connexion à la BD
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur de la classe ManagerPersonn
        /// Appelle la méthode "InitConnexion"
        /// </summary>
        public ManagerPersonn()
        {
            this.InitConnexion();
        }
        #endregion

        #region Méthodes de Connection/Déconnection
        /// <summary>
        /// Effectue la connexion à la base de données
        /// </summary>
        public void InitConnexion()
        {
            try
            {
                this.connexion = new MySqlConnection(connectionString);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("Impossible de se connecter au serveur de base de données: " + probleme.Message);
            }
        }

        /// <summary>
        /// Ouvre la connexion à la base de données
        /// </summary>
        public void OpenConnexion()
        {
            this.connexion.Open();
        }

        /// <summary>
        /// Ferme la connexion à la base de données
        /// </summary>
        public void CloseConnexion()
        {
            this.connexion.Close();
        }
        #endregion

        #region Select

        #region Select 
        /// <summary>
        /// </summary>
        /// <param name="Nom_PS">Une chaine: Nom de la table </param>
        /// <param name="id">Un entier: Valeur par défaut à -1.</param>
        /// <returns>Retourne les résultats</returns>
        public MySqlDataReader Select(string Nom_PS, int id = -1)
        {
            MySqlCommand cmd = this.connexion.CreateCommand();
            if (id == -1)
            {
                cmd.CommandText = "CALL PS_S_" + Nom_PS;
            }
            else
            {
                cmd.CommandText = "CALL PS_S_W_" + Nom_PS + "(@Code)";
                cmd.Parameters.AddWithValue("@Code", id);
            }
            return cmd.ExecuteReader();
        }
        #endregion

        #region Select Where

        /// <summary>
        /// Méthode qui permet de recherche une personne par Nom
        /// </summary>
        /// <param name="Nom_PS"></param>
        /// <param name="recherche">un nom</param>
        /// <returns></returns>
        public MySqlDataReader SelectRechercheNom(string Nom_PS, string recherche)
        {
            MySqlCommand cmd = this.connexion.CreateCommand();
            try
            {
                cmd.CommandText = "CALL PS_S_W_N_" + Nom_PS + "(@Code)";
                cmd.Parameters.AddWithValue("@Code", recherche);
            }
            catch
            {
                MessageBox.Show("La recherche que vous avez faite ne correspond pas à une personne", "Erreur");
            }
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// Méthode qui permet de recherche une personne par Entreprise
        /// </summary>
        /// <param name="Nom_PS"></param>
        /// <param name="recherche">un nom</param>
        /// <returns></returns>
        public MySqlDataReader SelectRechercheEntreprise(string Nom_PS, string recherche)
        {
            MySqlCommand cmd = this.connexion.CreateCommand();
            try
            {
                cmd.CommandText = "CALL PS_S_W_E_" + Nom_PS + "(@Code)";
                cmd.Parameters.AddWithValue("@Code", recherche);
            }
            catch
            {
                MessageBox.Show("La recherche que vous avez faite ne correspond pas à une personne", "Erreur");
            }
            return cmd.ExecuteReader();
        }

        #endregion

        #endregion

        #region Insertion
        /// <summary>
        /// Permet d'insérer une nouvelle Personne dans la BD
        /// </summary>
        /// <param name="unePersonne">une Personne </param>
        public void InsertPersonne(Personne unePersonne)
        {
            try
            {
                // Ouverture de la connexion
                this.OpenConnexion();
                MySqlCommand cmd = this.connexion.CreateCommand();
                // Exécution de la PS --> PS_I_PERSONNE
                cmd.CommandText = "CALL PS_I_PERSONNE(@Titre,@Nom,@Prenom,@Telephone,@Service,@DateEntree,@Entreprise)";
                // Attribution des paramétres 
                cmd.Parameters.AddWithValue("@Titre", unePersonne.name.title);
                cmd.Parameters.AddWithValue("@Nom", unePersonne.name.last);
                cmd.Parameters.AddWithValue("@Prenom", unePersonne.name.first);
                cmd.Parameters.AddWithValue("@Telephone", unePersonne.phone);
                cmd.Parameters.AddWithValue("@Service", unePersonne.id.value);
                cmd.Parameters.AddWithValue("@DateEntree", unePersonne.registered.date);
                cmd.Parameters.AddWithValue("@Entreprise", unePersonne.id.name);
                cmd.ExecuteNonQuery();
                this.CloseConnexion();
            }
            catch (MySqlException probleme)
            {
                MessageBox.Show(probleme.Message);
                this.CloseConnexion();
            }
        }
        #endregion

    }
}
