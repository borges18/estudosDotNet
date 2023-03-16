using System;

namespace If
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Trabalhando com o "if"

            int a = 1;
            int b = 2;
            int c = 4;

            if ((a + b > c) && (a == b))
            {
                Console.WriteLine($"A soma de {a} + {b} é maior que {c} e {a} é igual a {b}. ");
            }
            else
            {
                Console.WriteLine($"A soma de {a} + {b} não é maior que {c} e {a} é diferente de {b}. ");
            }
        }
    }
}