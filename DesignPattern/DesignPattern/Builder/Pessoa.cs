using System;

namespace DesignPattern.Builder
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento, string cpf, string rg, string sexo, string apelido, string celular, string telefone, string email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            Apelido = apelido;
            Celular = celular;
            Telefone = telefone;
            Email = email;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Sexo { get; private set; }
        public string Apelido { get; private set; }
        public string Celular { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
    }
}