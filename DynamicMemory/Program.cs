using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMemory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> dynamicList = new List<int>();

            Console.WriteLine("Enter integers to add to the list (enter -1 to stop):");

            while (true)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == -1)
                    break;

                dynamicList.Add(input);
            }

            Console.WriteLine("Dynamic List Elements:");
            foreach (int num in dynamicList)
            {
                Console.Write(num + " ");
            }

            int[] dynamicArray = dynamicList.ToArray();

            Console.WriteLine("\n\nDynamic Array Elements:");
            foreach (int num in dynamicArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}
