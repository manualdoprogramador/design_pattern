using System;

namespace DesignPattern.State
{
    public class PedidoReprovado : IEstadoDoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedido está em estado de reprovado e não pode ser aprovado");
        }

        public void EmAndamento(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoEmAndamento();
        }

        public void Finalizado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoFinalizado();
        }

        public void Reprovado(Pedido pedido)
        {
            throw new Exception("Pedido já esta reprovado");
        }
    }
}