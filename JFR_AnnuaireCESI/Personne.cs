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
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Service { get; set; }
        public string Entreprise { get; set; }
        public DateTime DateEntree { get; set; }


        public Personne(string unNom,string unPrenom, string unTelephone, string unService, string uneEntreprise,DateTime uneDateEntree)
        {
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Telephone = unTelephone;
            this.Service = unService;
            this.Entreprise = uneEntreprise;
            this.DateEntree = uneDateEntree;
        }

        string v1 = "https://randomuser.me/api/";

    }

}



