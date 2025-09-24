namespace ConsoleApp4
{
    internal class Lab1_n4
    {
        public void RndArr(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
        }
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public int findLast(int[] arr, int x)
        {
            arr.Reverse();
            int lastind = -1;
            for (int i = arr.Length - 1; i > -1; i--)
            {
                if (arr[i] == x)
                {
                    lastind = i;
                    break;                             
                }
            }
            return lastind;
        }

        public int[]add (int[] arr, int x, int pos)
        {
            int[] narr = new int[arr.Length + 1];
            for (int i = 0; i < narr.Length; i++)
            {
                if (i < pos)
                    narr[i] = arr[i];             
                else if (i == pos)
                    narr[i] = x;                   
                else
                    narr[i] = arr[i - 1];          
            }            
            return narr;
        }


        public void reverse(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }

        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }

            return result;
        }

        public int[] deleteNegative(int[] arr)
        {

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }

    }
}
