using System;

namespace DesignPattern.State
{
    public class PedidoFinalizado : IEstadoDoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedidos finalizados não pode mudar seu estado para aprovado");
        }

        public void EmAndamento(Pedido pedido)
        {
            throw new Exception("Pedidos finalizados não pode mudar seu estado!");
        }

        public void Finalizado(Pedido pedido)
        {
            throw new Exception("Pedidos já foi finalizado");
        }

        public void Reprovado(Pedido pedido)
        {
            throw new Exception("Pedidos finalizados não pode mudar seu estado para reprovado");
        }
    }
}