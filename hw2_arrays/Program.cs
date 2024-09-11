internal class Program
{
    static void Main()
    {
        /*char[] array = { 'a', 'b', 'c' };

        for (int i = 0; i < array.Length; i++)

            Console.WriteLine(array[i]);*/


        /*// 0.1 ... 0.6
        double[] array = new double[6];

        array[0] = 0.1; Console.Write($"{array[0]}, ");


        for (int i = 1; i < array.Length; i++)
        {
            array[i] = array[i-1] + 0.1;

            Console.Write($"{array[i]:f1}, ");
        }*/


        //custom int array

        while (true)
        {
            Console.Write("Write size of array: "); int array_size = Convert.ToInt32(Console.ReadLine());

            if (array_size <= 0)
            {
                Console.WriteLine("Must be more then 0");
                Console.Write("Write size of array: "); array_size = Convert.ToInt32(Console.ReadLine());
            }

            int[] array = new int[array_size];

            for (int i = 0; i < array_size; i++)
            {
                Console.Write($"Enter {i + 1} element: "); array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            //вывод всего массива
            Console.Write("\nResult [");
            for (int i = 0; i < array_size; i++)
            {
                if (i == array_size - 1)
                    Console.Write($"{array[i]}]");
                else
                    Console.Write($"{array[i]}, ");
            }

            //сумма всех элементов
            int sum = 0;

            for (int i = 0; i < array_size; i++) 
                 sum += array[i];
            
            Console.WriteLine($"\n\nSum of elements: {sum}");

            //max, min
            int min = array[0], max = array[0]; //точка отсчета - первый элемент

            for(int i = 0; i < array_size; i++)
            {
                if (array[i] < min) //если найдется элемент меньше точки отсчета, он становится новым минимальным
                    min = array[i];

                if (array[i] > max)
                    max = array[i];
            }

            Console.WriteLine($"\nMin: {min}, Max: {max}");

            //average of elements
            Console.WriteLine($"\nAvarage of elements: {(int)(sum / array.Length)}");


            Console.WriteLine("\n");
        }
















    }
}

