using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Ingrese un número para verificar si es primo: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (EsPrimo(numero))
        {
            Console.WriteLine("El número " + numero + " es primo.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " no es primo.");
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static bool EsPrimo(int num)
    {
        if (num <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }

        return true;
    }
}