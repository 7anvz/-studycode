using System;
using Microsoft.Win32.SafeHandles;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario una cantidad de minutos y conviértela a horas y minutos. 
        Por ejemplo, 125 minutos son 2 horas y 5 minutos.
        */
        Console.Write("Escriba una cantidad de minutos : ");
        int minutos = int.Parse(Console.ReadLine());
        int horas = minutos / 60;
        int minHoras = minutos % 60;
        Console.WriteLine($"{minutos} minutos es igual a {horas} y {minHoras} minutos");
    }
}