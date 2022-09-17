using System.Collections.Generic;

namespace DesignPattern.Memento
{
    public class HistoricoDoProduto
    {
        private IList<Produto> _produto = new List<Produto>();
        public void Adicionar(Produto produto)
        {
            if(_produto == null)
                _produto = new List<Produto>();

            _produto.Add(new Produto(produto.Nome,produto.Preco,produto.DataAlteracao));
        }

        public Produto Buscar(int index)
        {
            return _produto[index];
        }
    }
}