using DM_cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Film
    {
        private string annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film() { }

        public Film(string annee, string genre, int idFilm, string resume, string titre,Acteur actprincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = actprincipal;
        }

        public string Annee { get => annee; set => annee = value; }
        public string Genre { get => genre; set => genre = value; }
        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Titre { get => titre; set => titre = value; }
        public Acteur ActeurPrincipal { get => acteurPrincipal; set => acteurPrincipal = value; }

        public override string ToString()
        {
            return "Titre: " + titre + " Année: " + annee + " Genre: " + genre + " Résumé: " + resume+" Acteur Principal :"+acteurPrincipal ;
        }
    }

}
