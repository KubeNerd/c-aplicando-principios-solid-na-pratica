namespace SOLID_LSP_Violation2;

public class CalculaSomaNumerosPares : CalculaSoma
{
    public CalculaSomaNumerosPares(int[] numeros)
    : base(numeros)
    { }

    public new int Calcular() =>
        _numeros.Where(x => x % 2 == 0).Sum();
}
