using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository
{
    public class InicializadorBd
    {
        private const string ConnectioString = "Data Source=Marcenaria.db";
        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectioString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Carrinhos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 ProdutoId INTEGER NOT NULL,
                 ClienteId INTEGER NOT NULL
                 );";


                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Clientes(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                NOME TEXT NOT NULL, 
                CONTATO TEXT NOT NULL,
                ENDERECO TEXT NOT NULL,
                USUARIO TEXT NOT NULL,
                SENHA INTEGER NOT NULL
                
          
            );";


                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Compras(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                DATACOMPRA DATETIME NOT NULL,
                TOTAL REAL NOT NULL,
                PRODUTOSID INTEGER NOT NULL,
                CLIENTEID INTEGER NOT NULL
                
          
            );";


                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Fornecedores(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                CNPJ INTEGER NOT NULL,
                ENDERECO TEXT NOT NULL,
                EMAIL TEXT NOT NULL,
                TELEFONE TEXT NOT NULL
          
            );";


                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Funcionarios(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                CARGO TEXT NOT NULL,
                CONTATO TEXT NOT NULL,
                DATACONTRATACAO DATETIME NOT NULL,
                USUARIO TEXT NOT NULL,
                SENHA INTEGER NOT NULL
                
          
            );";


                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Materiais(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                DESCRICAO TEXT NOT NULL,
                FORNECEDORID INTEGER NOT NULL
                
                
          
            );";


                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Produtos(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                PRECO REAL NOT NULL,
                VALIDADE TEXT NOT NULL,
                DESCRICAO TEXT NOT NULL,
                CATEGORIA TEXT NOT NULL,
                QUANTIDADEESTOQUE INTEGER NOT NULL,
                FORNECEDORID INTEGER NOT NULL
          
            );";


                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Vendas(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                DATAVENDA DATETIME NOT NULL,
                PRODUTOID INTEGER NOT NULL,
                VALORFINAL REAL NOT NULL,
                CLIENTEID INTEGER NOT NULL,
                FUNCIONARIOID INTEGER NOT NULL
                
            );";

                connection.Execute(commandoSQL);


            }
        }
    }
}
