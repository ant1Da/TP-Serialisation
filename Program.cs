namespace TP_Serialisation___Gestions_d_une_liste_de_jeux_vidéo;

class Program
{
    static void Main(string[] args)
    {
        JeuVideo jeu1 = new JeuVideo("Minecraft", "Mojang", 29.99);
        JeuVideo jeu2 = new JeuVideo("Mario Kart 8 Deluxe", "Nintendo", 59.99);
        JeuVideo jeu3 = new JeuVideo("The Witcher 3: Wild Hunt", "CD Projekt", 39.99);
        GestionJeux gestionJeux = new GestionJeux(new List<JeuVideo>());
        gestionJeux.AjouterJeu(jeu1);
        gestionJeux.AjouterJeu(jeu2);
        gestionJeux.AjouterJeu(jeu3);
        gestionJeux.AfficherJeux();
    }
}
