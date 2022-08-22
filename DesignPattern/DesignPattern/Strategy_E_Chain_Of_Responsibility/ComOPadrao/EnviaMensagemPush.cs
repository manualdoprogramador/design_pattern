using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public class EnviaMensagemPush : IEnviaMensagem
    {
        public IEnviaMensagem Proxima { get; set; }

        public IEnviaMensagem CriarEnvio(string tipo)
        {
            if (tipo != "push")
                return Proxima.CriarEnvio(tipo);

            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            // tudo que é necessario para enviar um push
            Console.WriteLine("Push enviado");
        }
    }
}
