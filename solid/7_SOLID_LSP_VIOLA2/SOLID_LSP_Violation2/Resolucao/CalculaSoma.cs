namespace Resolucao;

public class CalculaSoma : Calculadora
{
    public CalculaSoma(int[] numeros)
        : base(numeros)
    {
    }
    public override int Calcular() => _numeros.Sum();
}
