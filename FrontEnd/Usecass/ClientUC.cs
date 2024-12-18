using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Usecass
{
    public class ClientUC
    {
        private readonly HttpClient _client;
        public ClientUC(HttpClient cliente)
        {
            _client = cliente;
        }
        public List<Cliente> ListarUsuarios()
        {
            return _client.GetFromJsonAsync<List<Cliente>>("Cliente/listar-Clientes").Result;
        }
        public void CadastrarUsuario(Cliente usuario)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Cliente/adicionar-Clientes", usuario).Result;
        }
        public Cliente FazerLogin(CreateClienteDTO usuLogin)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Cliente/Fazer-Login", usuLogin).Result;
            Cliente usuario = response.Content.ReadFromJsonAsync<Cliente>().Result;
            return usuario;
        }
    }
}