using Dapper;
using Dapper.Contrib.Extensions;
using Marcenaria._2__Repository.interfaces;
using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly string ConnectionString;
        public ClienteRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Cliente clientes)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Cliente>(clientes);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Cliente clientes = BuscarPorId(id);
            connection.Delete<Cliente>(clientes);
        }
        public void Editar(Cliente clientes)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Cliente>(clientes);
        }
        public List<Cliente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Cliente>().ToList();
        }
        public Cliente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Cliente>(id);
        }
    }
}
