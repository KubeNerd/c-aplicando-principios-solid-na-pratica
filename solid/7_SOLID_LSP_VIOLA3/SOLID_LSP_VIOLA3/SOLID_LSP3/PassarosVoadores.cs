namespace SOLID_LSP3;

public class PassarosVoadores : Passaro
{
    public PassarosVoadores(string nome): base(nome)
    { }

    public virtual void Voar()
    {
        Console.WriteLine($"\n{Nome} voando...");
    }
}
