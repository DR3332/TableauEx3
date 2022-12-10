using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauEx3
{
    class Program
    {


        static int ControleErreur(int MauvaiseTemperature)
        {
            int Temperature = MauvaiseTemperature;
            Temperature = 0;
            bool Correct = false;
            while (!Correct)
            {
                try
                {

                    Temperature = int.Parse(Console.ReadLine());
                    Correct = true;


                }
                catch
                {
                    Console.WriteLine("Erreur");
                    Correct = false;
                }
            }
            return Temperature;
        }
        static int ControleTemperature(int Temperature)
        {
            int BonneTemperature = 0;
            while (Temperature < -20 || Temperature > 40)
            {
                Console.WriteLine("Erreur");
                int MauvaiseTemperature = 0;
                MauvaiseTemperature = Temperature;
                Temperature = ControleErreur(MauvaiseTemperature);
            }

            BonneTemperature = Temperature;

            return BonneTemperature;
        }

  
        static int[] SaisieFinale(int[] Tableau)
        {
            for(int Elements = 0; Elements < Tableau.Length; Elements ++)
            {
                
                Console.WriteLine("Veuillez saisir vos températures entières entre -20 et 40 degrés : ");
                Console.WriteLine();
                Tableau[Elements] = ControleTemperature(ControleErreur(0)); ;
            }
            return Tableau;
        }
        static void Main(string[] args)
        {
            /* Le programme doit permettre de saisir plusieurs températures entières, forcément entre -20 et +40 (il faut
            contrôler la saisie). Le nombre de températures doit être saisi dès le début du programme. Au final, pour
            chaque température, il faut afficher sa fréquence (le nombre de fois où cette température a été saisie).
            On ne s’inquiètera pas du problème lié à une saisie erronée au niveau du type d’une variable */

            Console.WriteLine("Veuillez saisir le nombre de températures : ");
            int[] TableauInitialisé = new int[int.Parse(Console.ReadLine())];
            int []TableauFinal = SaisieFinale(TableauInitialisé);

            int[] Compteur = new int[TableauFinal.Length]; // Je souhaite faire mon compteur ici.
            for(int J = 0; J < TableauFinal.Length; J ++)
            {
                
            }
            
            for(int K = 0; K < TableauFinal.Length; K ++)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(TableauFinal[K]);
            }
            Console.ReadLine();
            
        }
    }
}
