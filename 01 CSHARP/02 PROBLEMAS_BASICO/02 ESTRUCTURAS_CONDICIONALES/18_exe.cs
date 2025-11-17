using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide tres lados y determina si pueden formar un triángulo válido
        (la suma de dos lados debe ser mayor al tercero).
        */
        Console.Write("Ingresa el 1er lado : ");
        double lado1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el 2do lado : ");
        double lado2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el 3er lado : ");
        double lado3 = double.Parse(Console.ReadLine());
        if (lado1 + lado2 > lado3 &&
           lado2 + lado3 > lado1 &&
           lado1 + lado3 > lado2)
        { Console.WriteLine("Forma un triangulo válido!"); }
        else { Console.WriteLine("No forma un triangulo válido!"); }
    }
}