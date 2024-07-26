using System;

class TemperatureConverter
{
    static void Main()
    {
        int fahrenheit1 = 50;
        decimal temperature1 = (fahrenheit1 - 32) * 5m / 9;
        Console.WriteLine("The temperature is " + temperature1 + " degrees Celsius");

        int fahrenheit2 = 65;
        decimal temperature2 = (fahrenheit2 - 32m) * 5m / 9m;
        Console.WriteLine("The temperature is " + Math.Round(temperature2) + " degrees Celsius");
    }
}
