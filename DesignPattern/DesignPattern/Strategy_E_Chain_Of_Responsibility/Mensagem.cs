using System;
using System.Collections.Generic;

namespace DesignPattern.Strategy
{
    public class Mensagem
    {
        public Mensagem(string destino, string texto)
        {
            Destino = destino;
            Texto = texto;
        }

        public string Destino { get; private set; }
        public string Texto { get; private set; }
    }
}
