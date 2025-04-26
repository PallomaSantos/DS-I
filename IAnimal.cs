using System;

interface IAnimal
{
    string EmitirSom();
}

abstract class Animal : IAnimal
{
    private string nome;
    private string tipo;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public Animal(string nome, string tipo)
    {
        this.nome = nome;
        this.tipo = tipo;
    }

    
    public abstract string EmitirSom();
}

class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome, "Cachorro") { }

    public override string EmitirSom()
    {
        return "Au Au!";
    }
}

class Gato : Animal
{
    public Gato(string nome) : base(nome, "Gato") { }

    public override string EmitirSom()
    {
        return "Miau!";
    }
}

class Leao : Animal
{
    public Leao(string nome) : base(nome, "Leão") { }

    public override string EmitirSom()
    {
        return "Roooaar!";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tipo de animal (Cachorro, Gato, Leão):");
        string tipoAnimal = Console.ReadLine().ToLower();

        Animal animal = null;

        switch (tipoAnimal)
        {
            case "cachorro":
                animal = new Cachorro("Cachorro");
                break;
            case "gato":
                animal = new Gato("Gato");
                break;
            case "leão":
            case "leao": 
                animal = new Leao("Leão");
                break;
            default:
                Console.WriteLine("Este animal ainda não foi cadastrado no sistema.");
                break;
        }

        if (animal != null)
        {
            Console.WriteLine($"O {animal.Tipo} faz: {animal.EmitirSom()}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
