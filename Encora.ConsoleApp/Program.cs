using System;
using System.Collections.Generic;
using Encora.Business.Implement;
using Encora.Business.Interface;

namespace Encora.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your count string:");

            int countString = Int32.Parse(Console.ReadLine());
            List<string> stringToTest = new List<string>();
            for (int i = 0; i < countString; i++)
                stringToTest.Add(Console.ReadLine());

            ISortedServices sortedServices = new SortedServices();

            foreach (string stringToSort in stringToTest)
            {
                Console.WriteLine(sortedServices.SortingOperations(stringToSort));
            }
        }
    }
}
