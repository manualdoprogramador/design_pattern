using System;
using System.Collections.Generic;
using DesignPattern.Observer;
using DesignPattern.Decorator;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Strategy.ComOPadrao;
using System.Data;
using System.Data.SqlClient;
using DesignPattern.Factory;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // forma sem o Padrão 
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=banco";
            conexao.Open();

            // aqui iriamos fazer as interações

            // Com padrão 
            var conexao1 = new ConnectionFactory().GetConnection();

            
        }
    }
}
