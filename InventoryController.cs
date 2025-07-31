using System;

public class InventoryController
{
    private InventoryManager inventoryManager;

    public InventoryController(InventoryManager inventoryManager)
    {
        this.inventoryManager = inventoryManager;
    }

    public void AddItem(Item item)
    {
        inventoryManager.AddItem(item);
    }

    public void ViewItems()
    {
        var items = inventoryManager.GetItems();
        foreach (var item in items)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price:C}");
        }
    }

    public void DisplayTotalValue()
    {
        var totalValue = inventoryManager.CalculateTotalValue();
        Console.WriteLine($"Current Total Value of Inventory: {totalValue:C}");
    }

    public void DeleteItem(string name)
    {
        if (inventoryManager.DeleteItem(name))
        {
            Console.WriteLine("Item deleted successfully!");
        }
        else
        {
            Console.WriteLine("Item not found!");
        }
    }
}
