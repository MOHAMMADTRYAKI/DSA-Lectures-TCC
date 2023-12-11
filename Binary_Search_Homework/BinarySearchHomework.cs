using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end)
        {
            if (start <= end)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;

                if (arr[mid1] == key)
                    return mid1;
                if (arr[mid2] == key)
                    return mid2;

                if (key < arr[mid1])
                    return TernarySearch(arr, key, start, mid1 - 1);
                else if (key > arr[mid2])
                    return TernarySearch(arr, key, mid2 + 1, end);
                else
                    return TernarySearch(arr, key, mid1 + 1, mid2 - 1);
            }

            return -1;
        }

        public static int BinarySearchForCalculatingRepeated (int[] arr, int key, bool is_first, int start, int end) 
        {
            if (is_first == true)
            {
                int middlefirst = (start + end) / 2;

                if (arr[middlefirst] == key && arr[middlefirst - 1] != key)
                    return middlefirst;

                if (start > end)
                    return -1;

                if (arr[middlefirst] > key || arr[middlefirst - 1] == key)
                    return BinarySearchForCalculatingRepeated(arr, key, true, start, middlefirst - 1);

                if (arr[middlefirst] < key || arr[middlefirst + 1] == key)
                    return BinarySearchForCalculatingRepeated(arr, key, true, middlefirst + 1, end);
            }

            if (is_first == false)
            {
                int middleEnd = (start + end) / 2;

                if (arr[middleEnd] == key && arr[middleEnd + 1] != key)
                    return middleEnd;

                if (start > end)
                    return -1;

                if (arr[middleEnd] > key)
                    return BinarySearchForCalculatingRepeated(arr, key, false, start, middleEnd - 1);

                return BinarySearchForCalculatingRepeated(arr, key, false, middleEnd + 1, end);
            }
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            int x = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            int y = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);
            int count = 0;
            for (int i = x; i <= y; i++)
            {
                count++;
            }
            return count;
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
           
        }
    }
}
