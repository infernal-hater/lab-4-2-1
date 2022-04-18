using System;

namespace lab_4_2_1
{
    class Program
    {
        public static void Main()
        {
            int arr_rows = 0, arr_columns; //arr_rows - Кол-во строк массива, arr_columns - кол-во столбцов массива.
            Console.Write("Enter the number of rows in the array:");
            arr_rows = Convert.ToInt32(Console.Read()); // Присвоение целочисленного значения через чтение с клавиатуры.
            // Очень неудобно после С++. Значение = Конвертировать.ВЦелочисл(Чтение с клавиатруы());

            Console.Write("Enter the number of columns in the array:");
            arr_rows = Convert.ToInt32(Console.Read());
        }
    }


}