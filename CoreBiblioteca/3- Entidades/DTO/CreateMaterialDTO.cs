using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades.DTO
{
    public class CreateMaterialDTO
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int FornecedorId { get; set; }
    }
}
