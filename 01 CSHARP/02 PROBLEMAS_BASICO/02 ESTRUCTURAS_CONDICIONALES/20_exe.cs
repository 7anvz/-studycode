using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Convierte una nota numérica (0-20) a letras: 
        A (18-20), B (14-17), C (11-13), D (0-10).
        */
        Console.Write("Escribe una nota numérica : ");
        int nota = int.Parse(Console.ReadLine());
        string notatxt = "";
         if (nota < 0 || nota > 20)
        {
            Console.WriteLine("Escriba una nota válida (0-20)!");
            return;
        }
        if (nota >= 18) notatxt = "A";
        else if (nota >= 14) notatxt = "B";
        else if (nota >= 11) notatxt = "C";
        else { notatxt = "D"; }
        
        Console.WriteLine($"NOTA OBTENIDA >>> {notatxt} : {nota}"); 
    }
}