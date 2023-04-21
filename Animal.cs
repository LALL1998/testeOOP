public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }

    public abstract string EmitirSom();
}
