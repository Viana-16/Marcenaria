using FrontEnd.Usecass;
using Marcenaria._3__Entidades;
using Marcenaria._3__Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    public class SISTEMA
    {
        public  static Cliente usuariologado { get; set; }
      private readonly  ClientUC clientUC;
        public SISTEMA(HttpClient cliente)
        {
           clientUC = new ClientUC(cliente);
        }
        public void IniciarSistema()
        {
            int resposta = -1;
            while (resposta != 0)
            {
                if (usuariologado == null)
                {
                    resposta = ExibirLogin();

                    if (resposta == 1)
                    {
                        FazerLogin();
                    }
                    else if (resposta == 2)
                    {
                        Cliente usuario = CriarUsuario();
                        clientUC.CadastrarUsuario(usuario);
                        Console.WriteLine("Usuário cadastrado com sucesso");
                    }
                    else if (resposta == 3)
                    {
                        List<Cliente> usuarios = clientUC.ListarUsuarios();
                        foreach (Cliente u in usuarios)
                        {
                            Console.WriteLine(u.ToString());
                        }
                    }
                }
                else
                {
                    ExibirMenuPrincipal();
                }
            }
        }
        public int ExibirLogin()
        {
            Console.WriteLine($"--------- LOGIN Bem vindo ---------");
            Console.WriteLine("1 - Deseja Fazer Login");
            Console.WriteLine("2 - Deseja se Cadastrar");
            Console.WriteLine("3 - Listar Usuario Cadastrados");
            return int.Parse(Console.ReadLine());
        }
        public Cliente CriarUsuario()
        {
            Cliente usuario = new Cliente();
            Console.WriteLine("Digite seu nome: ");
            usuario.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu contato: ");
            usuario.Contato = Console.ReadLine();
            Console.WriteLine("Digite seu endereco: ");
            usuario.Endereco = Console.ReadLine();
            Console.WriteLine("Digite seu usuario: ");
            usuario.Usuario = Console.ReadLine();
            Console.WriteLine("Digite seu senha: ");
            usuario.Senha =int.Parse( Console.ReadLine());
            return usuario;
        }
        //public Produto CriarProduto()
        //{
        //    Produto usuario = new Produto();
        //    Console.WriteLine("Digite seu nome: ");
        //    usuario.Nome = Console.ReadLine();
        //    Console.WriteLine("Digite seu preco: ");
        //    usuario.Preco = double.Parse(Console.ReadLine());
        //    return usuario;
        //}
        public void FazerLogin()
        {
            Console.WriteLine("Digite seu username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());
            CreateClienteDTO usuDTO = new CreateClienteDTO
            {
                Nome = username,
                Senha = senha
            };
            Cliente usuario = clientUC.FazerLogin(usuDTO);
            if (usuario == null)
            {
                Console.WriteLine("Usuário ou senha inválidos!!!");
            }
            usuariologado = usuario;
        }
        public void ExibirMenuPrincipal()
        {
            Console.WriteLine($" {usuariologado.Nome}");
            Console.WriteLine("1 - Listar Produtos");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Realizar uma compra");
            Console.WriteLine("4 - Visualizar carrinho");
            Console.WriteLine("Qual operação deseja realizar?");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
            {
              
            }
            else if (resposta == 2)
            {

            }
            if (resposta == 3)
            {

            }
        }
    }
}
