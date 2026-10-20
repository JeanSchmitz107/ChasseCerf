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

        int Nbr_flèches = 5, Nbr_tir_réussis = 0;
        string tir_réussis = "?";

        Console.WriteLine("Est-ce que vous avez réussis votre tir ?");

        while ((tir_réussis != "Oui") || tir_réussis != "Non")
        {
            tir_réussis = "?";

            Console.WriteLine("Est-ce que vous avez réussis votre tir ?   Oui/Non");

            tir_réussis = Console.ReadLine();

            if (tir_réussis == "Oui")
            {
                Nbr_tir_réussis++;
            }
            else if (tir_réussis == "Non")
            {
                Console.WriteLine("Dommage...");
            }
            else
            {
                Console.WriteLine("Je n'ai pas compris votre réponse.\n Veillez à bien répondre à la question !\n");
            }

        }
        Nbr_flèches--;

        
    }
}