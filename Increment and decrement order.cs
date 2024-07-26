using System;

class IncrementDecrement
{
    static void Main()
    {
        int value = 33;
        value++;
        Console.WriteLine("First: " + value);
        
        Console.WriteLine("Second: " + value++);
        Console.WriteLine("Third: " + value);
        
        Console.WriteLine("Fourth: " + (++value));
        ++value;
        value++;
        
        Console.WriteLine("Fifth: " + value);
    }
}
