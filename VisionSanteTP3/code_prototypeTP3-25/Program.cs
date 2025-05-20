namespace Tp3_VisionSante;

internal  class Program
{
    static void Main(string[] args)
    {
        Parseur.ChargerPopulation();
        Parseur.ChargerProblemes();
        
        Menu menu = new Menu("Profils offerts");

        menu.AjouterOption(new MenuItem('C', "Ajouter un citoyen", AjouterCitoyen));
        menu.AjouterOption(new MenuItem('P', "Ajouter un probleme", AjouterProbleme));

        menu.SaisirOption();
    }

    private static void AjouterCitoyen()
    {
        Utilitaire.ViderEcran();
        Utilitaire.Titre("Ajout d'un citoyen");
        
        Console.Write("Nom: ");
        string? nom = Console.ReadLine();
        
        Console.Write("Naissance: ");
        string? naissance =  Console.ReadLine();
        
        Citoyen citoyen = new(nom, naissance);
        Utilitaire.Populations.Add(citoyen);
        
        Parseur.DechargerPopulation();
        Console.WriteLine("Population enregistrée!");
        Utilitaire.Pause();
    }

    private static void AjouterProbleme()
    {
        Utilitaire.ViderEcran();
        Utilitaire.Titre("Ajout d'un probleme");
        
        Console.Write("NAS: ");
        string? nas = Console.ReadLine();
        
        Console.Write("Nom: ");
        string? nom = Console.ReadLine();
        
        Console.Write("Date début (aaaa-mm-jj): ");
        string? debut = Console.ReadLine();
        
        Console.Write("Date guérison (aaaa-mm-jj): ");
        string? guerison = Console.ReadLine();
        
        Console.Write("Description: ");
        string? description = Console.ReadLine();
        
        Console.Write("Blessure (b) ou maladie (m): ");
        char choix = char.ToLower(Utilitaire.RecupererCaractere());
        
        if (choix  == 'b')
        {
            Blessure blessure = new(nas, nom, debut, guerison, description);
            Utilitaire.Problemes.Add(blessure);
        }
        
        else if (choix == 'm')
        {
            Console.Write("Stade (1,2,3,4): ");
            string? stade = Console.ReadLine();
            
            Maladie maladie = new(nom, nas, debut, guerison, description, stade);
            Utilitaire.Problemes.Add(maladie);
        }

        else
        {
            Console.WriteLine("Erreur dans l'enregistrement des informations. Enregistrement annulé!");
            Utilitaire.Pause();
            return;
        }
        
        Parseur.DechargerProbleme();
        Console.WriteLine("\nProbleme enregistré!");
        Utilitaire.Pause();
    }
}
