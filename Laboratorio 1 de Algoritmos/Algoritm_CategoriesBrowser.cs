using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Laboratorio_1_de_Algoritmos
{
    class Algoritm_CategoriesBrowser
    {
        // It browses all the searching algoritms exercises.
        public static void SearchAlgoritmsCategory()
        {
            int algortimNumber, result, number;
            do
            {
                // Stores a randomly generated array.
                int[] generatedArray = ExtraFunctions.RandomArrayGenerator();
                Console.Clear();

                // Validates the user input
                Display.SearchAlgoritmsMenu();
                algortimNumber = ExtraFunctions.NumberValidation("Número de algoritmo: ");

                Console.Clear();
                switch (algortimNumber)
                {
                    case 0: algortimNumber = 0; break; // Breaks the while cycle. It returns to the main menu

                    // Exercise 1
                    case 1:
                        Display.ExersiceDescription("-- Búsqueda Binaria en un Array Ordenado --",
                            "Funcionamiento: Encuentra el indice de un número dado en el arreglo.");
                        Array.Sort(generatedArray);
                        ExtraFunctions.ShowArray("ordenados", generatedArray);
                        number = ExtraFunctions.NumberValidation("Ingrese un número entero: ");
                        result = Search_Algoritms_Exercises.Exercise1(generatedArray, number);
                        ExtraFunctions.ExerciseResultConvertor(result,
                            $"El indice del número es: {result}", "No existe ese número en el arreglo");
                        break;

                    // Exercise 2
                    case 2:
                        Display.ExersiceDescription("-- Búsqueda Secuencial con Condición --",
                            "Funcionamiento: Muestra el índice del primer número que puede ser divisible por 3.");
                        ExtraFunctions.ShowArray("desordenados", generatedArray);
                        result = Search_Algoritms_Exercises.Exercise2(generatedArray);
                        ExtraFunctions.ExerciseResultConvertor(result,
                            $"El indice del número divisible es: {result}.", "No hay un número divisible por 3.");
                        break;

                    // Exercise 3
                    case 3:
                        Display.ExersiceDescription("-- Búsqueda de un Elemento Mayor que uno Dado --",
                            "Funcionamiento: Muestra el índice del primer número que es mayor a un número ingresado.");
                        ExtraFunctions.ShowArray("desordenados", generatedArray);
                        number = ExtraFunctions.NumberValidation("Ingresa un número entero: ");
                        result = Search_Algoritms_Exercises.Exercise3(generatedArray, number);
                        ExtraFunctions.ExerciseResultConvertor(result,
                            $"El indice del número mayor al número ingresado es: {result}",
                            "No hay un número mayor al número ingresado.");
                        break;

                    // Exercise 4
                    case 4:
                        Display.ExersiceDescription("-- Búsqueda de Elementos Duplicados --",
                            "Funcionamiento: Muestra si el arreglo tiene elementos duplicados.");
                        ExtraFunctions.ShowArray("desordenados", generatedArray);
                        result = Search_Algoritms_Exercises.Exercise4(generatedArray);
                        ExtraFunctions.ExerciseResultConvertor(result,
                            "El arreglo tiene elementos duplicados.", "El arreglo no tiene elementos duplicados.");
                        break;

                    // If the input number is not between 0-4.
                    default:
                        Console.WriteLine("Porfavor utilice otro número."); break;

                }
                Console.ReadKey();
            } while (algortimNumber != 0);
        }


        // It browses all the sorting algoritms exercises.
        public static void SortAlgoritmsCategory()
        {
            int algortimNumber;
            int[] organizedArray;
            string description = "Funcionamiento: Ordena un arreglo desordenado";
            do
            {
                // Stores a randomly generated array.
                int[] deorganizedArray = ExtraFunctions.RandomArrayGenerator();
                Console.Clear();
                Display.SortAlgoritmsMenu();

                algortimNumber = ExtraFunctions.NumberValidation("Número de algoritmo: "); // Validates the user input

                Console.Clear();
                switch (algortimNumber)
                {
                    case 0: algortimNumber = 0; break; // Breaks the while cycle. It returns to the main menu

                    // Exercise 1
                    case 1:
                        Display.ExersiceDescription("-- Ordenación por Inserción -- ", description);
                        ExtraFunctions.ShowArray("desordenados", deorganizedArray);
                        //organizedArray = Sort_Algoritms_Exercises.Exercise1();
                        organizedArray = Sort_Algoritms_Exercises.Exercise1(deorganizedArray);
                        ExtraFunctions.ShowArray("ordenados", organizedArray);
                        break;

                    // Exercise 2
                    case 2:
                        Display.ExersiceDescription("-- Ordenación por Selección -- ", description);
                        ExtraFunctions.ShowArray("desordenados", deorganizedArray);
                        organizedArray = Sort_Algoritms_Exercises.Exercise2(deorganizedArray);
                        ExtraFunctions.ShowArray("ordenados", organizedArray);
                        break;

                    // Exercise 3
                    case 3:
                        Display.ExersiceDescription("-- Ordenación por Burbuja Optimizada -- ", description);
                        ExtraFunctions.ShowArray("desordenados", deorganizedArray);
                        organizedArray = Sort_Algoritms_Exercises.Exercise3(deorganizedArray);
                        ExtraFunctions.ShowArray("ordenados", organizedArray);
                        break;

                    // Exercise 4
                    case 4:
                        Display.ExersiceDescription("-- Ordenación por Fusión (MergeSort) -- ", description);
                        ExtraFunctions.ShowArray("desordenados", deorganizedArray);
                        organizedArray = Sort_Algoritms_Exercises.Exercise4(deorganizedArray);
                        ExtraFunctions.ShowArray("ordenados", organizedArray);
                        break;

                    // If the user input another number
                    default:
                        Console.WriteLine("Porfavor utilice otro número."); break;
                }
                Console.ReadKey();
            } while (algortimNumber != 0);
        }

        public static void E_B_AlgoritmsCategory()
        {
            int algortimNumber, result, number;
            do
            {
                int[] deorganizedArray = ExtraFunctions.RandomArrayGenerator();
                Console.Clear();
                Display.SearchAlgoritmsMenu();
                algortimNumber = ExtraFunctions.NumberValidation("Número de algoritmo: ");

                Console.Clear();
                switch (algortimNumber)
                {
                    case 0: algortimNumber = 0; break;
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    default:
                        Console.WriteLine("Porfavor utilice otro número."); break;
                }
                Console.ReadKey();
            } while (algortimNumber != 0);
        }
    }
}
