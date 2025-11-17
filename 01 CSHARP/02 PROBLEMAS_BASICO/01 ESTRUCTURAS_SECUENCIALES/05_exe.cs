using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario el radio de una circunferencia y calcula su perímetro
        usando la fórmula 2 * π * radio. (Usa 3.1416 como valor de π).
        */
        Console.Write("Escribe el radio de una circunferencia : ");
        double radioCircun = double.Parse(Console.ReadLine());
        double perimetro = 2 * 3.1416 * radioCircun;
        Console.WriteLine($"El perimetro de la circunferencia es : {perimetro}");
    }
}