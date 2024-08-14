using System;
using System.Text;

public class Programa
{
    static void Main()
    {
        //  Usar UTF-8 no console.
        Console.OutputEncoding = Encoding.UTF8;
        
        //  Solicitar o nome.
        //  Obtendo o nome.
        Console.WriteLine ("Olá! Qual o seu nome? ");
        //  Armazenando o nome.
        string nome = Console.ReadLine();
        
        //  Solicitar data de nascimento.
        //  Obtendo data de nascimento.
        Console.WriteLine("Agora insira sua data de nascimento: (DD/MM/AAAA)");
        //  Armazenando data de nascimento.
        string dataNascimentoInput = Console.ReadLine();
        
        //  Converter a String dataNascimento para DataType (DateTime).
        DateTime dataNascimento;
        if(DateTime.TryParseExact(dataNascimentoInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
        {
            //  Calcular a idade
            int idade = CalcularIdade(dataNascimento);
            
            //  Responder no console
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
        }
        else
        {
            //  Mensagem de Erro
            Console.WriteLine("insira uma data de nascimento válida (dd/mm/aaaa). ");
        }
        
        static int CalcularIdade(DateTime dataNascimento)
        {
            //  DateTime de hoje
            DateTime hoje = DateTime.Today;
            
            //  Calcular a idade
            int idade = hoje.Year - dataNascimento.Year;
            
            //  Ajustar a idade caso não tenha completado aniversário
            if(dataNascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }
    }
}