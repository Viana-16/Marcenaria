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
    public class MaterialRepository : IMaterialRepository
    {
        private readonly string ConnectionString;
        public MaterialRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Material material)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Material>(material);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Material material = BuscarPorId(id);
            connection.Delete<Material>(material);
        }
        public void Editar(Material material)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Material>(material);
        }
        public List<Material> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Material>().ToList();
        }
        public Material BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Material>(id);
        }
    }
}

