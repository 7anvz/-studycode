using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Pide el número de mes de nacimiento (1-12) y muestra el signo zodiacal correspondiente.
        */
        Console.Write("Hey! Digita tu mes de nacimiento : ");
        int mes = int.Parse(Console.ReadLine());
        Console.WriteLine("Buscando mes...");
        Console.ReadKey();
        switch (mes)
        {
            case 1:
            Console.WriteLine("Mes >>> Enero");
            Console.WriteLine("Signos Zodiacales >>> Capricornio / Acuario");
            break;
            case 2:
            Console.WriteLine("Mes >>> Febrero");
            Console.WriteLine("Signos Zodiacales >>> Acuario / Piscis");
            break;
            case 3:
            Console.WriteLine("Mes >>> Marzo");
            Console.WriteLine("Signos Zodiacales >>> Piscis / Aries");
            break;
            case 4:
            Console.WriteLine("Mes >>> Abril");
            Console.WriteLine("Signos Zodiacales >>> Aries / Tauro");
            break;
            case 5:
            Console.WriteLine("Mes >>> Mayo");
            Console.WriteLine("Signos Zodiacales >>> Tauro / Géminis");
            break;
            case 6:
            Console.WriteLine("Mes >>> Junio");
            Console.WriteLine("Signos Zodiacales >>> Géminis / Cáncer");
            break;
            case 7:
            Console.WriteLine("Mes >>> Julio");
            Console.WriteLine("Signos Zodiacales >>> Cáncer / Leo");
            break;
            case 8:
            Console.WriteLine("Mes >>> Agosto");
            Console.WriteLine("Signos Zodiacales >>> Leo / Virgo");
            break;
            case 9:
            Console.WriteLine("Mes >>> Septiembre");
            Console.WriteLine("Signos Zodiacales >>> Virgo / Libra");
            break;
            case 10:    
            Console.WriteLine("Mes >>> Octubre");
            Console.WriteLine("Signos Zodiacales >>> Libra / Escorpio");
            break;
            case 11:            
            Console.WriteLine("Mes >>> Noviembre");
            Console.WriteLine("Signos Zodiacales >>> Escorpio / Sagitario");
            break;
            case 12: 
            Console.WriteLine("Mes >>> Diciembre");
            Console.WriteLine("Signos Zodiacales >>> Sagitario / Capricornio");
            break;
            default:
            Console.WriteLine("Digite numeros del 1 al 12");
            Console.WriteLine("Intentelo Nuevamente!");
            break;
        }
    }
}