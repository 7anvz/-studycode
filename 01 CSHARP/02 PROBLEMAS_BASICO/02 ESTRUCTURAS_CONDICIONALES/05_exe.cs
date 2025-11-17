using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide dos números y una operación (+, -, *, /)
        y muestra el resultado.
        Valida la división entre cero.
        */
        Console.WriteLine("MINI-CALCULADORA");
        Console.Write("Escribe el primer numero : ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.Write("Escribe el segundo numero : ");
        double numero2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Decida que operacion realizar : ");
        Console.WriteLine("1|SUMA - 2|RESTA - 3|MULTIPLICACION - 4|DIVISION");
        Console.Write("Digite el numero de la operacion : ");
        int operacion = int.Parse(Console.ReadLine());
        if (operacion == 1) Console.WriteLine($"La suma es : {numero1 + numero2}");
        else if (operacion == 2) Console.WriteLine($"La resta es : {numero1 - numero2}");
        else if (operacion == 3) Console.WriteLine($"La multiplicación es : {numero1 * numero2}");
        else
        {
        if (numero2 != 0) Console.WriteLine($"La división es : {numero1 / numero2}");
        else { Console.WriteLine("No se puede dividir entre 0!"); }
        }
    }
}