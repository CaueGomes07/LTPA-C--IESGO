// Você vai criar um programa que calcula o salário de um funcionário com base nas horas trabalhadas,na taxa de pagamento por hora e no valor das comissões. 
// O programa deve usar diferentes tipos de dados para armazenar as informações e realizar as operações necessárias.

// Requisitos:

// Solicite ao usuário para inserir o nome do funcionário (string).
// Solicite ao usuário para inserir as horas trabalhadas na semana (int).
// Solicite ao usuário para inserir a taxa de pagamento por hora (double).
// Solicite ao usuário para inserir o valor das comissões recebidas na semana (decimal).
// Calcule o salário bruto (horas trabalhadas multiplicadas pela taxa de pagamento) e adicione as comissões.
// Exiba o nome do funcionário e o salário total (decimal) no final.

using System;

class Program
{
    static void Main()
    {
        // Nome do funcionário;
        Console.Write("Digite o nome do funcionário: ");
        string nomeFuncionario = Console.ReadLine();

        // Horas trabalhadas;
        Console.Write("Digite o número de horas trabalhadas na semana: ");
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        // Taxa de pagamento por hora trabalhada;
        Console.Write("Digite a taxa de pagamento por hora: ");
        double taxaPagamento = Convert.ToDouble(Console.ReadLine());

        // Valor das comissões da semana;
        Console.Write("Digite o valor das comissões recebidas na semana: ");
        decimal comissoes = Convert.ToDecimal(Console.ReadLine());

        // Salário bruto + comissões;
        decimal salarioBruto = (decimal)(horasTrabalhadas * taxaPagamento) + comissoes;

        // Exibir o resultado
        Console.WriteLine($"Nome do Funcionário: {nomeFuncionario}");
        Console.WriteLine($"Salário Bruto (incluindo comissões): R${salarioBruto:F2}");
    }
}