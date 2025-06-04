using System;

namespace DSA_Learning
{
    public class Example1
    {
        public void FindMinimum()
        {
            int[] my_array = { 7, 12, 9, 4, 11 };
            int minValue = my_array[0];

            foreach (int i in my_array)
            {
                if (i < minValue)
                {
                    minValue = i;
                }
            }

            Console.WriteLine("Minimum value in the array is: " + minValue);
        }
    }
}
