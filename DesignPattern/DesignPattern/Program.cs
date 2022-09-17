using System;
using System.Collections.Generic;
using DesignPattern.Observer;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Strategy.ComOPadrao;
using System.Data;
using System.Data.SqlClient;
using DesignPattern.Factory;
using DesignPattern.Memento;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {      
            HistoricoDoProduto historicoDoProduto = new HistoricoDoProduto();     
            var produto = new Produto("Gustavo", 10);            
            historicoDoProduto.Adicionar(produto);
            
            produto.EditarPreco(20);
            historicoDoProduto.Adicionar(produto);
            
            produto.EditarPreco(50);
            historicoDoProduto.Adicionar(produto);
            
            produto.EditarPreco(10);
            historicoDoProduto.Adicionar(produto);
            
            produto.EditarPreco(60);            
            historicoDoProduto.Adicionar(produto);
            
            var index = 2;
            Console.WriteLine(historicoDoProduto.Buscar(index).Nome);
            Console.WriteLine(historicoDoProduto.Buscar(index).Preco);
            Console.WriteLine(historicoDoProduto.Buscar(index).DataAlteracao);
            
        }
    }
}
