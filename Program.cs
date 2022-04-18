using System;

namespace lab_4_2_1
{
    class Program
    {
        public static void Main() // Хотела голова моя дурная сделать ООП, но что-то пошло не так. Сколько я его уже учу...
        {
            int arr_rows = 0, arr_columns = 0; //arr_rows - Кол-во строк массива, arr_columns - кол-во столбцов массива.
                                               // Что интересно. Далее по тексту я буду создавать массив. И пока я при инициализации не присвою значения данным переменным,
                                               // массив я не смогу объявить. Даже с учётом того, что я задал ввод с клавиатуры с присвоением значений.
            byte choice = 0; // Пригодится для switch-case

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

            do
            {

                Console.Write("Choose your method: ");
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Test1");
                        break;

                    case 2:
                        Console.WriteLine("Test2");
                        break;

                    default:
                        Console.WriteLine("Wrong answer! Let's try again...");
                        break;
                }

            } while (choice != 1 || choice != 2);

        }
    }
}