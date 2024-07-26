using System;

class ArrayOperations
{
    static void Main()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        // Sorting the array
        Console.WriteLine("Sorted ....");
        Array.Sort(pallets);
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // Reversing the array
        Console.WriteLine("Reverse ....");
        Array.Reverse(pallets);
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}
