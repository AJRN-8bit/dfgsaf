using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Laboratorio_1_de_Algoritmos
{
    class Sort_Algoritms_Exercises
    {
        public static int[] Exercise1(int[] array)
        {
            // Insertion Sort algoritm

            // For the number of elements in the array, the cycle continues. 
            for (int index = 0; index < array.Length; index++)
            {
                int position = index; // This is made to use the value of the rotation without affecting the cycle.
                int storedValue = array[index]; // It stores the current value the that index.
                int previousIndex = position - 1;
                /* It reads: while the position of the element is greater than 0 and the value of previous index is 
                greater than the value of the current index, change the current value with the previous value*/
                while ((position > 0) && (array[previousIndex] > storedValue))
                {
                    array[position] = array[previousIndex];
                    position--; // It traverses the array backwards to reach the left side index.
                }
                array[position] = storedValue; // Sets the stored value to the left side of the array.
            }
            return array;
        }
        public static int[] Exercise2(int[] array)
        {
            // Selection Sort algortim

            // For the number of elements in the array, the cycle continues. 
            for (int elementPlace = 0; elementPlace < array.Length -1; elementPlace++)
            {
                int firstIndex = elementPlace; // This is made to use the value of the rotation without affecting the cycle.

                // Traverses the array index by index. Starts with a +1 to not count the same element.
                for (int index = elementPlace + 1; index < array.Length; index++)
                {
                    // If the value of the current index is smaller than the value of the first index. 
                    if (array[index] < array[firstIndex])
                    {
                        // Swaps the indexes, this to evaluate again if there is a smaller value.
                        firstIndex = index;
                    }
                }
 
                // The element of the first element is stored.
                int storedValue = array[elementPlace];
                // The value of the element is change to the smallest value.
                array[elementPlace] = array[firstIndex];
                // The value that was in the first index is now set in the original index of the smallest value.
                array[firstIndex] = storedValue;
                // It basically switches the values.
            }
            return array;

            // Previous code
            /*
            // For the number of elements in the array, the cycle continues. 
            for (int index = 0; index < array.Length - 1; index++)
            {
                // It resumes the second for cycle.
                int minValueIndex = ExtraFunctions.ArraySmallestValueIndex(array, index, array[index]);
                if (array[index] > array[minValueIndex])
                {
                    int storedValue = array[index];
                    array[index] = array[minValueIndex];
                    array[minValueIndex] = storedValue;
                }
                //Console.WriteLine(array[index]);
            }
            */
            //return array;
        }
        public static int[] Exercise3(int[] array)
        {
            // Bubble Sort algoritm

            int[] orgArray = new int[array.Length];
            Array.Copy(array, orgArray, array.Length);
            Array.Sort(orgArray);


            // For the number of elements in the array, the cycle continues. 
            for (int element = 1; element < array.Length; element++)
            {
                // Traverses the array index by index.
                for (int index = 0; index < array.Length-1; index++)
                {
                    // If an element has less value than the next element, it moves the next element to the previous index.
                    int nextIndex = index + 1;
                    if (array[index] > array[nextIndex])
                    {
                        // The element is store in a variable
                        int storedElement = array[nextIndex];
                        // The value of the next index is placed in the previous index.
                        array[nextIndex] = array[index];
                        // The variable sets the value of the next element.
                        array[index] = storedElement;
                        // It basically switches the values.
                    }
                }
            }
            return array; // Returns the organized array.
        }
    }
}
