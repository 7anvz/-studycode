using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Desarrolla un programa que pida un número al usuario y
        muestre su tabla de multiplicar completa desde el 1 hasta el 10.
        */
        Console.Write("Escriba un numero : ");
        int numeroTabla = int.Parse(Console.ReadLine());
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
        }
    }
}