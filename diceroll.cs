using System;

class Program
{
    static void Main()
    {
        Random rdn = new Random();
        int zar= rdn.Next(1, 7);
        Console.WriteLine("result" + zar);
    }
}
