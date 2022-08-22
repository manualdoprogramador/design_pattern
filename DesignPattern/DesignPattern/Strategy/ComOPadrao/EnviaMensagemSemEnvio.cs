using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public class EnviaMensagemSemEnvio : IEnviaMensagem
    {
        public IEnviaMensagem Proxima { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnviaMensagem CriarEnvio(string tipo)
        {
            throw new NotImplementedException();
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            throw new NotImplementedException();
        }
    }
}
