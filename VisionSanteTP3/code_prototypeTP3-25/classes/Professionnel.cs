﻿namespace Tp3_VisionSante;

internal class Professionnel
{
    public string? CodePS;

    public Professionnel()
    {
        CodePS = "";
    }
    public bool AfficherSommaire()
    {
        Console.Write("Code PS du professionnel désiré:");
        if (CodePS == "")
            CodePS = Console.ReadLine();
        
        Utilitaire.Entete();
        Console.WriteLine("\n------------------------------------------------------------------");
        Console.WriteLine("Nom: \t\tLouise Décarie, chirurgienne cardiaque");
        Console.WriteLine("Né le:\t\t1969-11-15");
        Console.WriteLine("Code PS:\t{0}", CodePS);
        Console.WriteLine("\n------------------------------------------------------------------");

        Console.WriteLine("Historique");
        Console.WriteLine("\t\t801 patients");
        Console.WriteLine("\t\t2508 interventions");
        Console.WriteLine("\n");

        Menu menuPS = new Menu("Consulter patients ou interventions de Louise Décarie?", false);
        menuPS.AjouterOption(new MenuItem('P', "Patients", AfficherPatients));
        menuPS.AjouterOption(new MenuItem('I', "Interventions", AfficherInterventions));
        menuPS.SaisirOption();

        return true;
     
    }



    public void AfficherPatients()
    {
        Utilitaire.Entete();
        AfficherOptionTri();
        SaisirOptionTri();
        Utilitaire.ViderEcran();

        Utilitaire.Entete();
        Console.WriteLine("Patients de Louise Décarie");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("{0,-30} {1,5}{2,12} {3,5}", "Nom", "NAS", "Naissance", " Nb Interv");
        Console.WriteLine("_________________________________________________________________________________");
        Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Diane Lemay", "5231", "1964-07-01", "18");
        Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Éric Brais", "4531", "1968-07-25", "3");
        Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Frédériane Boulay", "7234", "1984-07-01", "1");
        Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Mohamed Khadary", "6613", "1991-12-11", "2");
        Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Koricot M'Jeda", "7801", "1993-04-30", "42");
        Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Roslyn Hangemayd-Laramee", "8032", "2004-08-28", "9");
        Utilitaire.Pause();
       
    }

    public void AfficherInterventions()
    {
        Utilitaire.Entete();
        AfficherOptionTriIntervention();
        SaisirOptionTriIntervention();
        Utilitaire.ViderEcran();

        Utilitaire.Entete();

        Console.WriteLine("Interventions de Louise Décarie");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("{0,-30} {1,4} {2,-12}   {3,-20}", "Patient", "NAS", "  Date", "Établissement");
        Console.WriteLine("________________________________________________________________________________");
        Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Diane Lemay", "5231", "1980-01-15", "CLSC du Sud");
        Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Diane Lemay", "5231", "1981-01-15", "CLSC du Sud");
        Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Eric Brais", "4531", "1979-11-15", "CH de St-Jérôme");
        Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Frédériane Boulay", "7234", "1999-09-15", "CLSC du Nord");
        Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Koricot M'Jeda", "7801", "2003-09-15", "Clinique MTS");
        Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Koricot M'Jeda", "7801", "2004-03-15", "Clinique MTS");
        Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Koricot M'Jeda", "7801", "2004-09-23", "Clinique MTS");
        Utilitaire.Pause();
    }


    private static string SaisirOptionTri()
    {
        ConsoleKeyInfo keyInfo;
        AfficherOptionTri();
        string optionTri = "";
        keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key.ToString())
        {
            case "n":
            case "N":
            case "a":
            case "A":
            case "o":
            case "O":
            case "s":
            case "S":
                optionTri = "N";
                return optionTri;
            default:
                return "quitter";
        }
    }

    private static string SaisirOptionTriIntervention()
    {
        ConsoleKeyInfo keyInfo;
        AfficherOptionTriIntervention();
        string optionTri = "";
        keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key.ToString())
        {
            case "d":
            case "D":
            case "e":
            case "E":
            case "n":
            case "N":
            case "s":
            case "S":
                optionTri = "N";
                return optionTri;
            default:
                return "quitter";
        }
    }

    private static void AfficherOptionTri()
    {
        Utilitaire.Entete();
        Console.WriteLine("\t\t\tPatients de Louise Décarie triés par\n");
        Console.WriteLine("\t\t\tn-naissance .:");
        Console.WriteLine("\t\t\tN-Naissance :.");
        Console.WriteLine("\t\t\ta-nAS .:");
        Console.WriteLine("\t\t\tA-NAS :.");
        Console.WriteLine("\t\t\to-nom .:");
        Console.WriteLine("\t\t\tO-Nom :.");
        Console.WriteLine("\t\t\ts-sans tri");
    }

    private static void AfficherOptionTriIntervention()
    {
        Utilitaire.Entete();
        Console.WriteLine("\t\tInterventions de Louise Décarie triées par\n");
        Console.WriteLine("\t\td-date .:");
        Console.WriteLine("\t\tD-Date :.");
        Console.WriteLine("\t\te-établissement .:");
        Console.WriteLine("\t\tE-Établissement :.");
        Console.WriteLine("\t\ta-nas .:");
        Console.WriteLine("\t\tA-Nas :.");
        Console.WriteLine("\t\tn-nom .:");
        Console.WriteLine("\t\tN-Nom :.");
        Console.WriteLine("\t\ts-sans tri");
    }
}
