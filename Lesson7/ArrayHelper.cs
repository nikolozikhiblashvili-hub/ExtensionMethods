using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{

    internal static class ArrayHelper
    {
        //this - extension method


        public static void PrintReverse<T>(this T[] arr)
        {
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static T GetFirstElemnt<T>(this T[] arr)
        {
            return arr[0];
        }

        public static void PrintUpper(this string name)
        {
            Console.WriteLine(name.ToUpper());
        }

        public static bool ContainsElement<T>(this T[]arr,T value)
        {
            return arr.Contains(value);
        }

        public static int CountElemts<T>(this T[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                count++;
            }
            return count;
        }

        public static int FindIndex<T>(this T[] arr, T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
