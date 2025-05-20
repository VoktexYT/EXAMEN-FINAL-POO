namespace Tp3_VisionSante;

internal class Utilitaire
{
    public static Random Rdm = new Random();

    // public const string DOSSIER_RACINE = "C/utopia/BD";
    public const string DOSSIER_RACINE = "/home/voktex/BD";
    public const string FICHIER_POPULATION = $"{DOSSIER_RACINE}/population.txt";
    public const string FICHIER_PROBLEME = $"{DOSSIER_RACINE}/problemes.txt";

    public const char SEPARATEUR_FICHIER = ';';
    
    public const int TAILLE_CHAMP_CITOYEN = 3;
    public const int TAILLE_CHAMP_PROFESSIONNEL = 5;
    public const int TAILLE_CHAMP_BLESSURE = 5;
    public const int TAILLE_CHAMP_MALADIE = 6;

    public static List<Citoyen> Populations = new();
    public static List<Probleme> Problemes = new();

    //----------------------------------------------
    //
    //----------------------------------------------
    static public void Entete()
    {
        ViderEcran();

        W("\t\t\t");
        for (int i = 0; i < 33; i++)
            W("_");

        W("\t\t\t");
        WL("\n\t\t\t|\t\t\t\t|\n\t\t\t|\tUbert Guertin\t\t|\n\t\t\t|\tprésente\t\t|\n\t\t\t|\tVISION SANTÉ\t\t|");
        W("\t\t\t");
        W("|");
        for (int i = 0; i < 31; i++)
            W("_");

        W("|");
        WL("\n");
    }
    private static void WL(string s= "")
    {
        Console.WriteLine(s);
    }
    private static void W(string s)
    {
        Console.Write(s);
    }
    public static void Pause(string msg="")
    {
        WL("\n\n" + msg);
        W("Appuyez sur une touche...");
        Console.ReadLine();
    }

    public static void ViderEcran()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
    }
    public static void Titre(string t, bool cls=true)
    {
        if (cls)
        {
            Utilitaire.ViderEcran();
            Entete();
        }
        foreach (Char c in t)
        {
            W("-");
        }
        WL("\n" + t);
        foreach (Char c in t)
        {
            W("-");
        }
        WL();
    }

    public static char RecupererCaractere()
    {
        ConsoleKeyInfo cle = Console.ReadKey();
        return cle.KeyChar;
    }

    public static void Separateur(string texte)
    {
        WL(texte);
        foreach(char c in texte)
        {
            W("_");
        }
        WL();
    }

}
