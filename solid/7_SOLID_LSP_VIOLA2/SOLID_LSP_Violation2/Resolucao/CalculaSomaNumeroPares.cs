namespace Resolucao;

public class CalculaSomaNumeroPares : Calculadora
{
    public CalculaSomaNumeroPares(int[] numeros) : base(numeros)
    { }

    public override int Calcular() =>
        _numeros.Where(x => x % 2 == 0).Sum();
}
