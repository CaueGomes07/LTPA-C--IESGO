//  Criar um programa que verifique se um número é par ou impar.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O número é impar");
        }


    }
}