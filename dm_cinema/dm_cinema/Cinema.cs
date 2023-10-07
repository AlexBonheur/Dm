using dm_cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_cinema
{
    public class Cinema
    {
        private List<Acteur> lesActeurs;
        private List<Film> LesFilms;

        public Cinema() 
        {
            this.LesActeurs = new List<Acteur>();
            this.LesFilms = new List<Film>();
        }
        

        public List<Acteur> LesActeurs { get => lesActeurs; set => lesActeurs = value; }
        public List<Film> LesFilms1 { get => LesFilms; set => LesFilms = value; }

        public Acteur getActeur(int id)
        {
            foreach (Acteur acteur in lesActeurs)
            {
                if (acteur.Id == id)
                {
                    return acteur;
                }
            }
            return null; 
        }

        public Film getFilm(int id)
        {
            foreach (Film film in LesFilms)
            {
                if (film.IdFilm == id)
                {
                    return film;
                }
            }
            return null;
        }

        public void AjouterActeur( Acteur acteur)
        {
           lesActeurs.Add(acteur);
        }

        public void ajouterFilm(Film film)
        {
            LesFilms.Add(film);
        }

        

        public  int nbrActeur()
        {
            return LesActeurs.Count;
        }

        public void setFilm(string annee, string genre, int id, string resume, string titre, Acteur actprinc)
        {
            Film film = new Film(annee, genre, id, resume, titre, actprinc);
            ajouterFilm(film); 
        }

        public void setActeur(string anneeNaiss, int id, string nom, string prenom)
        {
            Acteur act = new Acteur(anneeNaiss,id,nom,prenom);
            AjouterActeur(act);
        }

        public override string ToString()
        {
            Console.WriteLine("Liste des acteurs :");

            foreach (Acteur acteur in lesActeurs)
            {
                Console.WriteLine($"ID : {acteur.Id} Nom : {acteur.Nom} Prénom : {acteur.Prenom} Année de naissance : {acteur.AnneeNaissance}\n");
                
            }

            Console.WriteLine("Liste des films :");

            foreach (Film film in LesFilms)
            {
                Console.WriteLine($"Année : {film.Annee}\r\n Genre : {film.Genre}\r\n Id : {film.IdFilm}\r\n Résumé : {film.Resume}\r\n Titre : {film.Titre}\r\n Acteur Principal : {film.ActeurPrincipal} \n");
            }

            return "";
        }
    }
}

