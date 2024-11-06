using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public int DataVenda { get; set; }
        public int ProdutoId { get; set; }
        public int ValorFinal { get; set; }
        public int ClienteId { get; set; }


        public string GetMetodoPagamentoById(int opcaoSelecionada)
        {
            switch (opcaoSelecionada)
            {
                case 1:
                    return "PIX";
                case 2:
                    return "Débito";
                case 3:
                    return "Crédito";
                default:
                    return null;
            }

        }
    }
}
