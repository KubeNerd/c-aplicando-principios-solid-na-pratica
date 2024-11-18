using System;

namespace encapsulamento_modelo_de_dominio
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        public ClienteRico()
        { 
        
        }

        public ClienteRico(int id, string nome, string endereco) 
        {
            //if (id < 0) 
            //{
            //    throw new InvalidOperationException("Id inválido");
            //}

            //if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))  
            //{
            //    throw new InvalidOperationException("Nome e Endereço não podem ser nullos.");
            //}

            DomainExceptionValidation.When(id < 0, "Id não pode ser negativo");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O nome não pode ser nullo");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "O endereço não pode ser nullo.");
            
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

    }
}
