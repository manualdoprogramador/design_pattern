﻿using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy.ComOPadrao
{
    public class EnviaMensagemSms : IEnviarMensagem
    {        
        public void Enviar(List<Mensagem> mensagens)
        {
            // tudo que é necessario para enviar um push
            Console.WriteLine("Push enviado");
        }
    }
}