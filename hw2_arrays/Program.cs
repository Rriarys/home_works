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



        //array customization menu

        Console.Write("Write sie of array: "); int size_arrray = Convert.ToInt32(Console.ReadLine());

        while (size_arrray <= 0)
        {
            Console.WriteLine("Size can be more than 0!");
            Console.Write("Write sie of array: "); size_arrray = Convert.ToInt32(Console.ReadLine());
        }

        int[] array = new int[size_arrray];

        for (int i = 0; i < size_arrray; i++)
        {
            Console.Write($"\nEnter {i + 1} element: "); array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nYour array: [");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
                Console.Write($"{array[i]}]\n");
            else
                Console.Write($"{array[i]}, ");
        }

        while (true)
        {
            Console.WriteLine("""

            1 -> Show array
            2 -> Edit array
            3 -> Add new element
            4 -> Remove element
            5 -> Sort elements
            6 -> Reverse elements
            7 -> Show pare numbers
            8 -> Remove duplicates
            9 -> Check if palindrome

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
                case 5: // SORT (BUBBLE)
                    for (int i = 0; i < array.Length; i++) // проходим по массиву
                    {
                        for (int j = 0; j < array.Length - i; j++) // самый большой элемент "всплывет" первым в самый конец
                        {                                          // дальше, мы уменьшаем проверку на колличество уже пройденых
                            if (array[j] > array[j + 1])           // потому что в конец уходят самые большие из оставшихся чисел
                            {
                                int temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp; // меняем местами через дополнительную переменную
                            }
                        }

                    }
                    // еще раз выведу всь массив
                    Console.Write("\nYour array: [");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                            Console.Write($"{array[i]}]\n");
                        else
                            Console.Write($"{array[i]}, ");
                    }
                    break;
                case 6: // REVERSE
                    for (int i = 0; i < array.Length / 2; i++) // будут сравниваться первый и последний элементы, попарно, значит достаточно пройтись до половины
                    {
                        int temp = array[i];
                        array[i] = array[array.Length - 1 - i]; // - 1 - i => меняем с последним индексом, с учетом пройденых
                        array[array.Length - 1 - i] = temp; // и первый ставим в конец
                    }
                    // еще раз вывожу массив
                    Console.Write("\nYour array: [");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                            Console.Write($"{array[i]}]\n");
                        else
                            Console.Write($"{array[i]}, ");
                    }
                    break;
                case 7: // NUMBERS % 2 == 0
                    Console.Write("\nYour array: [");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                            Console.Write($"{array[i]}]\n");
                        else
                            Console.Write($"{array[i]}, ");
                    }

                    Console.Write("\nPare numbers in array is: ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                            Console.Write($"{array[i]} ");  
                    }
                    break;
                case 8: // REMOVE DUPLICATES
                    int[] uniqArray = new int[array.Length]; // массив для хранения уникальных значений, не меньше чем основной

                    int counter = 0; // счетчик уникальных, он же сдвиг, первый элемент (0 индекс) и т.д.

                    for (int i = 0; i < array.Length; i++)
                    {

                        bool isDupl = false; // флажок, изначально полагаем что число не дубликат

                        for (int j = 0; j < counter; j++) // нет смысла проверять то, чего нет, поэтому отталкиваюсь от имеющихся в новом массиве значений
                        {
                            if (array[i] == uniqArray[j])
                            {
                                isDupl = true; // значение уже встречалось
                                break; // останавливаем
                            }
                        }

                        if (!isDupl) // если число так и осталось с пометкой "не дубликат", значит это условие выполнится (станет true, хитрость)
                        {            // а если в пред. цикле стало true, то это условие не выполнится вообще (будет false)
                            uniqArray[counter] = array[i]; // counter был 0 -> он же индекс первого элемента
                            counter++; // сдвигаемся в право, на след. индекс
                        }
                    }

                    array = uniqArray; // возвращаем ссылку по старому адресу

                    Console.Write("\nYour array: [");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                            Console.Write($"{array[i]}]\n");
                        else
                            Console.Write($"{array[i]}, ");
                    }
                    break;
                case 9: // PALINDROME
                    bool isPalindrome = true; // flag

                    for (int i = 0; i < array.Length / 2 ; i++) // достаточно пройти до половины, сравнение парами
                    {
                        if (array[i] != array[array.Length - 1 - i]) // сравниваем первый и последний
                        {
                            isPalindrome = false; // если нет сходства хоть по 1й паре, не палиндром
                            break;
                        }
                    }

                    Console.Write("\nYour array: [");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                            Console.Write($"{array[i]}]");
                        else
                            Console.Write($"{array[i]}, ");
                    }

                    if (isPalindrome)
                        Console.Write(" -> is palindrome\n");
                    else 
                        Console.Write(" -> is not a palindrome\n");
                    break;
            }
        }


























    }
}

