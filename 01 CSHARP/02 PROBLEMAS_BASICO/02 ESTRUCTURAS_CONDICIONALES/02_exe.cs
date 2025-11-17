using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Crea un programa que solicite un número entero
        y determine si es par o impar.
        */
        Console.Write("Escriba un numero : ");
        int numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0) Console.WriteLine("Numero es par");
        else if (numero % 2 != 0) Console.WriteLine("Numero es impar");
        else { Console.WriteLine("ERROR!"); }
    }
}