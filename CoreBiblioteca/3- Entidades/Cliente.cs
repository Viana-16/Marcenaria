using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Contato { get; set; }
        public string Endereco { get; set; }
        public string Usuario { get; set; }
        public int Senha { get; set; }

    }
}
