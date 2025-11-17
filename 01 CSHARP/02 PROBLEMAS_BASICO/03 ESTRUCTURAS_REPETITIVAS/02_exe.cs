using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Crea un programa que solicite al usuario 10 números y 
        al final muestre la suma total de todos ellos.
        */
        double suma = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Escribe el numero {i + 1} : ");
            double numero = double.Parse(Console.ReadLine());
            suma += numero; //crear acumulador -> suma = suma + numero -> 0 = 0 + 20 -> 20 = 20 + 30 (AHORA SUMA VALE 50)
        }
        Console.WriteLine($"La suma de los 10 numeros es : {suma}");
    }
}