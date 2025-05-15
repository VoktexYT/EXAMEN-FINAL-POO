using System;


namespace Tp3_VisionSante
{
    class Program
    {
        static Citoyen cit = new();
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                U.Titre("Execution Admin");
                ExecutionAdmin();
                return;
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            Menu menu = new Menu("Profils offerts");

            menu.AjouterOption(new MenuItem('C', "Profil citoyen", ProfilCitoyen));
            menu.AjouterOption(new MenuItem('P', "Profil professionnel de la santé", ProfilProfessionnelSante));

            menu.SaisirOption();
        
        }

        private static void ExecutionAdmin()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;

            Menu menu = new Menu("Profils offerts");

            menu.AjouterOption(new MenuItem('C', "Ajouter un citoyen", AjouterCitoyen));
            menu.AjouterOption(new MenuItem('P', "Ajouter un professionnel de la santé", AjouterProfesionnel));

            menu.SaisirOption();
        }

        private static void AjouterCitoyen()
        {
            U.CLS();
            U.Titre("Ajout d'un citoyen");
            U.P();
        }

        private static void AjouterProfesionnel()
        {
            U.CLS();
            U.Titre("Ajout d'un professionnel");
            U.P();
        }

        private static void ProfilCitoyen()
        {
            U.Entete();
            cit.AfficherSommaire();
        }

        private static void ProfilProfessionnelSante()
        {
            U.Entete();
            Professionnel ps = new();
            ps.AfficherSommaire();
        }
    }
}
