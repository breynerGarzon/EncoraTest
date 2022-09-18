using System;
using System.Collections.Generic;
using Encora.Business.Implement;
using Encora.Business.Interface;
using Encora.Model.StringReorderer;

namespace Encora.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your count string:");

            int countString = Int32.Parse(Console.ReadLine());
            List<ContainerStringComparison> stringToTest = new List<ContainerStringComparison>();
            for (int counter = 0; counter < countString; counter++)
            {
                Console.WriteLine("Enter your string value:");
                stringToTest.Add(new ContainerStringComparison() { OriginalString = Console.ReadLine() });
            }

            ISortedServices sortedServices = new SortedServices();

            foreach (ContainerStringComparison containerToSort in stringToTest)
            {
                containerToSort.ReorderedString = sortedServices.SortingOperations(containerToSort.OriginalString);
                string messageToUser = $"Original string= {containerToSort.OriginalString} Reordered string= {containerToSort.ReorderedString}";
                Console.WriteLine(messageToUser);
            }
        }
    }
}
