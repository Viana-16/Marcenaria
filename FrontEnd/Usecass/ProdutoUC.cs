using Marcenaria._3__Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Usecass
{
    public class ProdutoUC
    {
        private readonly HttpClient _cliente;
        public ProdutoUC(HttpClient cliente)
        {
            _cliente = cliente;
        }

        public void CiarPorduto(Produtos produto)
        {
            HttpResponseMessage response = _cliente.PostAsJsonAsync("Produto/adicionar-Produto", produto).Result;
        }
        public List<Produtos> ListarProdutos()
        {

            return _cliente.GetFromJsonAsync<List<Produtos>>("Produto/listar-produto").Result;

        }
    }
}
