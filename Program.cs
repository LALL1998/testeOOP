class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();

        Leao leao = new Leao("Leao", 4, 10);
        Cobra cobra = new Cobra("Cobra", 2, 3);

        miniZoo.AdicionarAnimal(leao);
        miniZoo.AdicionarAnimal(cobra);

        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();
    }
}
