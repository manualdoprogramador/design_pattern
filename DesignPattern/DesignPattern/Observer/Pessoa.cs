using System;
using System.Collections.Generic;

namespace DesignPattern.Observer
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento, string cpf, string rg, string sexo, string apelido, string celular, string telefone, string email, List<IAcaoAposCadastrarPessoa> acoesAposGerarNota)
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
            _acoesAposGerarNota = acoesAposGerarNota;
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
        private List<IAcaoAposCadastrarPessoa> _acoesAposGerarNota;

        public void Salvar()
        {
            Console.WriteLine("Pessoa salva");
            foreach (var acao in _acoesAposGerarNota)            
                acao.Executar(this);            
        }
    }
}