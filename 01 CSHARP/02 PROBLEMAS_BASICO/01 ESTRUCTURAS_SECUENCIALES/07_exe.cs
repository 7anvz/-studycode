using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario tres notas (pueden tener decimales) 
        y calcula su promedio. Muestra el resultado con dos decimales.
        */
        Console.Write("Escriba la primera nota : ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Escriba la segunda nota : ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Escriba la tercera nota : ");
        double nota3 = double.Parse(Console.ReadLine());
        double promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"EL PROMEDIO ES : {promedio}");
    }
}