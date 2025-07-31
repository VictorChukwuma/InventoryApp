using System;
using System.Collections.Generic;

public class InventoryManager
{
    private List<Item> inventory = new List<Item>();

    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public List<Item> GetItems()
    {
        return inventory;
    }

    public decimal CalculateTotalValue()
    {
        decimal totalValue = 0;
        foreach (Item item in inventory)
        {
            totalValue += item.Quantity * item.Price;
        }
        return totalValue;
    }

    public bool DeleteItem(string name)
    {
        Item itemToRemove = inventory.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            return true;
        }
        return false;
    }
}
