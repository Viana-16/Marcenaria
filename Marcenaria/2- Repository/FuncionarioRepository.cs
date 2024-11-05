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
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly string ConnectionString;
        public FuncionarioRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Funcionario>(funcionario);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Funcionario funcionario = BuscarPorId(id);
            connection.Delete<Funcionario>(funcionario);
        }
        public void Editar(Funcionario funcionario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Funcionario>(funcionario); 
        }
        public List<Funcionario> Listar()  
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Funcionario>().ToList();
        }
        public Funcionario BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Funcionario>(id);
        }
    }
}

