using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public class EnviaMensagem
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            IEnviarMensagem enviarMensagem;
            if (tipo.ToLower() == "email")
            {
                enviarMensagem = new EnviaMensagemEmail();
                enviarMensagem.Enviar(mensagens);
            }
            else if (tipo == "sms")
            {
                enviarMensagem = new EnviaMensagemSms();
                enviarMensagem.Enviar(mensagens);
            }
            else if (tipo == "push")
            {
                enviarMensagem = new EnviaMensagemPush();
                enviarMensagem.Enviar(mensagens);
            }
        }
    }
}
