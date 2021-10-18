using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta04PropriedadesAutoImplementadas
{
    class Produto
    {

        /*
         ORDEM SUGERIDA PARA IMPLEMENTAÇÃO
        Ordem sugerida
        •Atributos privados
        •Propriedades autoimplementadas
        •Construtores
        •Propriedades customizadas
        •Outros métodos da classe
         */

        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; set; }
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
