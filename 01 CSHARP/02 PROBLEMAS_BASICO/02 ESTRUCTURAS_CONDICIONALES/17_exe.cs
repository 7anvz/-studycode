using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide tres números diferentes y muéstralos en orden ascendente.
        SEGUNDA FORMA
        */
        Console.Write("Escribe el 1er numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.Write("Escribe el 2do numero");
        double numero2 = double.Parse(Console.ReadLine());
        Console.Write("Escribe el 3er numero");
        double numero3 = double.Parse(Console.ReadLine());
        double max, med, min;
        if (numero1 < numero2 && numero1 < numero3)
        {
            min = numero1;
            if (numero2 < numero3) { med = numero2; max = numero3; }
            else { med = numero3; max = numero2; }
        }
        else if (numero2 < numero1 && numero2 < numero3)
        {
            min = numero2;
            if (numero1 < numero3) { med = numero1; max = numero3; }
            else { med = numero3; max = numero1; }
        }
        else
        {
            min = numero3;
            if (numero1 < numero2) { med = numero1; max = numero2; }
            else { med = numero2; max = numero1; }
        }
        Console.WriteLine(string.Join("|", min, med, max));
    }
}