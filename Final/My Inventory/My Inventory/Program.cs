using System;
using System.Collections.Generic;

namespace My_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Max;
            string Name_St, Type_St;

            List<Item> Items = new List<Item>();
            List<string> TypeHave = new List<string>();

            Console.Write("Max number: ");
            int.TryParse(Console.ReadLine(), out Max);

            for (int i = 0; i < Max; i++)
            {
                Console.Write("Name: ");
                Name_St = Console.ReadLine();
                Console.Write("   Type: ");
                Type_St = Console.ReadLine();
                Console.WriteLine();
                Items.Add(AddItem(Name_St, Type_St));
                TypeHave.Add(Type_St);

            }

            if (Console.ReadLine() == "ShowAll")
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine($"Name: {Items[i].Name}  Type: {Items[i].Type}");

                }
                Console.WriteLine();
            }
        }
        public static Item AddItem(string N, string T)
        {
            Item NewItem = new Item();
            NewItem.Name = N;
            NewItem.Type = T;
            return NewItem;

        }
    }
    class Item
    {
        public string Name;
        public string Type;
    }
}
