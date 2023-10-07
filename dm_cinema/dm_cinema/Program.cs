using dm_cinema;
using DM_cinema;
public class Program
{
    private static void Main(string[] args)
    {
        Cinema monCinema = new Cinema();
        Acteur a1 = new Acteur("13/06/1942", 1, "Ford", "Harisson");
        Acteur a2 = new Acteur("09/07/1956", 2, "Hanks", "Tom");

        monCinema.AjouterActeur(a1);
        monCinema.AjouterActeur(a2);

        Film f1 = new Film("1982", "Science-Fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner",a1);
        Film f2 = new Film("1992", "Animation", 2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.", "Toy Story",a2);

        monCinema.ajouterFilm(f1);
        monCinema.ajouterFilm(f2);

        Console.WriteLine(monCinema.ToString());


    } 
}