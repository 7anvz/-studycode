using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario dos números enteros, calcula su suma y
         muestra el resultado en pantalla.
        */
        Console.Write("Escriba el primer numero : ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Escriba el segundo numero : ");
        int numero2 = int.Parse(Console.ReadLine());
        int suma = numero1 + numero2;
        Console.WriteLine($"Suma es igual a {suma}");
    }
}