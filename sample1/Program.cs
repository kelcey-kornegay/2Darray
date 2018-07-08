using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[6, 6];

            Console.Write("\n\nRead a 2D array of size 6x6 and print the matrix :\n");
            Console.Write("------------------------------------------------------\n");


            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter threshold");
            int threshold = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 6; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 6; j++)
                    if(arr1[i, j] > threshold)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("{0}\t", arr1[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0}\t", arr1[i, j]);
                    }
                    
            }
            Console.Write("\n\n");
        }
    }
}
