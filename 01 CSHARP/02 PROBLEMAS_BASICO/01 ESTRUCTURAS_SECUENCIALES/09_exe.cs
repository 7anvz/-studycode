using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario un número total y un porcentaje que quiere calcular. 
        Muestra el valor de ese porcentaje. 
        Ejemplo: Total = 200, Porcentaje = 15%, Resultado = 30.
        */
        Console.Write("Escribe una cantidad : ");
        double cantidad = double.Parse(Console.ReadLine());
        Console.Write("Escribe un porcentaje : ");
        int porcentaje = int.Parse(Console.ReadLine());
        int resultado = ((int)cantidad * porcentaje) / 100;
        Console.WriteLine($"TOTAL : {cantidad}");
        Console.WriteLine($"PORCENTAJE : {porcentaje}%");
        Console.WriteLine($"RESULTADO : {resultado}");
    }
}