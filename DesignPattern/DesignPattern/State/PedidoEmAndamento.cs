namespace DesignPattern.State
{
    public class PedidoEmAndamento : IEstadoDoPedido
    {
        public void EmAndamento(Pedido pedido)
        {
            return;
        }

        public void Aprovado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoAprovado();
        }
        
        public void Finalizado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoFinalizado();
        }

        public void Reprovado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoReprovado();
        }
    }
}