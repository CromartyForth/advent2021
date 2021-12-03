using System;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter = 0;
            foreach (string line in System.IO.File.ReadLines(@"HeightData.txt"))
            {
                counter++;
            }
            int [] heights = new int[counter];
            
            
            //Read file and create array of ints
            int index = 0;
            foreach (string line in System.IO.File.ReadLines(@"HeightData.txt"))
            {
                if(Int32.TryParse(line, out int num))
                {
                    heights[index] = num;
                }
                else
                {
                    Console.WriteLine($"Unable to parse string at index '{index}'");
                }
                index++;
            }

            //Compare each subsequent measuremnt to count the increases.
            int increaseCount = 0;
            
            for (int i = 1; i < counter; i++)
            {
                int current = heights[i];
                int precursor = heights[i-1];
                if (current > precursor)
                {
                    increaseCount++;
                }
            }

            Console.WriteLine($"Number of increases is '{increaseCount}'");

        }
    }
}
