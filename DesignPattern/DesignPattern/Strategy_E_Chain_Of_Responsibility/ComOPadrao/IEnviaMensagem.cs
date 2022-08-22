using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public interface IEnviaMensagem
    {
        void Enviar(List<Mensagem> mensagens);
        IEnviaMensagem Proxima { get; set; }
        IEnviaMensagem CriarEnvio(string tipo);
    }
}
