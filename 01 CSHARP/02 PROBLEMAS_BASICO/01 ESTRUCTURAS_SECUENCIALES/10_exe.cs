using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario el precio base de un producto sin
        IVA y aplica un 21% de IVA. Muestra el precio final.
        */
        Console.Write("Indique el precio del producto : ");
        double precio = double.Parse(Console.ReadLine());
        double iva = precio * 0.21;
        double finalprecio = precio + iva;
        Console.WriteLine($"PRECIO INICIAL : {precio}");
        Console.WriteLine($"IVA 21% : {iva}");
        Console.WriteLine($"PRECIO FINAL : {finalprecio}");
    }
}