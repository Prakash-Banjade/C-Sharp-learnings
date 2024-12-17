using System;

namespace ArrayExample {
    public class Program {
        static void Main() {
            // simple array definition
            int[] simpleArray_v1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] simpleArray = { 1, 2, 3 };

            PrintSimpleArray(simpleArray);

            // 2D array
            int [,] matrix = new int[2, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            Print2DArray(matrix);

            // 3D array
            int[,,] cube = new int[2, 2, 3] {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };

            // Jagged Array
            int[][] jagged = new int[2][]; // two inner arrays with variable sizes
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 11, 12 };

            PrintJaggedArray(jagged);
            
        }

        static void PrintSimpleArray(int[] arr) {
            Console.WriteLine("This is simple-array -->");
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Print2DArray(int[,] arr) {
            Console.WriteLine("This is a 2D array -->");
            for (int i = 0; i < arr.GetLength(0); i++) { // .GetLength(0) returns the size of rows i.e. 2
                for (int j = 0; j < arr.GetLength(1); j++) { // .GetLength(1) returns the size of each array i.e. 3
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintJaggedArray(int[][] arr) {
            Console.WriteLine("This is a Jagged array -->");
            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr[i].Length; j++) {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}