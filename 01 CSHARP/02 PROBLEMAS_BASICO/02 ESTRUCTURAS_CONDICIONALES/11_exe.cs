using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Solicita un número y determina si es positivo, negativo o cero.
        */
        Console.Write("Escribe un numero : ");
        int numero = int.Parse(Console.ReadLine());
        if (numero < 0) Console.WriteLine("El numero es negativo");
        else if (numero > 0) Console.WriteLine("El numero es positivo");
        else { Console.WriteLine("El numero es 0"); }
    }
}