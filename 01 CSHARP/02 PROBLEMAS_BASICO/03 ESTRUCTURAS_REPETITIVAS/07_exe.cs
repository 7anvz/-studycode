using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Realiza un programa que pida números al usuario hasta que
        ingrese el cero, luego muestre el mayor número ingresado.
        */
        double numero;
        int i = 1;
        double max = 0;
        while (numero != 0)
        {
            Console.Write($"Ingrese el numero {i} : ");
            numero = double.Parse(Console.ReadLine());
            i++;
            if (max < numero) max = numero;
        }
        Console.WriteLine($"El numero máximo es : {max}");
    }
}