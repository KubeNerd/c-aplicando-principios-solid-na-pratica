namespace SOLID_LSP;

public class Gerente : Funcionario
{
    private double bonus = 3000;

    public Gerente(string nome, string cargo) : base(nome, cargo)
    { }

    public override double CalculaSalario(double salario)
    {
        return salario + bonus;
    }
}
