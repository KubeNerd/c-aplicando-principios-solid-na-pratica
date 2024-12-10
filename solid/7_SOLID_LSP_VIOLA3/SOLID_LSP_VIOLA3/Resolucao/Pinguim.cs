namespace SOLID_LSP3;

public class Pinguim : Passaro
{
    public Pinguim(string nome) : base(nome)
    { }

    public override void Comer()
    {
        Console.WriteLine($"\n{Nome} come peixes...");
    }

    public override void BotarOvos()
    {
        Console.WriteLine($"\n{Nome} bota 2 ovos...");
    }  
}
