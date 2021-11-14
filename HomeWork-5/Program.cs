using System;
using HW5Library;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello new World! yes cool git get";
            Console.WriteLine(str);
            char ch = 'e';
            Console.WriteLine(HW5Lib.ExtractWordsWithChar(str, ch));
            Console.WriteLine(HW5Lib.ExtractWordsWithChar(str, 'o'));
            int[] array = new int[20];
            int[] array1 = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(-10, 0);
            }

            HW5Lib.Printarray(array);
            Console.Write("\nArrayReverse  ");
            HW5Lib.ArrayReverse(array);
            HW5Lib.Printarray(array);

            Console.Write("\nBubbleSort <  ");
            HW5Lib.BubbleSort(array, HW5Lib.Less);
            HW5Lib.Printarray(array);

            Console.Write("\nBubbleSort >  ");
            HW5Lib.BubbleSort(array, HW5Lib.Greater);
            HW5Lib.Printarray(array);

            Console.Write("\nHalfSwapArray ");
            HW5Lib.HalfSwapArray(array);
            HW5Lib.Printarray(array);

            Console.Write("\nSelectSort <  ");
            HW5Lib.SelectionSort(array, HW5Lib.Less);
            HW5Lib.Printarray(array);

            Console.Write("\nSelectSort >  ");
            HW5Lib.SelectionSort(array, HW5Lib.Greater);
            HW5Lib.Printarray(array);

            Console.Write("\nInsertionSort < ");
            HW5Lib.InsertionSort(array, HW5Lib.Less);
            HW5Lib.Printarray(array);

            Console.Write("\nInsertionSort > ");
            HW5Lib.InsertionSort(array, HW5Lib.Greater);
            HW5Lib.Printarray(array);

            Console.Write("\nDeleteNegativeElementsFromArray ");
            HW5Lib.Printarray(HW5Lib.InsertArrayToArray(array, array1, 3));

            Console.Write("\nInsertArrayToArray ");
            HW5Lib.Printarray(HW5Lib.DeleteNegativeElementsFromArray(HW5Lib.InsertArrayToArray(array, array1, 5)));

            Console.WriteLine("\nmin element " + HW5Lib.MinElementOfArray(array));
            Console.WriteLine("max element " + HW5Lib.MaxElementOfArray(array));
            Console.WriteLine("index of min element " + HW5Lib.IndexOfMinElementOfArray(array));
            Console.WriteLine("index of max element " + HW5Lib.IndexOfMaxElementOfArray(array));
            Console.WriteLine("sum of odd indexes elements " + HW5Lib.SumOddIndxElemOfArray(array));
            Console.WriteLine("sum of odd indexes elements " + HW5Lib.SumOddIndxElemOfArray(array));
            Console.WriteLine("number of odd elements " + HW5Lib.NumOfOddElements(array));
        }
    }
}
