using System;
using System.Collections.Generic;
using DesignPattern.Decorator;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Strategy.ComOPadrao;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto("Tenis",500);
            var imposto = new ICB(new ICC());
            var valorDoImposto = imposto.Calcular(produto);
            Console.WriteLine($"O valor do imposto é: {valorDoImposto}");
        }
    }
}
