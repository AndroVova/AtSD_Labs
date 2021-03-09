using System;

namespace Lab1_AtSD
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedLinkedList<int>();

            Console.WriteLine("Enter number of items you want to add: ");
            int numOfAddItems = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numOfAddItems; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }


            Console.WriteLine("Enter number of items you want to delete: ");
            int numOfDeleteItems = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numOfDeleteItems; i++)
            {
                list.Delete(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Enter number you want to find: ");
            list.Search(Convert.ToInt32(Console.ReadLine()));

        }
    }
}
