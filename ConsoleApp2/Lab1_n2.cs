using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lab1_n2
    {
        readonly string[] arr = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };


        public double safeDiv(int x, int y)
          => y == 0 ? 0 : Math.Round((double)x / y, 3); 
      

        public String makeDecision(int x, int y)
        {
            if (x > y) return (x + " > " + y);
            else if (x < y) return (x + " < " + y);
            else return (x + " == " + y);
        }


        public bool sum3(int x, int y, int z)
            => ((x + y == z) || (x + z == y) || (z + y == x));


        public String age(int x)
        {
            if (x == 11 || x == 12 || x == 13 || x == 14) return (x + " лет");
            else
            {
                switch(x % 10)
                {
                    case 1:
                        return (x + " год");
                    case 2:
                    case 3:
                    case 4:
                        return (x + " года");
                    default:
                        return (x + " лет");

                }
            }
        }


        public void printDays(String x)
        {
            try
            {
                int ind = Array.FindIndex(arr, s => s == x);
                for (int i = ind; i < 7; i++) Console.WriteLine(arr[i]);                
            }
            catch
            {
                Console.WriteLine("Это не день недели");
            }
        }
    }
}
