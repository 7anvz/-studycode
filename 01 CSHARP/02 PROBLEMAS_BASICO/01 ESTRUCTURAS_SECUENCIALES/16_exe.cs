using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario una cantidad de tiempo en segundos
        y conviértela a minutos y segundos. 
        Ejemplo: 125 segundos = 2 minutos y 5 segundos.
        */
        Console.Write("Escriba una cantidad de segundos : ");
        int segundos = int.Parse(Console.ReadLine());
        int minutos = segundos / 60;
        int segMinutos = segundos % 60;
        Console.WriteLine($"{segundos} segundos es igual a {minutos} minutos y {segMinutos} segundos.");
    }
}