using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades.DTO
{
    public class CreateCompraDTO
    {
        public int DataCompra { get; set; }
        public int ProdutosId { get; set; }
        public int Total { get; set; }
        public int ClienteId { get; set; }

    }
}
