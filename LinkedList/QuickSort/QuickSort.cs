using System;

namespace Quick
{
    class QuickSort
    {
        public static void Swap(int x, int y)
        {
            x += y;
            y = x - y;
            x -= y;
        }
        public static void Main()
        {
            Random random = new Random();
            int[] arr = { 3, 5, 8, 1, 2, 9, 3, 7, 6 };
            random.Next(0, arr.Length);
            Swap(4, 6);
        }

    }
}
