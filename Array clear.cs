using System;

class ArrayClear
{
    static void Main()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("");
        Console.WriteLine($"Before: {pallets[0].ToLower()}");

        // Clearing the first two elements
        Array.Clear(pallets, 0, 2);

        // Checking if the first element is not null before using ToLower()
        if (pallets[0] != null)
        {
            Console.WriteLine($"After: {pallets[0].ToLower()}");
        }

        // Displaying array details after clearing
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}