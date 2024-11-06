﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._3__Entidades
{
    [Table("Compras")]
    public class Compra
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public int ProdutosId { get; set; }
        public double Total { get; set; }
        public int ClienteId { get; set; }
    }
}
