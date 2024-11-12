using Tyuiu.KhrapkoDD.Sprint4.Task6.V22.Lib;

namespace Tyuiu.KhrapkoDD.Sprint4.Task6.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных используя класс Array, выведите             *");
            Console.WriteLine("* элементы массива, длина которых равна 4 символам.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] things = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Элементы длина которых равна 4: ");
            string[] res = ds.Calculate(things);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}