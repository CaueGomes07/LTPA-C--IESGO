//  Criar um programa que receba 3 valores e calcule a média.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        // media
        double media = (num1 + num2 + num3) / 3;
        Console.WriteLine("A média dos números é: " + media);

    }
}
