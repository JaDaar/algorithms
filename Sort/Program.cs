using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7,6,5,1 };
            var b=InsertionSort(x);
            Console.WriteLine(b);
        }

        private static int[] InsertionSort(int[] list)
        {
            int key;
            for(var iter = 0; iter < list.Length; iter++)
            {
                for (var index = 0; index < list.Length; index++)
                {
                    key = list[index];
                    if (index + 1 < list.Length)
                    {
                        while (list[index + 1] < key)
                        {
                            var shiftDown = list[index + 1];
                            list[index] = shiftDown;
                            list[index + 1] = key;
                        }
                    }
                }
            }
            return list;
        }
    }
}
