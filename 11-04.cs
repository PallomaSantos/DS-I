using System;

class Program
{
    static void Main()
    {  
        string nomeDigitado = NomeSaudacao();
        Console.WriteLine("Olá, " + nomeDigitado + ". Seja Bem-Vindo(a)!");
        
        EscolherLugares();
    }

    static string NomeSaudacao()
    {
        Console.WriteLine("///------///------///");
        Console.WriteLine("Qual é o seu nome? ");
        string name = Console.ReadLine();
        return name;
    }
    
    
    static void EscolherLugares()
    {
        Console.WriteLine("Me diga três lugares que você gostaria de conhecer:");

        Console.Write("Lugar 1: ");
        string lugar1 = Console.ReadLine();

        Console.Write("Lugar 2: ");
        string lugar2 = Console.ReadLine();

        Console.Write("Lugar 3: ");
        string lugar3 = Console.ReadLine();

        Console.WriteLine($"\n Uau! Seria incrível visitar {lugar1}, {lugar2} e {lugar3}!");
    }
 
}
