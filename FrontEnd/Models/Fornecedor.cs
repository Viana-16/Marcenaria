using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} -Nome:{Nome} -CNPJ:{CNPJ} -Endereco{Endereco} -Email{Email} -Telefone{Telefone}";
        }
    }
}
