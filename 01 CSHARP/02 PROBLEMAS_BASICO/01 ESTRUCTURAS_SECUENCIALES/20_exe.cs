using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario su año de 
        nacimiento y el año actual. 
        Calcula y muestra su edad actual.
        */
        Console.Write("Digite su año de nacimiento : ");
        int añonacimiento = int.Parse(Console.ReadLine());
        Console.Write("Digite el año actual : ");
        int añoactual = int.Parse(Console.ReadLine());
        int edad = añoactual - añonacimiento;
        Console.WriteLine($"Usted tiene {edad} años.");
    }
}