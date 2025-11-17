using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Escribe un programa que pida la edad del usuario 
        y determine si es mayor de edad (18 años o más).
        */
        Console.Write("Escriba su edad : ");
        int edad = int.Parse(Console.ReadLine());
        if (edad >= 18) Console.WriteLine("Usted es mayor de edad");
        else { Console.WriteLine("Usted es menor de edad"); }
    }
}