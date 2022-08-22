using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public class EnviaMensagemEmail : IEnviarMensagem
    {
        
        public void Enviar(List<Mensagem> mensagens)
        {
            // tudo que é necessario para enviar um email
            Console.WriteLine("Email enviado");
        }
    }
}
