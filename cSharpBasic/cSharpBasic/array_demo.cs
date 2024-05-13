using System;

namespace cSharpBasic
{
    public class array_demo
    {
        public void setArray()
        {
            //1d Array
            
            //direct method
            int[] array1 = { 1, 2, 3, 4, 5 };
            
            //size
            int[] array2 = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("\n\n------Using For Loop------");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            
            //2d array
            int[,] array3 =
            {
                { 2, 3, 4 }, //0th row 3 col (0-2)
                { 5, 6, 7 },
                { 1, 5, 9 }
            };
            Console.WriteLine("\nUsing for each loop:");
            foreach (int a in array3)
            {
                Console.Write(a);
            }
            
            Console.WriteLine("\nUsing for loop array:");
            
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j<array3.GetLength(1); j++)
                {
                    Console.Write(array3[i,j]);
                }
                Console.WriteLine(" ");
            }
            
            //jagged array:variation in column
            int[][] jagged = new int[3][];
            jagged[0] = new[] { 1, 2, 3 };
            jagged[1] = new[] { 4, 5, 6, 7 };
            jagged[2] = new[] { 7, 8 };
            
            Console.WriteLine("\nUsing for loop for jagged array:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j<jagged.Length; j++)
                {
                    Console.Write(jagged[i][j]);
                }
                Console.WriteLine(" ");
            }
            
            Console.WriteLine("\nUsing for each loop for jagged array");
            foreach (int []i in jagged)    
            {
                foreach (int j in i)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
}