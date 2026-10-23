namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */

        int Nbr_flèches = 5, Nbr_tir_réussis = 0, Nbr_tir_raté = 0;
        string tir_réussis = "?";


        int Nbr_flèches_restant = Nbr_flèches;
        while (Nbr_flèches_restant > 0 && Nbr_tir_réussis < 3)
        {
            tir_réussis = "?";
            while (tir_réussis != "Oui" && tir_réussis != "Non")
            {

                Console.WriteLine("Est-ce que vous avez réussis votre tir ?   Oui/Non");

                tir_réussis = Console.ReadLine();

                if (tir_réussis == "Oui")
                {
                    Console.WriteLine("Bien Jouer ^^");
                    Nbr_tir_réussis++;
                }
                else if (tir_réussis == "Non")
                {
                    Console.WriteLine("Dommage...");
                    Nbr_tir_raté++;
                }
                else
                {
                    Console.WriteLine("\nJe n'ai pas compris votre réponse.\nVeillez à bien répondre à la question !\n\n");
                }
            }
            Console.WriteLine("\n");
            Nbr_flèches_restant--;
        }
        Console.WriteLine("Fin de chasse!");

        Console.WriteLine("-----------------------------");
        Console.WriteLine("|  Tir réussis  -->  " + Nbr_tir_réussis + " tir  |");
        Console.WriteLine("|  Tir rater    -->  " + Nbr_tir_raté + " tir  |");
        Console.WriteLine("-----------------------------");

        //if (Nbr_tir_raté == 0)
        //{
        //    Console.WriteLine("Vous avez tirer parfaitement !!!");
        //}
        //else if (Nbr_tir_raté <= 2)
        //{
        //    Console.WriteLine("Super !");
        //}
        //else if (Nbr_tir_raté <= 4)
        //{
        //    Console.WriteLine("Il a des effort à faire mais vous ètes sur la bonne voie !\nCourage ^^");
        //}
        //else if (Nbr_tir_raté == 5)
        //{
        //    Console.WriteLine("Dommage !");
        //}
        //else
        //{
        //    Console.WriteLine("Il y a une erreur (x_x)");
        //}


        switch(Nbr_tir_raté)
        {
            case 0:
                Console.WriteLine("Vous avez tirer parfaitement !!!");
                break;

            case 1:
            case 2:
                Console.WriteLine("Super !");
                break;

            case 3:
            case 4:
                Console.WriteLine("Il a des effort à faire mais vous ètes sur la bonne voie !\nCourage ^^");
                break;

            case 5:
                Console.WriteLine("Dommage !");
                break;

            default :
                Console.WriteLine("Il y a une erreur (x_x)");
                break;
        }
    }
}