using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Escribe un programa que pida al usuario su nombre y 
        luego lo salude personalmente. Por ejemplo, si el usuario introduce "Ana", 
        el programa debe mostrar: "¡Hola, Ana!".
        */
        Console.Write("Escribe tu nombre : ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hey {nombre}!");
    }
}