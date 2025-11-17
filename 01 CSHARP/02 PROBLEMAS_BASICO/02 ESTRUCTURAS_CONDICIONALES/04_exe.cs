using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Solicita la nota de un estudiante (0-20) y determina
        si está aprobado (≥11) o reprobado.
        */
        Console.Write("Escriba la nota del Estudiante : ");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 11) Console.WriteLine("Está aprobado");
        else { Console.WriteLine("Está reprobado"); }
    }
}