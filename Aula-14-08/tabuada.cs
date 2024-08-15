//  Criar um programa que exiba uma tabuada.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para ver a tabuada: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }

    }
}