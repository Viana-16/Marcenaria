﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public int ProdutosId { get; set; }
        public double Total { get; set; }
        public int ClienteId { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} -DataCompra:{DataCompra} -Total:{Total}";
        }
    }
}
