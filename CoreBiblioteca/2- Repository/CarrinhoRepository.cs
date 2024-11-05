using Dapper;
using Dapper.Contrib.Extensions;
using Marcenaria._2__Repository.interfaces;
using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria._2__Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string ConnectionString;
        private readonly IProdutoRepository _repositoryProduto;
        private readonly IClienteRepository _repositoryCliente;

        public CarrinhoRepository(IConfiguration config, IProdutoRepository produto, IClienteRepository cliente)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");

            _repositoryProduto = produto;
            _repositoryCliente = cliente;

        }
        public void Adicionar(Carrinho carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Carrinho>(carrinho);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Carrinho carrinho = BuscarPorId(id);
            connection.Delete<Carrinho>(carrinho);
        }
        public void Editar(Carrinho carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carrinho>(carrinho);
        }
        public List<Carrinho> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Carrinho> list = connection.GetAll<Carrinho>().ToList();
            //TransformarListaCarrinhoEmCarrinhoDTO();
            return list;
        }

        private List<Readcarrinho> TransformarListaCarrinhoEmCarrinhoDTO(List<Carrinho> list)
        {
            List<Readcarrinho> listDTO = new List<Readcarrinho>();

            foreach (Carrinho car in list)
            {
                Readcarrinho readCarrinho = new Readcarrinho();
                readCarrinho.produto = _repositoryProduto.BuscarPorId(car.ProdutoId);
                readCarrinho.cliente = _repositoryCliente.BuscarPorId(car.ClienteId);
                listDTO.Add(readCarrinho);
            }
            return listDTO;
        }

        public List<Readcarrinho> ListarCarrinhoDoUsuario(int clienteId)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Carrinho> list = connection.Query<Carrinho>($"SELECT Id, ClienteId, ProdutoId FROM Carrinhos WHERE ClienteId = {clienteId}").ToList();
            List<Readcarrinho> listDTO = TransformarListaCarrinhoEmCarrinhoDTO(list);
            return listDTO;
        }
        public Carrinho BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carrinho>(id);
        }
    }
}
