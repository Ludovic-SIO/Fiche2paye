using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2PAYE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****Fiche de paye association AAD ****");
            Console.WriteLine("Quel est votre nom ?");
            string Nom = Console.ReadLine();
            Console.WriteLine("Votre Nom est : {0}", Nom);
            Console.WriteLine("Quel est votre Prénom ?");
            string Prenom = Console.ReadLine();
            Console.WriteLine("Votre Prénom est : {0}", Prenom);
            Console.WriteLine("Quel est le mois ?");
            string Mois = Console.ReadLine();
            Console.WriteLine("Mois : {0}", Mois);
            Console.WriteLine("Combien d'heure avez vous travaillées ?");
            double nbHeureTravaillées = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nombre d'heure travaillées : {0}",nbHeureTravaillées);
            Console.WriteLine("Quelle est votre taux horaire ?");
            double tauxHoraire = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Taux horaires : {0}", tauxHoraire);
            Console.ReadKey();

        }
    }
}
