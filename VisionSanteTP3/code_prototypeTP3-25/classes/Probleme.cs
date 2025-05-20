namespace Tp3_VisionSante;

internal class Probleme
{
    public string NAS { get; set; }
    public string Nom { get; set; }
    public string Debut { get; set; }
    public string Guerison { get; set; }
    public string Description { get; set; }

    public Probleme(string nas, string nom, string debut, string guerison, string description)
    {
        NAS = nas;
        Nom = nom;
        Debut = debut;
        Guerison = guerison;
        Description = description;
    }

    public virtual void Ecrire(StreamWriter sw)
    {

    }
}
