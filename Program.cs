// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Array_Sample_Code;
using System;

internal class ArrayInput
{
    public static void toPrint<X>(X[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.WriteLine(element);
        }
        //for (int i = 0; i < inputArray.Length; i = i + 2)
        //{
        //    Console.WriteLine(inputArray[i]);
        //}
        Console.WriteLine("----------------------------------");
    }
    class program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            //Program.toPrint(intArray);
            //Program.toPrint(doubleArray);
            //Program.toPrint(charArray);

            ArrayInput.toPrint<int>(intArray);
            ArrayInput.toPrint<double>(doubleArray);
            ArrayInput.toPrint<char>(charArray);
            Console.ReadKey();
        }
    }
}
