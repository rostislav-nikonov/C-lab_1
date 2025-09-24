using ConsoleApp2;

internal class Program

{
    private static void Main(string[] args)
    {
        Lab1_n2 F = new Lab1_n2();
        int x, y, z, choose;
        bool b, choosebool = true;
        char c;
        string s;

        while (choosebool == true)
        {

            Console.Write("Выберите номер задания\n" +
                "2 -- Безопасное деление\n" +
                "4 -- Строка сравнения\n" +
                "6 -- Тройная сумма\n" +
                "8 -- Возраст\n" +
                "10 -- Вывод дней недели\n" +
                "Ваш выбор: ");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {

                case 2:

                    Console.WriteLine("Введите первое число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("x / y = " + F.safeDiv(x, y));
                    break;

                case 4:

                    Console.WriteLine("Введите первое число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(F.makeDecision(x, y));
                    break;

                case 6:

                    Console.WriteLine("Введите первое число: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число: ");
                    z = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine(F.sum3(x, y, z));
                    break;


                case 8:

                    Console.WriteLine("Введите возраст: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(F.age(x));
                    break;

                case 10:
              
                    Console.WriteLine("Введите день недели(С большой буквы)");
                    s = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Результат:");
                    F.printDays(s);
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