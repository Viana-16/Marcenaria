using FrontEnd;

HttpClient cliente = new HttpClient
{
    BaseAddress = new Uri("https://localhost:7243/")
};
SISTEMA sistema = new SISTEMA(cliente);
sistema.IniciarSistema();