using System;
using System.Runtime.InteropServices;


partial class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Swap(ref a, ref b);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}