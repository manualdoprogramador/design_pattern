using System;
using System.Collections.Generic;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Strategy.ComOPadrao;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido("Tenis",500);
            try
            {
                pedido.Aprovado();
                pedido.Reprovado();
                pedido.Finalizado();
            }              
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
