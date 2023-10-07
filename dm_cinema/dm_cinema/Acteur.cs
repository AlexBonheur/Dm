using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_cinema
{
    public class Acteur
    {
        private string anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur() { }    

        public Acteur(string anneeNaiss,int id, string nom, string prenom)
        {
            this.AnneeNaissance = anneeNaiss;
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public string AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public override string ToString()
        {
            return "Nom: "+nom+" Prénom: "+prenom+" année de naissance: "+anneeNaissance ;
        }
    }
}
