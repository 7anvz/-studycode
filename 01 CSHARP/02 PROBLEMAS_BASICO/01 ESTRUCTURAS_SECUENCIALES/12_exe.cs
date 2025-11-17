using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Enunciado: Pide al usuario una temperatura en grados Celsius
        y conviértela a Fahrenheit usando la fórmula: F = (C × 9/5) + 32.
        */
        Console.Write("Temperatura en Grados Celsius : ");
        double TemperaturaCelsius = double.Parse(Console.ReadLine());
        double TemperaturaFahrenheit = (TemperaturaCelsius * 9 / 5) + 32;
        Console.WriteLine($"{TemperaturaCelsius} Grados Celsius es igual a {TemperaturaFahrenheit} Grados Fahrenheit");
    }
}