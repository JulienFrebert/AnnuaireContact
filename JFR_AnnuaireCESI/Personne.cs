using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JFR_AnnuaireCESI
{
    public class Personne
    {
        public string gender { get; set; }
        public Name name { get; set; }
        public string email { get; set; }
        public Registered registered { get; set; }
        public ID id { get; set; }
        public string phone { get; set; }

        #region Constructeur 

        public Personne(Name unNom, Registered unRegistered, ID unid, string unphone)
        {
            this.name = unNom;
            this.registered = unRegistered;
            this.id = unid;
            this.phone = unphone;
        }

        #endregion

        #region Nom
        public class Name
        {
            public string title { get; set; }
            public string first { get; set; }
            public string last { get; set; }

            #region Constructeur 

            public Name(string unTitre, string unPrenom, string unNom)
            {
                this.title = unTitre;
                this.first = unPrenom;
                this.last = unNom;
            }
            #endregion
        }

        #endregion

        #region Entreprise

        #region Date d'entrée
        public class Registered
        {
            public DateTime date { get; set; }

            #region Constructeur
            public Registered(DateTime unedate)
            {
                this.date = unedate;
            }
            #endregion
        }
        #endregion



        #region NomEntreprise
        public class ID
        {
            public string name { get; set; }
            public string value { get; set; }

            #region Constructeur 
            public ID(string unNom, string unService)
            {
                this.name = unNom;
                this.value = unService;
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
    







