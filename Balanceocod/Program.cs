using BalanceoParentesis;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo de balanceo de parentesis");
        Console.WriteLine("Ingrese una expresion aritmetica con parentesis, llaves y corchetes");

        string expre = Console.ReadLine();
        Balanceo balanceo = new();

        if (balanceo.Expre(expre))
        {
            Console.WriteLine("La expresion {expre} esta balanceada");
        }
        else
        {
            Console.WriteLine("La expresion {expre} no esta balanceada");
        }

        Console.ReadKey();
    }
}
