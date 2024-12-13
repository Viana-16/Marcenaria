using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Contato { get; set; }
        public DateTime DataContratacao { get; set; }
        public string Usuario { get; set; }
        public int Senha { get; set; }


    }
}
