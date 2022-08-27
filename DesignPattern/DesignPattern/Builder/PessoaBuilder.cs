using System;

namespace DesignPattern.Builder
{
    public class PessoaBuilder
    {
        private string _nome;
        private DateTime _dataNascimento;
        private string _cpf;
        private string _rg;
        private string _sexo;
        private string _apelido;
        private string _celular;
        private string _telefone;
        private string _email;

        public PessoaBuilder SetNome(string nome)
        {
            this._nome = nome;
            return this;
        }

        public PessoaBuilder SetDataNascimento(DateTime dataNascimento)
        {
            this._dataNascimento = dataNascimento;
            return this;
        }

        public PessoaBuilder SetCpf(string cpf)
        {
            this._cpf = cpf;
            return this;
        }

        public PessoaBuilder SetRg(string rg)
        {
            this._rg = rg;
            return this;
        }

        public PessoaBuilder SetSexo(string sexo)
        {
            this._sexo = sexo;
            return this;
        }

        public PessoaBuilder SetApelido(string apelido)
        {
            this._apelido = apelido;
            return this;
        }

        public PessoaBuilder SetCelular(string celular)
        {
            this._celular = celular;
            return this;
        }

        public PessoaBuilder SetTelefone(string telefone)
        {
            this._telefone = telefone;
            return this;
        }

        public PessoaBuilder SetEmail(string email)
        {
            this._email = email;
            return this;
        }

        public Pessoa Construir()
        {
            return new Pessoa(_nome,_dataNascimento,_cpf,_rg,_sexo,_apelido,_celular,_telefone,_email);
        }

    }
}