namespace encapsulamento_modelo_de_dominio
{

    class Program
    {
        static void Main(string[] args)
        {
            ClienteRico clienteRico = new ClienteRico(1, "Antonio Nunes", "25 de Março, SP");

            Console.Write($"{clienteRico.Id}, {clienteRico.Nome}, {clienteRico.Endereco}");

        }

    }
}
