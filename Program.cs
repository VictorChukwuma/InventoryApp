using System;

class Program
{
    static InventoryManager inventoryManager = new InventoryManager();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Items");
            Console.WriteLine("3. Display Total Value of Inventory");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddItem();
                    break;
                case "2":
                    ViewItems();
                    break;
                case "3":
                    DisplayTotalValue();
                    break;
                case "4":
                    DeleteItem();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter item name: ");
        string name = Console.ReadLine();
        Console.Write("Enter item quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.Write("Enter item price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Item newItem = new Item(name, quantity, price);
        inventoryManager.AddItem(newItem);
        Console.WriteLine("Item added successfully!\n");
    }

    static void ViewItems()
    {
        var items = inventoryManager.GetItems();
        if (items.Count == 0)
        {
            Console.WriteLine("No items in the inventory.\n");
            return;
        }
        Console.WriteLine("\nCurrent Inventory:");
        foreach (var item in items)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price:C}");
        }
        Console.WriteLine();
    }

    static void DisplayTotalValue()
    {
        var totalValue = inventoryManager.CalculateTotalValue();
        Console.WriteLine($"Current Total Value of Inventory: {totalValue:C}\n");
    }

    static void DeleteItem()
    {
        Console.Write("Enter item name to delete: ");
        string name = Console.ReadLine();
        if (inventoryManager.DeleteItem(name))
        {
            Console.WriteLine("Item deleted successfully!\n");
        }
        else
        {
            Console.WriteLine("Item not found!\n");
        }
    }
}
