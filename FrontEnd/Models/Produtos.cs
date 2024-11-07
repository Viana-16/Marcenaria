using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Validade { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int FornecedorId { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} -Nome:{Nome} -Preco:{Preco} -Validade{Validade} -Descricao{Descricao} -Categoria{Categoria} -QuantidadeEstoque{QuantidadeEstoque}";
        }
    }
}
