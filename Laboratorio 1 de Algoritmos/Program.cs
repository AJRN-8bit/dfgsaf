using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_de_Algoritmos
{
    internal class AlgoritmExercises
    {
        static void Main(string[] args)
        {
            do
            {
                int exerciseNumber;
                Console.Clear();
                Display.MainMenu();

                Console.Write("Número de categoria: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out exerciseNumber);
                if (exerciseNumber != 0)
                {
                    AllCategoriesExecution(exerciseNumber);
                }
                else
                {
                    Console.WriteLine("Porfavor use un número entero.");
                    Console.ReadKey();
                }
            } while (true);
        }

        static void AllCategoriesExecution(int exerciseNumber)
        {
            switch (exerciseNumber)
            {
                case 0:
                    Environment.Exit(0); break;
                case 1:
                    Algoritm_CategoriesBrowser.SearchAlgoritmsCategory();
                    break;

                case 2:
                    Algoritm_CategoriesBrowser.SortAlgoritmsCategory();
                    break;

                case 3:
                    Algoritm_CategoriesBrowser.E_B_AlgoritmsCategory();
                    break;

                default:
                    Console.WriteLine("Porfavor utilize otro número."); break;
            }
        }
    }
}
