using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Contato { get; set; }
        public int DataContratacao { get; set; }
        public string Usuario { get; set; }
        public int Senha { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} -Nome:{Nome} -Cargo:{Cargo} -Contato{Contato} -DataContratacao{DataContratacao} -Usuario{Usuario} -Senha{Senha}";
        }
    }
}
