using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Realiza un programa que lea 8 edades diferentes y determine cuántas
        personas son mayores de edad y cuántas son menores de edad.
        */
        double mayores = 0;
        double menores = 0;
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Ingrese la edad {i + 1} : ");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 0)
            {
                Console.WriteLine("Ingrese edades mayores a 0");
                i--;
                continue;
            }
            if (edad >= 18) mayores++;
            else { menores++; }
        }
        Console.WriteLine($"Mayores : {mayores} | Menores {menores}");
    }
}