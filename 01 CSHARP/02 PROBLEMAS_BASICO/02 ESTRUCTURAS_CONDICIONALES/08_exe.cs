using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide la edad del usuario y clasifícala: niño (0-12),
        adolescente (13-17), adulto (18-64), adulto mayor (65+).
        */
        Console.Write("Escriba su edad : ");
        int edad = int.Parse(Console.ReadLine());
        if (edad < 0) { Console.WriteLine("Usted es un bebé... ._."); return; }
        if (edad > 0 && edad <= 12) Console.WriteLine("Usted es un Niño");
        else if (edad >= 13 && edad <= 17) Console.WriteLine("Usted es un Adolescente");
        else if (edad >= 18 && edad <= 64) Console.WriteLine("Usted es un Adulto");
        else if (edad > 65) Console.WriteLine("Usted es un Adulto Mayor");
    }
}