using System;

namespace DesignPattern.Observer
{
    public class EnviaEmail : IAcaoAposCadastrarPessoa
    {
        public void Executar(Pessoa pessoa)
        {
            Console.WriteLine("Envia e-mail apos cadastro de pessoa");
        }
    }
}