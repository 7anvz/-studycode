using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide dos números al usuario y muestra
        cuál es el mayor, o si son iguales.
        */
        Console.Write("Escriba el primer numero : ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.Write("Escriba el segundo numero : ");
        double numero2 = double.Parse(Console.ReadLine());
        if (numero1 > numero2) Console.WriteLine($"{numero1} es mayor que {numero2}");
        else if (numero1 < numero2) Console.WriteLine($"{numero2} es mayor que {numero1}");
        else { Console.WriteLine("Ambos numeros son iguales ehh"); }
    }
}