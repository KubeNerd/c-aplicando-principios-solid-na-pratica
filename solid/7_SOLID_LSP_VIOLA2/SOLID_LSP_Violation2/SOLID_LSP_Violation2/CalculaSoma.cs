namespace SOLID_LSP_Violation2;

public class CalculaSoma
{
    protected readonly int[] _numeros;

    public CalculaSoma(int[] numeros)
    {
        _numeros = numeros;
    }

    public int Calcular() => _numeros.Sum();
}
