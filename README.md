# Inventory Management System 
A simple console-based inventory management system that can track product inventory

Features
- *Add Items*: Add new items to the inventory with name, quantity, and price.
- *View Items*: Display all items in the inventory with their details.
- *Calculate Total Value*: Calculate and display the total value of all items in the inventory.
- *Delete Items*: Remove items from the inventory by name.

Requirements
- .NET Core or .NET Framework

Usage
1. Run the application.
2. Choose an option from the menu:
    - Add Item
    - View Items
    - Display Total Value of Inventory
    - Delete Item
    - Exit

Code Structure
The code is organized into the following classes:
- `Item`: Represents an item in the inventory (Model).
- `InventoryManager`: Manages the inventory, including adding, retrieving, calculating total value, and deleting items.
- `InventoryController`: Acts as an intermediary between the `Program` class and the `InventoryManager` class, encapsulating inventory management logic (optional).
- `Program`: The main program class that interacts with the inventory management system.

