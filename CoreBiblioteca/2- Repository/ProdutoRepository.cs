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
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string ConnectionString;
        public ProdutoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Produtos produtos)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Produtos>(produtos);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Produtos produtos = BuscarPorId(id);
            connection.Delete<Produtos>(produtos);
        }
        public void Editar(Produtos produtos)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Produtos>(produtos);
        }
        public List<Produtos> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Produtos>().ToList();
        }
        public Produtos BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Produtos>(id);
        }
    }
}

