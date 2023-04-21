public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "Au Au";
    }
}


public class Leao : Animal
{
    public int Tamanho { get; set; }
    public Leao(string nome, int idade, int Tamanho) : base(nome, idade) { }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Tamanho: {Tamanho}");
    }

    public override string EmitirSom()
    {
        return "AUAUAUAU";    
    }
}