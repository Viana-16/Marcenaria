using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades.DTO
{
    public class CreateProdutosDTO
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Validade { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int FornecedorId { get; set; }
    }
}
