using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Solicita un año y determina si es bisiesto (divisible entre 4,
        pero no entre 100, excepto si es divisible entre 400).
        */
        Console.Write("Escribe un año : ");
        int anio = int.Parse(Console.ReadLine());
        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
        {
            Console.WriteLine("El año es Bisiesto");
            return;
        }
        Console.WriteLine("El año no es Bisiesto");
    }
}