using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario el total de la cuenta de un restaurante y el
        porcentaje de propina que desea dejar. Calcula el monto de la propina
         y el total a pagar.
        */
        Console.Write("Digite el total de la cuenta : ");
        double CuentaPagar = double.Parse(Console.ReadLine());
        Console.Write("Porcentaje de propina que desea dejar : ");
        int Porcentaje = int.Parse(Console.ReadLine());
        double Propina = (CuentaPagar * (double)Porcentaje) / 100;
        double TotalPagar = Propina + CuentaPagar;
        Console.WriteLine($"--- RESUMEN DE CUENTA --- ");
        Console.WriteLine($"PROPINA : {Propina}");
        Console.WriteLine($"TOTAL A PAGAR : {TotalPagar}");
    }
}