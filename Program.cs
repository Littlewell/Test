using System;
using System.Linq;
using System.Threading.Channels;

namespace ConsoleApp1
{

    
    internal class Program
    {
        /// <summary>
        /// Insert element by index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <param name="index"></param>
        static void InsertByIndex(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;

        }
        /// <summary>
        /// Insert first element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        static void InsertFirst(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = value;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;
        }
        /// <summary>
        /// insert last element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        static void InsertLast(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[newArray.Length - 1] = value;

            for (int i = 0; i < newArray.Length - 1; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        /// <summary>
        /// Delete first element
        /// </summary>
        /// <param name="array"></param>
        static void DeleteFirst(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }

            array = newArray;
        }
        /// <summary>
        /// Delete last element
        /// </summary>
        /// <param name="array"></param>
        static void DeleteLast(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        /// <summary>
        /// Delete by index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        static void DeleteByIndex(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }

            array = newArray;
        }





        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4};
            int[] myArray1 = {1, 2, 3, 4};
            int[] myArray2 = {1, 2, 3, 4};
            int[] myArray3 = {1, 2, 3, 4};
            int[] myArray4 = {1, 2, 3, 4};
            int[] myArray5 = {1, 2, 3, 4};

            InsertByIndex(ref myArray, 4, 0);
            InsertFirst(ref myArray1, 4);
            InsertLast(ref myArray2, 5);
            DeleteFirst(ref myArray3);
            DeleteLast(ref myArray4);
            DeleteByIndex(ref myArray5, 0);
            
        }
    }
}
