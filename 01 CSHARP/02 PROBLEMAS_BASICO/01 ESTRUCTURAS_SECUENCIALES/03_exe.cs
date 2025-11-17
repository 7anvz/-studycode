using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario la base y la altura de un rectángulo, 
        calcula su área (base * altura) y muestra el resultado.
        */
        Console.Write("Indique la base del rectangulo :");
        int baseR = int.Parse(Console.ReadLine());
        Console.Write("Indique la altura del rectangulo : ");
        int alturaR = int.Parse(Console.ReadLine());
        int areaR = baseR * alturaR;
        Console.WriteLine($"El area del rectangulo es {areaR}");
    }
}