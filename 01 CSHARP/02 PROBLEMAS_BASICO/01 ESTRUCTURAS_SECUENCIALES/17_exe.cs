using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario el capital inicial, la tasa de interés
        anual (%) y el tiempo en años. Calcula el interés simple usando la
        fórmula: Interés = capital * tasa * tiempo / 100.
        */
        Console.Write("El capital inicial es : ");
        double CapitalInicial = double.Parse(Console.ReadLine());
        Console.Write("La tasa de interes es : ");
        double TasaInteres = double.Parse(Console.ReadLine());
        Console.Write("El tiempo (en años) es : ");
        double Tiempo = double.Parse(Console.ReadLine());
        double Interes = (CapitalInicial * TasaInteres * Tiempo) / 100;
        double CapitalFinal = CapitalInicial + Interes;
        Console.Clear();
        Console.WriteLine($"CAPITAL INICIAL : {CapitalInicial}");
        Console.WriteLine($"TASA INTERES : {TasaInteres}");
        Console.WriteLine($"INTERES SIMPLE : {Interes}");
        Console.WriteLine($"CAPITAL FINAL : {CapitalFinal}");
        Console.WriteLine($">>> EN UN TIEMPO DE {Tiempo} AÑOS");

    }
}