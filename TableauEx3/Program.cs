using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauEx3
{
    class Program
    {
        int ContrôleEtSaisie(int[] Tableau)
        {
            int Température = 0;

            for(int Elements = 0; Elements < Tableau.Length; Elements ++)
            {
                bool Correct = false;
                while(!Correct)
                {
                    try
                    {
                        Température = int.Parse(Console.ReadLine());
                        Correct = true;
                        Tableau[Elements] = Température;
                        
                    }
                    catch
                    {
                        Console.WriteLine("Erreur");
                    }
                }
            }
            return int[] Tableau;
        }
        static void Main(string[] args)
        {
            /* Le programme doit permettre de saisir plusieurs températures entières, forcément entre -20 et +40 (il faut
            contrôler la saisie). Le nombre de températures doit être saisi dès le début du programme. Au final, pour
            chaque température, il faut afficher sa fréquence (le nombre de fois où cette température a été saisie).
            On ne s’inquiètera pas du problème lié à une saisie erronée au niveau du type d’une variable */

            Console.WriteLine("Veuillez saisir le nombre de températures");
            int[] Tableau = new int[int.Parse(Console.ReadLine())];


            Console.WriteLine();
            
        }
    }
}
