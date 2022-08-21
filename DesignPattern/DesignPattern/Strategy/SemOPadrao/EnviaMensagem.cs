using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.SemOPadrao
{
    public class EnviaMensagem
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            if(tipo.ToLower()    == "email")
            {
                // tudo que é necessario para enviar um email
                Console.WriteLine("Email enviado");
            }
            else if(tipo == "sms")
            {
                // tudo que é necessario para enviar um sms
                Console.WriteLine("Sms enviado");
            }
            else if (tipo == "push")
            {
                // tudo que é necessario para enviar um push
                Console.WriteLine("Push enviado");
            }
        }
    }
}
