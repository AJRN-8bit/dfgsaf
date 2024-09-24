using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_de_Algoritmos
{
    // This class has all the search algoritm exercises.
    class Search_Algoritms_Exercises
    {
        
        public static int Exercise1(int[] array, int number)
        {
            // Binary Search
            try
            {


                int middleIndex;
                int firstIndex = 0;
                int lastIndex = array.Length - 1;
                do // Does a while cycle until the middle element has the same value as the input number.
                {
                    // For every cycle the middle index is set.
                    middleIndex = (lastIndex + firstIndex) / 2;

                    // If the middle element of the array has the same value as the input number:
                    if (array[middleIndex] == number)
                    {
                        return middleIndex; // Returns that index.
                    }
                    // If the input number is bigger than the middle element:
                    else if (array[middleIndex] < number)
                    {
                        /* By increasing to the next index, it forgets about the non useful
                        elements and start reaching the bigger numbers. */
                        firstIndex++;
                    }
                    // If the input number is smaller than the middel element:
                    else
                    {
                        /* By decreasing to the previous index, it forgets about the non useful
                        elements and start reaching the smaller numbers. */
                        firstIndex--;
                    }
                    // It repeats it self until by increasing or decreasing, the middle element is the same as the imput number.
                }
                while (middleIndex != number);
            }
            catch (Exception){ Console.WriteLine("Porfavor introduzca un número entero."); }
            return -1;
            
            /* This code was not used due to not being able to return the index correctly
            // Previous code.

            if (array.Length <= 0) // No array has to be null. 
            {
                return -1;
            }

            int middle = (lastIndex - firstIndex) / 2;

            if (array[middle] == number)
            {
                return middle;
            }
            if (array[middle] < number)
            {
                Exercise1(array, number, firstIndex -1, array.Length -1);
            }
            else
            {
                Exercise1(array, number, firstIndex +1, array.Length - 1);
            }
            // It works, it only fails to return middle.
            return -1;
            */
         }
        
    

        public static int Exercise2(int[] array)
        {
            // Secuencial Search with Condition.

            // The array is traversed to search if an element is divisible by 3.
            // From the index 0 to the last index of the array.
            for (int index = 0; index < array.Length -1; index++)
            {
                // If an element is divisible by 3:
                if (array[index] % 3 == 0)
                {
                    // It returns the index of the element.
                    return index;
                }
            }
            // If there is no element divisible, it return -1.
            return -1;
        }
        public static int Exercise3(int[] array, int number)
        {
            // Search of a bigger number.

            // The array is traversed to search if an element has higher value than a specific number. 
            // From the index 0 to the last index of the array.
            for (int index = 0; index < array.Length - 1; index++)
            {
                // If an element is bigger than the input number:
                if (array[index] > number)
                {
                    // Returns the index of the element of higher value.
                    return index;
                }
            }
            // If there is no element with higher value it return a -1.
            return -1;
        }
        public static int Exercise4(int[] array)
        {
            // Search for duplicated elements.

            // An increment interger is created.
            int increment = 0;
            // For every element in the array, the next "for" cycle traverses the array.
            foreach(int element in array)
            {
                increment++; // It increments by 1. This allows the element to not count itself.
                // From the index 0 to the last index of the array.
                for (int index = increment; index < array.Length - 1; index++)
                {
                    // If the element is the same as the element in the array index it returns true.
                    if (element == array[index])
                    {
                        return 1; // Counts as true.
                    }
                }
            } // If theres is no duplicated numbers it return false.
            return -1; // Counts as false.
        }
    }
}
