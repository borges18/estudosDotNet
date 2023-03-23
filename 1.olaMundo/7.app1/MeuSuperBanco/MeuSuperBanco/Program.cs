using System;

namespace MeuSuperBanco
{
    class Program
    {
        static void Main(string[] args) 
        {
            MeuSuperBanco.ContaBanco conta1 = new ContaBanco("Mateus", 25000);
            Console.WriteLine($"A conta {conta1.Numero} de {conta1.Dono} foi criada e possui o saldo de R${conta1.Saldo}. ");

            conta1.Sacar(2500, DateTime.Now, "Sacando");
            Console.WriteLine($"Após a transação o saldo atual é de R${conta1.Saldo}. ");

            conta1.Sacar(30000, DateTime.Now, "Sacando");
            Console.WriteLine($"Após a transação o saldo atual é de R${conta1.Saldo}. ");

        }
    }
}