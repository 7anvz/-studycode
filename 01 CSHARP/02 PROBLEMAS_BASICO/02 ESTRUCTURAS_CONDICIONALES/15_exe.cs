using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide un carácter y clasifícalo en:
        - Vocal (a,e,i,o,u)
        - Consonante (letras que no son vocales)
        - Dígito (0-9)
        - Otro (cualquier otro carácter)
        Usa Contains() con strings para cada categoría.
        */
        Console.Write("Escriba algun caracter : ");
        char caracter = char.Parse(Console.ReadLine());

        string vocal = "aeiouAEIOU";
        string digito = "123456789";
        string consonante = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

        if (vocal.Contains(caracter)) Console.WriteLine("Es vocal");
        else if (consonante.Contains(caracter)) Console.WriteLine("Es consonante");
        else if (digito.Contains(caracter)) Console.WriteLine("Es digito");
        else { Console.WriteLine("Es otro carácter"); }
    }
}