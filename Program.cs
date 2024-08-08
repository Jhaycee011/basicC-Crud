using System;

namespace CrudApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            while (true)
            {
                Console.WriteLine("Inventory Management System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Update Item");
                Console.WriteLine("3. Delete Item");
                Console.WriteLine("4. View Items");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddItem(inventory);
                        break;
                    case "2":
                        UpdateItem(inventory);
                        break;
                    case "3":
                        DeleteItem(inventory);
                        break;
                    case "4":
                        ViewItems(inventory);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddItem(Inventory inventory)
        {
            Console.Write("Enter item name: ");
            var name = Console.ReadLine();
            Console.Write("Enter item quantity: ");
            var quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter item price: ");
            var price = decimal.Parse(Console.ReadLine());
            inventory.AddItem(name, quantity, price);
        }

        static void UpdateItem(Inventory inventory)
        {
            Console.Write("Enter item ID to update: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Enter new item name: ");
            var name = Console.ReadLine();
            Console.Write("Enter new item quantity: ");
            var quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter new item price: ");
            var price = decimal.Parse(Console.ReadLine());
            inventory.UpdateItem(id, name, quantity, price);
        }

        static void DeleteItem(Inventory inventory)
        {
            Console.Write("Enter item ID to delete: ");
            var id = int.Parse(Console.ReadLine());
            inventory.DeleteItem(id);
        }

        static void ViewItems(Inventory inventory)
        {
            inventory.ViewItems();
        }
    }
}
