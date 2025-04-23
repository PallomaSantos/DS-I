using System;

class Pessoa
{
    public string nome;

    public void PerguntarNome()
    {
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
    }

    public void Falar()
    {
        Console.WriteLine("Olá, meu nome é " + nome);
    }
}

class Aluno : Pessoa
{
    public int idade;

    public void PerguntarIdade()
    {
        Console.Write("Digite a sua idade: ");
        idade = int.Parse(Console.ReadLine());
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos.");
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();

        aluno.PerguntarNome();   // herdado de Pessoa
        aluno.PerguntarIdade();  // próprio de Aluno
        aluno.Apresentar();      // próprio de Aluno
    }
}
