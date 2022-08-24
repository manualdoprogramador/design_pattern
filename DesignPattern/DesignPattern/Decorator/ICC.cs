namespace DesignPattern.Decorator
{
    public class ICC : ImpostoDoProduto
    {
        public ICC(){}
        public ICC(ImpostoDoProduto outroImposto) : base(outroImposto){}

        public override double Calcular(Produto produto)
        {
            return (produto.Valor * 0.05) + CalcularOutroImposto(produto);
        }
    }
}