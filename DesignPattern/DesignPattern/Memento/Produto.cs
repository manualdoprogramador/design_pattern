using System;

namespace DesignPattern.Memento
{
    public class Produto
    {                
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            DataAlteracao = DateTime.Now;                     
        }

        public Produto(string nome, double preco, DateTime dataAlteracao)
        {
            Nome = nome;
            Preco = preco;
            DataAlteracao = dataAlteracao;
        }

        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        public void EditarPreco(double preco)
        {
            this.Preco = preco;
            DataAlteracao = DateTime.Now;         
        }        
    }
}