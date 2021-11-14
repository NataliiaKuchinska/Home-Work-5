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

        public static int MinElementOfArray(int[] array) //HW Task1
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int MaxElementOfArray(int[] array)    //HW Task2
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int IndexOfMinElementOfArray(int[] array) //HW Task3
        {
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    index = i;
                }
            }

            return index;
        }

        public static int IndexOfMaxElementOfArray(int[] array) //HW Task4
        {
            int max = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    index = i;
                }
            }

            return index;
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
                    if (CompareMethod(array[j], array[j + 1]) == false)
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
                    if (CompareMethod(array[j], array[index]) == true)
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
                    array[j + 1] = array[j];
                    --j;
                }

                array[j + 1] = temp;
            }
        }

        public static int[] InsertArrayToArray(int[] inarray, int[] putarray, int position) // ClassWork MediumTask3
        {
            int lenght = inarray.Length + putarray.Length;
            int[] resultarray = new int[lenght];
            int index = 0;
            for (int i = 0; i < lenght; i++)
            {
                resultarray[i] = inarray[i];
                if (i == position)
                {
                    index = i;
                    break;
                }
            }
            for (int i = position, k = 0; i < position + putarray.Length; ++i, ++k)
            {
                resultarray[i] = putarray[k];
            }
            for (int i = position + putarray.Length + 1; i < lenght; ++i)
            {
                resultarray[i] = inarray[++index];
            }

            return resultarray;
        }

        public static int[] DeleteNegativeElementsFromArray(int[] array) // ClassWork MediumTask2
        {
            int numofnegative = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    numofnegative++;
                }
            }

            int[] newarray = new int[array.Length-numofnegative];
            int index = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] >= 0)
                {
                    newarray[index++]=array[i];
                }
            }

            return newarray;
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
            int numofch = NumOfCharInString(str, ch);
            int[] chindex = new int[numofch];
            int numofspaces = 2 + NumOfCharInString(str, ' ');
            int[] spacesindex = new int[numofspaces];
            int j = 0;
            int k = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == ch)
                {
                    chindex[j++] = i;
                }
                else if (str[i] == ' ')
                {
                    spacesindex[++k] = i;
                }
            }

            spacesindex[++k] = str.Length;
            k++;
            int s = 0;
            for (int i = 0; i < k; ++i)
            {
                if ((s >= numofch) || ((i + 1) >= numofspaces))
                {
                    break;
                }
                if ((spacesindex[i] < chindex[s]) && (chindex[s] < spacesindex[i + 1]))
                {
                    int ind = i;
                    for (int t = spacesindex[ind]; t < spacesindex[ind + 1]; t++)
                    {

                        result += str[t];
                    }

                    s++;
                }

                result += " ";
            }

            return result;
        }
    }
}
