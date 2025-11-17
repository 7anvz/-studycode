using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario el área de una pared a pintar (m²)
        y el rendimiento de la pintura (m²/litro). Calcula cuántos litros
        de pintura necesita comprar.
        */
        Console.Write("Digita el area de la pared (m^2) : ");
        double area = double.Parse(Console.ReadLine());
        Console.Write("Los m^2 que por litro se pueden pintar : ");
        double metroscuadrados = double.Parse(Console.ReadLine());
        double pintura = area / metroscuadrados;
        Console.WriteLine($"Se necesitará {pintura} litros de pintura");
        Console.WriteLine($"para pintar una pared de {area} m^2");
    }
}