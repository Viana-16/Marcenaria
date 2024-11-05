using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades.DTO
{
    public class CreateVendaDTO
    {
        //public int DataVenda { get; set; }
        //public string ItensVendidos { get; set; }
        //public int TotalVendas { get; set; }
        //public int FuncionarioId { get; set; }

        public int DataVenda { get; set; }
        public int ProdutoId { get; set; }
        public int TotalVendas { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
    }
}
