using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AgafonovKS.Sprint3.Task5.V10.Lib;

namespace Tyuiu.AgafonovKS.Sprint3.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Агафонов К. С. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант 10                                                              *");
            Console.WriteLine("* Выполнил: Агафонов Кирилл Сергеевич | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("      при X=5");
            Console.WriteLine("     ___    ___                ");
            Console.WriteLine("y =  \\      \\   (x^3*k)+2                                                ");
            Console.WriteLine("     /__    /__       ");
            Console.WriteLine("    i = 1  k = 1 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Переменная x: " + x);
            Console.WriteLine("Старт шага первой суммы ряда: " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда: " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда: " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда: " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда: " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
