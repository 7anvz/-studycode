using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Crea un menú que pida números para sumar. 
        Después de cada suma, pregunta "¿Continuar? (s/n)". 
        Si responde 'n', usa return para terminar. 
        Si ingresa un número negativo, 
        usa continue para pedirlo nuevamente.
        */
        double suma = 0;
        int contador = 1;
        
        while (true)  // Bucle infinito controlado
        {
            Console.Write($"Escriba el numero {contador}: ");
            double numero = double.Parse(Console.ReadLine());
            
            // Si es negativo, pedir nuevamente
            if (numero < 0)
            {
                Console.WriteLine("Número negativo, ingrese otro...");
                continue;
            }
            
            // Sumar solo si es positivo
            suma += numero;
            Console.WriteLine($"SUMA ACUMULADA | {suma}");
            
            // Preguntar si continúa
            Console.Write("¿Continuar? (s/n) >>> ");
            string respuesta = Console.ReadLine().ToLower();
            
            if (respuesta == "n")
            {
                Console.WriteLine($"Suma final: {suma}");
                return;  // Termina el programa
            }
            
            contador++;
        }
    }
}