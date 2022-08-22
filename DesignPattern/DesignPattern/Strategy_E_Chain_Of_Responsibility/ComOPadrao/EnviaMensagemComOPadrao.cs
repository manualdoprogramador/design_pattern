using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public class EnviaMensagemComOPadrao
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            var enviaMensagemEmail = new EnviaMensagemEmail();
            var enviaMensagemSms = new EnviaMensagemSms();
            var enviaMensagemPush = new EnviaMensagemPush();
            var enviaMensagemSemCanal = new EnviaMensagemSemEnvio();
            enviaMensagemEmail.Proxima = enviaMensagemSms;
            enviaMensagemSms.Proxima = enviaMensagemPush;
            enviaMensagemPush.Proxima = enviaMensagemSemCanal;

            var enviaMensagem = enviaMensagemEmail.CriarEnvio(tipo);
            enviaMensagem.Enviar(mensagens);
        }
    }
}
