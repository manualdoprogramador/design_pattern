using System;
using System.Collections.Generic;
using DesignPattern.Observer;
using DesignPattern.Strategy;
using DesignPattern.Strategy.ComOPadrao;
using System.Data;
using System.Data.SqlClient;
using DesignPattern.Factory;
using DesignPattern.Memento;
using DesignPattern.Command;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {      
            Pedido pedido1 = new Pedido("Mauricio", 150.0);
            Pedido pedido2 = new Pedido("Marcelo", 250.0);

            FilaDeProcessamento fila = new FilaDeProcessamento();

            fila.Adicionar(new PagaPedido(pedido1));
            fila.Adicionar(new PagaPedido(pedido2));
            fila.Adicionar(new FinalizaPedido(pedido1));

            fila.Processar();            
        }
    }
}
