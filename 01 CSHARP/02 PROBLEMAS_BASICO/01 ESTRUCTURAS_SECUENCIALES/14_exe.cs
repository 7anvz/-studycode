using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide el precio original de un producto y el porcentaje
         de descuento. Calcula el monto descontado y el precio final.
        */
        Console.Write("Precio de producto : ");
        double PrecioOriginal = double.Parse(Console.ReadLine());
        Console.Write("Porcentaje de descuento : ");
        double Porcentaje = double.Parse(Console.ReadLine());
        double Descuento = PrecioOriginal * (Porcentaje / 100);
        double PrecioFinal = PrecioOriginal - Descuento;
        Console.WriteLine($"PRECIO ORIGINAL : S/{PrecioOriginal}");
        Console.WriteLine($"PORCENTAJE DESCUENTO : {Porcentaje}%");
        Console.WriteLine($"CANTIDAD DESCUENTO : S/{Descuento}");
        Console.WriteLine($"PRECIO FINAL : S/{PrecioFinal}");
    }
}