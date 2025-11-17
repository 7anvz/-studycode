using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario la distancia recorrida (en km)
        y el tiempo empleado (en horas). Calcula y muestra
        la velocidad promedio.
        */
        Console.Write("Distancia recorrida (km) : ");
        double km = double.Parse(Console.ReadLine());
        Console.Write("Tiempo empleado (Horas) : ");
        double tiempo = double.Parse(Console.ReadLine());
        double velocidad = km / tiempo;
        Console.Write($"Usted recorrera {km}km en {tiempo} horas. \nA una velocidad de {velocidad:F2}km/h");
    }
}