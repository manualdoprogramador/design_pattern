using System;
using System.Collections.Generic;
using DesignPattern.Observer;
using DesignPattern.Decorator;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Strategy.ComOPadrao;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new PessoaBuilder()
                         .SetNome("Gustavo")
                         .SetApelido("Gustavo")
                         .SetCpf("123456789-64")
                         .SetDataNascimento(Convert.ToDateTime("1993-01-01"))
                         .SetEmail("teste@teste.com")
                         .SetAcaoAposCadastrarPessoa(new EnviaEmail())
                         .SetAcaoAposCadastrarPessoa(new EnviaSms())
                         .Construir();

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Cpf);
            Console.WriteLine(pessoa.DataNascimento);
            Console.WriteLine(pessoa.Email);
            pessoa.Salvar();
        }
    }
}
