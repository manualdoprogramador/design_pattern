using System;

namespace DesignPattern.State
{
    public class Pedido
    {
        public Pedido(string descricao, double valorTotal)
        {
            this.Descricao = descricao;
            this.ValorTotal = valorTotal;  
            EstadoAtual = new PedidoEmAndamento();          
        }
        public string Descricao { get; private set; }
        public double ValorTotal { get; private set; }
        public IEstadoDoPedido EstadoAtual { private get; set; }

        public void EmAndamento()
        {
            EstadoAtual.EmAndamento(this);
            Console.WriteLine("Pedido em andamento");
        }

        public void Aprovado()
        {
            EstadoAtual.Aprovado(this);
            Console.WriteLine("Pedido aprovado");
        }

        public void Reprovado()
        {
            EstadoAtual.Reprovado(this);
            Console.WriteLine("Pedido reprovado");
        }

        public void Finalizado()
        {
            EstadoAtual.Finalizado(this);
            Console.WriteLine("Pedido finalizado");
        }
    }
}