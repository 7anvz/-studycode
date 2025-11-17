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
        string tipo = "";
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            tipo = "Vocal";
        }
        else
        {
            tipo = "Consonante";
        }
        Console.WriteLine($"{letra} es una {tipo}");
    }
}