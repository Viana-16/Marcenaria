using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades.DTO
{
    public class CreateClienteDTO
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }
        public string Usuario { get; set; }
        public int Senha { get; set; }
    }
}
