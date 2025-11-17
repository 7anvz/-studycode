using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario una cantidad de dinero en euros y el precio actual
         del dólar (1 euro = X dólares). Convierte la cantidad a dólares y muéstrala.
        */
        Console.Write("Escriba una cantidad de dinero en EUROS : ");
        double cantEuros = double.Parse(Console.ReadLine());
        Console.Write("Escriba el valor del dolar: ");
        double dolar = double.Parse(Console.ReadLine());
        double conversion = cantEuros * dolar;
        Console.WriteLine($"{cantEuros} euros es igual a {conversion} dolares");
    }
}