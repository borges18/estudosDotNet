using System;

public class Program
{
    public static void Main()
    {
        //Método "Contains" vai buscar o parâmetro na variável e retornar "true" ou "false".

        string letraMusica = "Você disse tchau, e eu digo olá";

        Console.WriteLine(letraMusica.Contains("tchau"));
        Console.WriteLine(letraMusica.Contains("saudações"));

        //Método "StartsWith" busca se a variável inicia com o parâmetro indicado, e retorna também "true" ou "false".
        Console.WriteLine(letraMusica.StartsWith("Você"));
        Console.WriteLine(letraMusica.StartsWith("Digo"));

        //Método "EndsWith" busca se a variável termina com o parâmetro indicado, e retorna também "true" ou "false".
        Console.WriteLine(letraMusica.EndsWith("Disse"));
        Console.WriteLine(letraMusica.EndsWith("olá"));
    }
}
