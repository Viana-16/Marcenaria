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
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly string ConnectionString;
        public FornecedorRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Fornecedor fornecedor)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Fornecedor>(fornecedor);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Fornecedor fornecedor = BuscarPorId(id);
            connection.Delete<Fornecedor>(fornecedor);
        }
        public void Editar(Fornecedor fornecedor)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Fornecedor>(fornecedor);
        }
        public List<Fornecedor> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Fornecedor>().ToList();
        }
        public Fornecedor BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Fornecedor>(id);
        }
    }
}
