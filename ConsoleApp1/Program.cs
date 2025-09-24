using System;
using System.ComponentModel;
using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Lab1_n1 Cl = new Lab1_n1();
        int x, x1, x2, x3, y, ans, choose;
        bool b, choosebool = true; ;
        char c;

        while (choosebool == true) {

            Console.Write("Выберите номер задания\n" +
                "2 -- Сумма знаков\n" +
                "4 -- Есть ли позитив\n" +
                "6 -- Большая буква\n" +
                "8 -- Делитель\n" +
                "10 -- Многократный вызов\n" +
                "Ваш выбор: ");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 2:
                    
                    Console.Write("Введите целое число x (x > 9): ");
                    x = Convert.ToInt32(Console.ReadLine());

                    while (x <= 9)
                    {
                        Console.Write("Число должно быть больше 9, повторите ввод: ");
                        x = Convert.ToInt32(Console.ReadLine());
                    }

                    ans = Cl.sumLastNums(x);
                    Console.WriteLine(ans);
                    break;

                case 4:

                    
                    Console.Write("Введите целое число x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    b = Cl.isPositive(x);
                    Console.WriteLine(b);
                    break;

                case 6:

                    Console.Write("Введите любую букву Латиницы: ");
                    c = Convert.ToChar(Console.ReadLine());
                    b = Cl.isUpperCase(c);
                    Console.WriteLine(b);
                    break;

                case 8:

                    
                    Console.Write("Введите первое число x1: ");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число x2: ");
                    x2 = Convert.ToInt32(Console.ReadLine());

                    b = Cl.isDivisor(x1, x2);
                    Console.WriteLine(b);
                    break;

                case 10:

                    
                    Console.Write("Введите 1 число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2 число: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    x3 = Cl.lastNumSum(x, y);
                    Console.WriteLine("Итог: " + x3);
                    break;
                
                default: 
                    Console.WriteLine("Такого задания не существует"); 
                    break;

            }

            Console.Write("Хотите выбрать новую задачу? Y/N: ");
            c = Convert.ToChar(Console.ReadLine());
            if (c != 'Y')
                {
                choosebool = false;
            }

        }
    }
}

