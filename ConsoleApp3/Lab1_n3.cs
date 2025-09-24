using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Lab1_n3
    {
        public String reverseListNums(int x)
        {
            string s = string.Empty;
            for (int i = 0; i < x + 1; i++)
            {
                s = s + i.ToString() + " "; 
            }
            return s;
        }


        public int pow(int x, int y)
        {
            int sum = 1;
            for (int i = 0;i < y; i++)
            {
                sum *= x;
            }
            return sum;
        }


        public bool equalNum(int x)
        {
            int n, revers, digit;
            n = x;
            revers = 0;
            while (x > 0)
            {
                digit = x % 10;
                revers = revers * 10 + digit;
                x = x / 10;
            }
            if (n == revers) return true;
            else return false;
        }


        public void leftTriangle(int x)
        {
            for (int i = 1; i < x + 1 ; i++)
            {
                for (int j = 0; j < i ; j++) Console.Write("*");                
                Console.WriteLine();                
            }
        }


        public void guessGame()
        {
            bool b = true;
            int i = 0;
            Random rnd = new Random();

            Console.Write("Введите число от 0 до 9: ");

            while (b == true)
            {
                i++;
                int x = Convert.ToInt32(Console.ReadLine());                
                int rand = rnd.Next(0, 10);
                if (x != rand) Console.Write("Ошибка! Вы не угадали число, попробуйте еще раз: ");
                else { b = false; Console.WriteLine("Ура! Число угадано c " + i + " попытки."); }
            }
        }
    }
}
