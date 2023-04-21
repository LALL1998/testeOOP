public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "Au Au";
    }
}

public class Cobra : Reptil
{
    double Comprimento { get; set; }
    public Cobra(string nome, int idade, int Comprimento) : base(nome, idade) { }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Comprimento: {Comprimento}");
    }

        public override string EmitirSom()
    {
        return "sssSSSssSS";
    }
}