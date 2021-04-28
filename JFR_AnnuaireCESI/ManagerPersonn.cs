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
        /// <summary>
        /// Avec le nom de la table en paramètre affiche toutes les infos de cette table grâce aux PS enregistrées dans la base de données
        /// Nécessite ouverture préalable de la connexion et fermeture après utilisation du DataReader.
        /// Si l'id est spécifié, la requete select se fera avec une clause where portant sur la PK de la table avec comme valeur l'ID.
        /// </summary>
        /// <param name="Nom_PS">Une chaine: Nom de la table de la PS --> ENTREPRISE/ETUDIANT/...</param>
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

        /// <summary>
        /// Méthode qui permet de recherche une personne 
        /// </summary>
        /// <param name="Nom_PS"></param>
        /// <param name="recherche">un nom</param>
        /// <returns></returns>
        public MySqlDataReader SelectRecherche(string Nom_PS, string recherche)
        {
            MySqlCommand cmd = this.connexion.CreateCommand();
            try
            {
                cmd.CommandText = "CALL PS_S_W_R_" + Nom_PS + "(@Code)";
                cmd.Parameters.AddWithValue("@Code", recherche);
            }
            catch
            {
                MessageBox.Show("La recherche que vous avez faite ne correspond pas à une personne", "Erreur");
            }
            return cmd.ExecuteReader();
        }

        #endregion

    }
}
