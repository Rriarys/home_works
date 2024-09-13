internal class Program
{
    static void Main()
    {
        /*for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

            }

        }*/ 



        /*// md array
        int[,] array = new int[2, 3]
        {
            {3, 6, 8 },
            {0, 1, 4 }
        };

        int sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
                sum += array[i, j];
            }
            Console.Write("}");

            Console.WriteLine();
        }

        Console.WriteLine($"\nSum: {sum}");*/


        /*// md 2
        int[,] array = new int[2, 3]
        {
            {3, 0, 8 },
            {11, 72, 4 }
        };

        int[,] array2 = new int[2, 3]
        {
            {0, 12, 5 },
            {99, 99, 1 }
        };

        int[,] sumArray = new int[2, 3];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],3} ");
            }
            Console.Write("}");

            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < array2.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                Console.Write($"{array2[i, j],3} ");
            }
            Console.Write("}");

            Console.WriteLine();
        }

        Console.WriteLine("\nSum of same indexes\n");

        for (int i = 0; i < sumArray.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < sumArray.GetLength(1); j++)
            {
                sumArray[i, j] = array[i, j] + array2[i, j];
                Console.Write($"{sumArray[i, j],3} ");
            }
            Console.Write("}");

            Console.WriteLine();
        }*/



        // md 3
        /*int[,] array = new int[3, 4]
        {
            {6, 22, 11, 7},
            {0, 6, 6, 6 },
            {9, 65, 0, 2 },
        };

        int min = array[0, 0], max = array[0, 0];

        int minI = 0, minJ = 0, maxI = 0, maxJ = 0; // чтобы записать координаты min max

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minI = i;
                    minJ = j;
                }

                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxI = i;
                    maxJ = j;
                }

                Console.Write($"{array[i, j],3} ");
            }
            Console.Write("}");

            Console.WriteLine();
        }

        Console.WriteLine($"\nMin: {min}, Max: {max}");

        array[minI, minJ] = max; // swap
        array[maxI, maxJ] = min;

        Console.WriteLine("\nMin and Max was swaped\n");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],3} ");
            }
            Console.Write("}");

            Console.WriteLine();
        }*/


       /* // is symmetric matrix
        int[,] array = new int[3, 3]
        {
            { 0, 1, 5 },
            { 1, 0, 1 },
            { 5, 1, 0 },
        };

        int[,] transpArray = new int[3, 3];

        bool isSymmetric = true; // flag

        // транспорируем матрицу
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                transpArray[j, i] = array[i, j]; // строки становятся столбцами
            }
        }

        Console.WriteLine("\nMatrix\n");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],3} ");
            }
            Console.Write("}");

            Console.WriteLine();
        }

        Console.WriteLine("\nTransporent matrix\n");

        for (int i = 0; i < transpArray.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < transpArray.GetLength(1); j++)
            {
                Console.Write($"{transpArray[i, j],3} ");
            }
            Console.Write("}");

            Console.WriteLine();
        }

        // symetric check
        for (int i = 0; i < array.GetLength(0); i++)
        { 
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] != transpArray[i,j])
                {
                    isSymmetric = false;
                    goto OutSymmetric; // если хоть 1 не равен, можно дропать
                }
            }  
        }

        OutSymmetric: Console.WriteLine("\nMatrix is " + (isSymmetric ? "symmetric" : "not symmetric"));*/









    }
}

