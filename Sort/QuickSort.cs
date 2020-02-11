class QuickSort
{
    private static int counter_check = 0;
    private static int counter_permutation = 0;
    private static int counter = 0;
    private static void DoSort(int[] data, int start, int end)
    {
        if (start >= end) return;
        int left = start;
        int right = end;
        int curr = left - (left - right) / 2; //middle of the array
        while (left < right)
        {
            // skip already sorted left side
            while (data[left] <= data[curr] && left < curr)
            {
                counter_check++;
                left++;
            }
            // skip already sorted right side
            while (data[curr] <= data[right] && curr < right)
            {
                counter_check++;
                right--;
            }
            // now, actually sort
            if (left < right)
            {
                int tmp = data[left];
                data[left] = data[right];
                data[right] = tmp;
                counter++;
                counter_permutation++;
                if (curr == left) { curr = right; }
                else if (curr == right) { curr = left; }
            }
        }
        DoSort(data, start, curr);
        DoSort(data, curr + 1, end);
    }

    public static int[] Sort(int[] origin)
    {
        int[] process = (int[])origin.Clone();
        DoSort(process, 0, process.Length - 1);

        return process;
    }
    public static void Main()
    {
        int[] arr = { 3, 5, 8, 1, 2, 9, 3, 7, 6 };
        foreach (int item in arr)
        {
            System.Console.Write(item.ToString());
        }
        System.Console.Read();

        int[] sorted = Sort(arr);
        
        foreach (int item in sorted)
        {
            System.Console.Write(item.ToString());
        }
        System.Console.Read();

    }

}
