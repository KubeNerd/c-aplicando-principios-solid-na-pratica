namespace Resolucao;

public abstract class Calculadora
{
    protected readonly int[] _numeros;

    public Calculadora(int[] numeros)
    {
        _numeros = numeros;
    }

    public abstract int Calcular();
}
