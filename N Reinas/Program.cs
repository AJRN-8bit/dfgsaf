using N_Reinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Reinas
{
    class NReinas
    {
        private int[,] board;
        private int size;

        public NReinas(int n)
        {
            size = n;
            board = new int[n, n];
        }

        // Show the board on the console.
        private void ShowBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] == 1)
                        Console.Write("Q");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Verifies if the array cell is safe to use.
        private bool IsSafe(int row, int col)
        {
            // Rows
            for (int i = 0; i < row; i++)
            {
                if (board[i, col] == 1)
                    return false;
            }

            // Up-Left diagonal
            for (int i = row, j = col; i >= 0 && j <= 0; i--, j--)
			{
                if (board[i, j] == 1)
                    return false;
            }

            // Up-Right diagonal
            for (int i = row, j = col; i >= 0 && j < size; i--, j++)
			{
                if (board[i, j] == 1)
                    return false;
            }
            return true;
        }

        private bool Resolve(int row)
        {
            if (row >= size)
                return false;
            for (int col = 0; col < size; col++)
            {
                if (IsSafe(row, col))
                    board[row, col] = 1;
                if (Resolve(row + 1))
                    return true;
                board[row, col] = 0;
            }
            return false;
        }

        public void NQueensResolve()
        {
            if (Resolve(0))
                ShowBoard();
            else
                Console.WriteLine($"The is no solution for the {size} size.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad de Reinas (n): ");
                int n = int.Parse(Console.ReadLine());
                NReinas nReinas = new NReinas(n);
                nReinas.NQueensResolve();

                Console.ReadKey();
            } while (true);
        }
    }
}
