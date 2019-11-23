using System;

namespace Sort
{
    class Sorts
    {
        static void Main(string[] args)
        {
            int[] inputList = { 7,6,5,1 };
            System.Console.WriteLine($"Input Values {inputList[0]},{inputList[1]},{inputList[2]},{inputList[3]}");
            var baseList=InsertionSort(inputList);
            System.Console.WriteLine($"Sort Values  {baseList[0]},{baseList[1]},{baseList[2]},{baseList[3]}");
            Console.ReadLine();
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
