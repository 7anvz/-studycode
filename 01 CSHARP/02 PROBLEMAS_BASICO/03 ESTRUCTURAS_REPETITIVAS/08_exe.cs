using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide 10 números al usuario. Si el número es negativo, ignóralo (continue). 
        Si el número es 0, termina la suma inmediatamente (break). 
        Muestra la suma total de los números positivos procesados.
        */
        int i = 1;
        double suma = 0;
        do
        {
            Console.Write($"Escribe el numero {i} : ");
            double numero = double.Parse(Console.ReadLine());
            if (numero < 0)
            {
                i++; //para que no se quede atascado en el mismo numero Escribe el numero 2 Escribe el numero 3
                continue;
            }
            else if (numero == 0)
            {
                Console.WriteLine($"La suma de los numeros es {suma}");
                break;
            }
            suma += numero;
            i++;
        } while (i <= 10);
    }
}