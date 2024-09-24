using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_de_Algoritmos
{
    class Display
    {
        // This class has all the text that will be display in the terminal.
        // From the menus, to the exercise desciptions.
        public static void MainMenu()
        {
            Console.WriteLine("--- LABORATORIO DE ALGORITMOS ---");
            Console.WriteLine();
            Console.WriteLine("Selecciona una categoria para ver sus algoritmos.");
            Console.WriteLine("[1] Algoritmos de Búsqueda ");
            Console.WriteLine("[2] Algoritmos de Ordenamiento");
            Console.WriteLine("[3] Algoritmos Exahustivos y de Vuelta atrás");
            Console.WriteLine("[0] Cerrar programa");
            Console.WriteLine();
        }
        public static void SearchAlgoritmsMenu()
        {
            Console.WriteLine("- ALGORITMOS DE BUSQUEDA -");
            Console.WriteLine();
            Console.WriteLine("Selecciona un algoritmo para ejecutarlo.");
            Console.WriteLine("[1] Búsqueda Binaria en un Array Ordenado");
            Console.WriteLine("[2] Búsqueda Secuencial con Condición");
            Console.WriteLine("[3] Búsqueda de un Elemento Mayor que uno Dado");
            Console.WriteLine("[4] Búsqueda de Elementos Duplicados");
            Console.WriteLine("[0] Menú principal");
            Console.WriteLine();
        }
        public static void SortAlgoritmsMenu()
        {
            Console.WriteLine("- ALGORITMOS DE ORDENAMIENTO -");
            Console.WriteLine();
            Console.WriteLine("Selecciona un algoritmo para ejecutarlo.");
            Console.WriteLine("[1] Ordenación por Inserción");
            Console.WriteLine("[2] Ordenación por Selección");
            Console.WriteLine("[3] Ordenación por Burbuja Optimizada");
            Console.WriteLine("[4] Ordenación por Fusión");
            Console.WriteLine("[0] Menú principal");
            Console.WriteLine();
        }
        public static void E_B_AlgoritmsMenu()
        {
            Console.WriteLine("- ALGORITMOS DE BUSQUEDA EXHAUSTIVA -");
            Console.WriteLine();
            Console.WriteLine("Selcciona un algoritmo para ejecutarlo.");
            Console.WriteLine("[1] ");
            Console.WriteLine("[2] ");
            Console.WriteLine("[3] ");
            Console.WriteLine("[4] ");
            Console.WriteLine("[0] Menú principal");
            Console.WriteLine();
        }
        public static void ExersiceDescription(string title, string description)
        {
            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine();
        }

    }
}
