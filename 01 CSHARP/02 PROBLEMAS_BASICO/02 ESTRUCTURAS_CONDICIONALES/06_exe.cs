using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide un número del 1 al 7 y muestra el día de la semana correspondiente.
        */
        Console.Write("Escriba un numero del 1 al 7 : ");
        int numero = int.Parse(Console.ReadLine());
        if (numero > 7 && numero < 1)
        {
            Console.WriteLine("Le dijimos numeros del 1 al 7 ehh");
            Console.WriteLine("Saliendo del programa...");
            Console.ReadKey();
            return;
        }
            if (numero == 1) Console.WriteLine("Elegiste Lunes!");
            else if (numero == 2) Console.WriteLine("Elegiste Martes!");
            else if (numero == 3) Console.WriteLine("Elegiste Miercoles!");
            else if (numero == 4) Console.WriteLine("Elegiste Jueves!");
            else if (numero == 5) Console.WriteLine("Elegiste Sábado!");
            else if (numero == 6) Console.WriteLine("Elegiste Domingo!");
            else { Console.WriteLine("Elegiste Domingo!"); }
    }
}