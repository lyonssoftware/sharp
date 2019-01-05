using System;
class SelectionSort
{
    static void Main(string[] args)
    {
        // set the array size
        int array_size = 10;
        // array
        int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
        // print the below array 
        Console.WriteLine("The Array Before Selection Sort is: ");
        for (int i = 0; i < array_size; i++)
        {
            Console.WriteLine(array[i]);
        }
        int tmp, min_key;
 // array to fond selection 
        for (int j = 0; j < array_size - 1; j++)
        {
            // set the minkey 
            min_key = j;
 
            for (int k = j + 1; k < array_size; k++)
            {
                // check the aret
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }
 
            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }
 
        Console.WriteLine("The Array After Selection Sort is: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]);
        }
        // print the sorted array
        Console.ReadLine();
    }
    // end of program
}
