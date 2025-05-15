﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_VisionSante
{
    class Professionnel
    {
        public string? CodePS;

        public Professionnel()
        {
            CodePS = "";
        }
        public bool AfficherSommaire()
        {
            U.W("Code PS du professionnel désiré:");
            if (CodePS == "")
                CodePS = U.RL();
            
            U.Entete();
            U.WL("\n------------------------------------------------------------------");
            U.WL("Nom: \t\tLouise Décarie, chirurgienne cardiaque");
            U.WL("Né le:\t\t1969-11-15");
            Console.WriteLine("Code PS:\t{0}", CodePS);
            U.WL("\n------------------------------------------------------------------");

            U.WL("Historique");
            U.WL("\t\t801 patients");
            U.WL("\t\t2508 interventions");
            U.WL("\n");

            Menu menuPS = new Menu("Consulter patients ou interventions de Louise Décarie?", false);
            menuPS.AjouterOption(new MenuItem('P', "Patients", AfficherPatients));
            menuPS.AjouterOption(new MenuItem('I', "Interventions", AfficherInterventions));
            menuPS.SaisirOption();

            return true;
         
        }
 
  

        public void AfficherPatients()
        {
            U.Entete();
            AfficherOptionTri();
            SaisirOptionTri();
            U.CLS();

            U.Entete();
            U.WL("Patients de Louise Décarie");
            U.WL("------------------------------------");
            Console.WriteLine("{0,-30} {1,5}{2,12} {3,5}", "Nom", "NAS", "Naissance", " Nb Interv");
            U.WL("_________________________________________________________________________________");
            Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Diane Lemay", "5231", "1964-07-01", "18");
            Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Éric Brais", "4531", "1968-07-25", "3");
            Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Frédériane Boulay", "7234", "1984-07-01", "1");
            Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Mohamed Khadary", "6613", "1991-12-11", "2");
            Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Koricot M'Jeda", "7801", "1993-04-30", "42");
            Console.WriteLine("{0,-30} {1,5} {2,12} {3,5}", "Roslyn Hangemayd-Laramee", "8032", "2004-08-28", "9");
            U.P();
           
        }

        public void AfficherInterventions()
        {
            U.Entete();
            AfficherOptionTriIntervention();
            SaisirOptionTriIntervention();
            U.CLS();

            U.Entete();

            U.WL("Interventions de Louise Décarie");
            U.WL("-----------------------------------------------------");
            Console.WriteLine("{0,-30} {1,4} {2,-12}   {3,-20}", "Patient", "NAS", "  Date", "Établissement");
            U.WL("________________________________________________________________________________");
            Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Diane Lemay", "5231", "1980-01-15", "CLSC du Sud");
            Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Diane Lemay", "5231", "1981-01-15", "CLSC du Sud");
            Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Eric Brais", "4531", "1979-11-15", "CH de St-Jérôme");
            Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Frédériane Boulay", "7234", "1999-09-15", "CLSC du Nord");
            Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Koricot M'Jeda", "7801", "2003-09-15", "Clinique MTS");
            Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Koricot M'Jeda", "7801", "2004-03-15", "Clinique MTS");
            Console.WriteLine("{0,-30} {1,4} {2,12}   {3,-20}", "Koricot M'Jeda", "7801", "2004-09-23", "Clinique MTS");
            U.P();
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
            U.Entete();
            U.WL("\t\t\tPatients de Louise Décarie triés par\n");
            U.WL("\t\t\tn-naissance .:");
            U.WL("\t\t\tN-Naissance :.");
            U.WL("\t\t\ta-nAS .:");
            U.WL("\t\t\tA-NAS :.");
            U.WL("\t\t\to-nom .:");
            U.WL("\t\t\tO-Nom :.");
            U.WL("\t\t\ts-sans tri");
        }

        private static void AfficherOptionTriIntervention()
        {
            U.Entete();
            U.WL("\t\tInterventions de Louise Décarie triées par\n");
            U.WL("\t\td-date .:");
            U.WL("\t\tD-Date :.");
            U.WL("\t\te-établissement .:");
            U.WL("\t\tE-Établissement :.");
            U.WL("\t\ta-nas .:");
            U.WL("\t\tA-Nas :.");
            U.WL("\t\tn-nom .:");
            U.WL("\t\tN-Nom :.");
            U.WL("\t\ts-sans tri");
        }
    }
}
