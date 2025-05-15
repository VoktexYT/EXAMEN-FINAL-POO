using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp3_VisionSante
{
    class Citoyen
    {
        public string? NAS { get; set; }

        public string? Nom {  get; set; }
        public string? Naissance {  get; set; }

        private static int _prochainNAS = 0;

        public Citoyen(string nas, string nom, string naissance)
        {
            NAS = nas;
            Nom = nom;
            Naissance = naissance;

            if (int.Parse(nas) > _prochainNAS)
            {
                _prochainNAS = int.Parse(nas);
            }
        }

        public Citoyen(string nom, string naissance)
        {
            Nom = nom;
            Naissance = naissance;
            _prochainNAS++;
            NAS = _prochainNAS.ToString();
        }


        public Citoyen()
        {
            NAS = "";
        }
        
        public bool AfficherSommaire()
        {
            U.W("NAS du citoyen désiré:");
            NAS = U.RL();

            U.WL("\n------------------------------------------------------------------");
            U.WL("Nom: \t\tPascale Bisonnette");
            U.WL("Né le:\t\t1968-07-25");
            U.WL("NAS:\t\t" + NAS);
            U.WL("\n------------------------------------------------------------------");

            U.WL("Historique");
            U.WL("\t8 problèmes");
            U.WL("\t9 ressources utilisées");
            U.WL("\n");

            Menu menuCitoyen = new Menu("Consulter problèmes ou ressources?", false);
            menuCitoyen.AjouterOption(new MenuItem('P', "Problèmes", AfficherSommaireProblemes));
            menuCitoyen.AjouterOption(new MenuItem('R', "Ressources", AfficherSommaireRessources));
            menuCitoyen.SaisirOption();
          
            return true;
        }

        public void AfficherSommaireProblemes()
        {
            U.Entete();
            U.WL("Problèmes médicaux de Pascale Bisonnette\n----------------------------------------\n");
            U.WL("\t4 maladies");
            U.WL("\t3 blessures");

            U.WL("\n");

            Menu menuProb = new Menu("Consulter blessures ou maladies?", false);
            menuProb.AjouterOption(new MenuItem('B', "Blessures", AfficherBlessures));
            menuProb.AjouterOption(new MenuItem('M', "Maladies", AfficherMaladies));
            menuProb.AjouterOption(new MenuItem('T', "Tous problèmes", AfficherTousProblemes));
          
            menuProb.SaisirOption();
           
        }


        public void AfficherSommaireRessources()
        {
            U.Entete();
            U.WL("Ressources utilisées par Pascale Bisonnette\n----------------------------------------\n");
            U.WL("\t3 rendez-vous");
            U.WL("\t2 hospitalisations");

            U.WL("\n");

            Menu menuRess = new Menu("Consulter Rendez-Vous ou Hospitalisations?", false);
            menuRess.AjouterOption(new MenuItem('R', "Rendez-vous", AfficherRendezVous));
            menuRess.AjouterOption(new MenuItem('H', "Hospitalisation", AfficherHospitalisations));
            menuRess.AjouterOption(new MenuItem('T', "Toutes les ressources", AfficherToutesRessources));
            menuRess.SaisirOption();
        }

        public void AfficherBlessures()
        {
            U.Entete();
            U.WL("Blessures de Pascale Bisonnette:\n");
            U.WL("Type            Début      Guérison   Description ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Fracture", "2020-03-24", "2020-03-26", "Fracture ouverte du tibia");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Brûlure", "2019-06-21", "2019-08-31", "Brûlure 2ième degr au visage");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Contusion", "2017-12-24", "2018-02-11", "Hématome majeur suite à un accident d'auto");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Intoxication", "2007-03-02", "2007-03-21", "Perte de vision suite à surdose d'alcool");
           
            U.P();
        }
        public void AfficherMaladies()
        {
            U.Entete();
            U.WL("Maladies de Pascale Bisonnette:\n");
            U.WL("Pathologie             Stade  Début    Guérison   Commentaire ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Schlérose en plaques", "3", "1998-01-24", "", "État chronique mais stable");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Cancer de la prostate", "1", "2008-01-24", "2013-01-31", "Aucune récidive après plus de 5 ans");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Gonorrhée", "1", "1998-01-24", "1998-02-14", "Guérison après antibiotiques");

            U.P();
        }
        public void AfficherTousProblemes()
        {
            U.Entete();
            U.WL("Problèmes médicaux de Pascale Bisonnette:\n");
            
            U.WL("Blessures:");
            U.WL("Type            Début      Guérison   Description ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Fracture", "2020-03-24", "2020-03-26", "Fracture ouverte du tibia");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Brûlure", "2019-06-21", "2019-08-31", "Brûlure 2ième degr au visage");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Contusion", "2017-12-24", "2018-02-11", "Hématome majeur suite à un accident d'auto");
            Console.WriteLine("{0,-13} {1,11} {2,11} {3,-30}", "Intoxication", "2007-03-02", "2007-03-21", "Perte de vision suite à surdose d'alcool");
            U.WL( );
            U.WL("Maladies:");
            U.WL("Pathologie             Stade  Début    Guérison   Commentaire ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Schlérose en plaques", "3", "1998-01-24", "", "État chronique mais stable");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Cancer de la prostate", "1", "2008-01-24", "2013-01-31", "Aucune récidive après plus de 5 ans");
            Console.WriteLine("{0,-22} {1,3} {2,11} {3,11} {4,-30}", "Gonorrhée", "1", "1998-01-24", "1998-02-14", "Guérison après antibiotiques");
            U.P();
        }

        public void AfficherRendezVous()
        {
            U.Entete();
            U.WL("Rendez-vous de Pascale Bisonnette:\n");
            Console.WriteLine("{0,-22} {1,-12} {2,8}", "Établissement", "  Date", "Code PS");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CLSC Rosemère", "2022-02-13", "NC-103");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "Clinique MTS", "2012-02-13", "MG-803");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CH St-Jérôme", "2017-02-13", "UR-504");

            U.P();
        }
        public void AfficherHospitalisations()
        {
            U.Entete();
            U.WL("Hospitalisations  de Pascale Bisonnette:\n");
            Console.WriteLine("{0,-22} {1,-12} {2,8} {3,-8} {4,-12}", "Établissement", "  Arrivée", "Code PS", "Chambre", "  Départ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CUSM", "2022-02-03", "NC-103", "233", "");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CH Hotel Dieu", "1995-12-03", "MG-512", "D-1233", "1996-02-03");
            U.P();

        }
        public void AfficherToutesRessources()
        {
            U.Entete();
            U.WL("Ressources utilisées par Pascale Bisonnette:\n");
            U.WL("--------------------------------------");
            U.WL("Rendez-vous:");
            Console.WriteLine("{0,-22} {1,-12} {2,8}", "Établissement", "  Date", "Code PS");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CLSC Rosemère", "2022-02-13", "NC-103");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "Clinique MTS", "2012-02-13", "MG-803");
            Console.WriteLine("{0,-22} {1,12} {2,8}", "CH St-Jérôme", "2017-02-13", "UR-504");
            U.WL();
            U.WL("Hospitalisations:");
            Console.WriteLine("{0,-22} {1,-12} {2,8} {3,-8} {4,-12}", "Établissement", "  Arrivée", "Code PS" , "Chambre", "  Départ");
            U.WL("_________________________________________________________________");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CUSM", "2022-02-03", "NC-103", "233", "");
            Console.WriteLine("{0,-22} {1,12} {2,8} {3,-8} {4,12}", "CH Hotel Dieu", "1995-12-03", "MG-512", "D-1233", "1996-02-03");
            U.P();
        }
    }
}
