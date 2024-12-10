namespace SOLID_LSP3;

public class Passaro
{
    public string Nome { get; }

    public Passaro(string nome)
    {
        Nome = nome;
    }
    public virtual void Comer()
    {
        Console.WriteLine("\n{Nome} comendo...");
    }
    public virtual void BotaOvos()
    {
        Console.WriteLine($"\n{Nome} botando ovos...");
    }
}
