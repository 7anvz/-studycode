using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Calcula el IMC y clasifica: Bajo peso (<18.5), 
        Normal (18.5-24.9), Sobrepeso (25-29.9), Obesidad (≥30).
        */
        Console.Write("Indique su peso (kilogramos) : ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Indique su altura (metros) : ");
        double altura = double.Parse(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine("Obteniendo resultados...");
        Console.ReadKey();
        Console.WriteLine($"Su indice de masa corporal es {imc:F2}");
        if (imc < 18.5) Console.WriteLine("Usted tiene un bajo peso!");
        else if (imc >= 18.5 && imc <= 24.9) Console.WriteLine("Usted tiene un peso normal");
        else if (imc >= 25 && imc <= 29.9) Console.WriteLine("Usted tiene sobrepreso!");
        else if (imc >= 30) Console.WriteLine("Usted tiene Obesidad");
        else { Console.WriteLine("Error");  }
    }
}