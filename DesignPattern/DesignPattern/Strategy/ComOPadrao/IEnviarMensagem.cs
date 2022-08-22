using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public interface IEnviarMensagem
    {
        void Enviar(List<Mensagem> mensagens);
    }
}
