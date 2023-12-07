using System;

class InventoryItem
{
    public string ItemCode { get; set; }
    public int InitialUnits { get; set; }
    public int UnitsPurchased { get; set; }
    public int UnitsIssued { get; set; }

    public int CurrentUnits => InitialUnits + UnitsPurchased - UnitsIssued;

    public double CurrentLevelPercentage => (double)CurrentUnits / InitialUnits * 100;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Inventory Level Calculator");

        // Envanterdeki öğe sayısıbı giriş
        Console.Write("Enter the number of inventory items: ");
        int itemCount = int.Parse(Console.ReadLine());

        // Envanter öğelerini depolamak için dizi
        InventoryItem[] inventoryItems = new InventoryItem[itemCount];

        // Her envanter kalemi için giriş
        for (int i = 0; i < itemCount; i++)
        {
            Console.WriteLine($"\nEnter details for Item {i + 1}:");

            // yeni bir InventoryItem değişkeni oluştrumak
            InventoryItem item = new InventoryItem();

            Console.Write("Item Code: ");
            item.ItemCode = Console.ReadLine();

            Console.Write("Initial Number of Units: ");
            item.InitialUnits = int.Parse(Console.ReadLine());

            Console.Write("Number of Units Purchased: ");
            item.UnitsPurchased = int.Parse(Console.ReadLine());

            Console.Write("Number of Units Issued: ");
            item.UnitsIssued = int.Parse(Console.ReadLine());

            // envantere başka bir item ekleme
            inventoryItems[i] = item;
        }

        // Herhangi bir öğenin envanter düzeyinin %1 düşüp düşmediğini kontrol edin.
        Console.WriteLine("\nInventory Status:");

        foreach (var item in inventoryItems)
        {
            Console.WriteLine($"Item Code: {item.ItemCode}");
            Console.WriteLine($"Current Units: {item.CurrentUnits}");
            Console.WriteLine($"Current Level Percentage: {item.CurrentLevelPercentage}%");

            if (item.CurrentLevelPercentage < 1)
            {
                Console.WriteLine("Alert: Inventory level is below 1%!\n");
            }
            else
            {
                Console.WriteLine("\n");
            }
        }
    }
}