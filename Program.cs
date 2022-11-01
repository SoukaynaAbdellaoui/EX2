using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] T = new int[10];
                //N la taille du tableau ,i pour rechercher la position,E l'element a inserer 
                int N, i, E, p = 0;

                Console.WriteLine("entrer la taille du tableau:");
                N = Convert.ToInt32(Console.ReadLine());
                // la saisie des elements du tableau 
                Console.WriteLine("entrer {0} element du tableau on ordre croissant : \r\n");

                for (i = 0; i < N; i++)
                {
                    Console.WriteLine("element - {0} : ", i);

                    T[i] = Convert.ToInt32(Console.ReadLine());

                }
                //saisir l'element E 
                Console.WriteLine("saisir la valeur du l'element a inserer : \n");
                E = Convert.ToInt32(Console.ReadLine());

                Console.Write("le tableau avant insertion  :\n ");
                for (i = 0; i < N; i++)
                    Console.Write("{0} ", T[i]);

                //chercher la position de E
                for (i = 0; i < N; i++)
                    if (E < T[i])
                    {
                        p = i;
                        break;
                    }
                // decaler les element du tableau
                for (i = N; i >= p; i--)
                    T[i] = T[i - 1];
                //insertion de l'element a son emplacement 
                T[p] = E;

                //affichage du tableau apres insertion
                Console.Write("\n\n le tableau apres l'insertion :\n ");
                for (i = 0; i <= N; i++)
                    Console.Write("{0} ", T[i]);
                Console.Write("\n");
            Console.ReadKey(); 
     




       }

        
    }
    
}
