using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide el monto de compra. Si es mayor a S/100,
        aplica 10% de descuento, sino no aplica descuento.
        */
        Console.Write("Escriba el precio de compra : ");
        double precio = double.Parse(Console.ReadLine());
        double descuento = 0;
        string mensaje = "";
        if (precio > 100)
        {
            descuento = precio * 0.10;
            mensaje = "Aplica descuento! Su descuento es de : ";
        }
        else { mensaje = "No aplica descuento"; }
        Console.WriteLine(mensaje + descuento);
        Console.WriteLine($"El precio final a pagar es : {precio - descuento}");
    }
}