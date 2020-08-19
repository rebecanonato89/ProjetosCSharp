using System;
using System.Globalization;

namespace ControleEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qte)
        {
           Quantidade += qte;
        }

        public void RetirarProdutos(int qte)
        {
            Quantidade -= qte;
        }

        public override string ToString()
        {
            return Nome
                      + ", $"
                      + Preco.ToString("F2", CultureInfo.InvariantCulture)
                      + ", "
                      + Quantidade
                      + " unidades, Total: $"
                      + ValorTotalEstoque();
        }
    }
}
