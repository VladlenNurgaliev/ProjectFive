using System;

namespace C_Sharp
{
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;

            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            Console.WriteLine(myArray?.Sum() ?? 0);



            Console.ReadLine();
        }
    }
}