using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide los años de antigüedad de un empleado. 
        Si tiene más de 5 años, recibe 10% de bonificación, sino 5%.
        */
        Console.Write("Años de antiguedad : ");
        int antiguedad = int.Parse(Console.ReadLine());
        string mensaje = "";
        double bonificacion = 0;
        if (antiguedad > 5) { mensaje = "Recibe bonificación de 10%"; bonificacion = 0.10; }
        else { mensaje = "Recibe bonificación de 5%"; bonificacion = 0.05; }
        Console.WriteLine("Presione enter para aplicar");
        Console.ReadKey();
        Console.Write("Ingrese lo que recibe : ");
        double sueldo = double.Parse(Console.ReadLine());
        double sueldo_final = sueldo + (sueldo * bonificacion);
        Console.WriteLine($"RECIBE INICIAL : {sueldo}");
        Console.WriteLine($"BONIFICACION : {bonificacion*sueldo}");
        Console.WriteLine($"RECIBE FINAL : {sueldo_final}");
    }
}