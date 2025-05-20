namespace Tp3_VisionSante;

internal class Maladie : Probleme
{
    public string Stade { get; set; }

    public Maladie(string nas, string nom, string debut, string guerison, string description, string stade)
        : base(nas, nom, debut, guerison, description)
    {
        Stade = stade;
    }

    public override void Ecrire(StreamWriter sw)
    {
        sw.WriteLine($"{NAS};{Nom};{Debut};{Guerison};{Description};{Stade}");
    }
}
