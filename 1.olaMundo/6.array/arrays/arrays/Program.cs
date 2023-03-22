using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void Main(string[] args) 
        {
            var nomes = new List<string> { "Mateus", "Maurício", "Simone" };

            nomes.Add("Lucas");

            nomes.Sort(); //este comando vai classificar em ordem alfabética antes de imprimir na tela.
            foreach (var nome in nomes)
            {
                Console.WriteLine($"Olá {nome}");
            }

            //a variável "index", é o nome dado para a posição dentro das listas.
            var index = nomes.IndexOf("kk");

            if (index == -1 )
            {
                Console.WriteLine($"Quando o item não for encontrado, IndexOf retornará {index}. ");
            }
            else
            {
                Console.WriteLine($"O nome {nomes[index]} esta na posição {index}. ");
            }

        }
    }
}