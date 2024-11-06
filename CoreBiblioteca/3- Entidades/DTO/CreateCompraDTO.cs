using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades.DTO
{
    public class CreateCompraDTO
    {
        public DateTime DataCompra { get; set; }
        public int ProdutosId { get; set; }
        public double Total { get; set; }
        public int ClienteId { get; set; }

    }
}
