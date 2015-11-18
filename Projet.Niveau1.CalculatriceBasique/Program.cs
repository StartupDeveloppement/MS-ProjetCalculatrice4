using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Affichage.AffichageCouleur("Bonjour maître Anis !", ConsoleColor.Yellow);
            TypeOperation();
        }

        private static void TypeOperation()
        {
            Affichage.AffichageCouleur("Quelle type d'opération souhaitez vous faire :", ConsoleColor.Red);
            Affichage.AffichageCouleur("1.Addition", ConsoleColor.DarkBlue);
            Affichage.Afficher("2.Soustraction");
            Affichage.Afficher("3.Multiplication");
            Affichage.Afficher("4.Division");
            


           int saisieClavier = Convert.ToInt16(Console.ReadLine());

            if (saisieClavier == 1)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var  calcul = new Calcul(premierChiffre, secondChiffre);
                var  resultat = calcul.addition();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (saisieClavier == 2)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.soustraction();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (saisieClavier == 3)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());
                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.multiplication();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (saisieClavier == 4)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());
                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.division();

                if (secondChiffre == 0)
                {
                    Console.WriteLine("Impossible de diviser par 0 !");
                    TypeOperation();
                        }

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
                
            }
           
            {
                Affichage.Afficher("Mauvaise saisie");
                TypeOperation();
            }
        }
    }
}