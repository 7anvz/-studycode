using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario la distancia del viaje (km)
        y el consumo de combustible del vehículo (km/litro).
        Calcula cuántos litros de combustible necesitará.
        */
        Console.Write("Distancia del viaje (km) : ");
        double distancia = double.Parse(Console.ReadLine());
        Console.Write("Consumo de combustible (km por litro) : ");
        double kmlitro = double.Parse(Console.ReadLine());
        double combustible = distancia/kmlitro;
        Console.WriteLine($"Recorrera {distancia} km, para lo que necesitara {combustible:F1} litros de combustible");
    }
}