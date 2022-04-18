using System;

namespace lab_4_2_1
{
    class Program
    {
        public static void Main() // Хотела голова моя дурная сделать ООП, но что-то пошло не так. Сколько я его уже учу...
        {
            Random rnd = new Random(); // Необходим лишь раз чисто для рандома.
            int arr_rows = 0, arr_columns = 0; //arr_rows - Кол-во строк массива, arr_columns - кол-во столбцов массива.
              // Что интересно. Далее по тексту я буду создавать массив. И пока я при инициализации не присвою значения данным переменным,
              // массив я не смогу объявить. Даже с учётом того, что я задал ввод с клавиатуры с присвоением значений.
            byte choice = 0; // Пригодится для switch-case
            int row_count = 0, zero_count = 0; // Счетчик нулевых элементов и строк без нулевых элементов.

            // Запрос у пользователя размера матрицы. Вначале строки, потом столбцы.
            Console.Write("Enter the number of rows in the array: ");
            arr_rows = Convert.ToInt32(Console.ReadLine()); // Присвоение целочисленного значения через чтение с клавиатуры.
            Console.Write("Enter the number of columns in the array: ");
            arr_columns = Convert.ToInt32(Console.ReadLine());
            // Очень неудобно после С++. Значение = Конвертировать.ВЦелочисл(Чтение с клавиатруы());

            int[,] array = new int[arr_rows, arr_columns]; // Создание двухмерного массива.
                                                           // Скорее всего, создал массив я неверно.
            Console.WriteLine();

            Console.Write("Array fill methods:\n" + // Спрашиваем у пользователя метод наполнения массива
                "1) Randomise \n" +
                "2) By myself \n");

            while (!(choice == 1 || choice == 2))
            {
                Console.Write("Choose your method: ");
                choice = Convert.ToByte(Console.ReadLine()); // Тут конвертация не в Int32! 
                Console.WriteLine();

                switch (choice)
                {
                    case 1: // Заполнение через рандом.
                        for (int i = 0; i < arr_rows; i++)
                        {
                            for (int j = 0; j < arr_columns; j++)
                            {
                                array[i, j] = rnd.Next(-5, 5); // Рандомизация значений.                            
                            }
                        }
                            break;

                    case 2: // Заполнение через клавиатуру.
                        Console.WriteLine("Enter a value and press Enter.");
                        for (int i = 0; i < arr_rows; i++)
                        {
                            for (int j = 0; j < arr_columns; j++)
                            {
                                Console.Write($"[{i}, {j}] = "); // Рандомизация значений.
                                array[i, j] = Convert.ToInt32(Console.ReadLine()); // Красивый вывод.
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;

                    default: // Если пользователь де... неверно ввел ответ.
                        Console.WriteLine("Wrong answer! Let's try again...");
                        break;
                }

            }

            Console.WriteLine("That's your array:"); // Красивый вывод.
            for (int i = 0; i < arr_rows; i++)
            {
                for (int j = 0; j < arr_columns; j++)
                {
                    Console.Write($"{array[i, j],-6}");
                    if (array[i, j] == 0) // Заодно подсчитаем количество строк без нулей.
                        zero_count++; // Вначале считаем сколько в строке нулей.
                }
                if (zero_count == 0) // В конце прогона строки смотрим количество нулей в строке и
                    row_count++; // если их количество равно нулю, то повышаем счётчик безнулевых строк на один.
                zero_count = 0; // И не забываем обнулить счётчик нулевых элементов в строке. 20 минут искал проблему, б...
                Console.WriteLine();
            }
            Console.WriteLine($"\nArray has {row_count} rows without zero."); // И получаем красивый ответ по поводу безнулевых строк.


        }
    }
}