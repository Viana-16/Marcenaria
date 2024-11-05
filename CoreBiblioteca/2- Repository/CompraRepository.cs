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
    public class CompraRepository : ICompraRepository
    {
        private readonly string ConnectionString;
        public CompraRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Compra compra)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Compra>(compra);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Compra compra = BuscarPorId(id);
            connection.Delete<Compra>(compra);
        }
        public void Editar(Compra compra)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Compra>(compra);
        }
        public List<Compra> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Compra>().ToList();
        }
        public Compra BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Compra>(id);
        }
    }
}

