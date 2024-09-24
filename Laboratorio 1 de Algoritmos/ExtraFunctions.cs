using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Laboratorio_1_de_Algoritmos
{
    class ExtraFunctions
    {
        // This class has multiple functions that complement the exercises.
        public static int NumberValidation(string text)
        {
            sbyte exerciseNumber;
            Console.Write(text);
            string userInput = Console.ReadLine();
            bool isvalid = sbyte.TryParse(userInput, out exerciseNumber);
            if (isvalid == true)
                return exerciseNumber;

            return -1;
        }
        public static void ExerciseResultConvertor(int result, string ifFound, string notFound)
        {
            Console.WriteLine();
            if (result == -1)
                Console.WriteLine(notFound);
            else
                Console.WriteLine(ifFound);
        }
        public static int[] RandomArrayGenerator()
        {
            Random randomNumber = new Random();
            int[] generatedArray = new int[randomNumber.Next(6, 9)];
            for (int x = 0; x < generatedArray.Length; x++)
            {
                generatedArray[x] = randomNumber.Next(1, 20);
            }
            return generatedArray;
        }
        public static void ShowArray(string typeOfArray, int[] array)
        {
            Console.WriteLine($"Elementos {typeOfArray}: {string.Join(", ", array)}");
        }


        /* Seccion previouslly used for the Sort_Algoritims_Exercises.Exercise2() 
         * 
        public static int ArraySmallestValueIndex(int[] array, int firstIndex)
        {
            int minValue = array[firstIndex];
            int index = 0;
            // Traverses the array index by index searching for the true smallest element.
            for (int i = firstIndex; i < array.Length -1; i++)
            {
                // If the value of the next index is smaller than the value of the first index of the array:
                if (array[i] < minValue)
                {
                    // Sets the next index value to be the smallest.
                    minValue = array[i];
                    index = i;
                }
                Console.WriteLine(minValue);
                Console.WriteLine();
            }
            return index; // Return the index of the smallest element.
         }
        */
    }
}
