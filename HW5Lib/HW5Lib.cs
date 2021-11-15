using System;

namespace HW5Library
{
    public class HW5Lib
    {
        public static void Printarray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Swap(ref int a, ref int b)
        {
            if (a != b)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
        }

        public static bool Greater(int a, int b)
        {
            return a > b;
        }

        public static bool Less(int a, int b)
        {
            return a < b;
        }

        public static int IndexOfMinElementOfArray(int[] array) //HW Task3
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int IndexOfMaxElementOfArray(int[] array) //HW Task4
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int MinElementOfArray(int[] array) //HW Task1
        {
            return array[IndexOfMinElementOfArray(array)];
        }

        public static int MaxElementOfArray(int[] array)    //HW Task2
        {
            return array[IndexOfMaxElementOfArray(array)];
        }

        public static int SumOddIndxElemOfArray(int[] array)    //HW Task5
        {
            int result = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                result += array[i];
            }

            return result;
        }

        public static void ArrayReverse(int[] array)    //HW Task6
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - i - 1]);
            }
        }

        public static int NumOfOddElements(int[] array) //HW Task7
        {
            int result = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if ((array[i] % 2) == 1)
                {
                    result++;
                }
            }

            return result;
        }

        public static void HalfSwapArray(int[] array)   //HW Task8
        {
            for (int i = 0; i < array.Length / 2; ++i)
            {
                Swap(ref array[i], ref array[array.Length / 2 + i]);
            }
        }

        public static void BubbleSort(int[] array, Func<int, int, bool> CompareMethod)   //HW Task9-10
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; i < array.Length - j - 1; ++j)
                {
                    if (!CompareMethod(array[j], array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array, Func<int, int, bool> CompareMethod)   //HW Task9-10
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (CompareMethod(array[j], array[index]))
                    {
                        index = j;
                    }
                }

                if (i != index)
                {
                    Swap(ref array[i], ref array[index]);
                }

            }
        }

        public static void InsertionSort(int[] array, Func<int, int, bool> CompareMethod)   //HW Task9-10
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int temp = array[i];
                int j = i - 1;
                while (j >= 0 && (CompareMethod(array[j], temp) == false))
                {
                    array[j + 1] = array[j--];
                }

                array[j + 1] = temp;
            }
        }

        public static int[] InsertArrayToArray(int[] inArray, int[] putArray, int position) // ClassWork MediumTask3
        {
            int lenght = inArray.Length + putArray.Length;
            int[] resultArray = new int[lenght];
            int index = 0;
            for (int i = 0; i < lenght; i++)
            {
                resultArray[i] = inArray[i];
                if (i == position)
                {
                    index = i;
                    break;
                }
            }
            for (int i = position, k = 0; i < position + putArray.Length; ++i, ++k)
            {
                resultArray[i] = putArray[k];
            }
            for (int i = position + putArray.Length + 1; i < lenght; ++i)
            {
                resultArray[i] = inArray[++index];
            }

            return resultArray;
        }

        public static int[] DeleteNegativeElementsFromArray(int[] array) // ClassWork MediumTask2
        {
            int negativeElementCount = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    negativeElementCount++;
                }
            }

            int[] newArray = new int[array.Length - negativeElementCount];
            int index = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] >= 0)
                {
                    newArray[index++] = array[i];
                }
            }

            return newArray;
        }

        public static int NumOfCharInString(string str, char ch)
        {
            int result = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == ch)
                {
                    result++;
                }
            }

            return result;
        }

        public static string ExtractWordsWithChar(string str, char ch) // ClassWork HardTask2
        {
            string result = "";
            int numOfChar = NumOfCharInString(str, ch);
            int[] charIndex = new int[numOfChar];
            int numOfSpaces = 2 + NumOfCharInString(str, ' ');
            int[] spacesIndex = new int[numOfSpaces];
            int i = 0;
            int j = 0;
            for (int k = 0; k < str.Length; ++k)
            {
                if (str[k] == ch)
                {
                    charIndex[i++] = k;
                }
                else if (str[k] == ' ')
                {
                    spacesIndex[++j] = k;
                }
            }

            spacesIndex[++j] = str.Length;
            j = 0;
            for (int k = 0; k < numOfSpaces; ++k)
            {
                if ((j >= numOfChar) || ((k + 1) >= numOfSpaces))
                {
                    break;
                }
                if ((spacesIndex[k] < charIndex[j]) && (charIndex[j] < spacesIndex[k + 1]))
                {
                    for (int l = spacesIndex[k]; l < spacesIndex[k + 1]; l++)
                    {
                        result += str[l];
                    }

                    j++;
                }

                result += " ";
            }

            return result;
        }
    }
}
