using System;
using System.Collections.Generic;
using DesignPattern.Strategy;
using DesignPattern.Strategy.ComOPadrao;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagens = new List<Mensagem>();
            mensagens.Add(new Mensagem("teste@teste.com", "Obrigado por se cadastrar"));
            mensagens.Add(new Mensagem("teste2@teste.com", "Obrigado por se cadastrar"));
            mensagens.Add(new Mensagem("teste3@teste.com", "Obrigado por se cadastrar"));
            var enviaMensagem = new EnviaMensagem();
            enviaMensagem.Enviar(mensagens, "email");            
        }
    }
}
