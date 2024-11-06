using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int FornecedorId { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} -Nome:{Nome} -Descricao:{Descricao}";
        }
    }
    
}
