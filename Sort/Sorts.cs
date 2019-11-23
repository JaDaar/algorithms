using System;

namespace Sort
{
    class Sorts
    {
        static void Main(string[] args)
        {
            int[] inputList = { 7, 6, 5, 1 };
            System.Console.WriteLine($"Input Values {inputList[0]},{inputList[1]},{inputList[2]},{inputList[3]}");
            var baseList = InsertionSort(inputList);
            System.Console.WriteLine($"Sort Values  {baseList[0]},{baseList[1]},{baseList[2]},{baseList[3]}");
            Console.ReadLine();

            Console.WriteLine("\nExercise 1.1-1");
            exercise1_dot1_1();
            Console.WriteLine("\nExercise 1.1-2");
            exercise1_dot1_2();

            Console.WriteLine("\nExercise 1.1-3");
            exercise1_dot1_3();
        }

        private static void exercise1_dot1_3()
        {
            int[] searchList = { 13, 23, 33, 55, 6 ,18};
            int arg = 182;
            var rslts=LinearSearch(searchList, arg);
            System.Console.WriteLine($"Search Values  {searchList[0]},{searchList[1]},{searchList[2]},{searchList[3]},{searchList[4]},{searchList[5]}");
            Console.WriteLine($"Argument to Find {arg}");
            Console.WriteLine($"RESULTS {rslts}");
            Console.ReadLine();
        }

        private static void exercise1_dot1_1(){
            int[] inputList = { 31, 41, 59, 26, 41, 58 };
            System.Console.WriteLine($"Input Values {inputList[0]},{inputList[1]},{inputList[2]},{inputList[3]},{inputList[4]},{inputList[5]}");
            var baseList = InsertionSort(inputList);
            System.Console.WriteLine($"Sort Values  {baseList[0]},{baseList[1]},{baseList[2]},{baseList[3]},{inputList[4]},{inputList[5]}");
            Console.ReadLine();
        }

        private static void exercise1_dot1_2()
        {
            int[] inputList = { 31, 41, 59, 26, 41, 58 };
            System.Console.WriteLine($"Input Values {inputList[0]},{inputList[1]},{inputList[2]},{inputList[3]},{inputList[4]},{inputList[5]}");
            var baseList = InsertionSortNonIncreasing(inputList);
            System.Console.WriteLine($"Sort Values  {baseList[0]},{baseList[1]},{baseList[2]},{baseList[3]},{inputList[4]},{inputList[5]}");
            Console.ReadLine();
        }


        private static int[] InsertionSort(int[] list)
        {
            // O(n^2)
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

        private static int[] InsertionSortNonIncreasing(int[] list)
        {
            // O(n^2)
            int key;
            for (var iter = 0; iter < list.Length; iter++)
            {
                for (var index = 0; index < list.Length; index++)
                {
                    key = list[index];
                    if (index - 1 >=0)
                    {
                        while (list[index - 1] < key)
                        {
                            var shiftDown = list[index - 1];
                            list[index] = shiftDown;
                            list[index - 1] = key;
                        }
                    }
                }
            }
            return list;
        }

        private static int? LinearSearch(int[] searchList, int arg)
        {
            for (var index = 0; index < searchList.Length; index++)
            {
                if (arg == searchList[index])
                    return index;
            }
            return null;
        }
    }
}
