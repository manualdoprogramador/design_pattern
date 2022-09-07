using System;

namespace DesignPattern.Observer
{
    public class EnviaSms : IAcaoAposCadastrarPessoa
    {
        public void Executar(Pessoa pessoa)
        {
            Console.WriteLine("Envia sms apos cadastro de pessoa");
        }
    }
}