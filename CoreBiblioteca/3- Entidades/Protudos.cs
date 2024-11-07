using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades
{
    [Table("Produtos")]
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


    }
}
