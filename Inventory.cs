using System;
using System.Collections.Generic;

namespace CrudApp
{
    public class Inventory
    {
        private List<Item> items;
        private int nextId;

        public Inventory()
        {
            items = new List<Item>();
            nextId = 1;
        }

        public void AddItem(string name, int quantity, decimal price)
        {
            var item = new Item
            {
                Id = nextId++,
                Name = name,
                Quantity = quantity,
                Price = price
            };
            items.Add(item);
            Console.WriteLine("Item added successfully.");
        }

        public void UpdateItem(int id, string name, int quantity, decimal price)
        {
            var item = items.Find(i => i.Id == id);
            if (item != null)
            {
                item.Name = name;
                item.Quantity = quantity;
                item.Price = price;
                Console.WriteLine("Item updated successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void DeleteItem(int id)
        {
            var item = items.Find(i => i.Id == id);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void ViewItems()
        {
            Console.WriteLine("Items in inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price:C}");
            }
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
