using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab1_n1
    {
        public int sumLastNums(int x)
        {
            int y, sum = 0;
            sum = sum + x % 10;
            y = x / 10;
            sum = sum + y % 10;
            return sum;
        }

        public bool isPositive(int x)
        {
            if (x >= 0) return true;
            else return false;
        }


        public bool isUpperCase(char x)
        {
            if (x >= 'A' && x <= 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool isDivisor(int a, int b)
        {
            if ((a % b == 0) | (b % a == 0)) return true;
            else return false;
        }


        public int lastNumSum(int a, int b)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a + " + " + b + " = ");
                a = (a % 10) + (b % 10);
                Console.WriteLine(a);
                if (i < 5 - 1)
                {
                    Console.Write("Введите новое второе число: ");
                    b = Convert.ToInt32(Console.ReadLine());
                }
            }
            return a;
        }
    }
}

