using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario su peso (en kg) y su altura (en metros).
         Calcula el IMC usando la fórmula: IMC = peso / (altura * altura).
        */
        Console.Write("Indique su peso (kilogramos) : ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Indique su altura (metros) : ");
        double altura = double.Parse(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine($"Su indice de masa corporal es {imc:F2}");
    }
}