using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades
{
    [Table("Vendas")]
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int ProdutoId { get; set; }
        public double ValorFinal { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
    }
}
