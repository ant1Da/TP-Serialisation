class GestionJeux
{
    private List<JeuVideo> jeux;
    public GestionJeux(List<JeuVideo> jeux)
    {
        this.jeux = jeux;
    }
    public void AfficherJeux()
    {
        foreach (var jeu in jeux)
        {
            jeu.AfficherDetails();
            Console.WriteLine("-----------------------");
        }
    }
    public void AjouterJeu(JeuVideo jeu)
    {
        jeux.Add(jeu);
    }
    public void SupprimerJeu(string titre)
    {
        jeux.RemoveAll(j => j.getTitre() == titre);
    }
}