using FrontEnd;
using System.Net.Http.Json;
using System.Text.Json;
HttpClient cliente = new HttpClient
{
    BaseAddress = new Uri("https://localhost:7243/")
};
Sistema sistema = new Sistema(cliente);
sistema.IniciarSistema();
