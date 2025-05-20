namespace Tp3_VisionSante;

internal class Blessure : Probleme
{
    public Blessure(string nas, string nom, string debut, string guerison, string description) 
        : base(nas, nom, debut, guerison, description)
    { 
        
    }
    public override void Ecrire(StreamWriter sw)
    {
        sw.WriteLine($"{NAS};{Nom};{Debut};{Guerison};{Description}");
    }
}
