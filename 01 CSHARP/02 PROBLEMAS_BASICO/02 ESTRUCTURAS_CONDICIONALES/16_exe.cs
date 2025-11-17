using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide tres números diferentes y muéstralos en orden ascendente.
        */
        Console.Write("Escribe el 1er numero : ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.Write("Escribe el 1er numero : ");
        double numero2 = double.Parse(Console.ReadLine());
        Console.Write("Escribe el 1er numero : ");
        double numero3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ordenándolos de forma ascendente...");
        Console.ReadKey();
        if (numero1 < numero2 && numero2 < numero3) Console.WriteLine(string.Join(" - ", numero1, numero2, numero3));
        else if (numero2 < numero3 && numero3 < numero1) Console.WriteLine(string.Join(" - ", numero2, numero3, numero1));
        else if (numero3 < numero1 && numero1 < numero2) Console.WriteLine(string.Join(" - ", numero3, numero2, numero1));
        else Console.WriteLine(string.Join(" - ", numero3, numero1, numero2));
    }
}