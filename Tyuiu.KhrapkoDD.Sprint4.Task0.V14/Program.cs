using Tyuiu.KhrapkoDD.Sprint4.Task0.V14.Lib;

namespace Tyuiu.KhrapkoDD.Sprint4.Task0.V14
{
    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов,                    *");
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9.              *");
        Console.WriteLine("* Подсчитать сумму нечетных сумму нечетных элементов массива.             *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.WriteLine(numsArray[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма нечётных элементов массива: ");

        int res = ds.GetSumOddArrEl(numsArray);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}
}