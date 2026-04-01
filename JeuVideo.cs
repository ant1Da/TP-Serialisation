using System.ComponentModel.DataAnnotations;
using System.Dynamic;

class JeuVideo
{
    private string Titre { get; set; }
    private string Studio { get; set; }
    private double prix { get; set; }
    public string getTitre()
    {
        return Titre;
    }
    public string getStudio()
    {
        return Studio;
    }
    public double getPrix()
    {
        return prix;
    }
    public void setTitre(string titre)
    {
        Titre = titre;
    }
    public void setStudio(string studio)
    {
        Studio = studio;
    }
    public void setPrix(double prix)
    {
        this.prix = prix;
    }
    public JeuVideo(string titre, string studio, double prix)
    {
        this.setTitre(titre);
        this.setStudio(studio);
        this.setPrix(prix);
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"Titre: {getTitre()}");
        Console.WriteLine($"Studio: {getStudio()}");
        Console.WriteLine($"Prix: {getPrix():C}");
    }
}