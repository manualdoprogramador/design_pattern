using System;

namespace DesignPattern.Command
{
    public class PagaPedido : IComando
    {
        private Pedido _pedido;

        public PagaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executar()
        {
            _pedido.Pagar();
            Console.WriteLine($"Pedido do cliente: {_pedido.NomeDoCliente} foi pago");
        }
    }
}