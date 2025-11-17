using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Crea un programa que pida números positivos al usuario y los sume. 
        El programa debe terminar cuando se ingrese un número negativo.
        */
        double suma = 0;
        double numero;
        do
        {
            Console.Write("Escriba un numero positivo : ");
            numero = double.Parse(Console.ReadLine());
            suma += (numero >= 0) ? numero : 0; //operador ternario con acumulador
        } while (numero >= 0);
        Console.WriteLine($"La suma de los numeros es: {suma}");
    }
}