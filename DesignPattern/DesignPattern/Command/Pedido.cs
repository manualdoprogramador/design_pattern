using System;

namespace DesignPattern.Command
{
    public class Pedido
    {
        public Pedido(string nomeDoCliente, double valor)
        {
            NomeDoCliente = nomeDoCliente;
            Valor = valor;
            Status = StatusDoPerdido.Novo;            
        }

        public string NomeDoCliente { get; private set; }
        public double Valor { get; private set; }
        public StatusDoPerdido Status { get; set; }
        public DateTime DataFinalizacao { get; private set; }

        public void Pagar()
        {
            Status = StatusDoPerdido.Pago;
        }

        public void Finalizar()
        {
            Status = StatusDoPerdido.Finalizado;
            DataFinalizacao = DateTime.Now;
        }
    }
}