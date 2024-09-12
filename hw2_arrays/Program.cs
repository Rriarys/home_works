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


        /*//custom int array

        while (true)
        {
            Console.Write("Write size of array: "); int array_size = Convert.ToInt32(Console.ReadLine());

            while (array_size <= 0)
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
        }*/



        //array menu

        Console.Write("Write sie of array: "); int size_arrray = Convert.ToInt32(Console.ReadLine());

        while (size_arrray <= 0)
        {
            Console.WriteLine("Size can be more than 0!");
            Console.Write("Write sie of array: "); size_arrray = Convert.ToInt32(Console.ReadLine());
        }

        int[] array = new int[size_arrray];

        while (true)
        {
            Console.WriteLine("""

            1) - Show array
            2) - Edit array
            3) - Add new element
            4) - Remove element

            """);

            Console.Write("What to do with it: "); int choiсe = Convert.ToInt32(Console.ReadLine());

            switch (choiсe)
            {
                case 1: // SHOW
                    Console.Write("\nYour array: [");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                            Console.Write($"{array[i]}]\n");
                        else
                            Console.Write($"{array[i]}, ");
                    }
                    break;

                case 2: // EDIT
                    Console.Write("\nWhich element you want change, where 0 is index of the first one: "); int index_array = Convert.ToInt32(Console.ReadLine());
                    
                    while (index_array < 0 || index_array > array.Length - 1)
                    {
                        Console.Write("\nWrong index!\n");
                        Console.Write("\nWhich element you want change, where 0 is index of the first one: "); index_array = Convert.ToInt32(Console.ReadLine()); 
                    }

                    Console.Write($"Put new value for {index_array} INDEX: "); array[index_array] = Convert.ToInt32(Console.ReadLine());

                    break;

                case 3: // ADD
                    Console.Write("\nPut value of new element: "); int new_elem = Convert.ToInt32(Console.ReadLine());

                    int[] tempArray = new int[array.Length + 1]; // делаем новый массив на основе старого + 1

                    for (int i = 0; i < array.Length; i++) // проходим по всем элементам старого массива 
                        tempArray[i] = array[i];           // и кладем их в новый

                    tempArray[tempArray.Length - 1] = new_elem; // в последний кладем значение юзера

                    array = tempArray; // возвращаем ссылку от нового массива к старому адресу, старый утратит ссылку и будет стерт компилятором
                    break;

                case 4: // REMOVE
                    Console.Write("\nWich element you want, where 0 is index of the first one: "); int index_rem = Convert.ToInt32(Console.ReadLine());

                    int[] tempArrayRem = new int[array.Length - 1];

                    for (int i = 0, j = 0; i < array.Length; i++) // i - старый массв, j - новый
                    {
                        if (i != index_rem)
                        {
                            tempArrayRem[j] = array[i]; // присваеваем если индекс старого массива не подпадает под удаление
                            j++; // двигаемся по новому
                        }

                    }
                    array = tempArrayRem;
                    break;
                //new cases

            }
        }


























    }
}

