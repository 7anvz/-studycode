using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario dos valores (A y B).
        Intercambia sus valores y muestra el resultado. Ejemplo: Si A=5 y B=3,
        después del intercambio se debe mostrar A=3 y B=5.
        Pista: Necesitarás una variable auxiliar.
        */
        Console.Write("Escribe el valor de A : ");
        string A = Console.ReadLine();
        Console.Write("Escribe el valor de B : ");
        string B = Console.ReadLine();
        string auxiliar;
        Console.WriteLine($"A vale >>> {A} B vale : {B}");
        auxiliar = A;
        A = B;
        B = auxiliar;
        Console.WriteLine($"A vale >>> {A} B vale : {B}");
    }
}