using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Contato { get; set; }
        public string Endereco { get; set; }
        public string Usuario { get; set; }
        public int Senha { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} -Nome:{Nome} -Contato:{Contato} -Endereco:{Endereco} -Usuario:{Usuario} -Senha:{Senha}";
        }
    }
}
