namespace Tp3_VisionSante;

internal class Parseur
{
    public static void ChargerPopulation()
    {
        if (File.Exists(Utilitaire.FICHIER_POPULATION))
        {
            StreamReader lectureFichierPopulation = new(Utilitaire.FICHIER_POPULATION);
            string? ligne;

            while (lectureFichierPopulation.Peek() != -1)
            {
                ligne = lectureFichierPopulation.ReadLine();

                if (ligne != null)
                {
                    string[] ligneCoupee = ligne.Split(Utilitaire.SEPARATEUR_FICHIER);

                    Citoyen citoyen = new(
                        ligneCoupee[0],
                        ligneCoupee[1],
                        ligneCoupee[2]);
                    Utilitaire.Populations.Add(citoyen);
                }
            }
            
            lectureFichierPopulation.Close();
        }

        else
        {
            Console.WriteLine("Erreur 404 : " + Utilitaire.FICHIER_POPULATION);
        }
    }

    public static void DechargerPopulation()
    {
        if (File.Exists(Utilitaire.FICHIER_POPULATION))
        {
            StreamWriter sw = new StreamWriter(Utilitaire.FICHIER_POPULATION, false);

            foreach (Citoyen citoyen in Utilitaire.Populations)
            {
                sw.WriteLine($"{citoyen.NAS};{citoyen.Nom};{citoyen.Naissance}");
            }
            
            sw.Close();
        }
    }
    
    public static void DechargerProbleme()
    {
        if (File.Exists(Utilitaire.FICHIER_PROBLEME))
        {
            StreamWriter sw = new StreamWriter(Utilitaire.FICHIER_PROBLEME, false);

            foreach (Probleme probleme in Utilitaire.Problemes)
            {
                probleme.Ecrire(sw);
            }
            
            sw.Close();
        }
    }

    public static void ChargerProblemes()
    {
        if (File.Exists(Utilitaire.FICHIER_PROBLEME))
        {
            StreamReader lectureFichierProbleme = new(Utilitaire.FICHIER_PROBLEME);
            string? ligne;

            while (lectureFichierProbleme.Peek() != -1)
            {
                ligne = lectureFichierProbleme.ReadLine();

                if (ligne != null)
                {
                    string[] ligneCoupee = ligne.Split(Utilitaire.SEPARATEUR_FICHIER);

                    if (ligneCoupee.Length == Utilitaire.TAILLE_CHAMP_BLESSURE)
                    {
                        Blessure blessure = new(
                            ligneCoupee[0],
                            ligneCoupee[1],
                            ligneCoupee[2],
                            ligneCoupee[3],
                            ligneCoupee[4]);

                        Utilitaire.Problemes.Add(blessure);
                    }

                    else if (ligneCoupee.Length == Utilitaire.TAILLE_CHAMP_MALADIE)
                    {
                        Maladie maladie = new(
                            ligneCoupee[0],
                            ligneCoupee[1],
                            ligneCoupee[2],
                            ligneCoupee[3],
                            ligneCoupee[4],
                            ligneCoupee[5]);

                        Utilitaire.Problemes.Add(maladie);
                    }
                }
            }
            
            lectureFichierProbleme.Close();
        }

        else
        {
            Console.WriteLine("Erreur 404 : " + Utilitaire.FICHIER_PROBLEME);
        }
    }
}