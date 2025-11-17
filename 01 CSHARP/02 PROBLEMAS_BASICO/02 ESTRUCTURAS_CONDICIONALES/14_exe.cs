using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide una letra y determina si es una vocal o consonante.
        */

        Console.Write("Escriba una letra : ");
        char letra = char.Parse(Console.ReadLine());
        
        string vocales = "aeiouAEIOU";
        string tipo = vocales.Contains(letra) ? "Vocal" : "Consonante";
        
        Console.WriteLine($"'{letra}' es una {tipo}");
    }
}