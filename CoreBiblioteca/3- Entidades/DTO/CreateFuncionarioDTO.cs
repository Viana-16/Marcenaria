using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades.DTO
{
    public class CreateFuncionarioDTO
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Contato { get; set; }
        public string DataContratacao { get; set; }
        public string Usuario { get; set; }
        public int Senha { get; set; }
    }
}
